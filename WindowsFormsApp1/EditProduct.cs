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
    public partial class EditProduct: Form
    {
        private int oldProductId;
        private string oldProductName;
        private int oldCategoryId;
        private int oldQuantity;
        private float oldPurchaseCost;
        private float oldItemCost;
        private string oldNote;

        public EditProduct(int productId, string productName, int categoryId, int quantity, float purchaseCost, float itemCost, string note)
        {
            InitializeComponent();
            LoadCategories();

            // Store old values
            oldProductId = productId;
            oldProductName = productName;
            oldCategoryId = categoryId;
            oldQuantity = quantity;
            oldPurchaseCost = purchaseCost;
            oldItemCost = itemCost;
            oldNote = note;

            // Initialize form with current values
            productNameTxt.Text = productName;
            categorySelect.SelectedValue = categoryId;
            quantityTxt.Text = quantity.ToString();
            purchaseCostTxt.Text = purchaseCost.ToString();
            itemCostTxt.Text = itemCost.ToString();
            noteTxt.Text = note;
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string newProductName = productNameTxt.Text.Trim();
            object newCategoryId = categorySelect.SelectedValue;
            string quantityText = quantityTxt.Text.Trim();
            string purchaseCostText = purchaseCostTxt.Text.Trim();
            string itemCostText = itemCostTxt.Text.Trim();
            string newNote = noteTxt.Text.Trim();

            // Validation
            if (string.IsNullOrEmpty(newProductName) ||
                newCategoryId == null ||
                string.IsNullOrEmpty(quantityText) ||
                string.IsNullOrEmpty(purchaseCostText) ||
                string.IsNullOrEmpty(itemCostText))
            {
                MessageBox.Show("Vui lòng ghi đầy đủ thông tin tối thiểu của sản phẩm (có chứa *)");
                return;
            }

            // Parse numeric values
            if (!int.TryParse(quantityText, out int newQuantity) || newQuantity < 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên không âm!");
                return;
            }

            if (!float.TryParse(purchaseCostText, out float newPurchaseCost) || newPurchaseCost < 0)
            {
                MessageBox.Show("Giá nhập phải là số không âm!");
                return;
            }

            if (!float.TryParse(itemCostText, out float newItemCost) || newItemCost < 0)
            {
                MessageBox.Show("Giá bán phải là số không âm!");
                return;
            }

            // Check if any changes were made
            bool isChanged = oldProductName != newProductName ||
                             oldCategoryId != Convert.ToInt32(newCategoryId) ||
                             oldQuantity != newQuantity ||
                             oldPurchaseCost != newPurchaseCost ||
                             oldItemCost != newItemCost ||
                             oldNote != newNote;

            if (!isChanged)
            {
                MessageBox.Show("Dữ liệu không thay đổi, không cần cập nhật.");
                return;
            }

            try
            {
                string query = $@"
                                UPDATE Product
                                SET 
                                    ProductName = '{newProductName}',
                                    CategoryId = {newCategoryId},
                                    Quantity = {newQuantity},
                                    PurchaseCost = {newPurchaseCost},
                                    ItemCost = {newItemCost},
                                    Note = {(string.IsNullOrEmpty(newNote) ? "NULL" : "'" + newNote + "'")}
                                WHERE ProductID = {oldProductId}";

                Modify modify = new Modify();
                int result = modify.ExecuteNonQuery(query);

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật sản phẩm thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật sản phẩm: " + ex.Message);
            }
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}