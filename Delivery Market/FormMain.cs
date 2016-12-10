using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryMarket
{
    public partial class FormMain : Form
    {
        private Controller mController;
        private int mAccountID;

        /* Constructor */
        public FormMain()
        {
            // Initialzes form's components
            InitializeComponent();


            mController = new Controller();
            mAccountID = 99; // Just for testing
        }

        /* Add product button clicked callback function */
        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            // For test
            Product.Product p = new Product.Product();
            p.Name = "iPhone 7";
            p.Price = "78.65";
            p.StockCount = "15";
            p.Description = "Apple greatest phone ever.";
            p.Category = "Mobile phone";
            p.SellerID = "99";

            new Product.FormAddProduct(mAccountID).Show(this);
            this.Hide();
        }

        /* View products button clicked callback function */
        private void buttonViewProducts_Click(object sender, EventArgs e)
        {
            new Product.FormProducts(mAccountID).Show();
        }

        /* View sellers button clicked callback function */
        private void buttonViewSellers_Click(object sender, EventArgs e)
        {
			new Account.FormAccounts(mAccountID).Show();
        }

        /* Admin panel button clicked callback function */
        private void buttonAdminPanel_Click(object sender, EventArgs e)
        {
            this.Focus();
        }

        /* About button clicked callback function */
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            this.Focus();
        }

        /* Sign out button clicked callback function */
        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
