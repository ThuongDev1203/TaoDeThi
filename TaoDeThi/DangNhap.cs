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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Thay thế các giá trị này bằng thông tin đăng nhập thực tế của bạn
            string validUsername = "user";
            string validPassword = "password";

            if (username == validUsername && password == validPassword)
            {
                MessageBox.Show("Login successful!");
                // Mở form chính hoặc thực hiện hành động khác ở đây
                this.Hide(); // Ẩn form đăng nhập
                DangNhap dangNhap = new DangNhap(); // Tạo form chính
                dangNhap.Show(); // Hiển thị form chính
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
