namespace WindowsFormsApp1
{
    partial class Customers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.editCustomerBtn = new System.Windows.Forms.Button();
            this.fetchCustomers = new System.Windows.Forms.Button();
            this.addCustomers = new System.Windows.Forms.Button();
            this.delCustomerBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customersTableAdapter1 = new WindowsFormsApp1.DataSetTableAdapters.CustomersTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "    Customers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.88889F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(719, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.58766F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.41234F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(713, 52);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.editCustomerBtn, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.fetchCustomers, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.addCustomers, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.delCustomerBtn, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(271, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(439, 46);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // editCustomerBtn
            // 
            this.editCustomerBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.editCustomerBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCustomerBtn.ForeColor = System.Drawing.Color.White;
            this.editCustomerBtn.Image = ((System.Drawing.Image)(resources.GetObject("editCustomerBtn.Image")));
            this.editCustomerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editCustomerBtn.Location = new System.Drawing.Point(218, 0);
            this.editCustomerBtn.Margin = new System.Windows.Forms.Padding(0);
            this.editCustomerBtn.Name = "editCustomerBtn";
            this.editCustomerBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.editCustomerBtn.Size = new System.Drawing.Size(109, 46);
            this.editCustomerBtn.TabIndex = 2;
            this.editCustomerBtn.Text = "   Sửa TT";
            this.editCustomerBtn.UseVisualStyleBackColor = false;
            // 
            // fetchCustomers
            // 
            this.fetchCustomers.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.fetchCustomers.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchCustomers.ForeColor = System.Drawing.Color.White;
            this.fetchCustomers.Image = ((System.Drawing.Image)(resources.GetObject("fetchCustomers.Image")));
            this.fetchCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fetchCustomers.Location = new System.Drawing.Point(3, 3);
            this.fetchCustomers.Name = "fetchCustomers";
            this.fetchCustomers.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.fetchCustomers.Size = new System.Drawing.Size(103, 40);
            this.fetchCustomers.TabIndex = 1;
            this.fetchCustomers.Text = "    Refresh";
            this.fetchCustomers.UseVisualStyleBackColor = false;
            this.fetchCustomers.Click += new System.EventHandler(this.fetchCustomers_Click);
            // 
            // addCustomers
            // 
            this.addCustomers.BackColor = System.Drawing.Color.ForestGreen;
            this.addCustomers.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomers.ForeColor = System.Drawing.Color.White;
            this.addCustomers.Image = ((System.Drawing.Image)(resources.GetObject("addCustomers.Image")));
            this.addCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCustomers.Location = new System.Drawing.Point(109, 0);
            this.addCustomers.Margin = new System.Windows.Forms.Padding(0);
            this.addCustomers.Name = "addCustomers";
            this.addCustomers.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.addCustomers.Size = new System.Drawing.Size(109, 46);
            this.addCustomers.TabIndex = 0;
            this.addCustomers.Text = "   Thêm KH";
            this.addCustomers.UseVisualStyleBackColor = false;
            this.addCustomers.Click += new System.EventHandler(this.addCustomers_Click);
            // 
            // delCustomerBtn
            // 
            this.delCustomerBtn.BackColor = System.Drawing.Color.Crimson;
            this.delCustomerBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delCustomerBtn.ForeColor = System.Drawing.Color.White;
            this.delCustomerBtn.Image = ((System.Drawing.Image)(resources.GetObject("delCustomerBtn.Image")));
            this.delCustomerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delCustomerBtn.Location = new System.Drawing.Point(327, 0);
            this.delCustomerBtn.Margin = new System.Windows.Forms.Padding(0);
            this.delCustomerBtn.Name = "delCustomerBtn";
            this.delCustomerBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.delCustomerBtn.Size = new System.Drawing.Size(109, 46);
            this.delCustomerBtn.TabIndex = 3;
            this.delCustomerBtn.Text = "    Xóa KH";
            this.delCustomerBtn.UseVisualStyleBackColor = false;
            this.delCustomerBtn.Click += new System.EventHandler(this.delCustomerBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(713, 386);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Customers";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.formDashboard_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button addCustomers;
        private System.Windows.Forms.Button fetchCustomers;
        private System.Windows.Forms.Button delCustomerBtn;
        private System.Windows.Forms.Button editCustomerBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}