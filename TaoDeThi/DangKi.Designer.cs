namespace TaoDeThi
{
    partial class DangKi
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
            label3 = new Label();
            txtRegUsername = new TextBox();
            txtRegPassword = new TextBox();
            txtRegConfirmPassword = new TextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(198, 86);
            Username.Name = "Username";
            Username.Size = new Size(75, 20);
            Username.TabIndex = 0;
            Username.Text = "Username";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(198, 152);
            Password.Name = "Password";
            Password.Size = new Size(70, 20);
            Password.TabIndex = 1;
            Password.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 223);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 2;
            label3.Text = "Confirm Password";
            // 
            // txtRegUsername
            // 
            txtRegUsername.Location = new Point(347, 86);
            txtRegUsername.Name = "txtRegUsername";
            txtRegUsername.Size = new Size(248, 27);
            txtRegUsername.TabIndex = 3;
            // 
            // txtRegPassword
            // 
            txtRegPassword.Location = new Point(347, 152);
            txtRegPassword.Name = "txtRegPassword";
            txtRegPassword.Size = new Size(248, 27);
            txtRegPassword.TabIndex = 4;
            // 
            // txtRegConfirmPassword
            // 
            txtRegConfirmPassword.Location = new Point(347, 220);
            txtRegConfirmPassword.Name = "txtRegConfirmPassword";
            txtRegConfirmPassword.Size = new Size(248, 27);
            txtRegConfirmPassword.TabIndex = 5;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(328, 297);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Đăng kí";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // DangKi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(txtRegConfirmPassword);
            Controls.Add(txtRegPassword);
            Controls.Add(txtRegUsername);
            Controls.Add(label3);
            Controls.Add(Password);
            Controls.Add(Username);
            Name = "DangKi";
            Text = "DangKi";
            Load += DangKi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Username;
        private Label Password;
        private Label label3;
        private TextBox txtRegUsername;
        private TextBox txtRegPassword;
        private TextBox txtRegConfirmPassword;
        private Button btnRegister;
    }
}