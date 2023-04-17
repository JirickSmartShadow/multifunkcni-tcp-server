namespace ZaverecnyProjekt_TcpClient
{
    partial class FormJokesQuotes
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
            btnJoke = new Button();
            btnQuote = new Button();
            lbHeader = new Label();
            lbJokeQuote = new Label();
            lbTime = new Label();
            lbDate = new Label();
            tmrDatetime = new System.Windows.Forms.Timer(components);
            lbQuoteAuthor = new Label();
            SuspendLayout();
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
            // btnJoke
            // 
            btnJoke.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnJoke.Location = new Point(131, 304);
            btnJoke.Name = "btnJoke";
            btnJoke.Size = new Size(214, 119);
            btnJoke.TabIndex = 0;
            btnJoke.Text = "Joke";
            btnJoke.UseVisualStyleBackColor = true;
            btnJoke.Click += btnJoke_Click;
            // 
            // btnQuote
            // 
            btnQuote.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuote.Location = new Point(596, 304);
            btnQuote.Name = "btnQuote";
            btnQuote.Size = new Size(214, 119);
            btnQuote.TabIndex = 1;
            btnQuote.Text = "Quote";
            btnQuote.UseVisualStyleBackColor = true;
            btnQuote.Click += btnQuote_Click;
            // 
            // lbHeader
            // 
            lbHeader.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbHeader.Location = new Point(246, 68);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(461, 73);
            lbHeader.TabIndex = 3;
            lbHeader.Text = "Random Joke or Quote";
            lbHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbJokeQuote
            // 
            lbJokeQuote.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbJokeQuote.Location = new Point(12, 166);
            lbJokeQuote.Name = "lbJokeQuote";
            lbJokeQuote.Size = new Size(920, 64);
            lbJokeQuote.TabIndex = 4;
            lbJokeQuote.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbTime
            // 
            lbTime.AutoSize = true;
            lbTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTime.Location = new Point(28, 72);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(82, 28);
            lbTime.TabIndex = 11;
            lbTime.Text = "<Time>";
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbDate.Location = new Point(28, 29);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(81, 28);
            lbDate.TabIndex = 10;
            lbDate.Text = "<Date>";
            // 
            // tmrDatetime
            // 
            tmrDatetime.Enabled = true;
            tmrDatetime.Tick += tmrDatetime_Tick;
            // 
            // lbQuoteAuthor
            // 
            lbQuoteAuthor.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbQuoteAuthor.Location = new Point(12, 244);
            lbQuoteAuthor.Name = "lbQuoteAuthor";
            lbQuoteAuthor.Size = new Size(920, 25);
            lbQuoteAuthor.TabIndex = 5;
            lbQuoteAuthor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormJokesQuotes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 573);
            Controls.Add(lbTime);
            Controls.Add(lbDate);
            Controls.Add(lbQuoteAuthor);
            Controls.Add(lbJokeQuote);
            Controls.Add(lbHeader);
            Controls.Add(btnQuote);
            Controls.Add(btnJoke);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormJokesQuotes";
            StartPosition = FormStartPosition.Manual;
            Text = "Jokes & Quotes";
            FormClosing += FormJokesQuotes_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnJoke;
        private Button btnQuote;
        private Label lbHeader;
        private Label lbJokeQuote;
        private Label lbTime;
        private Label lbDate;
        private System.Windows.Forms.Timer tmrDatetime;
        private Label lbQuoteAuthor;
    }
}