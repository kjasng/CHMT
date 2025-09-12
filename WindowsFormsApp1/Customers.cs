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
            ConfigureDataGridView();

            if (dataGridView1.Columns.Contains("CustomerID"))
                dataGridView1.Columns["CustomerID"].HeaderText = "Mã KH";
            if (dataGridView1.Columns.Contains("Firstname"))
                dataGridView1.Columns["Firstname"].HeaderText = "Tên";
            if (dataGridView1.Columns.Contains("Lastname"))
                dataGridView1.Columns["Lastname"].HeaderText = "Họ";
            if (dataGridView1.Columns.Contains("Gender"))
                dataGridView1.Columns["Gender"].HeaderText = "Giới tính";
            if (dataGridView1.Columns.Contains("DateOfBirth"))
                dataGridView1.Columns["DateOfBirth"].HeaderText = "Ngày sinh";
            if (dataGridView1.Columns.Contains("Address"))
                dataGridView1.Columns["Address"].HeaderText = "Địa chỉ";
            if (dataGridView1.Columns.Contains("District"))
                dataGridView1.Columns["District"].HeaderText = "Quận/Huyện";
            if (dataGridView1.Columns.Contains("Phone"))
                dataGridView1.Columns["Phone"].HeaderText = "Số điện thoại";
            if (dataGridView1.Columns.Contains("Identificard"))
                dataGridView1.Columns["Identificard"].HeaderText = "CMND/CCCD";
            if (dataGridView1.Columns.Contains("Note"))
                dataGridView1.Columns["Note"].HeaderText = "Ghi chú";

        }

        private void ConfigureDataGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 230, 250);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
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
