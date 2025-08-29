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
	public partial class ForgotPasswordForm : Form
	{
		public ForgotPasswordForm()
		{
			InitializeComponent();
			label3.Text = "";
		}
		Modify modify = new Modify();

		private void button1_Click(object sender, EventArgs e)
		{

            // Khai báo biến để lưu trữ credentials từ input
            string username = forgotUsernameTxt.Text;
			string identifyCard = identifyCardTxt.Text;

            // Kiểm tra nếu input rỗng thì hiện thông báo
            if (username.Trim() == "" || identifyCard.Trim() == "") { MessageBox.Show("Vui lòng nhập tài khoản và CCCD!"); }
			else
			{
				string query = "SELECT * FROM Users WHERE username = '" + username + "' AND identificard = '" + identifyCard + "'";
				if (modify.Users(query).Count != 0)
				{
                    // Cập nhật mật khẩu về mặc định là 123456
                    string updatePassword = "UPDATE Users SET password = '123456' WHERE username = '" + username + "'";
					modify.Users(updatePassword);
                    label3.ForeColor = Color.Blue;
					label3.Text = "Bạn đã thành công lấy lại mật khẩu: " + modify.Users(query)[0].Password;
				}
				else
				{
					label3.ForeColor = Color.Red;
					label3.Text = "Tài khoản này chưa được đăng ký!";
				}
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
