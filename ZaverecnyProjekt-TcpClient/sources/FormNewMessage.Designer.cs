namespace ZaverecnyProjekt_TcpClient
{
    partial class FormNewMessage
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
            tbReceiver = new TextBox();
            lbReceiver = new Label();
            lbMessage = new Label();
            tbMessage = new TextBox();
            btnSend = new Button();
            btnClear = new Button();
            lbHeader = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(391, 480);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(162, 55);
            btnBack.TabIndex = 4;
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
            lbTime.TabIndex = 19;
            lbTime.Text = "<Time>";
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbDate.Location = new Point(28, 29);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(81, 28);
            lbDate.TabIndex = 18;
            lbDate.Text = "<Date>";
            // 
            // tmrDatetime
            // 
            tmrDatetime.Enabled = true;
            tmrDatetime.Tick += tmrDatetime_Tick;
            // 
            // tbReceiver
            // 
            tbReceiver.CharacterCasing = CharacterCasing.Lower;
            tbReceiver.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbReceiver.Location = new Point(225, 118);
            tbReceiver.MaxLength = 500;
            tbReceiver.Name = "tbReceiver";
            tbReceiver.Size = new Size(494, 34);
            tbReceiver.TabIndex = 0;
            // 
            // lbReceiver
            // 
            lbReceiver.AutoSize = true;
            lbReceiver.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbReceiver.Location = new Point(117, 116);
            lbReceiver.Name = "lbReceiver";
            lbReceiver.Size = new Size(93, 28);
            lbReceiver.TabIndex = 21;
            lbReceiver.Text = "Receiver :";
            // 
            // lbMessage
            // 
            lbMessage.AutoSize = true;
            lbMessage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbMessage.Location = new Point(117, 170);
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new Size(97, 28);
            lbMessage.TabIndex = 22;
            lbMessage.Text = "Message :";
            // 
            // tbMessage
            // 
            tbMessage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbMessage.Location = new Point(225, 170);
            tbMessage.MaxLength = 500;
            tbMessage.Multiline = true;
            tbMessage.Name = "tbMessage";
            tbMessage.ScrollBars = ScrollBars.Vertical;
            tbMessage.Size = new Size(494, 215);
            tbMessage.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSend.Location = new Point(225, 401);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(162, 55);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(558, 401);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(162, 55);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lbHeader
            // 
            lbHeader.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbHeader.Location = new Point(301, 9);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(342, 94);
            lbHeader.TabIndex = 23;
            lbHeader.Text = "New Message";
            lbHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormNewMessage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 573);
            Controls.Add(lbHeader);
            Controls.Add(btnClear);
            Controls.Add(btnSend);
            Controls.Add(tbMessage);
            Controls.Add(lbMessage);
            Controls.Add(lbReceiver);
            Controls.Add(tbReceiver);
            Controls.Add(lbTime);
            Controls.Add(lbDate);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormNewMessage";
            StartPosition = FormStartPosition.Manual;
            Text = "New Message";
            FormClosing += FormNewMessage_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label lbTime;
        private Label lbDate;
        private System.Windows.Forms.Timer tmrDatetime;
        private TextBox tbReceiver;
        private Label lbReceiver;
        private Label lbMessage;
        private TextBox tbMessage;
        private Button btnSend;
        private Button btnClear;
        private Label lbHeader;
    }
}