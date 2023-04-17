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
    public partial class FormGames : Form
    {
        public FormMainMenu FormMainMenu { get; set; }

        public FormGames(FormMainMenu formMainMenu)
        {
            InitializeComponent();
            FormMainMenu = formMainMenu;
        }

        private void FormGames_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnMathQuiz_Click(object sender, EventArgs e)
        {
            FormMathQuiz formMathQuiz = new FormMathQuiz(this);
            formMathQuiz.Location = Location;
            formMathQuiz.Show();
            Hide();
        }

        private void btnRockPaperScissors_Click(object sender, EventArgs e)
        {
            FormRockPaperScissors formRockPaperScissors = new FormRockPaperScissors(this);
            formRockPaperScissors.Location = Location;
            formRockPaperScissors.Show();
            Hide();
        }
    }
}
