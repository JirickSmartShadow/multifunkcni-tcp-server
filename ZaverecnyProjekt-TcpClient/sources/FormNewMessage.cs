using System;
using System.Collections;
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
    public partial class FormNewMessage : Form
    {
        public FormMail FormMail { get; set; }

        public FormNewMessage(FormMail formMail)
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

        private void FormNewMessage_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            btnBack.PerformClick();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnClear.PerformClick();
            FormMail.Location = Location;
            FormMail.Show();
            Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbReceiver.Text = string.Empty;
            tbMessage.Text = string.Empty;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string receiver = tbReceiver.Text;
            string message = tbMessage.Text;

            string response = string.Empty;

            if (receiver != string.Empty && message != string.Empty)
            {
                if (receiver.Contains(';'))
                {
                    string[] receivers = receiver.Split(';');

                    List<string> receivers2 = new List<string>(receivers);

                    List<string> receivers3 = receivers2.Distinct().ToList();

                    bool exists = true;

                    foreach (string r in receivers3)
                    {
                        FormMail.FormMainMenu.ClientInfo.StreamWriter.WriteLine("userexists;" + r);
                        FormMail.FormMainMenu.ClientInfo.StreamWriter.Flush();

                        response = FormMail.FormMainMenu.ClientInfo.StreamReader.ReadLine();
                        if (response == "false")
                        {
                            exists = false;
                        }
                    }

                    bool noDupes = receivers2.Count == receivers2.Distinct().Count();
                    bool sent = true;

                    if (exists)
                    {
                        if (noDupes)
                        {
                            foreach (string r in receivers)
                            {
                                FormMail.FormMainMenu.ClientInfo.StreamWriter.WriteLine("sendmessage;" + r + ";" + message);
                                FormMail.FormMainMenu.ClientInfo.StreamWriter.Flush();

                                response = FormMail.FormMainMenu.ClientInfo.StreamReader.ReadLine();
                                if (response == "false")
                                {
                                    sent = false;
                                }
                            }
                            if (sent)
                            {
                                //dialog messages sent
                                FormDialog formDialog = new FormDialog();
                                formDialog.Text = "Message Success";
                                foreach (Control control in formDialog.Controls)
                                {
                                    if (control.Name == "lbHeader")
                                    {
                                        control.Text = "Messages Sent";
                                    }
                                    else if (control.Name == "lbMessage")
                                    {
                                        control.Text = "All messages successfully sent";
                                    }
                                }
                                btnClear.PerformClick();
                                formDialog.ShowDialog();
                            }
                            else
                            {
                                //dialog something went wrong
                                FormDialog formDialog = new FormDialog();
                                formDialog.Text = "Message Error";
                                foreach (Control control in formDialog.Controls)
                                {
                                    if (control.Name == "lbHeader")
                                    {
                                        control.Text = "Send Message Error";
                                    }
                                    else if (control.Name == "lbMessage")
                                    {
                                        control.Text = "Something went wrong, please try again later";
                                    }
                                }
                                formDialog.ShowDialog();
                            }
                        }
                        else
                        {
                            //dialog cannot send two identical messages to the same person
                            FormDialog formDialog = new FormDialog();
                            formDialog.Text = "Message Error";
                            foreach (Control control in formDialog.Controls)
                            {
                                if (control.Name == "lbHeader")
                                {
                                    control.Text = "The Same Receiver Twice";
                                }
                                else if (control.Name == "lbMessage")
                                {
                                    control.Text = "Cannot send the same message to the same receiver twice at the same time. Please, mention each receiver only once";
                                }
                            }
                            formDialog.ShowDialog();
                        }

                    }
                    else
                    {
                        //dialog not all receivers exist
                        FormDialog formDialog = new FormDialog();
                        formDialog.Text = "Message Error";
                        foreach (Control control in formDialog.Controls)
                        {
                            if (control.Name == "lbHeader")
                            {
                                control.Text = "Not Existing Receiver/s";
                            }
                            else if (control.Name == "lbMessage")
                            {
                                control.Text = "Cannot send message, one or more receiver/s not existing";
                            }
                        }
                        formDialog.ShowDialog();
                    }
                }
                else
                {
                    FormMail.FormMainMenu.ClientInfo.StreamWriter.WriteLine("userexists;" + receiver);
                    FormMail.FormMainMenu.ClientInfo.StreamWriter.Flush();

                    response = FormMail.FormMainMenu.ClientInfo.StreamReader.ReadLine();
                    if (response == "true")
                    {
                        FormMail.FormMainMenu.ClientInfo.StreamWriter.WriteLine("sendmessage;" + receiver + ";" + message);
                        FormMail.FormMainMenu.ClientInfo.StreamWriter.Flush();

                        response = FormMail.FormMainMenu.ClientInfo.StreamReader.ReadLine();
                        if (response == "true")
                        {
                            //dialog message sent
                            FormDialog formDialog = new FormDialog();
                            formDialog.Text = "Message Success";
                            foreach (Control control in formDialog.Controls)
                            {
                                if (control.Name == "lbHeader")
                                {
                                    control.Text = "Message Sent";
                                }
                                else if (control.Name == "lbMessage")
                                {
                                    control.Text = "Message successfully sent";
                                }
                            }
                            btnClear.PerformClick();
                            formDialog.ShowDialog();
                        }
                        else
                        {
                            //dialog something went wrong
                            FormDialog formDialog = new FormDialog();
                            formDialog.Text = "Message Error";
                            foreach (Control control in formDialog.Controls)
                            {
                                if (control.Name == "lbHeader")
                                {
                                    control.Text = "Send Message Error";
                                }
                                else if (control.Name == "lbMessage")
                                {
                                    control.Text = "Something went wrong, please try again later";
                                }
                            }
                            formDialog.ShowDialog();
                        }
                    }
                    else
                    {
                        //dialog receiver does not exit
                        FormDialog formDialog = new FormDialog();
                        formDialog.Text = "Message Error";
                        foreach (Control control in formDialog.Controls)
                        {
                            if (control.Name == "lbHeader")
                            {
                                control.Text = "Receiver Does Not Exist";
                            }
                            else if (control.Name == "lbMessage")
                            {
                                control.Text = "Cannot send message, this receiver does not exist";
                            }
                        }
                        formDialog.ShowDialog();
                    }
                }
            }
            else
            {
                FormDialog formDialog = new FormDialog();
                formDialog.Text = "Message Error";
                foreach (Control control in formDialog.Controls)
                {
                    if (control.Name == "lbHeader")
                    {
                        control.Text = "Receiver Or Message Not Filled";
                    }
                    else if (control.Name == "lbMessage")
                    {
                        control.Text = "Cannot send message, please fill both reciever and message fields";
                    }
                }
                formDialog.ShowDialog();
            }
        }
    }
}
