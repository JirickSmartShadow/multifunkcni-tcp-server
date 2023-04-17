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
    public partial class FormSent : Form
    {
        public FormMail FormMail { get; set; }

        public FormSent(FormMail formMail)
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

        private void FormSent_FormClosing(object sender, FormClosingEventArgs e)
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

        private void LoadSent()
        {
            flpSent.Controls.Clear();
            FormMail.FormMainMenu.ClientInfo.StreamWriter.WriteLine("sent");
            FormMail.FormMainMenu.ClientInfo.StreamWriter.Flush();

            string response = FormMail.FormMainMenu.ClientInfo.StreamReader.ReadLine();

            if (response == "No messages in the sent")
            {
                Label l = new Label();
                l.Text = response;
                l.AutoSize = false;
                l.TextAlign = ContentAlignment.MiddleCenter;
                l.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
                l.Width = flpSent.Width - 10;
                l.Height = 100;
                flpSent.Controls.Add(l);
            }
            else
            {
                string[] messages = response.Split(';');

                foreach (string message in messages)
                {
                    string[] messageSegments = message.Split("|");
                    string receiver = messageSegments[0];
                    string text = messageSegments[1];
                    string date = messageSegments[2];

                    ButtonMessage buttonMessage = new ButtonMessage(receiver, text, date, this, FormMail.FormMainMenu.ClientInfo, false);
                    buttonMessage.Text = receiver + " - ";
                    if (text.Length > 30)
                    {
                        buttonMessage.Text += text.Substring(0, 30) + "...";
                    }
                    else
                    {
                        buttonMessage.Text += text;
                    }
                    buttonMessage.Text += " - " + date;
                    buttonMessage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                    buttonMessage.AutoSize = false;
                    buttonMessage.TextAlign = ContentAlignment.MiddleLeft;
                    buttonMessage.Width = flpSent.Width - 30;
                    buttonMessage.Height = 40;
                    buttonMessage.Margin = new Padding(3, 3, 3, 0);
                    buttonMessage.Click += buttonMessage.btnMessage_Click;
                    flpSent.Controls.Add(buttonMessage);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSent();
        }

        private void FormSent_Activated(object sender, EventArgs e)
        {
            LoadSent();
        }
    }
}
