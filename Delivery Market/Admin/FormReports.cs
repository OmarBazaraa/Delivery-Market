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
	public partial class FormReports : Form {
		private const string BAN_ACCOUNT_FAILED = "Failed to ban account";
		AdminController mController;
		DataTable mReportList;
		private const int ReportIdIndex = 0;
		private int mAdminID;

		public FormReports(int adminId) {
			InitializeComponent();
			mController = new AdminController();
			mAdminID = adminId;

			PopulateListView();
		}

		public void PopulateListView() {
			mReportList = mController.SelectReports(textBoxSearch.Text.Replace("'", "''").Trim());
			listViewReports.Items.Clear();

			if (mReportList == null) return;

			foreach (DataRow row in mReportList.Rows) {
				ListViewItem item = new ListViewItem(row[ReportEntry.COL_REPORT_ID].ToString());
				item.SubItems.Add(row[ProductEntry.COL_PRODUCT_NAME].ToString());
				item.SubItems.Add(row[AccountEntry.COL_USERNAME].ToString());
				item.SubItems.Add(row[ReportEntry.COL_REPORT_REASON].ToString());
				item.SubItems.Add(row[ReportEntry.COL_REPORT_DATE].ToString());

				listViewReports.Items.Add(item);
			}
		}

		private void ClearDetailView() {
			//clear product-report tab
			textBoxReportReason.Clear();
			textBoxReportDescription.Clear();
			textBoxProductId.Clear();
			textBoxProductName.Clear();
			textBoxProductPrice.Clear();
			textBoxProductQuantity.Clear();
			comboBoxProductCategory.Text = "";
			dateTimeProductSellingDate.Text = "";
			textBoxProductDescription.Clear();

			//clear account tab
			textBoxSellerId.Clear();
			textBoxSellerName.Clear();
			textBoxSellerUserName.Clear();
			textBoxSellerMobileNumber.Clear();
			comboBoxSellerGender.Text = "";
			dateTimeSellerBirthDate.Text = "";
			dateTimeSellerCreationDate.Text = "";
			textBoxSellerAddress.Clear();
			richTextBoxBanSellerDescription.Clear();
			comboBoxBanSellerReason.Text = "";
		}

		public void PopulateDetailView(string reportId = "") {
			ClearDetailView();

			if (reportId == "") return;

			DataTable retTable = mController.SelectReportDetails(reportId);

			if (retTable == null) return;

			DataRow reportDetails = retTable.Rows[0];

			DataTable BanReasons = mController.SelectBanReasons();

			//populate product-report tab
			textBoxReportReason.Text = reportDetails[ReportEntry.COL_REPORT_REASON].ToString();
			textBoxReportDescription.Text = reportDetails[ReportEntry.TABLE_NAME + "." + ReportEntry.COL_DESCRIPTION].ToString();
			textBoxProductId.Text = reportDetails[ProductEntry.COL_PRODUCT_ID].ToString();
			textBoxProductName.Text = reportDetails[ProductEntry.COL_PRODUCT_NAME].ToString();
			textBoxProductPrice.Text = reportDetails[ProductEntry.COL_PRICE].ToString();
			textBoxProductQuantity.Text = reportDetails[ProductEntry.COL_QUANTITY].ToString();
			comboBoxProductCategory.Text = reportDetails[ProductEntry.COL_CATEGORY].ToString();
			dateTimeProductSellingDate.Text = reportDetails[ProductEntry.COL_SELLING_DATE].ToString();
			textBoxProductDescription.Text = reportDetails[ProductEntry.TABLE_NAME + "." + ProductEntry.COL_DESCRIPTION].ToString();

			//populate account tab
			textBoxSellerId.Text = reportDetails[AccountEntry.COL_ACCOUNT_ID].ToString();
			textBoxSellerName.Text = reportDetails[AccountEntry.COL_FIRST_NAME].ToString() + ", " + reportDetails[AccountEntry.COL_LAST_NAME].ToString();
			textBoxSellerUserName.Text = reportDetails[AccountEntry.COL_USERNAME].ToString();
			textBoxSellerMobileNumber.Text = reportDetails[AccountEntry.COL_MOBILE_NUMBER].ToString();
			comboBoxSellerGender.Text = reportDetails[AccountEntry.COL_GENDER].ToString();
			dateTimeSellerBirthDate.Text = reportDetails[AccountEntry.COL_BIRTHDATE].ToString();
			dateTimeSellerCreationDate.Text = reportDetails[AccountEntry.COL_CREATION_DATE].ToString();
			textBoxSellerAddress.Text = reportDetails[AccountEntry.COL_CITY].ToString() + ", " + reportDetails[AccountEntry.COL_COUNTRY].ToString();
			comboBoxBanSellerReason.DataSource = BanReasons;
			comboBoxBanSellerReason.DisplayMember = ProductRemovalReasonsEntry.COL_REASON;
		}

		private void listViewReports_SelectedIndexChanged(object sender, EventArgs e) {
			if (listViewReports.SelectedItems.Count == 0)
				return;

			ListViewItem item = listViewReports.SelectedItems[0];
			string id = item.SubItems[ReportIdIndex].Text;
			PopulateDetailView(id);
		}

		private void buttonBanSeller_Click(object sender, EventArgs e) {
			if (textBoxSellerId.Text == "")
				return;
			int ret = mController.BanAccount(textBoxSellerId.Text, mAdminID.ToString(), comboBoxBanSellerReason.Text, richTextBoxBanSellerDescription.Text.Replace("'","''").Trim());
			if (ret == -1)
				MessageBox.Show(BAN_ACCOUNT_FAILED);

			PopulateListView();
			PopulateDetailView();
		}

		private void buttonRemoveProduct_Click(object sender, EventArgs e) {
			new Product.FormRemoveProduct(mAdminID, Convert.ToInt32(textBoxProductId.Text)).Show();
		}


		private void buttonSearch_Click(object sender, EventArgs e) {
			PopulateListView();
		}

		public void FormReports_FormClosed(object sender, FormClosedEventArgs e) {
			if (e.CloseReason == CloseReason.UserClosing) {
				Owner.Show();
				Owner.Refresh();
			}
		}
	}
}
