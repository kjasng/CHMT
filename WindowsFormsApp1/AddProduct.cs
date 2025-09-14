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
    public partial class AddProduct: Form
    {
        public AddProduct()
        {
            InitializeComponent();
            LoadCategories();
        }

        private void LoadCategories()
        {
            try
            {
                Modify modify = new Modify();
                DataTable categories = modify.GetAllProductCategories();
                
                categorySelect.DisplayMember = "CategoryName";
                categorySelect.ValueMember = "CategoryId";
                categorySelect.DataSource = categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh mục: " + ex.Message);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string productName = productNameTxt.Text.Trim();
            object categoryId = categorySelect.SelectedValue;
            string quantityText = quantityTxt.Text.Trim();
            string purchaseCostText = purchaseCostTxt.Text.Trim();
            string itemCostText = itemCostTxt.Text.Trim();
            string note = noteTxt.Text.Trim();

            // Validation
            if (string.IsNullOrEmpty(productName) ||
                categoryId == null ||
                string.IsNullOrEmpty(quantityText) ||
                string.IsNullOrEmpty(purchaseCostText) ||
                string.IsNullOrEmpty(itemCostText))
            {
                MessageBox.Show("Vui lòng ghi đầy đủ thông tin tối thiểu của sản phẩm (có chứa *)");
                return;
            }

            // Parse numeric values
            if (!int.TryParse(quantityText, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên không âm!");
                return;
            }

            if (!float.TryParse(purchaseCostText, out float purchaseCost) || purchaseCost < 0)
            {
                MessageBox.Show("Giá nhập phải là số không âm!");
                return;
            }

            if (!float.TryParse(itemCostText, out float itemCost) || itemCost < 0)
            {
                MessageBox.Show("Giá bán phải là số không âm!");
                return;
            }

            try
            {
                string query = @"INSERT INTO Product
                                (ProductName, CategoryId, Quantity, PurchaseCost, ItemCost, Note)
                                VALUES ('" + productName + "', " + categoryId + ", " + quantity + ", " + purchaseCost + ", " + itemCost + ", " + (string.IsNullOrEmpty(note) ? "NULL" : "'" + note + "'") + ")";
                
                Modify modify = new Modify();
                int result = modify.ExecuteNonQuery(query);
                
                if (result > 0)
                {
                    MessageBox.Show("Thêm sản phẩm thành công!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sản phẩm: " + ex.Message);
            }
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}