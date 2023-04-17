using System;
using System.Configuration;
using System.Data.SqlClient;

namespace ZaverecnyProjekt_TcpServer
{
    class DatabaseCommunication
    {
        public static bool SignUp(string username, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["databaseConnectionString"]))
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand(
                        "select username from client;"
                        , conn))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            if (reader[0].ToString() == username)
                            {
                                return false;
                            }
                        }
                    }
                }
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["databaseConnectionString"]))
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand(
                        "insert into client (username, password) values (@username, @password);"
                        , conn))
                    {
                        command.Parameters.Add(new SqlParameter("@username", username));
                        command.Parameters.Add(new SqlParameter("@password", password));

                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool LogIn(string username, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["databaseConnectionString"]))
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand(
                        "select client.username, client.password " +
                        "from client " +
                        "where username=@username and password=@password;"
                        , conn))
                    {
                        command.Parameters.Add(new SqlParameter("@username", username));
                        command.Parameters.Add(new SqlParameter("@password", password));

                        SqlDataReader reader = command.ExecuteReader();

                        reader.Read();
                        if (reader[0] != null && reader[1] != null)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool UserExists(string username)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["databaseConnectionString"]))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(
                        "select client.username " +
                        "from client " +
                        "where client.username = @username; "
                        , conn))
                    {
                        command.Parameters.Add(new SqlParameter("@username", username));

                        SqlDataReader reader = command.ExecuteReader();

                        return reader.Read();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Database error while checking if '" + username + "' exists");
                Logging.Log("Database error while checking if '" + username + "' exists");
                return false;
            }
        }

        public static string GetJoke()
        {
            string joke = "";

            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["databaseConnectionString"]))
                {
                    conn.Open();

                    Random random = new Random();

                    using (SqlCommand command = new SqlCommand(
                        "select text from joke where id = @id;"
                        , conn))
                    {
                        command.Parameters.Add(new SqlParameter("@id", random.Next(1, 21)));
                        SqlDataReader reader = command.ExecuteReader();
                        reader.Read();
                        joke = "" + reader[0];
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Database error while retrieving joke from database");
                Logging.Log("Database error while retrieving joke from database");
            }
            return joke;
        }

        public static string GetQuote()
        {
            string quote = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["databaseConnectionString"]))
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand(
                        "select text, author from quote where id = @id;"
                        , conn))
                    {
                        Random random = new Random();
                        command.Parameters.Add(new SqlParameter("@id", random.Next(1, 21)));
                        SqlDataReader reader = command.ExecuteReader();

                        reader.Read();

                        quote = reader[0].ToString() + ";" + reader[1].ToString();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Database error while retrieving quote from database");
                Logging.Log("Database error while retrieving quote from database");
            }
            return quote;
        }
    }
}
