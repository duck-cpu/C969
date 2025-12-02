namespace C969
{
    partial class LoginForm
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
            labelUsername = new Label();
            textboxUsername = new TextBox();
            passwordLabel = new Label();
            textboxPassword = new TextBox();
            buttonLogin = new Button();
            labelLocale = new Label();
            SuspendLayout();
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(96, 77);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(126, 32);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Username:";
            labelUsername.Click += labelUsername_Click;
            // 
            // textboxUsername
            // 
            textboxUsername.Location = new Point(228, 77);
            textboxUsername.Name = "textboxUsername";
            textboxUsername.Size = new Size(200, 39);
            textboxUsername.TabIndex = 1;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(106, 126);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(116, 32);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password:";
            // 
            // textboxPassword
            // 
            textboxPassword.Location = new Point(228, 126);
            textboxPassword.Name = "textboxPassword";
            textboxPassword.PasswordChar = '*';
            textboxPassword.Size = new Size(200, 39);
            textboxPassword.TabIndex = 3;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(278, 171);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(150, 46);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // labelLocale
            // 
            labelLocale.Location = new Point(96, 220);
            labelLocale.Name = "labelLocale";
            labelLocale.Size = new Size(332, 102);
            labelLocale.TabIndex = 5;
            labelLocale.TextAlign = ContentAlignment.TopRight;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 389);
            Controls.Add(labelLocale);
            Controls.Add(buttonLogin);
            Controls.Add(textboxPassword);
            Controls.Add(passwordLabel);
            Controls.Add(textboxUsername);
            Controls.Add(labelUsername);
            Name = "LoginForm";
            Text = "Login";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUsername;
        private TextBox textboxUsername;
        private Label passwordLabel;
        private TextBox textboxPassword;
        private Button buttonLogin;
        private Label labelLocale;
    }
}
