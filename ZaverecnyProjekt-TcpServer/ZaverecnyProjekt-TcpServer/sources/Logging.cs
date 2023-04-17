using System;
using System.IO;

namespace ZaverecnyProjekt_TcpServer
{
    public class Logging
    {
        public static void Log(string message)
        {
            File.AppendAllText("log.txt", "[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "] " + message + Environment.NewLine);
        }
    }
}
