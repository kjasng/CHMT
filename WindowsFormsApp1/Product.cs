using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Bibliography;


namespace WindowsFormsApp1
{
    public partial class Product: Form
    {
        DataTable dt;
        AddProduct addProduct = new AddProduct();
        public Product()
        {
            InitializeComponent();
        }

        // Export DataTable to CSV
        private void ExportCSV(DataTable dt)
        {
            if (dt.Rows.Count > 0) {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (XLWorkbook wb = new XLWorkbook())
                            {
                                var ws = wb.Worksheets.Add("SanPham");

                                ws.Range("A1:G1").Merge();
                                ws.Cell("A1").Value = "Danh sách sản phẩm";
                                ws.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                                // Ghi header
                                for (int i = 0; i < dt.Columns.Count; i++)
                                {
                                    ws.Cell(2, i + 1).Value = dt.Columns[i].ColumnName;
                                }

                                // Ghi dữ liệu
                                for(int i = 0; i<dt.Rows.Count; i++)
                                {
                                    for (int j = 0; j < dt.Columns.Count; j++)
                                    {
                                        ws.Cell(i + 3, j + 1).Value = dt.Rows[i][j] == DBNull.Value ? "" : dt.Rows[i][j].ToString();
                                    }
                                }



                                // Thêm border cho bảng
                                var range = ws.Range(1, 1, dt.Rows.Count +1, dt.Columns.Count);
                                range.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                                range.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                                // Tự động co dãn cột
                                ws.Columns().AdjustToContents();

                                // Lưu file
                                wb.SaveAs(sfd.FileName);
                            }

                            MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            } 
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void formProduct_Load(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            dt = modify.GetAllProducts();
            dataGridView1.DataSource = dt;
            
            // Configure DataGridView appearance
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            
            ConfigureDataGridView();
            LoadCategories();
        }

        // Load categories into ComboBox
        private void LoadCategories()
        {
            try
            {
                Modify modify = new Modify();
                DataTable categories = modify.GetAllProductCategories();
                
                // Add "All" option at the beginning
                DataRow allRow = categories.NewRow();
                allRow[0] = 0;  // First column (ID)
                allRow[1] = "-- Tất cả --";  // Second column (Name)
                if (categories.Columns.Count > 2)
                    allRow[2] = "";  // Third column if exists (Description)
                categories.Rows.InsertAt(allRow, 0);
                
                categoryComboBox.DataSource = categories;
                categoryComboBox.DisplayMember = categories.Columns[1].ColumnName;  // Use second column for display
                categoryComboBox.ValueMember = categories.Columns[0].ColumnName;  // Use first column for value
                categoryComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh mục: " + ex.Message);
            }
        }

        private void fetchProducts_Click(object sender, EventArgs e)
        {
            // Reset category filter to "All"
            if (categoryComboBox != null && categoryComboBox.Items.Count > 0)
            {
                categoryComboBox.SelectedIndex = 0;
            }

            Modify modify = new Modify();
            dt = modify.GetAllProducts();
            dataGridView1.DataSource = dt;
            ConfigureDataGridView();
        }

        // Configure DataGridView columns and appearance
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

            if (dataGridView1.Columns.Count > 0)
            {
                // Configure columns based on their index to ensure proper mapping
                try
                {
                    // Check if columns exist by name first
                    if (dataGridView1.Columns.Contains("ProductID"))
                    {
                        dataGridView1.Columns["ProductID"].HeaderText = "Mã SP";
                        dataGridView1.Columns["ProductID"].Width = 80;
                        dataGridView1.Columns["ProductID"].DisplayIndex = 0;
                    }
                    
                    if (dataGridView1.Columns.Contains("ProductName"))
                    {
                        dataGridView1.Columns["ProductName"].HeaderText = "Tên sản phẩm";
                        dataGridView1.Columns["ProductName"].Width = 200;
                        dataGridView1.Columns["ProductName"].DisplayIndex = 1;
                    }
                    
                    if (dataGridView1.Columns.Contains("CategoryId"))
                    {
                        dataGridView1.Columns["CategoryId"].HeaderText = "Mã loại";
                        dataGridView1.Columns["CategoryId"].Width = 90;
                        dataGridView1.Columns["CategoryId"].DisplayIndex = 2;
                    }
                    
                    if (dataGridView1.Columns.Contains("Quantity"))
                    {
                        dataGridView1.Columns["Quantity"].HeaderText = "Số lượng";
                        dataGridView1.Columns["Quantity"].Width = 100;
                        dataGridView1.Columns["Quantity"].DisplayIndex = 3;
                    }
                    
                    if (dataGridView1.Columns.Contains("PurchaseCost"))
                    {
                        dataGridView1.Columns["PurchaseCost"].HeaderText = "Giá nhập";
                        dataGridView1.Columns["PurchaseCost"].Width = 120;
                        dataGridView1.Columns["PurchaseCost"].DefaultCellStyle.Format = "N0";
                        dataGridView1.Columns["PurchaseCost"].DisplayIndex = 4;
                    }
                    
                    if (dataGridView1.Columns.Contains("ItemCost"))
                    {
                        dataGridView1.Columns["ItemCost"].HeaderText = "Giá bán";
                        dataGridView1.Columns["ItemCost"].Width = 120;
                        dataGridView1.Columns["ItemCost"].DefaultCellStyle.Format = "N0";
                        dataGridView1.Columns["ItemCost"].DisplayIndex = 5;
                    }
                    
                    if (dataGridView1.Columns.Contains("Note"))
                    {
                        dataGridView1.Columns["Note"].HeaderText = "Ghi chú";
                        dataGridView1.Columns["Note"].Width = 180;
                        dataGridView1.Columns["Note"].DisplayIndex = 6;
                    }
                }
                catch
                {
                    // If specific columns don't exist, configure by index
                    if (dataGridView1.Columns.Count >= 7)
                    {
                        dataGridView1.Columns[0].HeaderText = "Mã SP";
                        dataGridView1.Columns[0].Width = 80;
                        
                        dataGridView1.Columns[1].HeaderText = "Tên sản phẩm";
                        dataGridView1.Columns[1].Width = 200;
                        
                        dataGridView1.Columns[2].HeaderText = "Mã loại";
                        dataGridView1.Columns[2].Width = 90;
                        
                        dataGridView1.Columns[3].HeaderText = "Số lượng";
                        dataGridView1.Columns[3].Width = 100;
                        
                        dataGridView1.Columns[4].HeaderText = "Giá nhập";
                        dataGridView1.Columns[4].Width = 120;
                        dataGridView1.Columns[4].DefaultCellStyle.Format = "N0";
                        
                        dataGridView1.Columns[5].HeaderText = "Giá bán";
                        dataGridView1.Columns[5].Width = 120;
                        dataGridView1.Columns[5].DefaultCellStyle.Format = "N0";
                        
                        dataGridView1.Columns[6].HeaderText = "Ghi chú";
                        dataGridView1.Columns[6].Width = 180;
                    }
                }
            }
        }

        // Add product button click
        private void addProducts_Click_1(object sender, EventArgs e)
        {
            if (addProduct.ShowDialog() == DialogResult.OK)
            {
                // Refresh data after successful addition
                Modify modify = new Modify();
                dt = modify.GetAllProducts();
                dataGridView1.DataSource = dt;
                ConfigureDataGridView();
            }
        }

        // Delete product button click
        private void delProductBtn_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xoá!");
                return;
            }

            try
            {
                string productId = dataGridView1.CurrentRow.Cells["ProductID"].Value.ToString();
                string productName = dataGridView1.CurrentRow.Cells["ProductName"].Value?.ToString() ?? "Sản phẩm";

                DialogResult dialogResult = MessageBox.Show(
                    this,
                    $"Bạn có chắc chắn muốn xoá sản phẩm '{productName}' không?",
                    "Xác nhận xoá",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    Modify modify = new Modify();
                    string query = @"DELETE FROM Product WHERE ProductID = " + productId;

                    int result = modify.ExecuteNonQuery(query);

                    if (result > 0)
                    {
                        MessageBox.Show("Xóa sản phẩm thành công!");
                        dt = modify.GetAllProducts();
                        dataGridView1.DataSource = dt;
                        ConfigureDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Xóa sản phẩm thất bại hoặc không tìm thấy ID!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Edit product button click
        private void editProductBtn_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để sửa!");
                return;
            }

            int productId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ProductID"].Value);
            string productName = dataGridView1.CurrentRow.Cells["ProductName"].Value?.ToString();
            int categoryId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CategoryId"].Value);
            int quantity = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Quantity"].Value);
            float purchaseCost = Convert.ToSingle(dataGridView1.CurrentRow.Cells["PurchaseCost"].Value);
            float itemCost = Convert.ToSingle(dataGridView1.CurrentRow.Cells["ItemCost"].Value);
            string note = dataGridView1.CurrentRow.Cells["Note"].Value?.ToString();

            EditProduct editProduct = new EditProduct(productId, productName, categoryId, quantity, purchaseCost, itemCost, note);

            if (editProduct.ShowDialog() == DialogResult.OK)
            {
                Modify modify = new Modify();
                dt = modify.GetAllProducts();
                dataGridView1.DataSource = dt;
                ConfigureDataGridView();
            }
        }

        // Search func
        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox.Text.Trim();
            if (string.IsNullOrEmpty(searchTerm) || searchTerm == "Tìm kiếm sản phẩm...")
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!");
                return;
            }

            Modify modify = new Modify();
            dt = modify.SearchProducts(searchTerm);
            dataGridView1.DataSource = dt;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sản phẩm nào phù hợp!");
            }
        }

        // Clear search input
        private void clearSearchButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = "Tìm kiếm sản phẩm...";
            searchTextBox.ForeColor = System.Drawing.Color.Gray;
            
            Modify modify = new Modify();
            dt = modify.GetAllProducts();
            dataGridView1.DataSource = dt;
        }

        // Placeholder text behavior
        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "Tìm kiếm sản phẩm...")
            {
                searchTextBox.Text = "";
                searchTextBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        // Remove placeholder if empty
        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                searchTextBox.Text = "Tìm kiếm sản phẩm...";
                searchTextBox.ForeColor = System.Drawing.Color.Gray;
            }
        }

        // Trigger search on Enter key
        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchButton_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // Filter products by category
        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryComboBox.SelectedValue == null) return;
            
            // Check if the SelectedValue is a DataRowView (happens during initial binding)
            if (categoryComboBox.SelectedValue is DataRowView)
                return;
            
            int categoryId = Convert.ToInt32(categoryComboBox.SelectedValue);
            Modify modify = new Modify();
            
            if (categoryId == 0)
            {
                // Show all products
                dt = modify.GetAllProducts();
            }
            else
            {
                // Filter by category
                DataTable filteredProducts = new DataTable();
                using (SqlConnection sqlConnection = Connection.GetSqlConnection())
                {
                    sqlConnection.Open();
                    string query = "SELECT * FROM Product WHERE CategoryId = @categoryId";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@categoryId", categoryId);
                        adapter.Fill(filteredProducts);
                    }
                }
                dt = filteredProducts;
            }
            
            dataGridView1.DataSource = dt;
            ConfigureDataGridView();
        }

        // Excel export button click
        private void excelExportBtn_Click(object sender, EventArgs e)
        {

                DialogResult confirmExport = MessageBox.Show(
                this,
                "Bạn có muốn xuất file ra excel không?",
                "Xác nhận xuất excel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
                if (confirmExport == DialogResult.Yes)
                {
                    ExportCSV(dt);
                }

        }
    }
}
