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

namespace WindowsFormsApp1
{
    public partial class AddProductCategories: Form
    {
        public AddProductCategories()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string categoryName = categoryNameTxt.Text;
            string description = descriptionTxt.Text;

            if (categoryName.Trim() == "" || description.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            else {
                string query = @"INSERT INTO ProductCategory
                                (CategoryName, Description)
                                VALUES ('" + categoryName + "', '" + description + "')";
                Modify modify = new Modify();

                modify.ProductCategories(query);
                MessageBox.Show("Thêm phân loại sản phẩm thành công!");
                
                this.Close();
            }
        }
    }
}
