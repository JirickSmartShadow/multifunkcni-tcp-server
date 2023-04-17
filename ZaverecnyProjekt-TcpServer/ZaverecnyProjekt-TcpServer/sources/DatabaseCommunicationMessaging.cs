using System;
using System.Configuration;
using System.Data.SqlClient;

namespace ZaverecnyProjekt_TcpServer
{
    class DatabaseCommunicationMessaging
    {
        public static bool SendMessage(string senderUsername, string receiverUsername, string text)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["databaseConnectionString"]))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(
                        "insert into message (sender_client_id, receiver_client_id, text, date, is_read) values " +
                        "((select id from client where client.username = @sender_username), " +
                        "(select id from client where client.username = @receiver_username), " +
                        "@text, " +
                        "getdate(), " +
                        "0);"
                        , conn))
                    {
                        command.Parameters.Add(new SqlParameter("@sender_username", senderUsername));
                        command.Parameters.Add(new SqlParameter("@receiver_username", receiverUsername));
                        command.Parameters.Add(new SqlParameter("@text", text));

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Database error while sending message from '" + senderUsername + "' to '" + receiverUsername + "'");
                Logging.Log("Database error while sending message from '" + senderUsername + "' to '" + receiverUsername + "'");
                return false;
            }
            return true;
        }

        public static string CheckInbox(string username)
        {
            string messages = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["databaseConnectionString"]))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(
                        "select sender.username, message.text, message.date, message.is_read " +
                        "from client as sender inner join message on sender.id = message.sender_client_id " +
                        "where message.receiver_client_id = (select id from client where username = @username) " +
                        "order by message.id desc;"
                        , conn))
                    {
                        command.Parameters.Add(new SqlParameter("@username", username));
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            messages += reader[0] + "|" + reader[1] + "|" + reader[2].ToString();
                            if (int.Parse(reader[3].ToString()) == 0)
                            {
                                messages += "|false";
                            }
                            else
                            {
                                messages += "|true";
                            }
                            while (reader.Read())
                            {
                                messages += ";";
                                messages += reader[0] + "|" + reader[1] + "|" + reader[2].ToString();
                                if (int.Parse(reader[3].ToString()) == 0)
                                {
                                    messages += "|false";
                                }
                                else
                                {
                                    messages += "|true";
                                }
                            }
                        }
                        else
                        {
                            messages = "No messages in the inbox";
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Database error while reading messages from inbox of '" + username + "'");
                Logging.Log("Database error while reading messages from inbox of '" + username + "'");
            }
            return messages;
        }

        public static bool ReadMessage(string receiver, string sender, string message, string date)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["databaseConnectionString"]))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(
                        "update message " +
                        "set is_read = 1 " +
                        "where message.receiver_client_id = (select id from client where username = @receiver) and " +
                        "message.sender_client_id = (select id from client where username = @sender) and " +
                        "message.text = @message and (select left(convert(varchar, message.date, 120), 19)) = @date;"
                        , conn))
                    {
                        command.Parameters.Add(new SqlParameter("@receiver", receiver));
                        command.Parameters.Add(new SqlParameter("@sender", sender));
                        command.Parameters.Add(new SqlParameter("@message", message));
                        command.Parameters.Add(new SqlParameter("@date", date));

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Database error while setting messages of '" + receiver + "' to read");
                Logging.Log("Database error while setting messages of '" + receiver + "' to read");
                return false;
            }
            return true;
        }

        public static string CheckSent(string username)
        {
            string messages = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["databaseConnectionString"]))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(
                        "select receiver.username, message.text, message.date " +
                        "from client as receiver inner join message on receiver.id = message.receiver_client_id " +
                        "where message.sender_client_id = (select id from client where username = @username) " +
                        "order by message.id desc;"
                        , conn))
                    {
                        command.Parameters.Add(new SqlParameter("@username", username));

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            messages += reader[0] + "|" + reader[1] + "|" + reader[2].ToString();
                            while (reader.Read())
                            {
                                messages += ";";
                                messages += reader[0] + "|" + reader[1] + "|" + reader[2].ToString();
                            }
                        }
                        else
                        {
                            messages = "No messages in the sent";
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Database error while reading messages from sent of '" + username + "'");
                Logging.Log("Database error while reading messages from sent of '" + username + "'");
            }
            return messages;
        }
    }
}
