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
    public partial class InvoiceDetail : Form
    {
        private int invoiceId = 0;
        private bool isViewMode = false;
        private DataTable dtProducts;
        private DataTable dtInvoiceItems;
        private decimal subtotal = 0;
        private decimal vatAmount = 0;
        private decimal grandTotal = 0;

        // Constructor for creating new invoice
        public InvoiceDetail()
        {
            InitializeComponent();
            isViewMode = false;
            LoadCustomers();
            LoadProducts();
            InitializeInvoiceItemsGrid();
            SetCreateMode();
        }

        // Constructor for viewing existing invoice
        public InvoiceDetail(int invoiceId)
        {
            InitializeComponent();
            this.invoiceId = invoiceId;
            isViewMode = true;
            LoadCustomers();
            LoadProducts();
            InitializeInvoiceItemsGrid();
            LoadInvoiceData();
            SetViewMode();
        }

        private void InvoiceDetail_Load(object sender, EventArgs e)
        {
            if (!isViewMode)
            {
                // Set invoice date
                if (invoiceDatePicker != null)
                    invoiceDatePicker.Value = DateTime.Now;
                
                // Set status combo box
                if (statusComboBox != null && statusComboBox.Items.Count > 0)
                    statusComboBox.SelectedIndex = 0;
                
                // Since paymentMethodComboBox doesn't exist in database, remove this
                // paymentMethodComboBox.SelectedIndex = 0;
            }
        }

        private void LoadCustomers()
        {
            try
            {
                Modify modify = new Modify();
                DataTable customers = modify.GetAllCustomers();
                
                customerComboBox.DataSource = customers;
                customerComboBox.DisplayMember = "Firstname";
                customerComboBox.ValueMember = "CustomerID";
                customerComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách khách hàng: " + ex.Message);
            }
        }

        private void LoadProducts()
        {
            try
            {
                Modify modify = new Modify();
                dtProducts = modify.GetAllProducts();
                
                productComboBox.DataSource = dtProducts;
                productComboBox.DisplayMember = "ProductName";
                productComboBox.ValueMember = "ProductID";
                productComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sản phẩm: " + ex.Message);
            }
        }

        private void InitializeInvoiceItemsGrid()
        {
            dtInvoiceItems = new DataTable();
            dtInvoiceItems.Columns.Add("ProductID", typeof(int));
            dtInvoiceItems.Columns.Add("ProductName", typeof(string));
            dtInvoiceItems.Columns.Add("Quantity", typeof(int));
            dtInvoiceItems.Columns.Add("UnitPrice", typeof(decimal));
            dtInvoiceItems.Columns.Add("LineTotal", typeof(decimal));

            invoiceItemsGrid.DataSource = dtInvoiceItems;
            ConfigureInvoiceItemsGrid();
        }

        private void ConfigureInvoiceItemsGrid()
        {
            if (invoiceItemsGrid == null) return;

            invoiceItemsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            invoiceItemsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            invoiceItemsGrid.MultiSelect = false;
            invoiceItemsGrid.AllowUserToAddRows = false;
            invoiceItemsGrid.RowHeadersVisible = false;
            invoiceItemsGrid.BackgroundColor = Color.White;
            invoiceItemsGrid.BorderStyle = BorderStyle.None;
            invoiceItemsGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            invoiceItemsGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 230, 250);
            invoiceItemsGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
            invoiceItemsGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);

            if (invoiceItemsGrid.Columns != null && invoiceItemsGrid.Columns.Count > 0)
            {
                if (invoiceItemsGrid.Columns.Contains("ProductID"))
                    invoiceItemsGrid.Columns["ProductID"].Visible = false;
                if (invoiceItemsGrid.Columns.Contains("ProductName"))
                    invoiceItemsGrid.Columns["ProductName"].HeaderText = "Tên sản phẩm";
                if (invoiceItemsGrid.Columns.Contains("Quantity"))
                {
                    invoiceItemsGrid.Columns["Quantity"].HeaderText = "Số lượng";
                    invoiceItemsGrid.Columns["Quantity"].FillWeight = 30;
                }
                if (invoiceItemsGrid.Columns.Contains("UnitPrice"))
                {
                    invoiceItemsGrid.Columns["UnitPrice"].HeaderText = "Đơn giá";
                    invoiceItemsGrid.Columns["UnitPrice"].DefaultCellStyle.Format = "N0";
                    invoiceItemsGrid.Columns["UnitPrice"].FillWeight = 35;
                }
                if (invoiceItemsGrid.Columns.Contains("LineTotal"))
                {
                    invoiceItemsGrid.Columns["LineTotal"].HeaderText = "Thành tiền";
                    invoiceItemsGrid.Columns["LineTotal"].DefaultCellStyle.Format = "N0";
                    invoiceItemsGrid.Columns["LineTotal"].FillWeight = 35;
                }
            }
        }

        private void SetCreateMode()
        {
            this.Text = "Tạo hóa đơn mới";
            if (saveBtn != null)
                saveBtn.Text = "Lưu hóa đơn";
            
            // Enable all controls for editing
            if (customerComboBox != null)
                customerComboBox.Enabled = true;
            if (invoiceDatePicker != null)
                invoiceDatePicker.Enabled = true;
            if (productComboBox != null)
                productComboBox.Enabled = true;
            if (quantityInput != null)
                quantityInput.Enabled = true;
            if (addProductBtn != null)
                addProductBtn.Enabled = true;
            if (removeProductBtn != null)
                removeProductBtn.Enabled = true;
            if (statusComboBox != null)
                statusComboBox.Enabled = true;
            if (paymentMethodComboBox != null)
                paymentMethodComboBox.Enabled = true;
            if (notesTextBox != null)
                notesTextBox.Enabled = true;
        }

        private void SetViewMode()
        {
            this.Text = "Chi tiết hóa đơn #" + invoiceId;
            if (saveBtn != null)
                saveBtn.Visible = false;
            
            // Disable all controls for viewing only
            if (customerComboBox != null)
                customerComboBox.Enabled = false;
            if (invoiceDatePicker != null)
                invoiceDatePicker.Enabled = false;
            if (productComboBox != null)
                productComboBox.Enabled = false;
            if (quantityInput != null)
                quantityInput.Enabled = false;
            if (addProductBtn != null)
                addProductBtn.Enabled = false;
            if (removeProductBtn != null)
                removeProductBtn.Enabled = false;
            if (statusComboBox != null)
                statusComboBox.Enabled = false;
            if (paymentMethodComboBox != null)
                paymentMethodComboBox.Enabled = false;
            if (notesTextBox != null)
                notesTextBox.ReadOnly = true;
            if (invoiceItemsGrid != null)
                invoiceItemsGrid.ReadOnly = true;
        }

        private void LoadInvoiceData()
        {
            try
            {
                Modify modify = new Modify();
                DataTable invoiceData = modify.GetInvoiceById(invoiceId);
                
                if (invoiceData.Rows.Count > 0)
                {
                    DataRow row = invoiceData.Rows[0];
                    
                    // Load customer
                    if (row["CustomerID"] != DBNull.Value)
                    {
                        LoadCustomers();
                        customerComboBox.SelectedValue = row["CustomerID"];
                    }
                    
                    // Load invoice date
                    if (row["InvoiceDate"] != DBNull.Value)
                        invoiceDatePicker.Value = Convert.ToDateTime(row["InvoiceDate"]);
                    
                    // Load status (Status is integer from InvoiceDetail)
                    if (row["Status"] != DBNull.Value && statusComboBox != null)
                    {
                        int statusValue = Convert.ToInt32(row["Status"]);
                        // 1 = Chưa thanh toán, 2 = Đã thanh toán
                        statusComboBox.SelectedIndex = (statusValue == 2) ? 1 : 0;
                    }
                    
                    // Notes field doesn't exist in Invoices table, skip it
                    // if (row["Notes"] != DBNull.Value && notesTextBox != null)
                    //     notesTextBox.Text = row["Notes"].ToString();
                    
                    // Load invoice items
                    LoadInvoiceItems();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu hóa đơn: " + ex.Message);
            }
        }

        private void LoadInvoiceItems()
        {
            try
            {
                Modify modify = new Modify();
                DataTable items = modify.GetInvoiceDetails(invoiceId);
                
                dtInvoiceItems.Clear();
                foreach (DataRow row in items.Rows)
                {
                    DataRow newRow = dtInvoiceItems.NewRow();
                    newRow["ProductID"] = row["ProductID"];
                    newRow["ProductName"] = row["ProductName"];
                    newRow["Quantity"] = row["Quantity"];
                    newRow["UnitPrice"] = row["UnitPrice"];
                    newRow["LineTotal"] = row["LineTotal"];
                    dtInvoiceItems.Rows.Add(newRow);
                }
                
                CalculateTotals();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải chi tiết hóa đơn: " + ex.Message);
            }
        }

        private void productComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productComboBox != null && productComboBox.SelectedValue != null && productComboBox.SelectedIndex >= 0)
            {
                DataRowView selectedRow = productComboBox.SelectedItem as DataRowView;
                if (selectedRow != null)
                {
                    // Check for PurchaseCost column (correct column name in Product table)
                    if (selectedRow.Row.Table.Columns.Contains("PurchaseCost"))
                    {
                        decimal price = Convert.ToDecimal(selectedRow["PurchaseCost"]);
                        if (unitPriceLabel != null)
                            unitPriceLabel.Text = price.ToString("N0") + " VNĐ";
                    }
                    // Fallback to ItemCost if it exists
                    else if (selectedRow.Row.Table.Columns.Contains("ItemCost"))
                    {
                        decimal price = Convert.ToDecimal(selectedRow["ItemCost"]);
                        if (unitPriceLabel != null)
                            unitPriceLabel.Text = price.ToString("N0") + " VNĐ";
                    }
                }
            }
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            if (productComboBox == null || productComboBox.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!");
                return;
            }

            if (quantityInput == null || quantityInput.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!");
                return;
            }

            int productId = Convert.ToInt32(productComboBox.SelectedValue);
            
            // Check if product already exists in grid
            if (dtInvoiceItems != null)
            {
                foreach (DataRow row in dtInvoiceItems.Rows)
                {
                    if (Convert.ToInt32(row["ProductID"]) == productId)
                    {
                        MessageBox.Show("Sản phẩm đã có trong hóa đơn!");
                        return;
                    }
                }
            }

            DataRowView selectedProduct = productComboBox.SelectedItem as DataRowView;
            if (selectedProduct == null) return;
            
            // Get unit price from correct column
            decimal unitPrice = 0;
            if (selectedProduct.Row.Table.Columns.Contains("PurchaseCost"))
                unitPrice = Convert.ToDecimal(selectedProduct["PurchaseCost"]);
            else if (selectedProduct.Row.Table.Columns.Contains("ItemCost"))
                unitPrice = Convert.ToDecimal(selectedProduct["ItemCost"]);
            
            decimal lineTotal = unitPrice * quantityInput.Value;

            if (dtInvoiceItems != null)
            {
                DataRow newRow = dtInvoiceItems.NewRow();
                newRow["ProductID"] = productId;
                newRow["ProductName"] = selectedProduct["ProductName"];
                newRow["Quantity"] = quantityInput.Value;
                newRow["UnitPrice"] = unitPrice;
                newRow["LineTotal"] = lineTotal;
                dtInvoiceItems.Rows.Add(newRow);
            }

            // Reset inputs
            if (productComboBox != null)
                productComboBox.SelectedIndex = -1;
            if (quantityInput != null)
                quantityInput.Value = 1;
            if (unitPriceLabel != null)
                unitPriceLabel.Text = "0 VNĐ";

            CalculateTotals();
        }

        private void removeProductBtn_Click(object sender, EventArgs e)
        {
            if (invoiceItemsGrid.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", 
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (result == DialogResult.Yes)
                {
                    dtInvoiceItems.Rows.RemoveAt(invoiceItemsGrid.CurrentRow.Index);
                    CalculateTotals();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa!");
            }
        }

        private void CalculateTotals()
        {
            subtotal = 0;
            if (dtInvoiceItems != null)
            {
                foreach (DataRow row in dtInvoiceItems.Rows)
                {
                    subtotal += Convert.ToDecimal(row["LineTotal"]);
                }
            }

            vatAmount = subtotal * 0.1m; // 10% VAT
            grandTotal = subtotal + vatAmount;

            if (subtotalLabel != null)
                subtotalLabel.Text = subtotal.ToString("N0") + " VNĐ";
            if (vatLabel != null)
                vatLabel.Text = vatAmount.ToString("N0") + " VNĐ";
            if (grandTotalLabel != null)
                grandTotalLabel.Text = grandTotal.ToString("N0") + " VNĐ";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Validation
            if (customerComboBox == null || customerComboBox.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!");
                return;
            }

            if (dtInvoiceItems == null || dtInvoiceItems.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm ít nhất một sản phẩm!");
                return;
            }

            try
            {
                Modify modify = new Modify();
                
                // Get status as integer (1 = Chưa thanh toán, 2 = Đã thanh toán)
                int status = 1; // Default to unpaid
                if (statusComboBox != null && statusComboBox.SelectedIndex >= 0)
                    status = (statusComboBox.SelectedIndex == 0) ? 1 : 2;
                
                // Use the Modify class method to create invoice with transaction support
                int newInvoiceId = modify.CreateInvoiceWithDetails(
                    Convert.ToInt32(customerComboBox.SelectedValue),
                    invoiceDatePicker.Value,
                    status,
                    dtInvoiceItems
                );

                MessageBox.Show("Tạo hóa đơn thành công! Mã hóa đơn: " + newInvoiceId, "Thành công", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu hóa đơn: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (!isViewMode)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn hủy? Dữ liệu chưa lưu sẽ bị mất.", 
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (result == DialogResult.No)
                    return;
            }
            
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}