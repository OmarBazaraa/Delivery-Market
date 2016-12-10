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
        private Controller mController;
        private int mAccountID;

        public FormProducts(int accountID)
        {
            InitializeComponent();

            this.mAccountID = accountID;
        }
    }
}
