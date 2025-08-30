using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class AddCustomer: Form
    {
        public AddCustomer()
        {
            InitializeComponent();
            customDatePicker1.DateChanged += customDatePicker1_DateChanged_1;
        }



        // Hàm xử lý sự kiện Load của customDatePicker1
        private void customDatePicker1_Load_1(object sender, EventArgs e)
        {

        }

        // Hàm xử lý sự kiện DateChanged của customDatePicker1
        private void customDatePicker1_DateChanged_1(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Hàm xử lý thêm khách hàng
        private void addBtn_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTxt.Text;
            string lastName = lastNameTxt.Text;
            int? gender = genderSelect.SelectedIndex;

            DateTime dateOfBirth = customDatePicker1.SelectedDate.Value;
            string dob = dateOfBirth.ToString("yyyy-MM-dd");
            string address = addressTxt.Text;
            string district = districtTxt.Text;
            string phone = phoneTxt.Text;
            string idCard = identifyCardTxt.Text;
            string note = noteTxt.Text;

            if (firstName.Trim() == "" ||
                lastName.Trim() == "" ||
                !gender.HasValue ||
                !customDatePicker1.SelectedDate.HasValue ||
                address.Trim() == "" ||
                district.Trim() == "" ||
                phone.Trim() == "" ||
                idCard.Trim() == ""
                )
            {
                MessageBox.Show("Vui lòng ghi đầy đủ thông tin tối thiểu của khách hàng (có chứa *)");
            }
            else {
                string query = @"INSERT INTO Customers
                                (Firstname, Lastname, Gender, DateOfBirth, Address, District, Phone, Identificard, Note)
                                VALUES ('" + firstName + "', '" + lastName + "', '" + gender + "', '" + dob + "', '" + address + "', '" + district + "', '" + phone + "', '" + idCard + "', '" + note + "')";
                Modify modify = new Modify();

                modify.Customers(query);
                MessageBox.Show("Thêm khách hàng thành công!");
                this.Close();
            }
        }
    }
}
