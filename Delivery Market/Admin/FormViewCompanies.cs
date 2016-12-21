using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeliveryMarket.Data.MarketContract;

namespace DeliveryMarket.Admin {
	public partial class FormViewCompanies : Form {
		AdminController mController;
		DataTable mDataTransportCompany,mDataTransactionCompany;
		int mCompanyIdIdx = 0;

		public FormViewCompanies() {
			InitializeComponent();
			mController = new AdminController();
			PopulateListViewTransportCompany();
			PopulateListViewTransactionCompany();
		}

		public void PopulateListViewTransportCompany() {
			listViewTransportCompanies.Items.Clear();
			
			mDataTransportCompany = mController.SelectTransportCompanies(textBoxTransportCompanySearch.Text.Replace("'", "''").Trim());
			if (mDataTransportCompany == null)
				return;

			
			foreach(DataRow row in mDataTransportCompany.Rows) {
				ListViewItem item = new ListViewItem(row[TransportCompanyEntry.COL_COMPANY_ID].ToString());
				item.SubItems.Add(row[TransportCompanyEntry.COL_COMPANY_NAME].ToString());

				listViewTransportCompanies.Items.Add(item);
			}
		}

		public void PopulateListViewTransactionCompany() {
			listViewTransactionCompanies.Items.Clear();

			mDataTransactionCompany = mController.SelectTransactionCompanies(textBoxTransactionCompanySearch.Text.Replace("'", "''").Trim());
			if (mDataTransactionCompany == null)
				return;

			foreach (DataRow row in mDataTransactionCompany.Rows) {
				ListViewItem item = new ListViewItem(row[TransactionCompanyEntry.COL_COMPANY_ID].ToString());
				item.SubItems.Add(row[TransactionCompanyEntry.COL_COMPANY_NAME].ToString());

				listViewTransactionCompanies.Items.Add(item);
			}
		}
		private void buttonTransportCompanySearch_Click(object sender, EventArgs e) {
			PopulateListViewTransportCompany();
		}

		private void buttonTransportCompanyAdd_Click(object sender, EventArgs e) {
			var childForm = new FormAddCompany(TransportCompanyEntry.TABLE_NAME.ToString());
			childForm.mParent = this;
			childForm.Show(this);
		}

		private void buttonTransactionCompanyAdd_Click(object sender, EventArgs e) {
			var childForm = new FormAddCompany(TransactionCompanyEntry.TABLE_NAME.ToString());
			childForm.mParent = this;
			childForm.Show(this);
		}

		private void buttonTransportCompanyRemove_Click(object sender, EventArgs e) {
			if (listViewTransportCompanies.SelectedItems.Count == 0)
				return;

			ListViewItem item = listViewTransportCompanies.SelectedItems[0];
			string id = item.SubItems[mCompanyIdIdx].Text;
			mController.RemoveTransportCompany(id);
			PopulateListViewTransportCompany();
		}

		private void buttonTransactionCompanyRemove_Click(object sender, EventArgs e) {
			if (listViewTransactionCompanies.SelectedItems.Count == 0)
				return;

			ListViewItem item = listViewTransactionCompanies.SelectedItems[0];
			string id = item.SubItems[mCompanyIdIdx].Text;
			mController.RemoveTransactionCompany(id);
			PopulateListViewTransactionCompany();
		}


		private void buttonTransactionCompanySearch_Click(object sender, EventArgs e) {
			PopulateListViewTransactionCompany();
		}

		private void FormCompanies_FormClosed(object sender, FormClosedEventArgs e) {
			if (e.CloseReason == CloseReason.UserClosing) {
				Owner.Show();
				Owner.Refresh();
			}
		}
	}
}
