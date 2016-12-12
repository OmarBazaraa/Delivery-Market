using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeliveryMarket.Admin;
using DeliveryMarket.Product;
using DeliveryMarket.Utils.Defs;

namespace DeliveryMarket {

	public partial class FormMain : Form {

		// Member variables
		private int mAccountID;
		private Privilege mPrivilege;

		/* Constructor */
		public FormMain(int accountID = 99, Privilege privilege = Privilege.Admin) {
			InitializeComponent();

			mAccountID = accountID;
			mPrivilege = privilege;
		}

		/* Form load callback function */
		private void FormMain_Load(object sender, EventArgs e) {
			switch (mPrivilege) {
				case Privilege.Admin:
					buttonAddProduct.Enabled = false;
					break;

				case Privilege.User:
					buttonAdminPanel.Enabled = false;
					break;
			}
		}

		/* Add product button clicked callback function */
		private void buttonAddProduct_Click(object sender, EventArgs e) {
			new FormSaveProduct(mAccountID).Show(this);
			Hide();
		}

		/* View products button clicked callback function */
		private void buttonViewProducts_Click(object sender, EventArgs e) {
			new FormProductList(mAccountID, mPrivilege).Show(this);
			//new FormProductDetail(mAccountID, 9, mPrivilege).Show(this);
			Hide();
		}

		/* View sellers button clicked callback function */
        private void buttonViewSellers_Click(object sender, EventArgs e)
        {
			new Account.FormAccounts(mAccountID).Show();
		}

		/* Admin panel button clicked callback function */
		private void buttonAdminPanel_Click(object sender, EventArgs e) {
			new FormAdminMain(mAccountID).Show(this);
			this.Hide();
		}

		/* About button clicked callback function */
		private void buttonAbout_Click(object sender, EventArgs e) {

		}

		/* Sign out button clicked callback function */
		private void buttonSignOut_Click(object sender, EventArgs e) {
			Close();
		}
	}
}