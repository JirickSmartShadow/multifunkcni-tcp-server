namespace ZaverecnyProjekt_TcpClient
{
    partial class FormMail
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
            lbHeader = new Label();
            btnNewMessage = new Button();
            btnSent = new Button();
            btnInbox = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(391, 480);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(162, 55);
            btnBack.TabIndex = 3;
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
            // lbHeader
            // 
            lbHeader.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbHeader.Location = new Point(234, 96);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(476, 88);
            lbHeader.TabIndex = 12;
            lbHeader.Text = "Mail";
            lbHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNewMessage
            // 
            btnNewMessage.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewMessage.Location = new Point(62, 257);
            btnNewMessage.Name = "btnNewMessage";
            btnNewMessage.Size = new Size(214, 119);
            btnNewMessage.TabIndex = 0;
            btnNewMessage.Text = "New Message";
            btnNewMessage.UseVisualStyleBackColor = true;
            btnNewMessage.Click += btnNewMessage_Click;
            // 
            // btnSent
            // 
            btnSent.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSent.Location = new Point(674, 257);
            btnSent.Name = "btnSent";
            btnSent.Size = new Size(214, 119);
            btnSent.TabIndex = 2;
            btnSent.Text = "Sent";
            btnSent.UseVisualStyleBackColor = true;
            btnSent.Click += btnSent_Click;
            // 
            // btnInbox
            // 
            btnInbox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnInbox.Location = new Point(365, 257);
            btnInbox.Name = "btnInbox";
            btnInbox.Size = new Size(214, 119);
            btnInbox.TabIndex = 1;
            btnInbox.Text = "Inbox";
            btnInbox.UseVisualStyleBackColor = true;
            btnInbox.Click += btnInbox_Click;
            // 
            // FormMail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 573);
            Controls.Add(btnNewMessage);
            Controls.Add(btnSent);
            Controls.Add(btnInbox);
            Controls.Add(lbHeader);
            Controls.Add(lbTime);
            Controls.Add(lbDate);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormMail";
            StartPosition = FormStartPosition.Manual;
            Text = "Mail";
            FormClosing += FormMail_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label lbTime;
        private Label lbDate;
        private System.Windows.Forms.Timer tmrDatetime;
        private Label lbHeader;
        private Button btnNewMessage;
        private Button btnSent;
        private Button btnInbox;
    }
}