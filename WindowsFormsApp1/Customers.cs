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
    }
}
