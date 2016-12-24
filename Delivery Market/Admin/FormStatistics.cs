using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using DeliveryMarket.Utils.Defs;
using DeliveryMarket.Data.MarketContract;

enum ProductType {
	ACTIVE,
	DELETED
}

namespace DeliveryMarket.Admin {
	public partial class FormStatistics : Form {
		private const string TRANSPORT_COMPANY = "Transport Companies";
		private const string TRANSACTION_COMPANY = "Transaction Companies";
		string mCompanyType;

		AdminController mController;
		DataTable mListViewData, mAccountsData, mProductsData;
		int mReportsCount;

		public FormStatistics() {
			InitializeComponent();
			mController = new AdminController();

			InitComboBox();

			StatUpdate();
		}

		private void InitComboBox() {
			comboBoxCompany.Items.Add(TRANSPORT_COMPANY);
			comboBoxCompany.Items.Add(TRANSACTION_COMPANY);

			comboBoxCompany.SelectedItem = TRANSPORT_COMPANY;
		}

		private void StatUpdate() {
			mAccountsData = mController.SelectAccountStat();
			mProductsData = mController.SelectProductStat();
			mReportsCount = mController.SelectReportsCount();

			if (mAccountsData == null || mProductsData == null)
				return;

			foreach(DataRow row in mAccountsData.Rows) {
				string accountType = row[Strings.ACCOUNT_TYPE].ToString();
				if (accountType == AccountType.ACTIVE) {
					//User
					textBoxUsersCount.Text = row[Strings.ACCOUNTS_COUNT].ToString();
					textBoxUsersAverageRate.Text = row[Strings.AVERAGE_ACCOUNTS_RATING].ToString();
					textBoxUsersMoneyPaid.Text =row[Strings.TOTAL_MONEY_PAID].ToString();
					textBoxUsersOrderCount.Text = row[Strings.ORDERS_COUNT].ToString();
				}
				else if (accountType == AccountType.BANNED) {
					textBoxBannedUsersCount.Text = row[Strings.ACCOUNTS_COUNT].ToString();
				}

				else if (accountType == AccountType.ADMIN) {
					//Admin
					textBoxAdminsCount.Text = row[Strings.ACCOUNTS_COUNT].ToString();
					textBoxAdminsAverageRate.Text = row[Strings.AVERAGE_ACCOUNTS_RATING].ToString();
					textBoxAdminsMoneyPaid.Text = row[Strings.TOTAL_MONEY_PAID].ToString();
					textBoxAdminsOrderCount.Text = row[Strings.ORDERS_COUNT].ToString();
				}
			}

			//Product
			foreach (DataRow row in mProductsData.Rows) {
				string productState = row[Strings.PRODUCT_DELETION_STATE].ToString();
				productState = (productState == "False" ? ProductType.ACTIVE.ToString() : ProductType.DELETED.ToString());
				if (productState == ProductType.ACTIVE.ToString()) { 
					textBoxProductsCount.Text = row[Strings.PRODUCTS_COUNT].ToString();
					textBoxProductsAverageRate.Text = row[Strings.PRODUCTS_AVERAGE_RATE].ToString();
				}
				else if (productState == ProductType.DELETED.ToString())
					textBoxRemovedProductsCount.Text = row[Strings.PRODUCTS_COUNT].ToString();
			}
			//Reports
			textBoxReportsCount.Text = mReportsCount.ToString();

			PopulateListView();
		}

		private void PopulateListView() {
			listViewCompanies.Items.Clear();

			if (mCompanyType == TRANSPORT_COMPANY)
				mListViewData = mController.SelectTransportCompanyStat();
			else if (mCompanyType == TRANSACTION_COMPANY)
				mListViewData = mController.SelectTransactionCompanyStat();

			if (mListViewData == null)
				return;

			textBoxCompanyCount.Text = mListViewData.Rows.Count.ToString();
			foreach(DataRow row in mListViewData.Rows) {
				ListViewItem item = new ListViewItem(row[Strings.COMPANY_NAME].ToString());
				item.SubItems.Add(row[Strings.COMPANY_ORDERS_COUNT].ToString());

				listViewCompanies.Items.Add(item);
			}
		}

		private void comboBoxCompany_SelectedIndexChanged(object sender, EventArgs e) {
			mCompanyType = comboBoxCompany.Text;
			PopulateListView();
		}

		private void FormStatistics_FormClosed(object sender, FormClosedEventArgs e) {
			if (e.CloseReason == CloseReason.UserClosing) {
				Owner.Show();
				Owner.Refresh();
			}
		}
	}
}
