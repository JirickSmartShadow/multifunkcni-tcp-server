using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjekt_TcpClient
{
    internal class ButtonMessage : Button
    {
        public string User { get; set; }
        public string Message { get; set; }
        public string Date { get; set; }
        public Form Form { get; set; }
        public ClientInfo ClientInfo { get; set; }
        public bool ReadMessage { get; set; }

        public ButtonMessage(string user, string message, string date, Form form, ClientInfo clientInfo, bool readMessage)
        {
            User = user;
            Message = message;
            Date = date;
            Form = form;
            ClientInfo = clientInfo;
            ReadMessage = readMessage;
        }

        public void btnMessage_Click(object? sender, EventArgs e)
        {
            if (ReadMessage)
            {
                ClientInfo.StreamWriter.WriteLine("readmessage;" + User + ";" + Message + ";" + Date);
                ClientInfo.StreamWriter.Flush();
                User = "From " + User;
            }
            else
            {
                User = "To " + User;
            }

            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormMessageDetail formMessageDetail = new FormMessageDetail(Form, User, Message, Date);
            formMessageDetail.Location = Form.Location;
            formMessageDetail.Show();
            Form.Hide();
        }
    }
}
