namespace WindowsFormsApp1
{
    partial class InvoiceDetail
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.invoicePanel = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.leftInfoPanel = new System.Windows.Forms.Panel();
            this.customerLabel = new System.Windows.Forms.Label();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.invoiceDatePicker = new System.Windows.Forms.DateTimePicker();
            this.rightInfoPanel = new System.Windows.Forms.Panel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.paymentMethodComboBox = new System.Windows.Forms.ComboBox();
            this.productPanel = new System.Windows.Forms.Panel();
            this.productLabel = new System.Windows.Forms.Label();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityInput = new System.Windows.Forms.NumericUpDown();
            this.priceLabel = new System.Windows.Forms.Label();
            this.unitPriceLabel = new System.Windows.Forms.Label();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.removeProductBtn = new System.Windows.Forms.Button();
            this.itemsPanel = new System.Windows.Forms.Panel();
            this.invoiceItemsGrid = new System.Windows.Forms.DataGridView();
            this.totalsPanel = new System.Windows.Forms.Panel();
            this.subtotalTextLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.vatTextLabel = new System.Windows.Forms.Label();
            this.vatLabel = new System.Windows.Forms.Label();
            this.grandTotalTextLabel = new System.Windows.Forms.Label();
            this.grandTotalLabel = new System.Windows.Forms.Label();
            this.notesPanel = new System.Windows.Forms.Panel();
            this.notesLabel = new System.Windows.Forms.Label();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.invoicePanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.leftInfoPanel.SuspendLayout();
            this.rightInfoPanel.SuspendLayout();
            this.productPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityInput)).BeginInit();
            this.itemsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemsGrid)).BeginInit();
            this.totalsPanel.SuspendLayout();
            this.notesPanel.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mainPanel.Controls.Add(this.invoicePanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(20);
            this.mainPanel.Size = new System.Drawing.Size(900, 700);
            this.mainPanel.TabIndex = 0;
            // 
            // invoicePanel
            // 
            this.invoicePanel.BackColor = System.Drawing.Color.White;
            this.invoicePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoicePanel.Controls.Add(this.headerPanel);
            this.invoicePanel.Controls.Add(this.infoPanel);
            this.invoicePanel.Controls.Add(this.productPanel);
            this.invoicePanel.Controls.Add(this.itemsPanel);
            this.invoicePanel.Controls.Add(this.totalsPanel);
            this.invoicePanel.Controls.Add(this.notesPanel);
            this.invoicePanel.Controls.Add(this.buttonPanel);
            this.invoicePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoicePanel.Location = new System.Drawing.Point(20, 20);
            this.invoicePanel.Name = "invoicePanel";
            this.invoicePanel.Size = new System.Drawing.Size(860, 660);
            this.invoicePanel.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Controls.Add(this.companyLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 520);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(858, 80);
            this.headerPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(30, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(146, 37);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "HÓA ĐƠN";
            // 
            // companyLabel
            // 
            this.companyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.companyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyLabel.ForeColor = System.Drawing.Color.White;
            this.companyLabel.Location = new System.Drawing.Point(458, 20);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(370, 40);
            this.companyLabel.TabIndex = 1;
            this.companyLabel.Text = "CÔNG TY TNHH CHMTHM\r\nĐịa chỉ: Số 36 Trương Định, Q. Hoàng Mai, TP.HN";
            this.companyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.leftInfoPanel);
            this.infoPanel.Controls.Add(this.rightInfoPanel);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoPanel.Location = new System.Drawing.Point(0, 420);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Padding = new System.Windows.Forms.Padding(30, 20, 30, 10);
            this.infoPanel.Size = new System.Drawing.Size(858, 100);
            this.infoPanel.TabIndex = 1;
            // 
            // leftInfoPanel
            // 
            this.leftInfoPanel.Controls.Add(this.customerLabel);
            this.leftInfoPanel.Controls.Add(this.customerComboBox);
            this.leftInfoPanel.Controls.Add(this.dateLabel);
            this.leftInfoPanel.Controls.Add(this.invoiceDatePicker);
            this.leftInfoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftInfoPanel.Location = new System.Drawing.Point(30, 20);
            this.leftInfoPanel.Name = "leftInfoPanel";
            this.leftInfoPanel.Size = new System.Drawing.Size(400, 70);
            this.leftInfoPanel.TabIndex = 0;
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(3, 5);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(84, 17);
            this.customerLabel.TabIndex = 0;
            this.customerLabel.Text = "Khách hàng*:";
            // 
            // customerComboBox
            // 
            this.customerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(100, 2);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(280, 25);
            this.customerComboBox.TabIndex = 1;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(3, 40);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(70, 17);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Ngày tạo*:";
            // 
            // invoiceDatePicker
            // 
            this.invoiceDatePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.invoiceDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.invoiceDatePicker.Location = new System.Drawing.Point(100, 37);
            this.invoiceDatePicker.Name = "invoiceDatePicker";
            this.invoiceDatePicker.Size = new System.Drawing.Size(150, 25);
            this.invoiceDatePicker.TabIndex = 3;
            // 
            // rightInfoPanel
            // 
            this.rightInfoPanel.Controls.Add(this.statusLabel);
            this.rightInfoPanel.Controls.Add(this.statusComboBox);
            this.rightInfoPanel.Controls.Add(this.paymentLabel);
            this.rightInfoPanel.Controls.Add(this.paymentMethodComboBox);
            this.rightInfoPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightInfoPanel.Location = new System.Drawing.Point(458, 20);
            this.rightInfoPanel.Name = "rightInfoPanel";
            this.rightInfoPanel.Size = new System.Drawing.Size(370, 70);
            this.rightInfoPanel.TabIndex = 1;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(3, 5);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(69, 17);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Trạng thái:";
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Chưa thanh toán",
            "Đã thanh toán",
            "Đã hủy"});
            this.statusComboBox.Location = new System.Drawing.Point(120, 2);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(200, 25);
            this.statusComboBox.TabIndex = 1;
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentLabel.Location = new System.Drawing.Point(3, 40);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(103, 17);
            this.paymentLabel.TabIndex = 2;
            this.paymentLabel.Text = "Phương thức TT:";
            // 
            // paymentMethodComboBox
            // 
            this.paymentMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentMethodComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.paymentMethodComboBox.FormattingEnabled = true;
            this.paymentMethodComboBox.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoản",
            "Thẻ tín dụng"});
            this.paymentMethodComboBox.Location = new System.Drawing.Point(120, 37);
            this.paymentMethodComboBox.Name = "paymentMethodComboBox";
            this.paymentMethodComboBox.Size = new System.Drawing.Size(200, 25);
            this.paymentMethodComboBox.TabIndex = 3;
            // 
            // productPanel
            // 
            this.productPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productPanel.Controls.Add(this.productLabel);
            this.productPanel.Controls.Add(this.productComboBox);
            this.productPanel.Controls.Add(this.quantityLabel);
            this.productPanel.Controls.Add(this.quantityInput);
            this.productPanel.Controls.Add(this.priceLabel);
            this.productPanel.Controls.Add(this.unitPriceLabel);
            this.productPanel.Controls.Add(this.addProductBtn);
            this.productPanel.Controls.Add(this.removeProductBtn);
            this.productPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.productPanel.Location = new System.Drawing.Point(0, 360);
            this.productPanel.Name = "productPanel";
            this.productPanel.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.productPanel.Size = new System.Drawing.Size(858, 60);
            this.productPanel.TabIndex = 2;
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.productLabel.Location = new System.Drawing.Point(33, 20);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(69, 17);
            this.productLabel.TabIndex = 0;
            this.productLabel.Text = "Sản phẩm:";
            // 
            // productComboBox
            // 
            this.productComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(105, 17);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(200, 25);
            this.productComboBox.TabIndex = 1;
            this.productComboBox.SelectedIndexChanged += new System.EventHandler(this.productComboBox_SelectedIndexChanged);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.quantityLabel.Location = new System.Drawing.Point(320, 20);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(24, 17);
            this.quantityLabel.TabIndex = 2;
            this.quantityLabel.Text = "SL:";
            // 
            // quantityInput
            // 
            this.quantityInput.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.quantityInput.Location = new System.Drawing.Point(350, 17);
            this.quantityInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityInput.Name = "quantityInput";
            this.quantityInput.Size = new System.Drawing.Size(60, 25);
            this.quantityInput.TabIndex = 3;
            this.quantityInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.priceLabel.Location = new System.Drawing.Point(425, 20);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(57, 17);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Đơn giá:";
            // 
            // unitPriceLabel
            // 
            this.unitPriceLabel.AutoSize = true;
            this.unitPriceLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.unitPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.unitPriceLabel.Location = new System.Drawing.Point(485, 20);
            this.unitPriceLabel.Name = "unitPriceLabel";
            this.unitPriceLabel.Size = new System.Drawing.Size(48, 17);
            this.unitPriceLabel.TabIndex = 5;
            this.unitPriceLabel.Text = "0 VNĐ";
            // 
            // addProductBtn
            // 
            this.addProductBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.addProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.addProductBtn.ForeColor = System.Drawing.Color.White;
            this.addProductBtn.Location = new System.Drawing.Point(600, 15);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(100, 28);
            this.addProductBtn.TabIndex = 6;
            this.addProductBtn.Text = "Thêm";
            this.addProductBtn.UseVisualStyleBackColor = false;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // removeProductBtn
            // 
            this.removeProductBtn.BackColor = System.Drawing.Color.Crimson;
            this.removeProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeProductBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.removeProductBtn.ForeColor = System.Drawing.Color.White;
            this.removeProductBtn.Location = new System.Drawing.Point(710, 15);
            this.removeProductBtn.Name = "removeProductBtn";
            this.removeProductBtn.Size = new System.Drawing.Size(100, 28);
            this.removeProductBtn.TabIndex = 7;
            this.removeProductBtn.Text = "Xóa";
            this.removeProductBtn.UseVisualStyleBackColor = false;
            this.removeProductBtn.Click += new System.EventHandler(this.removeProductBtn_Click);
            // 
            // itemsPanel
            // 
            this.itemsPanel.Controls.Add(this.invoiceItemsGrid);
            this.itemsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemsPanel.Location = new System.Drawing.Point(0, 160);
            this.itemsPanel.Name = "itemsPanel";
            this.itemsPanel.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.itemsPanel.Size = new System.Drawing.Size(858, 200);
            this.itemsPanel.TabIndex = 3;
            // 
            // invoiceItemsGrid
            // 
            this.invoiceItemsGrid.AllowUserToAddRows = false;
            this.invoiceItemsGrid.AllowUserToDeleteRows = false;
            this.invoiceItemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceItemsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoiceItemsGrid.Location = new System.Drawing.Point(30, 10);
            this.invoiceItemsGrid.Name = "invoiceItemsGrid";
            this.invoiceItemsGrid.ReadOnly = true;
            this.invoiceItemsGrid.Size = new System.Drawing.Size(798, 180);
            this.invoiceItemsGrid.TabIndex = 0;
            // 
            // totalsPanel
            // 
            this.totalsPanel.Controls.Add(this.subtotalTextLabel);
            this.totalsPanel.Controls.Add(this.subtotalLabel);
            this.totalsPanel.Controls.Add(this.vatTextLabel);
            this.totalsPanel.Controls.Add(this.vatLabel);
            this.totalsPanel.Controls.Add(this.grandTotalTextLabel);
            this.totalsPanel.Controls.Add(this.grandTotalLabel);
            this.totalsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.totalsPanel.Location = new System.Drawing.Point(0, 60);
            this.totalsPanel.Name = "totalsPanel";
            this.totalsPanel.Size = new System.Drawing.Size(858, 100);
            this.totalsPanel.TabIndex = 4;
            // 
            // subtotalTextLabel
            // 
            this.subtotalTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.subtotalTextLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.subtotalTextLabel.Location = new System.Drawing.Point(500, 10);
            this.subtotalTextLabel.Name = "subtotalTextLabel";
            this.subtotalTextLabel.Size = new System.Drawing.Size(120, 19);
            this.subtotalTextLabel.TabIndex = 0;
            this.subtotalTextLabel.Text = "Tổng cộng:";
            this.subtotalTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.subtotalLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.subtotalLabel.Location = new System.Drawing.Point(630, 10);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(180, 19);
            this.subtotalLabel.TabIndex = 1;
            this.subtotalLabel.Text = "0 VNĐ";
            this.subtotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // vatTextLabel
            // 
            this.vatTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vatTextLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.vatTextLabel.Location = new System.Drawing.Point(500, 35);
            this.vatTextLabel.Name = "vatTextLabel";
            this.vatTextLabel.Size = new System.Drawing.Size(120, 19);
            this.vatTextLabel.TabIndex = 2;
            this.vatTextLabel.Text = "VAT (10%):";
            this.vatTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // vatLabel
            // 
            this.vatLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vatLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.vatLabel.Location = new System.Drawing.Point(630, 35);
            this.vatLabel.Name = "vatLabel";
            this.vatLabel.Size = new System.Drawing.Size(180, 19);
            this.vatLabel.TabIndex = 3;
            this.vatLabel.Text = "0 VNĐ";
            this.vatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grandTotalTextLabel
            // 
            this.grandTotalTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grandTotalTextLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grandTotalTextLabel.Location = new System.Drawing.Point(500, 65);
            this.grandTotalTextLabel.Name = "grandTotalTextLabel";
            this.grandTotalTextLabel.Size = new System.Drawing.Size(120, 21);
            this.grandTotalTextLabel.TabIndex = 4;
            this.grandTotalTextLabel.Text = "Thành tiền:";
            this.grandTotalTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grandTotalLabel
            // 
            this.grandTotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grandTotalLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grandTotalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.grandTotalLabel.Location = new System.Drawing.Point(630, 65);
            this.grandTotalLabel.Name = "grandTotalLabel";
            this.grandTotalLabel.Size = new System.Drawing.Size(180, 21);
            this.grandTotalLabel.TabIndex = 5;
            this.grandTotalLabel.Text = "0 VNĐ";
            this.grandTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // notesPanel
            // 
            this.notesPanel.Controls.Add(this.notesLabel);
            this.notesPanel.Controls.Add(this.notesTextBox);
            this.notesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.notesPanel.Location = new System.Drawing.Point(0, 0);
            this.notesPanel.Name = "notesPanel";
            this.notesPanel.Padding = new System.Windows.Forms.Padding(30, 5, 30, 5);
            this.notesPanel.Size = new System.Drawing.Size(858, 60);
            this.notesPanel.TabIndex = 5;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.notesLabel.Location = new System.Drawing.Point(33, 20);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(54, 17);
            this.notesLabel.TabIndex = 0;
            this.notesLabel.Text = "Ghi chú:";
            // 
            // notesTextBox
            // 
            this.notesTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.notesTextBox.Location = new System.Drawing.Point(100, 17);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(710, 25);
            this.notesTextBox.TabIndex = 1;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.saveBtn);
            this.buttonPanel.Controls.Add(this.cancelBtn);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(0, 600);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(858, 58);
            this.buttonPanel.TabIndex = 6;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(560, 10);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(120, 38);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Lưu hóa đơn";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BackColor = System.Drawing.Color.Gray;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(690, 10);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(120, 38);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Thoát";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // InvoiceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvoiceDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết hóa đơn";
            this.Load += new System.EventHandler(this.InvoiceDetail_Load);
            this.mainPanel.ResumeLayout(false);
            this.invoicePanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.leftInfoPanel.ResumeLayout(false);
            this.leftInfoPanel.PerformLayout();
            this.rightInfoPanel.ResumeLayout(false);
            this.rightInfoPanel.PerformLayout();
            this.productPanel.ResumeLayout(false);
            this.productPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityInput)).EndInit();
            this.itemsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemsGrid)).EndInit();
            this.totalsPanel.ResumeLayout(false);
            this.notesPanel.ResumeLayout(false);
            this.notesPanel.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel invoicePanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Panel leftInfoPanel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker invoiceDatePicker;
        private System.Windows.Forms.Panel rightInfoPanel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.ComboBox paymentMethodComboBox;
        private System.Windows.Forms.Panel productPanel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.NumericUpDown quantityInput;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label unitPriceLabel;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.Button removeProductBtn;
        private System.Windows.Forms.Panel itemsPanel;
        private System.Windows.Forms.DataGridView invoiceItemsGrid;
        private System.Windows.Forms.Panel totalsPanel;
        private System.Windows.Forms.Label subtotalTextLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label vatTextLabel;
        private System.Windows.Forms.Label vatLabel;
        private System.Windows.Forms.Label grandTotalTextLabel;
        private System.Windows.Forms.Label grandTotalLabel;
        private System.Windows.Forms.Panel notesPanel;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}