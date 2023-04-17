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
    public partial class FormRockPaperScissors : Form
    {
        public FormGames FormGames { get; set; }
        public FormHighScores FormHighScores { get; set; }
        public ClientInfo ClientInfo { get; set; }
        public bool GameRunning { get; set; }
        private RockPaperScissors RockPaperScissors { get; set; }

        public FormRockPaperScissors(FormGames formGames)
        {
            InitializeComponent();
            FormGames = formGames;
            ClientInfo = FormGames.FormMainMenu.ClientInfo;
            FormHighScores = new FormHighScores(this, "Rock Paper Scissors", ClientInfo);
            GameRunning = false;
        }

        private void tmrDatetime_Tick(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("en-US");
            lbDate.Text = DateTime.Now.ToString("D", ci);
            lbTime.Text = DateTime.Now.ToString("H:mm:ss");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormRockPaperScissors_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GameRunning)
            {
                ClientInfo.StreamWriter.WriteLine("rockpaperscissorsfinish");
                ClientInfo.StreamWriter.Flush();
            }
            FormGames.Location = Location;
            FormGames.Show();
        }

        private void btnHighscores_Click(object sender, EventArgs e)
        {
            FormHighScores.Location = Location;
            FormHighScores.Show();
            Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GameRunning = true;
            btnStart.Text = "Restart";
            lbTimer.Text = "Time: 00:00";
            lbTimer.Show();
            lbRound.Show();
            lbPoints.Show();
            lbCorrectChoices.Show();
            lbWrongChoices.Show();
            lbTies.Show();
            lbMultiplier.Show();
            lbMessage.Show();
            lbWinstreak.Show();
            btnRock.Show();
            btnPaper.Show();
            btnScissors.Show();
            RockPaperScissors = new RockPaperScissors(this);
            RockPaperScissors.Start();
            tmrTimer.Enabled = true;
            tmrTimer.Start();
        }

        private void btnChoice_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Tag.ToString() == "Rock")
            {
                RockPaperScissors.EvaluateChoice(1);
            }
            else if (((Button)sender).Tag.ToString() == "Paper")
            {
                RockPaperScissors.EvaluateChoice(2);
            }
            else
            {
                RockPaperScissors.EvaluateChoice(3);
            }

            if (RockPaperScissors.Round == 20)
            {
                lbTimer.Hide();
                lbRound.Hide();
                lbPoints.Hide();
                lbCorrectChoices.Hide();
                lbWrongChoices.Hide();
                lbTies.Hide();
                lbMultiplier.Hide();
                lbMessage.Hide();
                lbWinstreak.Hide();
                btnRock.Hide();
                btnPaper.Hide();
                btnScissors.Hide();
                tmrTimer.Stop();
                tmrTimer.Enabled = false;
                btnStart.Text = "Start";
                GameRunning = false;
                RockPaperScissors.Finish();
            }
            else
            {
                RockPaperScissors.Continue();
            }
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            lbTimer.Text = "Time: " + (DateTime.Now - RockPaperScissors.StartTime).ToString("mm\\:ss");
        }
    }
}
