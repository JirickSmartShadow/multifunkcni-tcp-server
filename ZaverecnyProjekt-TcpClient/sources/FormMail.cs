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
    public partial class FormMail : Form
    {
        public FormMainMenu FormMainMenu { get; set; }
        public FormNewMessage FormNewMessage { get; set; }
        public FormInbox FormInbox { get; set; }
        public FormSent FormSent { get; set; }

        public FormMail(FormMainMenu formMainMenu)
        {
            InitializeComponent();
            FormMainMenu = formMainMenu;
            FormNewMessage = new FormNewMessage(this);
            FormInbox = new FormInbox(this);
            FormSent = new FormSent(this);
        }

        private void FormMail_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            btnBack.PerformClick();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMainMenu.Location = Location;
            FormMainMenu.Show();
            Hide();
        }

        private void tmrDatetime_Tick(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("en-US");
            lbDate.Text = DateTime.Now.ToString("D", ci);
            lbTime.Text = DateTime.Now.ToString("H:mm:ss");
        }

        private void btnNewMessage_Click(object sender, EventArgs e)
        {
            FormNewMessage.Location = Location;
            FormNewMessage.Show();
            Hide();
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            FormInbox.Location = Location;
            FormInbox.Show();
            Hide();
        }

        private void btnSent_Click(object sender, EventArgs e)
        {
            FormSent.Location = Location;
            FormSent.Show();
            Hide();
        }
    }
}
