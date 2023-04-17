namespace ZaverecnyProjekt_TcpClient
{
    partial class FormGames
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
            btnRockPaperScissors = new Button();
            btnMathQuiz = new Button();
            btnBack = new Button();
            lbHeader = new Label();
            lbTime = new Label();
            lbDate = new Label();
            tmrDatetime = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnRockPaperScissors
            // 
            btnRockPaperScissors.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnRockPaperScissors.Location = new Point(586, 257);
            btnRockPaperScissors.Name = "btnRockPaperScissors";
            btnRockPaperScissors.Size = new Size(214, 119);
            btnRockPaperScissors.TabIndex = 1;
            btnRockPaperScissors.Text = "Rock Paper Scissors";
            btnRockPaperScissors.UseVisualStyleBackColor = true;
            btnRockPaperScissors.Click += btnRockPaperScissors_Click;
            // 
            // btnMathQuiz
            // 
            btnMathQuiz.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnMathQuiz.Location = new Point(141, 257);
            btnMathQuiz.Name = "btnMathQuiz";
            btnMathQuiz.Size = new Size(214, 119);
            btnMathQuiz.TabIndex = 0;
            btnMathQuiz.Text = "Math Quiz";
            btnMathQuiz.UseVisualStyleBackColor = true;
            btnMathQuiz.Click += btnMathQuiz_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(391, 480);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(162, 55);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lbHeader
            // 
            lbHeader.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbHeader.Location = new Point(232, 96);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(480, 88);
            lbHeader.TabIndex = 6;
            lbHeader.Text = "Play your favourite games";
            lbHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbTime
            // 
            lbTime.AutoSize = true;
            lbTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTime.Location = new Point(28, 72);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(82, 28);
            lbTime.TabIndex = 13;
            lbTime.Text = "<Time>";
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbDate.Location = new Point(28, 29);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(81, 28);
            lbDate.TabIndex = 12;
            lbDate.Text = "<Date>";
            // 
            // tmrDatetime
            // 
            tmrDatetime.Enabled = true;
            tmrDatetime.Tick += tmrDatetime_Tick;
            // 
            // FormGames
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 573);
            Controls.Add(lbTime);
            Controls.Add(lbDate);
            Controls.Add(lbHeader);
            Controls.Add(btnRockPaperScissors);
            Controls.Add(btnMathQuiz);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormGames";
            StartPosition = FormStartPosition.Manual;
            Text = "Games";
            FormClosing += FormGames_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRockPaperScissors;
        private Button btnMathQuiz;
        private Button btnBack;
        private Label lbHeader;
        private Label lbTime;
        private Label lbDate;
        private System.Windows.Forms.Timer tmrDatetime;
    }
}