using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaoDeThi
{
    public partial class DangKi : Form
    {
        public DangKi()
        {
            InitializeComponent();
        }

        private void DangKi_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtRegUsername.Text;
            string password = txtRegPassword.Text;
            string confirmPassword = txtRegConfirmPassword.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            // Lưu thông tin đăng ký (ở đây là ví dụ, bạn có thể lưu vào cơ sở dữ liệu hoặc file)
            // Kiểm tra nếu tên người dùng đã tồn tại (để kiểm tra, bạn cần một danh sách hoặc cơ sở dữ liệu)

            if (IsUsernameTaken(username))
            {
                MessageBox.Show("Username is already taken.");
            }
            else
            {
                SaveUserInfo(username, password);
                MessageBox.Show("Registration successful!");
                this.Close();
            }
        }

        private bool IsUsernameTaken(string username)
        {
            // Kiểm tra tên người dùng đã tồn tại
            // Ví dụ sử dụng danh sách tạm thời
            var existingUsers = new List<string> { "user1", "user2" }; // Thay bằng kiểm tra cơ sở dữ liệu

            return existingUsers.Contains(username);
        }

        private void SaveUserInfo(string username, string password)
        {
            // Lưu thông tin người dùng
            // Ví dụ sử dụng file (thay bằng lưu vào cơ sở dữ liệu)
            string userInfo = $"{username}:{password}\n";
            System.IO.File.AppendAllText("users.txt", userInfo);
        }
    }
}
}
