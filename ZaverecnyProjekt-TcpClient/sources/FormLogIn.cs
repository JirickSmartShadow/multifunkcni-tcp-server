using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaverecnyProjekt_TcpClient
{
    public partial class FormLogIn : Form
    {
        public FormStart FormStart { get; set; }
        public FormMainMenu FormMainMenu { get; set; }

        public FormLogIn(FormStart fs)
        {
            FormStart = fs;
            FormMainMenu = new FormMainMenu(this);
            InitializeComponent();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            btnCancel.PerformClick();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbPassword.Text = string.Empty;
            this.Hide();
            FormStart.Location = Location;
            FormStart.Show();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            string response = "false";

            tbPassword.Text = string.Empty;

            if (username.Length > 2 && password.Length > 2)
            {
                FormStart.ClientInfo.StreamWriter.WriteLine("login;" + username + ";" + password);
                FormStart.ClientInfo.StreamWriter.Flush();
                response = FormStart.ClientInfo.StreamReader.ReadLine();
            }

            if (response == "true")
            {
                Hide();
                FormStart.ClientInfo.Username = username;
                FormStart.ClientInfo.Password = password;
                FormMainMenu.ClientInfo = FormStart.ClientInfo;
                FormMainMenu.Text += " - " + username;
                foreach (Control control in FormMainMenu.Controls)
                {
                    if (control.Name == "lbHeader")
                    {
                        control.Text = "Greetings, " + username + "!";
                    }
                }
                FormMainMenu.Show();
            }
            else
            {
                FormDialog formDialog = new FormDialog();
                formDialog.Text = "Error";
                foreach (Control control in formDialog.Controls)
                {
                    if (control.Name == "lbHeader")
                    {
                        control.Text = "Log In Error";
                    }
                    else if (control.Name == "lbMessage")
                    {
                        control.Text = "Username or password is incorrect";
                    }
                }
                formDialog.ShowDialog();
            }
        }
    }
}
