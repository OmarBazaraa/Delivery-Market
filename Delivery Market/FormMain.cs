using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeliveryMarket.Utils.Defs;

namespace DeliveryMarket {

	public partial class FormMain : Form {

		// Member variables
		private int mAccountID;
		private Privilege mPrivilege;

		/* Constructor */
		public FormMain(int accountID = 99, Privilege privilege = Privilege.User) {
			InitializeComponent();

			mAccountID = accountID;
			mPrivilege = privilege;
		}

		/* Add product button clicked callback function */
		private void buttonAddProduct_Click(object sender, EventArgs e) {
			new Product.FormSaveProduct(mAccountID).Show(this);
			Hide();
		}

		/* View products button clicked callback function */
		private void buttonViewProducts_Click(object sender, EventArgs e) {
			new Product.FormProducts(mAccountID).Show();
		}

		/* View sellers button clicked callback function */
		private void buttonViewSellers_Click(object sender, EventArgs e) {

		}

		/* Admin panel button clicked callback function */
		private void buttonAdminPanel_Click(object sender, EventArgs e) {
			new Admin.FormAdminMain().Show(this);
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