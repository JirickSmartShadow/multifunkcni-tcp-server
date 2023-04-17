namespace ZaverecnyProjekt_TcpClient
{
    partial class FormRockPaperScissors
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
            lbTime = new Label();
            lbDate = new Label();
            btnBack = new Button();
            tmrDatetime = new System.Windows.Forms.Timer(components);
            lbHeader = new Label();
            btnStart = new Button();
            btnHighscores = new Button();
            btnRock = new Button();
            btnPaper = new Button();
            btnScissors = new Button();
            lbRound = new Label();
            lbPoints = new Label();
            lbWrongChoices = new Label();
            lbCorrectChoices = new Label();
            lbTimer = new Label();
            lbMessage = new Label();
            lbMultiplier = new Label();
            lbWinstreak = new Label();
            lbTies = new Label();
            tmrTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lbTime
            // 
            lbTime.AutoSize = true;
            lbTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTime.Location = new Point(28, 72);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(82, 28);
            lbTime.TabIndex = 17;
            lbTime.Text = "<Time>";
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbDate.Location = new Point(28, 29);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(81, 28);
            lbDate.TabIndex = 16;
            lbDate.Text = "<Date>";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(391, 480);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(162, 55);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // tmrDatetime
            // 
            tmrDatetime.Enabled = true;
            tmrDatetime.Tick += tmrDatetime_Tick;
            // 
            // lbHeader
            // 
            lbHeader.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbHeader.Location = new Point(271, 9);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(403, 94);
            lbHeader.TabIndex = 25;
            lbHeader.Text = "Rock Paper Scissors";
            lbHeader.TextAlign = ContentAlignment.MiddleCenter;
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
            // btnHighscores
            // 
            btnHighscores.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnHighscores.Location = new Point(671, 437);
            btnHighscores.Name = "btnHighscores";
            btnHighscores.Size = new Size(162, 55);
            btnHighscores.TabIndex = 4;
            btnHighscores.Text = "Highscores";
            btnHighscores.UseVisualStyleBackColor = true;
            btnHighscores.Click += btnHighscores_Click;
            // 
            // btnRock
            // 
            btnRock.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnRock.Location = new Point(110, 334);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(162, 55);
            btnRock.TabIndex = 1;
            btnRock.Tag = "Rock";
            btnRock.Text = "Rock";
            btnRock.UseVisualStyleBackColor = true;
            btnRock.Visible = false;
            btnRock.Click += btnChoice_Click;
            // 
            // btnPaper
            // 
            btnPaper.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnPaper.Location = new Point(391, 334);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(162, 55);
            btnPaper.TabIndex = 2;
            btnPaper.Tag = "Paper";
            btnPaper.Text = "Paper";
            btnPaper.UseVisualStyleBackColor = true;
            btnPaper.Visible = false;
            btnPaper.Click += btnChoice_Click;
            // 
            // btnScissors
            // 
            btnScissors.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnScissors.Location = new Point(671, 334);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(162, 55);
            btnScissors.TabIndex = 3;
            btnScissors.Tag = "Scissors";
            btnScissors.Text = "Scissors";
            btnScissors.UseVisualStyleBackColor = true;
            btnScissors.Visible = false;
            btnScissors.Click += btnChoice_Click;
            // 
            // lbRound
            // 
            lbRound.AutoSize = true;
            lbRound.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbRound.Location = new Point(305, 137);
            lbRound.Name = "lbRound";
            lbRound.Size = new Size(129, 28);
            lbRound.TabIndex = 39;
            lbRound.Text = "Round <No>";
            lbRound.Visible = false;
            // 
            // lbPoints
            // 
            lbPoints.AutoSize = true;
            lbPoints.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbPoints.Location = new Point(492, 137);
            lbPoints.Name = "lbPoints";
            lbPoints.Size = new Size(129, 28);
            lbPoints.TabIndex = 38;
            lbPoints.Text = "Points: <No>";
            lbPoints.Visible = false;
            // 
            // lbWrongChoices
            // 
            lbWrongChoices.AutoSize = true;
            lbWrongChoices.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbWrongChoices.Location = new Point(110, 230);
            lbWrongChoices.Name = "lbWrongChoices";
            lbWrongChoices.Size = new Size(137, 28);
            lbWrongChoices.TabIndex = 43;
            lbWrongChoices.Text = "Wrong: <No>";
            lbWrongChoices.Visible = false;
            // 
            // lbCorrectChoices
            // 
            lbCorrectChoices.AutoSize = true;
            lbCorrectChoices.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCorrectChoices.Location = new Point(110, 186);
            lbCorrectChoices.Name = "lbCorrectChoices";
            lbCorrectChoices.Size = new Size(140, 28);
            lbCorrectChoices.TabIndex = 42;
            lbCorrectChoices.Text = "Correct: <No>";
            lbCorrectChoices.Visible = false;
            // 
            // lbTimer
            // 
            lbTimer.AutoSize = true;
            lbTimer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTimer.Location = new Point(110, 137);
            lbTimer.Name = "lbTimer";
            lbTimer.Size = new Size(133, 28);
            lbTimer.TabIndex = 41;
            lbTimer.Text = "Time: <Time>";
            lbTimer.Visible = false;
            // 
            // lbMessage
            // 
            lbMessage.BorderStyle = BorderStyle.FixedSingle;
            lbMessage.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbMessage.Location = new Point(271, 192);
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new Size(403, 108);
            lbMessage.TabIndex = 44;
            lbMessage.Text = "Choose your weapon";
            lbMessage.TextAlign = ContentAlignment.MiddleCenter;
            lbMessage.Visible = false;
            // 
            // lbMultiplier
            // 
            lbMultiplier.AutoSize = true;
            lbMultiplier.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbMultiplier.Location = new Point(689, 209);
            lbMultiplier.Name = "lbMultiplier";
            lbMultiplier.Size = new Size(170, 28);
            lbMultiplier.TabIndex = 45;
            lbMultiplier.Text = "Multiplier: <No>x";
            lbMultiplier.Visible = false;
            // 
            // lbWinstreak
            // 
            lbWinstreak.AutoSize = true;
            lbWinstreak.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbWinstreak.Location = new Point(689, 259);
            lbWinstreak.Name = "lbWinstreak";
            lbWinstreak.Size = new Size(163, 28);
            lbWinstreak.TabIndex = 46;
            lbWinstreak.Text = "Winstreak: <No>";
            lbWinstreak.Visible = false;
            // 
            // lbTies
            // 
            lbTies.AutoSize = true;
            lbTies.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTies.Location = new Point(110, 272);
            lbTies.Name = "lbTies";
            lbTies.Size = new Size(109, 28);
            lbTies.TabIndex = 47;
            lbTies.Text = "Ties: <No>";
            lbTies.Visible = false;
            // 
            // tmrTimer
            // 
            tmrTimer.Tick += tmrTimer_Tick;
            // 
            // FormRockPaperScissors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 573);
            Controls.Add(lbTies);
            Controls.Add(lbWinstreak);
            Controls.Add(lbMultiplier);
            Controls.Add(lbMessage);
            Controls.Add(lbWrongChoices);
            Controls.Add(lbCorrectChoices);
            Controls.Add(lbTimer);
            Controls.Add(lbRound);
            Controls.Add(lbPoints);
            Controls.Add(btnScissors);
            Controls.Add(btnPaper);
            Controls.Add(btnRock);
            Controls.Add(btnHighscores);
            Controls.Add(btnStart);
            Controls.Add(lbHeader);
            Controls.Add(btnBack);
            Controls.Add(lbTime);
            Controls.Add(lbDate);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormRockPaperScissors";
            StartPosition = FormStartPosition.Manual;
            Text = "Rock Paper Scissors";
            FormClosing += FormRockPaperScissors_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTime;
        private Label lbDate;
        private Button btnBack;
        private System.Windows.Forms.Timer tmrDatetime;
        private Label lbHeader;
        private Button btnStart;
        private Button btnHighscores;
        private Button btnRock;
        private Button btnPaper;
        private Button btnScissors;
        private Label lbRound;
        private Label lbPoints;
        private Label lbWrongChoices;
        private Label lbCorrectChoices;
        private Label lbTimer;
        private Label lbMessage;
        private Label lbMultiplier;
        private Label lbWinstreak;
        private Label lbTies;
        private System.Windows.Forms.Timer tmrTimer;
    }
}