using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ShopManager: Form
    {
        Customers customers;
        Product product;
        ProductCategories productCategories;
        Invoice invoices;

        public int CurrentUserRole { get; set; }

        private Button selectedButton = null;

        

        bool sidebarExpanded;
        public ShopManager()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // CHeck if user role === 1 -> enable admin button
            if (CurrentUserRole == 1)
            {
                adminBtn.Visible = true;
            }
            else
            {
                adminBtn.Visible = false;
            }
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpanded)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpanded = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpanded = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void menuBtnn_Paint(object sender, PaintEventArgs e)
        {
            //sidebarTimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        // Customers form
        private void customersBtn_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            // Unselect old button
            if (selectedButton != null)
                selectedButton.BackColor = Color.Transparent;

            // Select new button
            clickedButton.BackColor = Color.LightBlue;
            selectedButton = clickedButton;


            if (customers == null)
            {
                customers = new Customers();
                customers.FormClosed += customers_FormClosed;
                customers.MdiParent = this;
                customers.Dock = DockStyle.Fill;
                customers.Show();
            }
            else {
                customers.Activate();
            }

        }
        private void customers_FormClosed(object sender, FormClosedEventArgs e)
        {
            customers = null;
        }


        //Product form
        private void productBtn_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            // Unselect old button
            if (selectedButton != null)
                selectedButton.BackColor = Color.Transparent;

            // Select new button
            clickedButton.BackColor = Color.LightBlue;
            selectedButton = clickedButton;

            if (product == null)
            {
                product = new Product();
                product.FormClosed += product_FormClosed;
                product.MdiParent = this;
                product.Dock = DockStyle.Fill;
                product.Show();
            }
            else
            {
                product.Activate();
            }
        }

        private void product_FormClosed(object sender, FormClosedEventArgs e)
        {
            product = null;
        }

        // ProductCategories form
        private void productCategoryBtn_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            // Unselect old button
            if (selectedButton != null)
                selectedButton.BackColor = Color.Transparent;

            // Select new button
            clickedButton.BackColor = Color.LightBlue;
            selectedButton = clickedButton;

            if (productCategories == null)
            {
                productCategories = new ProductCategories();
                productCategories.FormClosed += productCategories_FormClosed;
                productCategories.MdiParent = this;
                productCategories.Dock = DockStyle.Fill;
                productCategories.Show();
            }
            else
            {
                productCategories.Activate();
            }
        }

        private void productCategories_FormClosed(object sender, FormClosedEventArgs e)
        {
            productCategories = null;
        }

        private void invoiceBtn_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            // Unselect old button
            if (selectedButton != null)
                selectedButton.BackColor = Color.Transparent;

            // Select new button
            clickedButton.BackColor = Color.LightBlue;
            selectedButton = clickedButton;

            if (invoices == null)
            {
                invoices = new Invoice();
                invoices.FormClosed += invoices_FormClosed;
                invoices.MdiParent = this;
                invoices.Dock = DockStyle.Fill;
                invoices.Show();
            }
            else
            {
                invoices.Activate();
            }
        }

        private void invoices_FormClosed(object sender, FormClosedEventArgs e)
        {
            invoices = null;
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
