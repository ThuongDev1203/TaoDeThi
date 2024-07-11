namespace TaoDeThi
{
    partial class DangNhap
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
            Username = new Label();
            Password = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(214, 116);
            Username.Name = "Username";
            Username.Size = new Size(75, 20);
            Username.TabIndex = 0;
            Username.Text = "Username";
            Username.Click += label1_Click;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(214, 190);
            Password.Name = "Password";
            Password.Size = new Size(70, 20);
            Password.TabIndex = 1;
            Password.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(361, 113);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(233, 27);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(361, 190);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(233, 27);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(345, 282);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(Password);
            Controls.Add(Username);
            Name = "DangNhap";
            Text = "DangNhap";
            Load += DangNhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Username;
        private Label Password;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}