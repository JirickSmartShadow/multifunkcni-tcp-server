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
    public partial class FormMainMenu : Form
    {
        public FormLogIn FormLogIn { get; set; }
        public FormMail FormMail { get; set; }
        public FormGames FormGames { get; set; }
        public FormJokesQuotes FormJokesQuotes { get; set; }
        public ClientInfo ClientInfo { get; set; }

        public FormMainMenu(FormLogIn formLogIn)
        {
            InitializeComponent();
            FormLogIn = formLogIn;
            FormMail = new FormMail(this);
            FormGames = new FormGames(this);
            FormJokesQuotes = new FormJokesQuotes(this);
        }

        private void FormMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            btnLogOut.PerformClick();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Hide();
            FormLogIn.Show();
            Text = "Main Menu";

            ClientInfo.StreamWriter.WriteLine("logout");
            ClientInfo.StreamWriter.Flush();
        }

        private void tmrDatetime_Tick(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("en-US");
            lbDate.Text = DateTime.Now.ToString("D", ci);
            lbTime.Text = DateTime.Now.ToString("H:mm:ss");
        }

        private void btnJokesQuotes_Click(object sender, EventArgs e)
        {
            FormJokesQuotes.Location = Location;
            FormJokesQuotes.Show();
            Hide();
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            FormGames.Location = Location;
            FormGames.Show();
            Hide();
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            FormMail.Location = Location;
            FormMail.Show();
            Hide();
        }
    }
}
