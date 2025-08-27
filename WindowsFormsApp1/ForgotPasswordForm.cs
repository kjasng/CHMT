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
			label2.Text = "";
		}
		Modify modify = new Modify();

		private void button1_Click(object sender, EventArgs e)
		{
			string username = textBox1.Text;
			if (username.Trim() == "") { MessageBox.Show("Vui lòng nhập tài khoản!"); }
			else
			{
				string query = "SELECT * FROM Users WHERE username = '" + username + "'";
				if (modify.Users(query).Count != 0)
				{
					label2.ForeColor = Color.Blue;
					label2.Text = "Mật khẩu: " + modify.Users(query)[0].Password;
				}
				else
				{
					label2.ForeColor = Color.Red;
					label2.Text = "Tài khoản này chưa được đăng ký!";
				}
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}
	}
}
