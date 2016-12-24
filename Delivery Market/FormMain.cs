using System;
using System.Windows.Forms;
using DeliveryMarket.Admin;
using DeliveryMarket.Product;
using DeliveryMarket.Utils.Defs;
using DeliveryMarket.Orders;
using DeliveryMarket.Account;

namespace DeliveryMarket {

	public partial class FormMain : Form {
		// Messages
		private const string WELCOME_LABEL = "Welcome";
		private const string LOGIN_LABEL = "Login";
		private const string SIGNOUT_LABEL = "Sign Out";
		private const string LOGIN_MSG = "Please log in first";

		// Member variables
		private int mAccountID;
		private Privilege mPrivilege;

		// Other variables
		private string mUsername;
		private bool mSignOut = false;

		/* Constructor */
		public FormMain(Privilege privilege = Privilege.Other, int accountID = -1, string username = "guest") {
			InitializeComponent();

			mAccountID = accountID;
			mUsername = username;
			mPrivilege = privilege;
		}

		/* Form load callback function */
		private void FormMain_Load(object sender, EventArgs e) {
			labelWelcome.Text = WELCOME_LABEL + " " + mUsername + "...";

			if (mPrivilege != Privilege.Admin) {
				buttonAdminPanel.Enabled = false;
			}
		}

		/* Form closed callback function */
		private void FormMain_FormClosed(object sender, FormClosedEventArgs e) {
			if (e.CloseReason == CloseReason.UserClosing && !mSignOut) {
				Owner.Close();
			}
		}

		/* Add product button clicked callback function */
		private void buttonAddProduct_Click(object sender, EventArgs e) {
			if (mPrivilege == Privilege.Other) {
				MessageBox.Show(LOGIN_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			new FormSaveProduct(mAccountID).ShowDialog(this);
		}

		/* View products button clicked callback function */
		private void buttonViewProducts_Click(object sender, EventArgs e) {
			new FormProductList(mPrivilege, mAccountID).Show(this);
			Hide();
		}

		/* View sellers button clicked callback function */
        private void buttonViewSellers_Click(object sender, EventArgs e) {
			new FormAccountList(mAccountID,mPrivilege).Show(this);
		}

		/* View orders button clicked callback function */
		private void buttonViewOrders_Click(object sender, EventArgs e) {
			if (mPrivilege == Privilege.Other) {
				MessageBox.Show(LOGIN_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			new FormOrders(mAccountID).Show(this);
		}

		/* Admin panel button clicked callback function */
		private void buttonAdminPanel_Click(object sender, EventArgs e) {
			new FormAdminMain(mAccountID).Show(this);
			this.Hide();
		}

		/* About button clicked callback function */
		private void buttonAbout_Click(object sender, EventArgs e) {
			new FormAbout().ShowDialog();
		}

		/* Sign out button clicked callback function */
		private void buttonSignOut_Click(object sender, EventArgs e) {
			mSignOut = true;
			Owner.Show();
			Close();
		}

		/* Loses buttons focus */
		private void LoseFocus(object sender, EventArgs e) {
			labelWelcome.Focus();
		}
	}
}