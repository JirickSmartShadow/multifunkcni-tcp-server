namespace ZaverecnyProjekt_TcpClient
{
    partial class FormMainMenu
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
            btnLogOut = new Button();
            btnGames = new Button();
            btnJokesQuotes = new Button();
            btnMail = new Button();
            lbHeader = new Label();
            tmrDatetime = new System.Windows.Forms.Timer(components);
            lbDate = new Label();
            lbTime = new Label();
            SuspendLayout();
            // 
            // btnLogOut
            // 
            btnLogOut.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogOut.Location = new Point(391, 480);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(162, 55);
            btnLogOut.TabIndex = 3;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnGames
            // 
            btnGames.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnGames.Location = new Point(365, 257);
            btnGames.Name = "btnGames";
            btnGames.Size = new Size(214, 119);
            btnGames.TabIndex = 1;
            btnGames.Text = "Games";
            btnGames.UseVisualStyleBackColor = true;
            btnGames.Click += btnGames_Click;
            // 
            // btnJokesQuotes
            // 
            btnJokesQuotes.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnJokesQuotes.Location = new Point(674, 257);
            btnJokesQuotes.Name = "btnJokesQuotes";
            btnJokesQuotes.Size = new Size(214, 119);
            btnJokesQuotes.TabIndex = 2;
            btnJokesQuotes.Text = "Jokes && Quotes";
            btnJokesQuotes.UseVisualStyleBackColor = true;
            btnJokesQuotes.Click += btnJokesQuotes_Click;
            // 
            // btnMail
            // 
            btnMail.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnMail.Location = new Point(62, 257);
            btnMail.Name = "btnMail";
            btnMail.Size = new Size(214, 119);
            btnMail.TabIndex = 0;
            btnMail.Text = "Mail";
            btnMail.UseVisualStyleBackColor = true;
            btnMail.Click += btnMail_Click;
            // 
            // lbHeader
            // 
            lbHeader.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbHeader.Location = new Point(234, 96);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(476, 88);
            lbHeader.TabIndex = 10;
            lbHeader.Text = "Greetings, <ClientName>";
            lbHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tmrDatetime
            // 
            tmrDatetime.Enabled = true;
            tmrDatetime.Tick += tmrDatetime_Tick;
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbDate.Location = new Point(28, 29);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(81, 28);
            lbDate.TabIndex = 8;
            lbDate.Text = "<Date>";
            // 
            // lbTime
            // 
            lbTime.AutoSize = true;
            lbTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTime.Location = new Point(28, 72);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(82, 28);
            lbTime.TabIndex = 9;
            lbTime.Text = "<Time>";
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 573);
            Controls.Add(lbHeader);
            Controls.Add(lbTime);
            Controls.Add(lbDate);
            Controls.Add(btnMail);
            Controls.Add(btnJokesQuotes);
            Controls.Add(btnGames);
            Controls.Add(btnLogOut);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            FormClosing += FormMainMenu_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogOut;
        private Button btnGames;
        private Button btnJokesQuotes;
        private Button btnMail;
        private Label lbHeader;
        private System.Windows.Forms.Timer tmrDatetime;
        private Label lbDate;
        private Label lbTime;
    }
}