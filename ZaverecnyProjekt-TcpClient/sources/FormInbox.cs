using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaverecnyProjekt_TcpClient
{
    public partial class FormInbox : Form
    {
        public FormMail FormMail { get; set; }

        public FormInbox(FormMail formMail)
        {
            InitializeComponent();
            FormMail = formMail;
        }

        private void tmrDatetime_Tick(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("en-US");
            lbDate.Text = DateTime.Now.ToString("D", ci);
            lbTime.Text = DateTime.Now.ToString("H:mm:ss");
        }

        private void FormInbox_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            btnBack.PerformClick();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMail.Location = Location;
            FormMail.Show();
            Hide();
        }

        private void LoadInbox()
        {
            flpInbox.Controls.Clear();
            FormMail.FormMainMenu.ClientInfo.StreamWriter.WriteLine("inbox");
            FormMail.FormMainMenu.ClientInfo.StreamWriter.Flush();

            string response = FormMail.FormMainMenu.ClientInfo.StreamReader.ReadLine();

            if (response == "No messages in the inbox")
            {
                Label l = new Label();
                l.Text = response;
                l.AutoSize = false;
                l.TextAlign = ContentAlignment.MiddleCenter;
                l.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
                l.Width = flpInbox.Width - 10;
                l.Height = 100;
                flpInbox.Controls.Add(l);
            }
            else
            {
                string[] messages = response.Split(';');

                foreach (string message in messages)
                {
                    string[] messageSegments = message.Split("|");
                    string sender = messageSegments[0];
                    string text = messageSegments[1];
                    string date = messageSegments[2];
                    string read = messageSegments[3];

                    ButtonMessage buttonMessage = new ButtonMessage(sender, text, date, this, FormMail.FormMainMenu.ClientInfo, true);
                    buttonMessage.Text = sender + " - ";
                    if (text.Length > 30)
                    {
                        buttonMessage.Text += text.Substring(0, 30) + "...";
                    }
                    else
                    {
                        buttonMessage.Text += text;
                    }
                    buttonMessage.Text += " - " + date;
                    if (read == "true")
                    {
                        buttonMessage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                    }
                    else
                    {

                        buttonMessage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
                    }
                    buttonMessage.AutoSize = false;
                    buttonMessage.TextAlign = ContentAlignment.MiddleLeft;
                    buttonMessage.Width = flpInbox.Width - 30;
                    buttonMessage.Height = 40;
                    buttonMessage.Margin = new Padding(3, 3, 3, 0);
                    buttonMessage.Click += buttonMessage.btnMessage_Click;
                    flpInbox.Controls.Add(buttonMessage);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadInbox();
        }

        private void FormInbox_Activated(object sender, EventArgs e)
        {
            LoadInbox();
        }
    }
}
