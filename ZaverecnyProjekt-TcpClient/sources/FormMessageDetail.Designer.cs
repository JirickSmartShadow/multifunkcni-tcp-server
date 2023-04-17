namespace ZaverecnyProjekt_TcpClient
{
    partial class FormMessageDetail
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
            lbUser = new Label();
            lbDate = new Label();
            tbMessage = new TextBox();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(391, 480);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(162, 55);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lbUser
            // 
            lbUser.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbUser.Location = new Point(81, 9);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(289, 60);
            lbUser.TabIndex = 20;
            lbUser.Text = "<user>";
            lbUser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbDate
            // 
            lbDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbDate.Location = new Point(575, 9);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(289, 60);
            lbDate.TabIndex = 21;
            lbDate.Text = "<date>";
            lbDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbMessage
            // 
            tbMessage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbMessage.Location = new Point(81, 74);
            tbMessage.Multiline = true;
            tbMessage.Name = "tbMessage";
            tbMessage.ReadOnly = true;
            tbMessage.ScrollBars = ScrollBars.Vertical;
            tbMessage.Size = new Size(783, 383);
            tbMessage.TabIndex = 22;
            tbMessage.Text = "<message>";
            // 
            // FormMessageDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 573);
            Controls.Add(tbMessage);
            Controls.Add(lbDate);
            Controls.Add(lbUser);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormMessageDetail";
            StartPosition = FormStartPosition.Manual;
            Text = "Message";
            FormClosing += FormMessageDetail_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label lbUser;
        private Label lbDate;
        private TextBox tbMessage;
    }
}