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
    public partial class FormSignUp : Form
    {
        public FormStart FormStart { get; set; }

        public FormSignUp(FormStart fs)
        {
            FormStart = fs;
            InitializeComponent();
        }

        private void FormSignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            btnCancel.PerformClick();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbUsername.Text = string.Empty;
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

            if (username.Length > 2 && password.Length > 2)
            {
                FormStart.ClientInfo.StreamWriter.WriteLine("signup;" + username + ";" + password);
                FormStart.ClientInfo.StreamWriter.Flush();
                response = FormStart.ClientInfo.StreamReader.ReadLine();
            }

            if (response == "true")
            {
                tbUsername.Text = string.Empty;
                tbPassword.Text = string.Empty;
                Hide();
                FormStart.Show();
                FormDialog formDialog = new FormDialog();
                formDialog.Text = "Success";
                foreach (Control control in formDialog.Controls)
                {
                    if (control.Name == "lbHeader")
                    {
                        control.Text = "Sign Up Success";
                    }
                    else if (control.Name == "lbMessage")
                    {
                        control.Text = "Successfully signed up";
                    }
                }
                formDialog.ShowDialog();
            }
            else
            {
                FormDialog formDialog = new FormDialog();
                formDialog.Text = "Error";
                foreach (Control control in formDialog.Controls)
                {
                    if (control.Name == "lbHeader")
                    {
                        control.Text = "Sign Up Error";
                    }
                    else if (control.Name == "lbMessage")
                    {
                        control.Text = "Username or password is incorrect, both must be at least 3 characters long";
                    }
                }
                formDialog.ShowDialog();
            }
        }
    }
}
