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
    public partial class FormMathQuiz : Form
    {
        public FormGames FormGames { get; set; }
        public FormHighScores FormHighScores { get; set; }
        public ClientInfo ClientInfo { get; set; }
        private MathQuiz MathQuiz { get; set; }
        private bool QuizRunning { get; set; }

        public FormMathQuiz(FormGames formGames)
        {
            InitializeComponent();
            FormGames = formGames;
            ClientInfo = FormGames.FormMainMenu.ClientInfo;
            FormHighScores = new FormHighScores(this, "Math Quiz", ClientInfo);
            QuizRunning = false;
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

        private void FormMathQuiz_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (QuizRunning)
            {
                ClientInfo.StreamWriter.WriteLine("mathquizfinish");
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
            QuizRunning = true;
            btnStart.Text = "Restart";
            lbTimer.Text = "Time: 00:00";
            lbTimer.Show();
            lbQuestion.Show();
            lbQuestionNumber.Show();
            lbLevel.Show();
            lbPoints.Show();
            lbCorrectAnswers.Show();
            lbWrongAnswers.Show();
            btnAnswer1.Show();
            btnAnswer2.Show();
            btnAnswer3.Show();
            btnAnswer4.Show();
            MathQuiz = new MathQuiz(this);
            MathQuiz.Start();
            tmrTimer.Enabled = true;
            tmrTimer.Start();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Tag.ToString() == "correct")
            {
                MathQuiz.EvaluateAnswer(true);
            }
            else
            {
                MathQuiz.EvaluateAnswer(false);
            }
            if (MathQuiz.QuestionNumber == 20)
            {
                lbTimer.Hide();
                lbQuestion.Hide();
                lbQuestionNumber.Hide();
                lbLevel.Hide();
                lbPoints.Hide();
                lbCorrectAnswers.Hide();
                lbWrongAnswers.Hide();
                btnAnswer1.Hide();
                btnAnswer2.Hide();
                btnAnswer3.Hide();
                btnAnswer4.Hide();
                tmrTimer.Stop();
                tmrTimer.Enabled = false;
                btnStart.Text = "Start";
                QuizRunning = false;
                MathQuiz.Finish();
            }
            else
            {
                MathQuiz.GenerateQuestionAndAnswers();
            }
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            lbTimer.Text = "Time: " + (DateTime.Now - MathQuiz.StartTime).ToString("mm\\:ss");
        }
    }
}
