using Microsoft.VisualBasic.Logging;
using System.Net.Sockets;
using System.Text;

namespace ZaverecnyProjekt_TcpClient
{
    public partial class FormStart : Form
    {
        public FormLogIn FormLogIn { get; set; }
        public FormSignUp FormSignUp { get; set; }
        public ClientInfo ClientInfo { get; set; }

        public FormStart()
        {
            FormLogIn = new FormLogIn(this);
            FormSignUp = new FormSignUp(this);
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogIn.Location = Location;
            FormLogIn.Show();
            this.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp.Location = Location;
            FormSignUp.Show();
            this.Hide();
        }

        private void FormStart_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClientInfo.StreamWriter.WriteLine("exit");
            ClientInfo.StreamWriter.Flush();

            ClientInfo.StreamWriter.Close();
            ClientInfo.StreamReader.Close();
            Environment.Exit(0);
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            try
            {
                TcpClient tcpClient = new TcpClient();
                tcpClient.Connect("127.0.0.1", 65525);
                StreamReader streamReader = new StreamReader(tcpClient.GetStream(), Encoding.UTF8);
                StreamWriter writeStream = new StreamWriter(tcpClient.GetStream(), Encoding.UTF8);
                ClientInfo = new ClientInfo(tcpClient, streamReader, writeStream);
            }
            catch (Exception)
            {
                FormDialog formDialog = new FormDialog();
                formDialog.FormClosed += FormError_FormClosed;
                formDialog.Text = "Fatal Error";
                foreach (Control control in formDialog.Controls)
                {
                    if (control.Name == "lbHeader")
                    {
                        control.Text = "Fatal Error";
                    }
                    else if (control.Name == "lbMessage")
                    {
                        control.Text = "The server is not initialized or the configuration file contains invalid data. Please check both and try again.";
                    }
                    else if (control.Name == "btnOk")
                    {
                        control.Click += button_Click;
                    }
                }
                formDialog.ShowDialog();
            }
        }

        private void button_Click(object? sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void FormError_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}