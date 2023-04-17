using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ZaverecnyProjekt_TcpClient
{
    internal class RockPaperScissors
    {
        public int Score { get; set; }
        public int Round { get; set; }
        public int CorrectChoices { get; set; }
        public int WrongChoices { get; set; }
        public int Ties { get; set; }
        public int Multiplier { get; set; }
        public int HighestMultiplier { get; set; }
        public int Winstreak { get; set; }
        public int LongestWinstreak { get; set; }
        public DateTime StartTime { get; set; }
        public FormRockPaperScissors FormRockPaperScissors { get; set; }

        public RockPaperScissors(FormRockPaperScissors formRockPaperScissors)
        {
            FormRockPaperScissors = formRockPaperScissors;
            Round = 0;
            CorrectChoices = 0;
            WrongChoices = 0;
            Ties = 0;
            Multiplier = 1;
            HighestMultiplier = 1;
            Winstreak = 0;
            LongestWinstreak = 0;
        }

        public void Start()
        {
            FormRockPaperScissors.ClientInfo.StreamWriter.WriteLine("rockpaperscissorsstart");
            FormRockPaperScissors.ClientInfo.StreamWriter.Flush();

            StartTime = DateTime.Now;
            Continue();
        }

        public void Continue()
        {
            Round++;
            FormRockPaperScissors.Controls["lbRound"].Text = "Round " + Round;
            FormRockPaperScissors.Controls["lbPoints"].Text = "Points: " + Score;
            FormRockPaperScissors.Controls["lbCorrectChoices"].Text = "Correct: " + CorrectChoices;
            FormRockPaperScissors.Controls["lbWrongChoices"].Text = "Wrong: " + WrongChoices;
            FormRockPaperScissors.Controls["lbTies"].Text = "Ties: " + Ties;
            FormRockPaperScissors.Controls["lbMultiplier"].Text = "Multiplier: " + Multiplier + "x";
            FormRockPaperScissors.Controls["lbWinstreak"].Text = "Winstreak: " + Winstreak;
        }

        public void EvaluateChoice(int clientChoice)
        {
            Random random = new Random();
            string message = string.Empty;

            int computerChoice = random.Next(1, 4);
            if (clientChoice == computerChoice) // tie, doesn't count as a lose
            {
                message = "It's a tie!";
                switch (clientChoice)
                {
                    case 1:
                        message += "\nBoth you and the computer chose rock";
                        break;
                    case 2:
                        message += "\nBoth you and the computer chose paper";
                        break;
                    case 3:
                        message += "\nBoth you and the computer chose scissors";
                        break;
                }
                message += "\nYou didn't gain any points this round";
                Ties++;
            }
            else if ((clientChoice - computerChoice == 1) || (computerChoice - clientChoice == 2)) // user won
            {
                message = "You won the round!";
                switch (clientChoice)
                {
                    case 1:
                        message += "\nYour rock crushed computers scissors";
                        break;
                    case 2:
                        message += "\nYour paper wrapped computers rock";
                        break;
                    case 3:
                        message += "\nYour scissors snipped through computers paper";
                        break;
                }
                Score += 100 * Multiplier;
                message += "\nYou gained " + (100 * Multiplier) + " points!";
                Multiplier *= 2;
                Winstreak++;
                if (Winstreak > LongestWinstreak)
                {
                    LongestWinstreak = Winstreak;
                }
                if (Multiplier > HighestMultiplier)
                {
                    HighestMultiplier = Multiplier;
                }
                CorrectChoices++;
            }
            else // user lost the round
            {
                message += "You lost the round!";
                switch (computerChoice)
                {
                    case 1:
                        message += "\nComputer rock crushed your scissors";
                        break;
                    case 2:
                        message += "\nComputer paper wrapped your rock";
                        break;
                    case 3:
                        message += "\nComputer scissors snipped through your paper";
                        break;
                }
                message += "\nYou didn't gain any points this round";
                Multiplier = 1;
                Winstreak = 0;
                WrongChoices++;
                
            }
            FormGameResults roundResults = new FormGameResults();
            roundResults.Text = "Rock Paper Scissors Round Results";
            roundResults.Controls["lbHeader"].Text = "Round Results";
            roundResults.Controls["lbMessages"].Text = message;
            roundResults.TopMost = true;
            roundResults.ShowDialog();
        }

        public void Finish()
        {
            TimeSpan time = DateTime.Now - StartTime;

            FormGameResults formGameResults = new FormGameResults();
            formGameResults.Text = "Rock Paper Scissors Results";
            formGameResults.Controls["lbHeader"].Text = "Rock Paper Scissors Final Results";
            formGameResults.Controls["lbMessages"].Text = "You scored " + Score + " points!" +
                "\nYour time was " + time.Minutes + " minutes " + time.Seconds + " seconds" +
                "\nYou chose the correct weapon " + CorrectChoices + " times" +
                "\nYou chose the wrong weapon " + WrongChoices + " times" +
                "\nYou and the computer chose the same weapon " + Ties + " times" +
                "\n" + Math.Round((double)CorrectChoices / 20 * 100) + "% of your choices were correct" +
                "\nYour biggest multiplier was " + HighestMultiplier + "" +
                "\nYour longest win streak lasted for " + LongestWinstreak + " rounds";
            formGameResults.ShowDialog();

            FormRockPaperScissors.ClientInfo.StreamWriter.WriteLine("rockpaperscissorsfinish;" + Score + ";" + time);
            FormRockPaperScissors.ClientInfo.StreamWriter.Flush();
        }
    }
}
