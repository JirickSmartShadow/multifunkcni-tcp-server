namespace ZaverecnyProjekt_TcpClient
{
    partial class FormGameResults
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
            lbHeader = new Label();
            btnOk = new Button();
            lbMessages = new Label();
            SuspendLayout();
            // 
            // lbHeader
            // 
            lbHeader.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lbHeader.Location = new Point(12, 9);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(686, 94);
            lbHeader.TabIndex = 27;
            lbHeader.Text = "<Game> Results";
            lbHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnOk.Location = new Point(274, 410);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(162, 55);
            btnOk.TabIndex = 28;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // lbMessages
            // 
            lbMessages.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbMessages.Location = new Point(12, 106);
            lbMessages.Name = "lbMessages";
            lbMessages.Size = new Size(686, 286);
            lbMessages.TabIndex = 29;
            lbMessages.Text = "<Messages>";
            lbMessages.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormGameResults
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 477);
            Controls.Add(lbMessages);
            Controls.Add(btnOk);
            Controls.Add(lbHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormGameResults";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "<Game> Results";
            TopMost = true;
            ResumeLayout(false);
        }

        #endregion

        private Label lbHeader;
        private Button btnOk;
        private Label lbMessages;
    }
}