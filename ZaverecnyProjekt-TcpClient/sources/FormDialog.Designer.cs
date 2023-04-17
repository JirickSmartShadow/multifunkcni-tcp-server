namespace ZaverecnyProjekt_TcpClient
{
    partial class FormDialog
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
            lbMessage = new Label();
            btnOk = new Button();
            lbHeader = new Label();
            SuspendLayout();
            // 
            // lbMessage
            // 
            lbMessage.Location = new Point(12, 97);
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new Size(350, 63);
            lbMessage.TabIndex = 5;
            lbMessage.Text = "<Dialog message>";
            lbMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnOk.Location = new Point(130, 184);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(112, 42);
            btnOk.TabIndex = 0;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // lbHeader
            // 
            lbHeader.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbHeader.Location = new Point(12, 9);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(350, 75);
            lbHeader.TabIndex = 3;
            lbHeader.Text = "<Dialog Header>";
            lbHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormDialog
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 238);
            Controls.Add(lbMessage);
            Controls.Add(btnOk);
            Controls.Add(lbHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "<Dialog Name>";
            ResumeLayout(false);
        }

        #endregion

        private Label lbMessage;
        private Button btnOk;
        private Label lbHeader;
    }
}