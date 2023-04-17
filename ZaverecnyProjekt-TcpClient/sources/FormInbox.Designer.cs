namespace ZaverecnyProjekt_TcpClient
{
    partial class FormInbox
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
            tmrDatetime = new System.Windows.Forms.Timer(components);
            btnBack = new Button();
            btnRefresh = new Button();
            flpInbox = new FlowLayoutPanel();
            lbHeader = new Label();
            SuspendLayout();
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
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.Location = new Point(110, 432);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(162, 55);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // flpInbox
            // 
            flpInbox.AutoScroll = true;
            flpInbox.BorderStyle = BorderStyle.FixedSingle;
            flpInbox.FlowDirection = FlowDirection.TopDown;
            flpInbox.Location = new Point(111, 111);
            flpInbox.Name = "flpInbox";
            flpInbox.Size = new Size(722, 313);
            flpInbox.TabIndex = 0;
            flpInbox.WrapContents = false;
            // 
            // lbHeader
            // 
            lbHeader.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbHeader.Location = new Point(347, 9);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(249, 93);
            lbHeader.TabIndex = 24;
            lbHeader.Text = "Inbox";
            lbHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormInbox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 573);
            Controls.Add(lbHeader);
            Controls.Add(flpInbox);
            Controls.Add(btnRefresh);
            Controls.Add(btnBack);
            Controls.Add(lbTime);
            Controls.Add(lbDate);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormInbox";
            StartPosition = FormStartPosition.Manual;
            Text = "Inbox";
            Activated += FormInbox_Activated;
            FormClosing += FormInbox_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTime;
        private Label lbDate;
        private System.Windows.Forms.Timer tmrDatetime;
        private Button btnBack;
        private Button btnRefresh;
        private FlowLayoutPanel flpInbox;
        private Label lbHeader;
    }
}