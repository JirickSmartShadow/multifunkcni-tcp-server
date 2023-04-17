
namespace ZaverecnyProjekt_TcpClient
{
    partial class FormLogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCancel = new Button();
            btnOk = new Button();
            tbPassword = new TextBox();
            lbPassword = new Label();
            tbUsername = new TextBox();
            lbUsername = new Label();
            lbHeader = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(253, 265);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(163, 55);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnOk.Location = new Point(45, 265);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(163, 55);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // tbPassword
            // 
            tbPassword.CharacterCasing = CharacterCasing.Lower;
            tbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbPassword.Location = new Point(171, 177);
            tbPassword.MaxLength = 20;
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(245, 34);
            tbPassword.TabIndex = 1;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbPassword.Location = new Point(45, 180);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(102, 28);
            lbPassword.TabIndex = 10;
            lbPassword.Text = "Password :";
            // 
            // tbUsername
            // 
            tbUsername.CharacterCasing = CharacterCasing.Lower;
            tbUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbUsername.Location = new Point(171, 122);
            tbUsername.MaxLength = 20;
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(245, 34);
            tbUsername.TabIndex = 0;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbUsername.Location = new Point(45, 125);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(108, 28);
            lbUsername.TabIndex = 8;
            lbUsername.Text = "Username :";
            // 
            // lbHeader
            // 
            lbHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbHeader.Location = new Point(183, 36);
            lbHeader.Name = "lbHeader";
            lbHeader.RightToLeft = RightToLeft.No;
            lbHeader.Size = new Size(101, 41);
            lbHeader.TabIndex = 7;
            lbHeader.Text = "Log In";
            // 
            // FormLogIn
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(465, 362);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(lbHeader);
            Controls.Add(tbPassword);
            Controls.Add(lbUsername);
            Controls.Add(lbPassword);
            Controls.Add(tbUsername);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormLogIn";
            StartPosition = FormStartPosition.Manual;
            Text = "Log In";
            FormClosing += FormLogin_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbHeader;
    }
}

