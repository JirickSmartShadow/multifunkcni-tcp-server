using System;
using System.Configuration;
using System.Data.SqlClient;

namespace ZaverecnyProjekt_TcpServer
{
    class DatabaseCommunicationGames
    {
        public static void SaveMathQuizScore(string username, int score, TimeSpan time)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["databaseConnectionString"]))
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand(
                        "insert into score (client_id, points, time, date) values " +
                        "((select id from client where username = @username), @score, @time, getdate());"
                        , conn))
                    {
                        command.Parameters.Add(new SqlParameter("@username", username));
                        command.Parameters.Add(new SqlParameter("@score", score));
                        command.Parameters.Add(new SqlParameter("@time", time));

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Database error while saving math quiz score of '" + username + "'to database");
                Logging.Log("Database error while saving math quiz score of '" + username + "'to database");
            }
        }

        public static void SaveRockPaperScissorsScore(string username, int score, TimeSpan time)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["databaseConnectionString"]))
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand(
                        "insert into rpsscore (client_id, points, time, date) values " +
                        "((select id from client where username = @username), @score, @time, getdate());"
                        , conn))
                    {
                        command.Parameters.Add(new SqlParameter("@username", username));
                        command.Parameters.Add(new SqlParameter("@score", score));
                        command.Parameters.Add(new SqlParameter("@time", time));

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Database error while saving rock paper scissors score of '" + username + "'to database");
                Logging.Log("Database error while saving rock paper scissors score of '" + username + "'to database");
            }
        }

        public static string GetMathQuizHighScores()
        {
            string scores = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["databaseConnectionString"]))
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand(
                        "select top 20 client.username, score.points, score.time, score.date " +
                        "from client inner join score on client.id = score.client_id " +
                        "order by score.points desc, score.time;"
                        , conn))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            scores += reader[0] + "|" + reader[1] + "|" + reader[2].ToString().Substring(0, reader[2].ToString().Length - 8) + "|" + ((DateTime)reader[3]).ToString("dd.MM.yyyy HH:mm");
                            while (reader.Read())
                            {
                                scores += ";";
                                scores += reader[0] + "|" + reader[1] + "|" + reader[2].ToString().Substring(0, reader[2].ToString().Length - 8) + "|" + ((DateTime)reader[3]).ToString("dd.MM.yyyy HH:mm");
                            }
                        }
                        else
                        {
                            scores = "No highscores set";
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Database error while retrieving math quiz scores from database");
                Logging.Log("Database error while retrieving math quiz scores from database");
            }
            return scores;
        }

        public static string GetRockPaperScissorsHighScores()
        {
            string highscores = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["databaseConnectionString"]))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(
                        "select top 20 client.username, rpsscore.points, rpsscore.time, rpsscore.date " +
                        "from client inner join rpsscore on client.id = rpsscore.client_id " +
                        "order by rpsscore.points desc, rpsscore.time;"
                        , conn))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            highscores += reader[0] + "|" + reader[1] + "|" + reader[2].ToString().Substring(0, reader[2].ToString().Length - 8) + "|" + ((DateTime)reader[3]).ToString("dd.MM.yyyy HH:mm");
                            while (reader.Read())
                            {
                                highscores += ";";
                                highscores += reader[0] + "|" + reader[1] + "|" + reader[2].ToString().Substring(0, reader[2].ToString().Length - 8) + "|" + ((DateTime)reader[3]).ToString("dd.MM.yyyy HH:mm");
                            }
                        }
                        else
                        {
                            highscores = "No highscores set";
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Database error while retrieving rock paper scissors high scores from database");
                Logging.Log("Database error while retrieving rock paper scissors high scores from database");
            }
            return highscores;
        }
    }
}
