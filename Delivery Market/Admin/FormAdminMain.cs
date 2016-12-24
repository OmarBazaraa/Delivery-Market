using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeliveryMarket.Data;

namespace DeliveryMarket.Admin {

	public partial class FormAdminMain : Form {

		Controller mController;
		int mAccountID;

		public FormAdminMain(int AccountId) {
			InitializeComponent();
			mController = new Controller();
			mAccountID = AccountId;
		}


		private void FormAdminMain_FormClosed(object sender, FormClosedEventArgs e) {
			if (e.CloseReason == CloseReason.UserClosing) {
				Owner.Show();
				Owner.Refresh();
			}
		}

		private void buttonBack_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void buttonViewAdmins_Click(object sender, EventArgs e) {
			new FormViewAccounts(mAccountID).Show(this);
			this.Hide();
		}

		private void buttonReports_Click(object sender, EventArgs e) {
			new FormReports(mAccountID).Show(this);
			this.Hide();
		}

		private void buttonCompanies_Click(object sender, EventArgs e) {
			new FormViewCompanies().Show(this);
			this.Hide();
		}

		private void buttonStatistics_Click(object sender, EventArgs e) {
			new FormStatistics().Show(this);
			this.Hide();
		}

		private void buttonExtras_Click(object sender, EventArgs e) {
			new FormExtras().Show(this);
			this.Hide();
		}
	}
}