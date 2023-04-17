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
    public partial class FormHighScores : Form
    {
        public Form Form { get; set; }
        public string GameName { get; set; }
        public ClientInfo ClientInfo { get; set; }

        public FormHighScores(Form form, string gameName, ClientInfo clientInfo)
        {
            InitializeComponent();
            Form = form;
            GameName = gameName;
            ClientInfo = clientInfo;
        }

        private void FormHighScores_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            btnBack.PerformClick();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form.Location = Location;
            Form.Show();
            Hide();
        }

        public void LoadHighScores()
        {
            flpHighScores.Controls.Clear();
            lbHeader.Text = GameName + " High Scores";
            string game = GameName.Replace(" ", "").ToLower();
            ClientInfo.StreamWriter.WriteLine("highscores;" + game);
            ClientInfo.StreamWriter.Flush();

            string response = ClientInfo.StreamReader.ReadLine();
            string[] highScores = response.Split(";");

            foreach (string highScore in highScores)
            {
                string[] highScoreSegments = highScore.Split("|");

                Label l = new Label();
                l.AutoSize = false;
                l.Text = highScoreSegments[0].PadRight(20) + highScoreSegments[1].PadRight(20) + highScoreSegments[2].PadRight(20) + highScoreSegments[3];
                l.Width = flpHighScores.Width - 30;
                l.Height = 40;
                l.TextAlign = ContentAlignment.MiddleCenter;
                l.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                l.Margin = new Padding(3, 3, 3, 0);
                flpHighScores.Controls.Add(l);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadHighScores();
        }

        private void FormHighScores_Activated(object sender, EventArgs e)
        {
            LoadHighScores();
        }
    }
}
