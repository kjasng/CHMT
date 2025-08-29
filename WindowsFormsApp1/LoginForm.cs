using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm: Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        Modify modify = new Modify();

        private void Login_Click(object sender, EventArgs e)
        {
            string username = loginUsernameTxt.Text;
            string password = loginPasswordTxt.Text;
            if(username.Trim() == "" || password.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoảng/mật khẩu!");
                return;
            } else {
                string query = "SELECT * FROM Users WHERE username = '" + username + "' AND password = '" + password + "'";
                if(modify.Users(query).Count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form1 mainForm = new Form1();
                    mainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản/mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            signupForm.Show();


        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            forgotPasswordForm.Show();

            //this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
