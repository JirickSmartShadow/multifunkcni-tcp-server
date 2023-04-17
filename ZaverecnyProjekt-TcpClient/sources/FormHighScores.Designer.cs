namespace ZaverecnyProjekt_TcpClient
{
    partial class FormHighScores
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
            btnBack = new Button();
            lbHeader = new Label();
            btnRefresh = new Button();
            flpHighScores = new FlowLayoutPanel();
            lbHighScoresHeaders = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(391, 480);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(162, 55);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lbHeader
            // 
            lbHeader.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbHeader.Location = new Point(12, 9);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(920, 94);
            lbHeader.TabIndex = 2;
            lbHeader.Text = "<Game Name> High Scores";
            lbHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.Location = new Point(110, 437);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(162, 55);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // flpHighScores
            // 
            flpHighScores.AutoScroll = true;
            flpHighScores.BorderStyle = BorderStyle.FixedSingle;
            flpHighScores.FlowDirection = FlowDirection.TopDown;
            flpHighScores.Location = new Point(111, 155);
            flpHighScores.Name = "flpHighScores";
            flpHighScores.Size = new Size(722, 276);
            flpHighScores.TabIndex = 4;
            flpHighScores.WrapContents = false;
            // 
            // lbHighScoresHeaders
            // 
            lbHighScoresHeaders.BorderStyle = BorderStyle.FixedSingle;
            lbHighScoresHeaders.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbHighScoresHeaders.Location = new Point(111, 111);
            lbHighScoresHeaders.Name = "lbHighScoresHeaders";
            lbHighScoresHeaders.Size = new Size(722, 40);
            lbHighScoresHeaders.TabIndex = 3;
            lbHighScoresHeaders.Text = "Player              Score                   Time                          Date               ";
            lbHighScoresHeaders.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormHighScores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 573);
            Controls.Add(lbHighScoresHeaders);
            Controls.Add(flpHighScores);
            Controls.Add(btnRefresh);
            Controls.Add(lbHeader);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormHighScores";
            StartPosition = FormStartPosition.Manual;
            Text = "High Scores";
            Activated += FormHighScores_Activated;
            FormClosing += FormHighScores_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private Label lbHeader;
        private Button btnRefresh;
        private FlowLayoutPanel flpHighScores;
        private Label lbHighScoresHeaders;
    }
}