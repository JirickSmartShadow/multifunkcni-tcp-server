using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjekt_TcpClient
{
    public class ClientInfo
    {
        public TcpClient Client { get; set; }
        public StreamReader StreamReader { get; set; }
        public StreamWriter StreamWriter { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public ClientInfo(TcpClient client, StreamReader streamReader, StreamWriter streamWriter)
        {
            Client = client;
            StreamReader = streamReader;
            StreamWriter = streamWriter;
            Username = string.Empty;
            Password = string.Empty;
        }
    }
}
