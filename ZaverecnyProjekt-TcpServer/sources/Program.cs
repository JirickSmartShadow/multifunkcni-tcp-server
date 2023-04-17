using System.Configuration;

namespace ZaverecnyProjekt_TcpServer
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpServer server = new TcpServer(int.Parse(ConfigurationManager.AppSettings["port"]));
        }  
    }
}
