namespace WindowsFormsApp1
{
    partial class AddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomer));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.noteTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.identifyCardTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.districtTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.genderSelect = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.customDatePicker1 = new WindowsFormsApp1.CustomDatePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.77778F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.label1.Size = new System.Drawing.Size(794, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "    Add New Customer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 48);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.96992F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.03008F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 399);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.noteTxt, 1, 8);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.identifyCardTxt, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.phoneTxt, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.districtTxt, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.addressTxt, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lastNameTxt, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.firstNameTxt, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.genderSelect, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.customDatePicker1, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 9;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11148F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11148F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11148F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11037F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11037F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11037F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11148F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11148F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11148F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(788, 344);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Right;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(327, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 40);
            this.label10.TabIndex = 16;
            this.label10.Text = "Note:   ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // noteTxt
            // 
            this.noteTxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.noteTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noteTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteTxt.Location = new System.Drawing.Point(394, 314);
            this.noteTxt.Margin = new System.Windows.Forms.Padding(0);
            this.noteTxt.Name = "noteTxt";
            this.noteTxt.Size = new System.Drawing.Size(164, 19);
            this.noteTxt.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Right;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(243, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 38);
            this.label9.TabIndex = 14;
            this.label9.Text = "Identify Card (*):   ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // identifyCardTxt
            // 
            this.identifyCardTxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.identifyCardTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.identifyCardTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identifyCardTxt.Location = new System.Drawing.Point(394, 275);
            this.identifyCardTxt.Margin = new System.Windows.Forms.Padding(0);
            this.identifyCardTxt.MaxLength = 10;
            this.identifyCardTxt.Name = "identifyCardTxt";
            this.identifyCardTxt.Size = new System.Drawing.Size(164, 19);
            this.identifyCardTxt.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Right;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(293, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 38);
            this.label8.TabIndex = 12;
            this.label8.Text = "Phone (*):   ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phoneTxt
            // 
            this.phoneTxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.phoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTxt.Location = new System.Drawing.Point(394, 237);
            this.phoneTxt.Margin = new System.Windows.Forms.Padding(0);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(164, 19);
            this.phoneTxt.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(283, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 38);
            this.label7.TabIndex = 10;
            this.label7.Text = "District  (*):   ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // districtTxt
            // 
            this.districtTxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.districtTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.districtTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.districtTxt.Location = new System.Drawing.Point(394, 199);
            this.districtTxt.Margin = new System.Windows.Forms.Padding(0);
            this.districtTxt.Name = "districtTxt";
            this.districtTxt.Size = new System.Drawing.Size(164, 19);
            this.districtTxt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(278, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 38);
            this.label6.TabIndex = 8;
            this.label6.Text = "Address  (*):   ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addressTxt
            // 
            this.addressTxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addressTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTxt.Location = new System.Drawing.Point(394, 161);
            this.addressTxt.Margin = new System.Windows.Forms.Padding(0);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(164, 19);
            this.addressTxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(245, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 38);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date of birth (*):   ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(287, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender (*):   ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lastname (*):   ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lastNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTxt.Location = new System.Drawing.Point(394, 47);
            this.lastNameTxt.Margin = new System.Windows.Forms.Padding(0);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(164, 19);
            this.lastNameTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Firstname (*):   ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.firstNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTxt.Location = new System.Drawing.Point(394, 9);
            this.firstNameTxt.Margin = new System.Windows.Forms.Padding(0);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(164, 19);
            this.firstNameTxt.TabIndex = 1;
            // 
            // genderSelect
            // 
            this.genderSelect.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.genderSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderSelect.FormattingEnabled = true;
            this.genderSelect.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.genderSelect.Location = new System.Drawing.Point(397, 84);
            this.genderSelect.Name = "genderSelect";
            this.genderSelect.Size = new System.Drawing.Size(121, 21);
            this.genderSelect.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.exitBtn, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.addBtn, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 353);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(788, 43);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBtn.Location = new System.Drawing.Point(397, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.exitBtn.Size = new System.Drawing.Size(141, 37);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "        Đóng";
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Image = ((System.Drawing.Image)(resources.GetObject("addBtn.Image")));
            this.addBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBtn.Location = new System.Drawing.Point(250, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.addBtn.Size = new System.Drawing.Size(141, 37);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "        Thêm";
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // customDatePicker1
            // 
            this.customDatePicker1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.customDatePicker1.Location = new System.Drawing.Point(397, 121);
            this.customDatePicker1.Name = "customDatePicker1";
            this.customDatePicker1.Size = new System.Drawing.Size(150, 24);
            this.customDatePicker1.TabIndex = 18;
            this.customDatePicker1.DateChanged += new System.EventHandler(this.customDatePicker1_DateChanged_1);
            this.customDatePicker1.Load += new System.EventHandler(this.customDatePicker1_Load_1);
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox noteTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox identifyCardTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox districtTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox genderSelect;
        private CustomDatePicker customDatePicker1;
    }
}