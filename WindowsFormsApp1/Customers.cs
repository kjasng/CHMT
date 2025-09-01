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
    public partial class Customers: Form
    {
        DataTable dt;
        AddCustomer addCustomer = new AddCustomer();
        public Customers()
        {
            InitializeComponent();
        }

        private void formDashboard_Load(object sender, EventArgs e)
        {
            //this.ControlBox = false;

            Modify modify = new Modify();

            dt = modify.GetAllCustomers();
            dataGridView1.DataSource = dt;

        }

        private void fetchCustomers_Click(object sender, EventArgs e)
        {
            // Fetch customers from database and display in
            Modify modify = new Modify();

            dt = modify.GetAllCustomers();
            dataGridView1.DataSource = dt;


        }

        private void addCustomers_Click(object sender, EventArgs e)
        {
            addCustomer.ShowDialog();
        }

        private void delCustomerBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xoá!");
                return;
            }

            string customerId = dataGridView1.CurrentRow.Cells["CustomerID"].Value.ToString();

            DialogResult dialogResult = MessageBox.Show(
                this,
                "Bạn có chắc chắn muốn xoá khách hàng này không?",
                "Xác nhận xoá",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                Modify modify = new Modify();
                string query = @"DELETE FROM Customers WHERE CustomerID = " + customerId;

                int result = modify.ExecuteNonQuery(query);

                if (result > 0)
                {
                    MessageBox.Show("Xóa khách hàng thành công!");
                    dt = modify.GetAllCustomers();
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Xóa khách hàng thất bại hoặc không tìm thấy ID!");
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Gender" && e.Value != null)
            {
                int genderValue = Convert.ToInt32(e.Value);
                e.Value = (genderValue == 0) ? "Nam" : "Nữ";
                e.FormattingApplied = true;
            }
        }

        private void editCustomerBtn_Click(object sender, EventArgs e)
        {
            string firstname = dataGridView1.CurrentRow.Cells["Firstname"].Value?.ToString();
            string lastname = dataGridView1.CurrentRow.Cells["Lastname"].Value?.ToString();
            int gender = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Gender"].Value);
            DateTime dob = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["DateOfBirth"].Value);
            string address = dataGridView1.CurrentRow.Cells["Address"].Value?.ToString();
            string district = dataGridView1.CurrentRow.Cells["District"].Value?.ToString();
            string phone = dataGridView1.CurrentRow.Cells["Phone"].Value?.ToString();
            string idCard = dataGridView1.CurrentRow.Cells["Identificard"].Value?.ToString();
            string note = dataGridView1.CurrentRow.Cells["Note"].Value?.ToString();

            EditCustomer editCustomer = new EditCustomer(firstname, lastname, gender, dob, address, district, phone, idCard, note);
            //editCustomer.ShowDialog();

            if (editCustomer.ShowDialog() == DialogResult.OK)
            {
                // Nếu update thành công thì fetch lại dữ liệu
                Modify modify = new Modify();

                dt = modify.GetAllCustomers();
                dataGridView1.DataSource = dt;
            }
        }

    }
}
