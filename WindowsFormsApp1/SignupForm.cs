using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SignupForm: Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;
            string confirmPassword = confirmPasswordTxt.Text;
            string identityCard = identityCardTxt.Text;
            if (username.Trim() == "" || password.Trim() == "" || confirmPassword.Trim() == "" || identityCard.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            else if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu không khớp!");
                return;
            }
            else if (password.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!");
                return;
            }
            else if (username.Length < 6)
            {
                MessageBox.Show("Tên đăng nhập phải có ít nhất 6 ký tự!");
                return;
            }
            else if (identityCard.Length != 10)
            {
                MessageBox.Show("Số CMND/CCCD phải có đúng 10 ký tự!");
                return;
            }
            else
            {
                Modify modify = new Modify();
                string query = "INSERT INTO Users (username, password, identificard, role) VALUES ('" + username + "', '" + password + "', '" + identityCard + "', '0')";
                string checkQuery = "SELECT * FROM Users WHERE username = '" + username + "'";
                if (modify.Users(checkQuery).Count != 0)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!");
                    return;
                }

                int result = modify.ExecuteNonQuery(query);
                if (result > 0)
                {
                    MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
