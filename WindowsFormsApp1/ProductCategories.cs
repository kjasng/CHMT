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
    public partial class ProductCategories: Form
    {
        DataTable dt;
        AddProductCategories addProductCategories = new AddProductCategories();

        public ProductCategories()
        {
            InitializeComponent();
        }

        private void ProductCategories_Load(object sender, EventArgs e)
        {
            LoadProductCategories();
            ConfigureDataGridView();
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

        private void LoadProductCategories()
        {
            Modify modify = new Modify();
            dt = modify.GetAllProductCategories();
            dataGridView1.DataSource = dt;
            
            if (dataGridView1.Columns.Contains("CategoryID"))
                dataGridView1.Columns["CategoryID"].HeaderText = "Mã loại";
            if (dataGridView1.Columns.Contains("CategoryName"))
                dataGridView1.Columns["CategoryName"].HeaderText = "Tên danh mục";
            if (dataGridView1.Columns.Contains("Description"))
                dataGridView1.Columns["Description"].HeaderText = "Mô tả";
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(searchText) && searchText != "Tìm kiếm danh mục...")
            {
                Modify modify = new Modify();
                dt = modify.SearchProductCategories(searchText);
                dataGridView1.DataSource = dt;
            }
            else
            {
                LoadProductCategories();
            }
        }

        private void clearSearchBtn_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = "Tìm kiếm danh mục...";
            searchTextBox.ForeColor = Color.Gray;
            LoadProductCategories();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadProductCategories();
            searchTextBox.Text = "Tìm kiếm danh mục...";
            searchTextBox.ForeColor = Color.Gray;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addProductCategories.ShowDialog();
            LoadProductCategories();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn danh mục để sửa!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int categoryId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CategoryID"].Value);
            string categoryName = dataGridView1.CurrentRow.Cells["CategoryName"].Value?.ToString();
            string description = dataGridView1.CurrentRow.Cells["Description"].Value?.ToString();

            using (var editForm = new Form())
            {
                editForm.Text = "Sửa danh mục";
                editForm.Size = new Size(400, 250);
                editForm.StartPosition = FormStartPosition.CenterParent;

                var lblName = new Label { Text = "Tên danh mục:", Location = new Point(20, 20), Size = new Size(100, 25) };
                var txtName = new TextBox { Text = categoryName, Location = new Point(130, 20), Size = new Size(230, 25) };

                var lblDesc = new Label { Text = "Mô tả:", Location = new Point(20, 60), Size = new Size(100, 25) };
                var txtDesc = new TextBox { Text = description, Location = new Point(130, 60), Size = new Size(230, 60), Multiline = true };

                var btnSave = new Button { Text = "Lưu", Location = new Point(130, 140), Size = new Size(100, 30) };
                var btnCancel = new Button { Text = "Hủy", Location = new Point(260, 140), Size = new Size(100, 30) };

                btnSave.Click += (s, args) =>
                {
                    if (string.IsNullOrWhiteSpace(txtName.Text))
                    {
                        MessageBox.Show("Vui lòng nhập tên danh mục!");
                        return;
                    }

                    string query = $@"UPDATE ProductCategory 
                                    SET CategoryName = N'{txtName.Text}', 
                                        Description = N'{txtDesc.Text}' 
                                    WHERE CategoryID = {categoryId}";

                    Modify modify = new Modify();
                    int result = modify.ExecuteNonQuery(query);
                    
                    if (result > 0)
                    {
                        MessageBox.Show("Cập nhật danh mục thành công!");
                        editForm.DialogResult = DialogResult.OK;
                        editForm.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật danh mục!");
                    }
                };

                btnCancel.Click += (s, args) => editForm.Close();

                editForm.Controls.AddRange(new Control[] { lblName, txtName, lblDesc, txtDesc, btnSave, btnCancel });
                
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadProductCategories();
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn danh mục để xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string categoryId = dataGridView1.CurrentRow.Cells["CategoryID"].Value.ToString();
            string categoryName = dataGridView1.CurrentRow.Cells["CategoryName"].Value.ToString();

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa danh mục '{categoryName}'?\n" +
                "Lưu ý: Điều này có thể ảnh hưởng đến các sản phẩm thuộc danh mục này.",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Modify modify = new Modify();
                string query = $"DELETE FROM ProductCategory WHERE CategoryID = {categoryId}";
                
                try
                {
                    int affected = modify.ExecuteNonQuery(query);
                    if (affected > 0)
                    {
                        MessageBox.Show("Xóa danh mục thành công!", "Thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProductCategories();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa danh mục!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa danh mục: {ex.Message}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "Tìm kiếm danh mục...")
            {
                searchTextBox.Text = "";
                searchTextBox.ForeColor = Color.Black;
            }
        }

        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                searchTextBox.Text = "Tìm kiếm danh mục...";
                searchTextBox.ForeColor = Color.Gray;
            }
        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchBtn_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }
    }
}