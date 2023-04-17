namespace ZaverecnyProjekt_TcpClient
{
    partial class FormStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            btnLogIn = new Button();
            btnSignUp = new Button();
            lbHeader = new Label();
            SuspendLayout();
            // 
            // btnLogIn
            // 
            resources.ApplyResources(btnLogIn, "btnLogIn");
            btnLogIn.Name = "btnLogIn";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogin_Click;
            // 
            // btnSignUp
            // 
            resources.ApplyResources(btnSignUp, "btnSignUp");
            btnSignUp.Name = "btnSignUp";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // lbHeader
            // 
            resources.ApplyResources(lbHeader, "lbHeader");
            lbHeader.Name = "lbHeader";
            // 
            // FormStart
            // 
            AcceptButton = btnLogIn;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbHeader);
            Controls.Add(btnSignUp);
            Controls.Add(btnLogIn);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormStart";
            FormClosed += FormStart_FormClosed;
            Load += FormStart_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogIn;
        private Button btnSignUp;
        private Label lbHeader;
    }
}