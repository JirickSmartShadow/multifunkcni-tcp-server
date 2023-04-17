using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjekt_TcpClient
{
    internal class MathQuiz
    {
        public int Level { get; set; }
        public int Score { get; set; }
        public int QuestionNumber { get; set; }
        public int CorrectAnswers { get; set; }
        public int WrongAnswers { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public DateTime StartTime { get; set; }
        public FormMathQuiz FormMathQuiz { get; set; }

        public MathQuiz(FormMathQuiz formMathQuiz)
        {
            Level = 1;
            Score = 0;
            QuestionNumber = 0;
            CorrectAnswers = 0;
            WrongAnswers = 0;
            Min = 1;
            Max = 10;
            FormMathQuiz = formMathQuiz;
        }

        public void Start()
        {
            FormMathQuiz.ClientInfo.StreamWriter.WriteLine("mathquizstart");
            FormMathQuiz.ClientInfo.StreamWriter.Flush();

            StartTime = DateTime.Now;
            GenerateQuestionAndAnswers();
        }

        public void GenerateQuestionAndAnswers()
        {
            QuestionNumber++;
            string question = GenerateQuestion();
            DataTable dataTable = new DataTable();                          //toto je z
            int correctAnswer = (int)dataTable.Compute(question, "");       //internetu
            int correctIndex = 0;
            List<int> answers = new List<int>();
            Random random = new Random();
            answers.Add(correctAnswer);
            for (int j = 0; j < 3; j++)
            {
                int wrongAnswer;
                bool ok = false;
                do
                {
                    wrongAnswer = correctAnswer + random.Next(-Max, Max);
                    ok = true;
                    if (!answers.Contains(wrongAnswer)) // so they are not the sane
                    {
                        answers.Add(wrongAnswer);
                    }
                    else
                    {
                        ok = false;
                    }
                } while (!ok);
            }

            //DIY shuffle   100x change two different answers
            for (int j = 0; j < 100; j++)
            {
                int first = random.Next(0, 4);
                int second = random.Next(0, 4);
                if (first == second)
                {
                    j--;
                }
                else
                {
                    int temp = answers[second];
                    answers[second] = answers[first];
                    answers[first] = temp;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                if (correctAnswer == answers[i])
                {
                    correctIndex = i;
                }
            }
            
            FormMathQuiz.Controls["lbLevel"].Text = "Level: " + Level;
            FormMathQuiz.Controls["lbPoints"].Text = "Points: " + Score;
            FormMathQuiz.Controls["lbQuestionNumber"].Text = "Question " + QuestionNumber;
            FormMathQuiz.Controls["lbCorrectAnswers"].Text = "Correct: " + CorrectAnswers;
            FormMathQuiz.Controls["lbWrongAnswers"].Text = "Wrong: " + WrongAnswers;

            FormMathQuiz.Controls["lbQuestion"].Text = question;

            FormMathQuiz.Controls["btnAnswer1"].Text = answers[0].ToString();
            FormMathQuiz.Controls["btnAnswer2"].Text = answers[1].ToString();
            FormMathQuiz.Controls["btnAnswer3"].Text = answers[2].ToString();
            FormMathQuiz.Controls["btnAnswer4"].Text = answers[3].ToString();

            FormMathQuiz.Controls["btnAnswer1"].Tag = string.Empty;
            FormMathQuiz.Controls["btnAnswer2"].Tag = string.Empty;
            FormMathQuiz.Controls["btnAnswer3"].Tag = string.Empty;
            FormMathQuiz.Controls["btnAnswer4"].Tag = string.Empty;

            FormMathQuiz.Controls["btnAnswer" + (correctIndex + 1).ToString()].Tag = "correct";
        }

        private string GenerateQuestion()
        {
            Random random = new Random();
            int numberOfNumbers = Level + 1;
            List<string> operators = new List<string>() { "+", "-" };
            switch (Level)
            {
                case 1:
                    Min = 1;
                    Max = 10;
                    break;
                case 2:
                    Min = 10;
                    Max = 25;
                    break;
                case 3:
                    Min = 25;
                    Max = 50;
                    break;
                case 4:
                    Min = 50;
                    Max = 100;
                    break;
            }

            string question = "";

            question += random.Next(Min, Max);

            for (int i = 0; i < numberOfNumbers - 1; i++)
            {
                question += operators[random.Next(0, operators.Count)];
                question += random.Next(Min, Max);
            }

            return question;
        }

        public void EvaluateAnswer(bool correct)
        {
            if (correct)
            {
                Score += Level * 100;
                CorrectAnswers++;
            }
            else
            {
                WrongAnswers++;
            }
            if ((QuestionNumber) % 5 == 0)
            {
                Level++;
            }
        }

        public void Finish()
        {
            TimeSpan time = DateTime.Now - StartTime;

            FormMathQuiz.ClientInfo.StreamWriter.WriteLine("mathquizfinish;" + Score + ";" + time);
            FormMathQuiz.ClientInfo.StreamWriter.Flush();
            
            FormGameResults formGameResults = new FormGameResults();
            formGameResults.Text = "Math Quiz Results";
            formGameResults.Controls["lbHeader"].Text = "Math Quiz Final Results";
            formGameResults.Controls["lbMessages"].Text = "You scored " + Score + " points!" +
                "\nYour time was " + time.Minutes + " minutes " + time.Seconds + " seconds" +
                "\nYou had " + CorrectAnswers + " answers correct and " + WrongAnswers + " wrong" +
                "\n" + Math.Round((double)CorrectAnswers / 20 * 100) + "% of your answers were correct";

            formGameResults.ShowDialog();
        }
    }
}
