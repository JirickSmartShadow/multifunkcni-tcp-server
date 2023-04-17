namespace ZaverecnyProjekt_TcpClient
{
    partial class FormMathQuiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnBack = new Button();
            lbTime = new Label();
            lbDate = new Label();
            tmrDatetime = new System.Windows.Forms.Timer(components);
            btnHighscores = new Button();
            btnStart = new Button();
            lbHeader = new Label();
            lbQuestion = new Label();
            btnAnswer1 = new Button();
            btnAnswer2 = new Button();
            btnAnswer3 = new Button();
            btnAnswer4 = new Button();
            lbPoints = new Label();
            lbQuestionNumber = new Label();
            lbTimer = new Label();
            lbCorrectAnswers = new Label();
            lbWrongAnswers = new Label();
            lbLevel = new Label();
            tmrTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(391, 480);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(162, 55);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lbTime
            // 
            lbTime.AutoSize = true;
            lbTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTime.Location = new Point(28, 72);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(82, 28);
            lbTime.TabIndex = 15;
            lbTime.Text = "<Time>";
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbDate.Location = new Point(28, 29);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(81, 28);
            lbDate.TabIndex = 14;
            lbDate.Text = "<Date>";
            // 
            // tmrDatetime
            // 
            tmrDatetime.Enabled = true;
            tmrDatetime.Tick += tmrDatetime_Tick;
            // 
            // btnHighscores
            // 
            btnHighscores.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnHighscores.Location = new Point(672, 437);
            btnHighscores.Name = "btnHighscores";
            btnHighscores.Size = new Size(162, 55);
            btnHighscores.TabIndex = 5;
            btnHighscores.Text = "Highscores";
            btnHighscores.UseVisualStyleBackColor = true;
            btnHighscores.Click += btnHighscores_Click;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.Location = new Point(110, 437);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(162, 55);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lbHeader
            // 
            lbHeader.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbHeader.Location = new Point(271, 9);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(403, 94);
            lbHeader.TabIndex = 26;
            lbHeader.Text = "Math Quiz";
            lbHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbQuestion
            // 
            lbQuestion.BorderStyle = BorderStyle.FixedSingle;
            lbQuestion.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbQuestion.Location = new Point(271, 192);
            lbQuestion.Name = "lbQuestion";
            lbQuestion.Size = new Size(403, 108);
            lbQuestion.TabIndex = 27;
            lbQuestion.Text = "<Question>";
            lbQuestion.TextAlign = ContentAlignment.MiddleCenter;
            lbQuestion.Visible = false;
            // 
            // btnAnswer1
            // 
            btnAnswer1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnswer1.Location = new Point(110, 334);
            btnAnswer1.Name = "btnAnswer1";
            btnAnswer1.Size = new Size(162, 55);
            btnAnswer1.TabIndex = 1;
            btnAnswer1.Text = "<Answer1>";
            btnAnswer1.UseVisualStyleBackColor = true;
            btnAnswer1.Visible = false;
            btnAnswer1.Click += btnAnswer_Click;
            // 
            // btnAnswer2
            // 
            btnAnswer2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnswer2.Location = new Point(298, 334);
            btnAnswer2.Name = "btnAnswer2";
            btnAnswer2.Size = new Size(162, 55);
            btnAnswer2.TabIndex = 2;
            btnAnswer2.Text = "<Answer2>";
            btnAnswer2.UseVisualStyleBackColor = true;
            btnAnswer2.Visible = false;
            btnAnswer2.Click += btnAnswer_Click;
            // 
            // btnAnswer3
            // 
            btnAnswer3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnswer3.Location = new Point(485, 334);
            btnAnswer3.Name = "btnAnswer3";
            btnAnswer3.Size = new Size(162, 55);
            btnAnswer3.TabIndex = 3;
            btnAnswer3.Text = "<Answer3>";
            btnAnswer3.UseVisualStyleBackColor = true;
            btnAnswer3.Visible = false;
            btnAnswer3.Click += btnAnswer_Click;
            // 
            // btnAnswer4
            // 
            btnAnswer4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnswer4.Location = new Point(672, 334);
            btnAnswer4.Name = "btnAnswer4";
            btnAnswer4.Size = new Size(162, 55);
            btnAnswer4.TabIndex = 4;
            btnAnswer4.Text = "<Answer4>";
            btnAnswer4.UseVisualStyleBackColor = true;
            btnAnswer4.Visible = false;
            btnAnswer4.Click += btnAnswer_Click;
            // 
            // lbPoints
            // 
            lbPoints.AutoSize = true;
            lbPoints.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbPoints.Location = new Point(672, 137);
            lbPoints.Name = "lbPoints";
            lbPoints.Size = new Size(129, 28);
            lbPoints.TabIndex = 32;
            lbPoints.Text = "Points: <No>";
            lbPoints.Visible = false;
            // 
            // lbQuestionNumber
            // 
            lbQuestionNumber.AutoSize = true;
            lbQuestionNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbQuestionNumber.Location = new Point(298, 137);
            lbQuestionNumber.Name = "lbQuestionNumber";
            lbQuestionNumber.Size = new Size(151, 28);
            lbQuestionNumber.TabIndex = 33;
            lbQuestionNumber.Text = "Question <No>";
            lbQuestionNumber.Visible = false;
            // 
            // lbTimer
            // 
            lbTimer.AutoSize = true;
            lbTimer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTimer.Location = new Point(110, 137);
            lbTimer.Name = "lbTimer";
            lbTimer.Size = new Size(133, 28);
            lbTimer.TabIndex = 34;
            lbTimer.Text = "Time: <Time>";
            lbTimer.Visible = false;
            // 
            // lbCorrectAnswers
            // 
            lbCorrectAnswers.AutoSize = true;
            lbCorrectAnswers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCorrectAnswers.Location = new Point(110, 203);
            lbCorrectAnswers.Name = "lbCorrectAnswers";
            lbCorrectAnswers.Size = new Size(140, 28);
            lbCorrectAnswers.TabIndex = 35;
            lbCorrectAnswers.Text = "Correct: <No>";
            lbCorrectAnswers.Visible = false;
            // 
            // lbWrongAnswers
            // 
            lbWrongAnswers.AutoSize = true;
            lbWrongAnswers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbWrongAnswers.Location = new Point(110, 263);
            lbWrongAnswers.Name = "lbWrongAnswers";
            lbWrongAnswers.Size = new Size(137, 28);
            lbWrongAnswers.TabIndex = 36;
            lbWrongAnswers.Text = "Wrong: <No>";
            lbWrongAnswers.Visible = false;
            // 
            // lbLevel
            // 
            lbLevel.AutoSize = true;
            lbLevel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbLevel.Location = new Point(485, 137);
            lbLevel.Name = "lbLevel";
            lbLevel.Size = new Size(120, 28);
            lbLevel.TabIndex = 37;
            lbLevel.Text = "Level: <No>";
            lbLevel.Visible = false;
            // 
            // tmrTimer
            // 
            tmrTimer.Tick += tmrTimer_Tick;
            // 
            // FormMathQuiz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 573);
            Controls.Add(lbLevel);
            Controls.Add(lbWrongAnswers);
            Controls.Add(lbCorrectAnswers);
            Controls.Add(lbTimer);
            Controls.Add(lbQuestionNumber);
            Controls.Add(lbPoints);
            Controls.Add(btnAnswer4);
            Controls.Add(btnAnswer3);
            Controls.Add(btnAnswer2);
            Controls.Add(btnAnswer1);
            Controls.Add(lbQuestion);
            Controls.Add(lbHeader);
            Controls.Add(btnHighscores);
            Controls.Add(btnStart);
            Controls.Add(lbTime);
            Controls.Add(lbDate);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormMathQuiz";
            StartPosition = FormStartPosition.Manual;
            Text = "Math Quiz";
            FormClosing += FormMathQuiz_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label lbTime;
        private Label lbDate;
        private System.Windows.Forms.Timer tmrDatetime;
        private Button btnHighscores;
        private Button btnStart;
        private Label lbHeader;
        private Label lbQuestion;
        private Button btnAnswer1;
        private Button btnAnswer2;
        private Button btnAnswer3;
        private Button btnAnswer4;
        private Label lbPoints;
        private Label lbQuestionNumber;
        private Label lbTimer;
        private Label lbCorrectAnswers;
        private Label lbWrongAnswers;
        private Label lbLevel;
        private System.Windows.Forms.Timer tmrTimer;
    }
}