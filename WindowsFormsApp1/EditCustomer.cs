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
    public partial class EditCustomer: Form
    {
        private int customerId;
        private string oldFirstname;
        private string oldLastname;
        private int oldGender;
        private DateTime dolDOB;
        private string oldAddress;
        private string oldDistrict;
        private string oldPhone;
        private string oldIdcard;
        private string oldNote;
        public EditCustomer(int CustomerID, string Firstname, string Lastname, int Gender, DateTime DOB, string Address, string District, string Phone, string idCard, string Note)
        {
            InitializeComponent();


            // store old value
            customerId = CustomerID;
            oldFirstname = Firstname;
            oldLastname = Lastname;
            oldGender = Gender;
            dolDOB = DOB;
            oldAddress = Address;
            oldDistrict = District;
            oldPhone = Phone;
            oldIdcard = idCard;
            oldNote = Note;

            // init form edit
            firstNameTxt.Text = Firstname;
            lastNameTxt.Text = Lastname;
            GenderInt.SelectedItem = (Gender == 0) ? "Nam" : "Nữ";
            customDatePicker1.Value = DOB;
            addressTxt.Text = Address;
            districtTxt.Text = District;
            phoneTxt.Text = Phone;
            identifyCardTxt.Text = idCard;
            noteTxt.Text = Note;
        }   

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newFirstname = firstNameTxt.Text.Trim();
            string newLastname = lastNameTxt.Text.Trim();
            int newGender = GenderInt.SelectedIndex;
            DateTime newDOB = customDatePicker1.Value.Value;
            string newAddress = addressTxt.Text.Trim();
            string newDistrict = districtTxt.Text.Trim();
            string newPhone = phoneTxt.Text.Trim();
            string newIdCard = identifyCardTxt.Text.Trim();
            string newNote = noteTxt.Text.Trim();

            bool isChanged = oldFirstname != newFirstname ||
                             oldLastname != newLastname ||
                             oldGender != newGender ||
                             dolDOB != newDOB ||
                             oldAddress != newAddress ||
                             oldDistrict != newDistrict ||
                             oldPhone != newPhone ||
                             oldIdcard != newIdCard ||
                             oldNote != newNote;

            if (!isChanged)
            {
                MessageBox.Show("Dữ liệu không thay đổi, không cần cập nhật.");
                return;
            }
            else
            {
                string query = $@"
                                UPDATE Customers
                                SET
                                    Firstname = '{newFirstname}',
                                    Lastname = '{newLastname}',
                                    Gender = {newGender},
                                    DateOfBirth = '{newDOB.ToString("yyyy-MM-dd")}',
                                    Address = '{newAddress}',
                                    District = '{newDistrict}',
                                    Phone = '{newPhone}',
                                    Identificard = '{newIdCard}',
                                    Note = '{newNote}'
                                WHERE CustomerID = {customerId}";

                Modify modify = new Modify();
                int result = modify.ExecuteNonQuery(query);

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật khách hàng thành công.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật khách hàng thất bại!");
                }
            }
        }
    }
}
