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
    public partial class FormJokesQuotes : Form
    {
        public FormMainMenu FormMainMenu { get; set; }

        public FormJokesQuotes(FormMainMenu formMainMenu)
        {
            InitializeComponent();
            FormMainMenu = formMainMenu;
        }

        private void FormJokesQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            btnBack.PerformClick();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMainMenu.Location = Location;
            FormMainMenu.Show();
            lbJokeQuote.Text = string.Empty;
            lbQuoteAuthor.Text = string.Empty;
            Hide();
        }

        private void btnJoke_Click(object sender, EventArgs e)
        {
            FormMainMenu.ClientInfo.StreamWriter.WriteLine("joke");
            FormMainMenu.ClientInfo.StreamWriter.Flush();

            string joke = FormMainMenu.ClientInfo.StreamReader.ReadLine();
            lbJokeQuote.Text = joke;
            lbQuoteAuthor.Text = string.Empty;
        }

        private void btnQuote_Click(object sender, EventArgs e)
        {
            FormMainMenu.ClientInfo.StreamWriter.WriteLine("quote");
            FormMainMenu.ClientInfo.StreamWriter.Flush();

            string response = FormMainMenu.ClientInfo.StreamReader.ReadLine();
            string[] responseSegments = response.Split(";");
            lbJokeQuote.Text = responseSegments[0];
            lbQuoteAuthor.Text = responseSegments[1];
        }

        private void tmrDatetime_Tick(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("en-US");
            lbDate.Text = DateTime.Now.ToString("D", ci);
            lbTime.Text = DateTime.Now.ToString("H:mm:ss");
        }
    }
}
