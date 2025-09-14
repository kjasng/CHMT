using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace WindowsFormsApp1
{
    public partial class Invoice : Form
    {
        DataTable dt;
        InvoiceDetail invoiceDetail;
        PrintDocument printDocument = new PrintDocument();
        PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
        private int currentInvoiceId = 0;

        public Invoice()
        {
            InitializeComponent();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            dt = modify.GetAllInvoices();
            dataGridView1.DataSource = dt;
            ConfigureDataGridView();
            ConfigureColumnHeaders();
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
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

        private void ConfigureColumnHeaders()
        {
            if (dataGridView1.Columns.Contains("InvoiceID"))
                dataGridView1.Columns["InvoiceID"].HeaderText = "Mã HĐ";
            if (dataGridView1.Columns.Contains("CustomerName"))
                dataGridView1.Columns["CustomerName"].HeaderText = "Tên khách hàng";
            if (dataGridView1.Columns.Contains("InvoiceDate"))
            {
                dataGridView1.Columns["InvoiceDate"].HeaderText = "Ngày tạo";
                dataGridView1.Columns["InvoiceDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            if (dataGridView1.Columns.Contains("TotalAmount"))
            {
                dataGridView1.Columns["TotalAmount"].HeaderText = "Tổng tiền";
                dataGridView1.Columns["TotalAmount"].DefaultCellStyle.Format = "N0";
            }
            if (dataGridView1.Columns.Contains("Status"))
                dataGridView1.Columns["Status"].HeaderText = "Trạng thái";
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            dt = modify.GetAllInvoices();
            dataGridView1.DataSource = dt;
            ConfigureDataGridView();
            ConfigureColumnHeaders();
        }

        private void createInvoiceBtn_Click(object sender, EventArgs e)
        {
            invoiceDetail = new InvoiceDetail();
            if (invoiceDetail.ShowDialog() == DialogResult.OK)
            {
                // Refresh the grid after adding
                Modify modify = new Modify();
                dt = modify.GetAllInvoices();
                dataGridView1.DataSource = dt;
            }
        }

        private void viewInvoiceBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để xem chi tiết!");
                return;
            }

            int invoiceId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["InvoiceID"].Value);
            invoiceDetail = new InvoiceDetail(invoiceId);
            invoiceDetail.ShowDialog();
        }

        private void deleteInvoiceBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để xóa!");
                return;
            }

            string invoiceId = dataGridView1.CurrentRow.Cells["InvoiceID"].Value.ToString();

            DialogResult dialogResult = MessageBox.Show(
                this,
                "Bạn có chắc chắn muốn xóa hóa đơn này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                Modify modify = new Modify();
                string query = @"DELETE FROM InvoiceDetail WHERE InvoiceID = " + invoiceId + "; " +
                              "DELETE FROM Invoices WHERE InvoiceID = " + invoiceId;

                int result = modify.ExecuteNonQuery(query);

                if (result > 0)
                {
                    MessageBox.Show("Xóa hóa đơn thành công!");
                    dt = modify.GetAllInvoices();
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Xóa hóa đơn thất bại!");
                }
            }
        }

        private void exportInvoiceBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để xuất!");
                return;
            }

            currentInvoiceId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["InvoiceID"].Value);
            
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Get invoice data
            Modify modify = new Modify();
            DataTable invoiceData = modify.GetInvoiceById(currentInvoiceId);
            DataTable invoiceDetails = modify.GetInvoiceDetails(currentInvoiceId);

            if (invoiceData.Rows.Count == 0) return;

            DataRow invoice = invoiceData.Rows[0];
            Graphics g = e.Graphics;
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font normalFont = new Font("Arial", 10);
            Brush brush = Brushes.Black;
            int yPos = 50;
            int leftMargin = 50;

            // Title
            g.DrawString("HÓA ĐƠN BÁN HÀNG", titleFont, brush, new Point(300, yPos));
            yPos += 40;

            // Invoice info
            g.DrawString("Mã hóa đơn: " + invoice["InvoiceID"].ToString(), normalFont, brush, new Point(leftMargin, yPos));
            yPos += 25;
            g.DrawString("Ngày: " + Convert.ToDateTime(invoice["InvoiceDate"]).ToString("dd/MM/yyyy"), normalFont, brush, new Point(leftMargin, yPos));
            yPos += 25;
            g.DrawString("Khách hàng: " + invoice["CustomerName"].ToString(), normalFont, brush, new Point(leftMargin, yPos));
            yPos += 35;

            // Table header
            g.DrawString("STT", headerFont, brush, new Point(leftMargin, yPos));
            g.DrawString("Tên sản phẩm", headerFont, brush, new Point(leftMargin + 50, yPos));
            g.DrawString("SL", headerFont, brush, new Point(leftMargin + 300, yPos));
            g.DrawString("Đơn giá", headerFont, brush, new Point(leftMargin + 350, yPos));
            g.DrawString("Thành tiền", headerFont, brush, new Point(leftMargin + 450, yPos));
            yPos += 30;

            // Draw line
            g.DrawLine(Pens.Black, leftMargin, yPos, leftMargin + 550, yPos);
            yPos += 10;

            // Table content
            int stt = 1;
            decimal totalAmount = 0;
            foreach (DataRow row in invoiceDetails.Rows)
            {
                g.DrawString(stt.ToString(), normalFont, brush, new Point(leftMargin, yPos));
                g.DrawString(row["ProductName"].ToString(), normalFont, brush, new Point(leftMargin + 50, yPos));
                g.DrawString(row["Quantity"].ToString(), normalFont, brush, new Point(leftMargin + 300, yPos));
                
                decimal unitPrice = Convert.ToDecimal(row["UnitPrice"]);
                g.DrawString(unitPrice.ToString("N0"), normalFont, brush, new Point(leftMargin + 350, yPos));
                
                decimal lineTotal = Convert.ToDecimal(row["LineTotal"]);
                g.DrawString(lineTotal.ToString("N0"), normalFont, brush, new Point(leftMargin + 450, yPos));
                
                totalAmount += lineTotal;
                yPos += 25;
                stt++;
            }

            // Draw line
            g.DrawLine(Pens.Black, leftMargin, yPos, leftMargin + 550, yPos);
            yPos += 10;

            // Total
            g.DrawString("Tổng cộng:", headerFont, brush, new Point(leftMargin + 350, yPos));
            g.DrawString(totalAmount.ToString("N0") + " VNĐ", headerFont, brush, new Point(leftMargin + 450, yPos));
            yPos += 30;

            // VAT if exists
            if (invoice["VAT"] != DBNull.Value)
            {
                decimal vat = Convert.ToDecimal(invoice["VAT"]);
                g.DrawString("VAT (10%):", normalFont, brush, new Point(leftMargin + 350, yPos));
                g.DrawString(vat.ToString("N0") + " VNĐ", normalFont, brush, new Point(leftMargin + 450, yPos));
                yPos += 25;

                decimal grandTotal = totalAmount + vat;
                g.DrawString("Thành tiền:", headerFont, brush, new Point(leftMargin + 350, yPos));
                g.DrawString(grandTotal.ToString("N0") + " VNĐ", headerFont, brush, new Point(leftMargin + 450, yPos));
            }

            yPos += 50;
            
            // Display status
            int statusValue = Convert.ToInt32(invoice["Status"]);
            string statusText = (statusValue == 1) ? "Chưa thanh toán" : "Đã thanh toán";
            g.DrawString("Trạng thái: " + statusText, normalFont, brush, new Point(leftMargin, yPos));
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox.Text.Trim();
            if (string.IsNullOrEmpty(searchTerm) || searchTerm == "Tìm kiếm hóa đơn...")
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!");
                return;
            }

            Modify modify = new Modify();
            dt = modify.SearchInvoices(searchTerm);
            dataGridView1.DataSource = dt;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy hóa đơn nào phù hợp!");
            }
        }

        private void clearSearchButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = "Tìm kiếm hóa đơn...";
            searchTextBox.ForeColor = System.Drawing.Color.Gray;
            
            Modify modify = new Modify();
            dt = modify.GetAllInvoices();
            dataGridView1.DataSource = dt;
        }

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "Tìm kiếm hóa đơn...")
            {
                searchTextBox.Text = "";
                searchTextBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                searchTextBox.Text = "Tìm kiếm hóa đơn...";
                searchTextBox.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchButton_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            // Real-time search
            if (searchTextBox.Text != "Tìm kiếm hóa đơn..." && !string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                Modify modify = new Modify();
                dt = modify.SearchInvoices(searchTextBox.Text.Trim());
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Format Status column to display text instead of integer
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                int statusValue = Convert.ToInt32(e.Value);
                e.Value = (statusValue == 1) ? "Chưa thanh toán" : "Đã thanh toán";
                e.FormattingApplied = true;
            }
        }
    }
}