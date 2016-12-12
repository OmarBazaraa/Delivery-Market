using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryMarket.Account
{
    public partial class FormAccounts : Form
    {
		private AccountController mController;
		int mAccountID;

		public FormAccounts(int accountID)
        {
            InitializeComponent();

			this.mAccountID = accountID;
		}
	}
}
