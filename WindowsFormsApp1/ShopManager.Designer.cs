namespace WindowsFormsApp1
{
    partial class ShopManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopManager));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.menuBtnn = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuBtn = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customersBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.productBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.productCategoryBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.invoiceBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.adminBtn = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebar.SuspendLayout();
            this.menuBtnn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuBtn)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Gainsboro;
            this.sidebar.Controls.Add(this.menuBtnn);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel5);
            resources.ApplyResources(this.sidebar, "sidebar");
            this.sidebar.Name = "sidebar";
            // 
            // menuBtnn
            // 
            this.menuBtnn.Controls.Add(this.label1);
            this.menuBtnn.Controls.Add(this.menuBtn);
            this.menuBtnn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.menuBtnn, "menuBtnn");
            this.menuBtnn.Name = "menuBtnn";
            this.menuBtnn.Paint += new System.Windows.Forms.PaintEventHandler(this.menuBtnn_Paint);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // menuBtn
            // 
            resources.ApplyResources(this.menuBtn, "menuBtn");
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.TabStop = false;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.customersBtn);
            this.panel1.Controls.Add(this.button1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // customersBtn
            // 
            this.customersBtn.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.customersBtn, "customersBtn");
            this.customersBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.customersBtn.Name = "customersBtn";
            this.customersBtn.UseVisualStyleBackColor = false;
            this.customersBtn.Click += new System.EventHandler(this.customersBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.productBtn);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // productBtn
            // 
            this.productBtn.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.productBtn, "productBtn");
            this.productBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.productBtn.Name = "productBtn";
            this.productBtn.UseVisualStyleBackColor = false;
            this.productBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.productCategoryBtn);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // productCategoryBtn
            // 
            this.productCategoryBtn.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.productCategoryBtn, "productCategoryBtn");
            this.productCategoryBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.productCategoryBtn.Name = "productCategoryBtn";
            this.productCategoryBtn.UseVisualStyleBackColor = false;
            this.productCategoryBtn.Click += new System.EventHandler(this.productCategoryBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.invoiceBtn);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // invoiceBtn
            // 
            this.invoiceBtn.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.invoiceBtn, "invoiceBtn");
            this.invoiceBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.invoiceBtn.Name = "invoiceBtn";
            this.invoiceBtn.UseVisualStyleBackColor = false;
            this.invoiceBtn.Click += new System.EventHandler(this.invoiceBtn_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.adminBtn);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // adminBtn
            // 
            this.adminBtn.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.adminBtn, "adminBtn");
            this.adminBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.UseVisualStyleBackColor = false;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // ShopManager
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidebar);
            this.IsMdiContainer = true;
            this.Name = "ShopManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidebar.ResumeLayout(false);
            this.menuBtnn.ResumeLayout(false);
            this.menuBtnn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel menuBtnn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox menuBtn;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button productBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button productCategoryBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button invoiceBtn;
        private System.Windows.Forms.Button customersBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button adminBtn;
    }
}

