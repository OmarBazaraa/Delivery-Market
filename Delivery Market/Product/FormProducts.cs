using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryMarket.Product
{
    public partial class FormProducts : Form
    {
        // Member variables
        private int mAccountID;
		private ProductController mController;

		public FormProducts(int accountID)
        {
            InitializeComponent();

            mAccountID = accountID;
			mController = new ProductController();
        }
    }
}
