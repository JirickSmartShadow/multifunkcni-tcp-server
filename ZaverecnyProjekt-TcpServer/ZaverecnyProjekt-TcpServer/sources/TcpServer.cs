using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ZaverecnyProjekt_TcpServer
{
    class TcpServer
    {
        private TcpListener server;
        private bool isRunning;

        public TcpServer(int port)
        {
            server = new TcpListener(IPAddress.Any, port);
            server.Start();
            isRunning = true;
            AcceptClients();
        }

        public void AcceptClients()
        {
            Console.WriteLine("server initialized");
            Logging.Log("server initialized");

            do
            {
                TcpClient client = server.AcceptTcpClient();
                Thread t = new Thread(new ThreadStart(() => { LoopClient(client); }));
                t.Start();
            } while (isRunning);

            Console.WriteLine("server has been shut down by admin");
            Logging.Log("server has been shut down by admin");
        }

        private void LoopClient(TcpClient client)
        {
            Console.WriteLine("user detected");
            Logging.Log("user detected");
            try
            {
                StreamReader streamReader = new StreamReader(client.GetStream(), Encoding.UTF8);
                StreamWriter streamWriter = new StreamWriter(client.GetStream(), Encoding.UTF8);

                string clientUsername = string.Empty;
                bool loop = true;

                do
                {
                    string clientInput = streamReader.ReadLine();

                    string[] inputSegments = clientInput.Split(";");

                    string command = inputSegments[0];

                    string username = string.Empty;
                    string password = string.Empty;
                    bool result = false;

                    switch (command)
                    {
                        case "signup":
                            username = inputSegments[1];
                            password = inputSegments[2];

                            result = DatabaseCommunication.SignUp(username, password);
                            if (result)
                            {
                                streamWriter.WriteLine("true");
                                streamWriter.Flush();
                                Console.WriteLine("user '" + username + "' signed up");
                                Logging.Log("user '" + username + "' signed up");
                            }
                            else
                            {
                                streamWriter.WriteLine("false");
                                streamWriter.Flush();
                                Console.WriteLine("user sign up unsuccessful");
                                Logging.Log("user sign up unsuccessful");
                            }
                            break;
                        case "login":
                            username = inputSegments[1];
                            password = inputSegments[2];

                            result = DatabaseCommunication.LogIn(username, password);
                            if (result)
                            {
                                clientUsername = username;
                                streamWriter.WriteLine("true");
                                streamWriter.Flush();
                                Console.WriteLine("user '" + clientUsername + "' logged in");
                                Logging.Log("user '" + clientUsername + "' logged in");
                            }
                            else
                            {
                                streamWriter.WriteLine("false");
                                streamWriter.Flush();
                                Console.WriteLine("user log in unsuccessful");
                                Logging.Log("user log in unsuccessful");
                            }
                            break;
                        case "joke":
                            string joke = DatabaseCommunication.GetJoke();
                            streamWriter.WriteLine(joke);
                            streamWriter.Flush();
                            Console.WriteLine("user '" + clientUsername + "' requested a joke");
                            Logging.Log("user '" + clientUsername + "' requested a joke");
                            break;
                        case "quote":
                            string quote = DatabaseCommunication.GetQuote();
                            streamWriter.WriteLine(quote);
                            streamWriter.Flush();
                            Console.WriteLine("user '" + clientUsername + "' requested a quote");
                            Logging.Log("user '" + clientUsername + "' requested a quote");
                            break;
                        case "userexists":
                            username = inputSegments[1];

                            result = DatabaseCommunication.UserExists(username);
                            if (result)
                            {
                                streamWriter.WriteLine("true");
                                streamWriter.Flush();
                            }
                            else
                            {
                                streamWriter.WriteLine("false");
                                streamWriter.Flush();
                            }
                            break;
                        case "sendmessage":
                            string receiver = inputSegments[1];
                            string message = inputSegments[2];

                            result = DatabaseCommunicationMessaging.SendMessage(clientUsername, receiver, message);
                            if (result)
                            {
                                streamWriter.WriteLine("true");
                                streamWriter.Flush();
                                Console.WriteLine("user '" + clientUsername + "' sent a message to user '" + receiver + "'");
                                Logging.Log("user '" + clientUsername + "' sent a message to user '" + receiver + "'");
                            }
                            else
                            {
                                streamWriter.WriteLine("false");
                                streamWriter.Flush();
                                Console.WriteLine("user '" + clientUsername + "' send message to user '" + receiver + "' unsuccessful");
                                Logging.Log("user '" + clientUsername + "' send message to user '" + receiver + "' unsuccessful");
                            }
                            break;
                        case "inbox":
                            string inbox = DatabaseCommunicationMessaging.CheckInbox(clientUsername);
                            streamWriter.WriteLine(inbox);
                            streamWriter.Flush();
                            Console.WriteLine("user '" + clientUsername + "' opened their inbox");
                            Logging.Log("user '" + clientUsername + "' opened their inbox");
                            break;
                        case "readmessage":
                            string sender = inputSegments[1];
                            string text = inputSegments[2];
                            string date = inputSegments[3];
                            date = DateTime.Parse(date).ToString("yyyy-MM-dd HH:mm:ss");

                            result = DatabaseCommunicationMessaging.ReadMessage(clientUsername, sender, text, date);
                            Console.WriteLine("user '" + clientUsername + "' read a message");
                            Logging.Log("user '" + clientUsername + "' read a message");
                            break;
                        case "sent":
                            string sent = DatabaseCommunicationMessaging.CheckSent(clientUsername);
                            streamWriter.WriteLine(sent);
                            streamWriter.Flush();
                            Console.WriteLine("user '" + clientUsername + "' opened their sent");
                            Logging.Log("user '" + clientUsername + "' opened their sent");
                            break;
                        case "highscores":
                            string game = inputSegments[1];
                            string response = string.Empty;

                            switch (game)
                            {
                                case "mathquiz":
                                    response = DatabaseCommunicationGames.GetMathQuizHighScores();
                                    break;
                                case "rockpaperscissors":
                                    response = DatabaseCommunicationGames.GetRockPaperScissorsHighScores();
                                    break;
                            }

                            streamWriter.WriteLine(response);
                            streamWriter.Flush();
                            Console.WriteLine("user '" + clientUsername + "' viewed '" + game + "' high scores");
                            Logging.Log("user '" + clientUsername + "' viewed '" + game + "' high scores");
                            break;
                        case "mathquizstart":
                            Console.WriteLine("user '" + clientUsername + "' is playing 'math quiz");
                            Logging.Log("user '" + clientUsername + "' is playing 'math quiz");
                            break;
                        case "mathquizfinish":
                            if (clientInput == "mathquizfinish")
                            {
                                Console.WriteLine("user '" + clientUsername + "' quitted 'math quiz'");
                                Logging.Log("user '" + clientUsername + "' quitted 'math quiz'");
                            }
                            else
                            {
                                string score = inputSegments[1];
                                string time = inputSegments[2];
                                DatabaseCommunicationGames.SaveMathQuizScore(clientUsername, int.Parse(score), TimeSpan.Parse(time));

                                Console.WriteLine("user '" + clientUsername + "' finished playing 'math quiz'");
                                Logging.Log("user '" + clientUsername + "' finished playing 'math quiz'");
                            }
                            break;
                        case "rockpaperscissorsstart":
                            Console.WriteLine("user '" + clientUsername + "' is playing 'rock paper scissors'");
                            Logging.Log("user '" + clientUsername + "' is playing 'rock paper scissors'");
                            break;
                        case "rockpaperscissorsfinish":
                            if (clientInput == "rockpaperscissorsfinish")
                            {
                                Console.WriteLine("user '" + clientUsername + "' quitted 'rock paper scissors'");
                                Logging.Log("user '" + clientUsername + "' quitted 'rock paper scissors'");
                            }
                            else
                            {
                                string score = inputSegments[1];
                                string time = inputSegments[2];
                                DatabaseCommunicationGames.SaveRockPaperScissorsScore(clientUsername, int.Parse(score), TimeSpan.Parse(time));

                                Console.WriteLine("user '" + clientUsername + "' finished playing 'rock paper scissors'");
                                Logging.Log("user '" + clientUsername + "' finished playing 'rock paper scissors'");
                            }
                            break;
                        case "logout":
                            Console.WriteLine("user '" + clientUsername + "' logged out");
                            Logging.Log("user '" + clientUsername + "' logged out");
                            clientUsername = string.Empty;
                            break;
                        case "exit":
                            loop = false;
                            Console.WriteLine("user disconnected");
                            Logging.Log("user disconnected");
                            break;
                    }
                } while (loop);
            }
            catch (IOException)
            {
                Console.WriteLine("user disconnected (exception)");
                Logging.Log("user disconnected (exception)");
            }
        }
    }
}
