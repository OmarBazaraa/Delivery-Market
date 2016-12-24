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
using DeliveryMarket.Data.MarketContract;
using DeliveryMarket.Product;

namespace DeliveryMarket.Account
{
    public partial class FormAccounts : Form
    {
		private AccountController mController;
		DataRow mData;
		Privilege mPrivilege;
		int mAccountID;
		string mUserID;
		UserList list;
		public FormAccounts(int accountID, Privilege privilege = Privilege.Other)
        {
            InitializeComponent();

			this.mAccountID = accountID;
			this.mPrivilege = privilege;
			mController = new AccountController();
			labelEmptyAccounts.Visible = true;
			showlabels(false);
			DataTable dt = mController.SelectAllAccounts("");
			if (dt == null) return;
			list = new UserList(dt);

			showlabels(true);
			labelEmptyAccounts.Visible = false;
			PopulateListView();

			if (list.ListItemsCount == 0) return;

			mUserID = list.AccountID[0];
			mData = mController.SelectAccount(mUserID);
		}

		private void PopulateListView() {
			ListViewItem[] l = new ListViewItem[list.ListItemsCount];
			for (int i = 0; i < list.ListItemsCount; ++i) {
				l[i] = new ListViewItem(list.UserName[i]);
				l[i].SubItems.Add(list.Rating[i]);
				l[i].SubItems.Add(list.ProductsCount[i]);
				listSellers.Items.Add(l[i]);
			}
		}

		private void listSellers_MouseDoubleClick(object sender, EventArgs e) {
			if (listSellers.Items.Count == 0) return;
			int idx = listSellers.SelectedItems[0].Index;
			new FormProfile(mAccountID, Convert.ToInt32(list.AccountID[idx]), mPrivilege).Show(this);
		}
		

		private void textBoxEmail_TextChanged(object sender, EventArgs e) {
			listSellers.Items.Clear();
			showlabels(false);
			labelEmptyAccounts.Visible = true;
			DataTable dt = mController.SelectAllAccounts(textBoxUsername.Text);
			if (dt == null) return;
			showlabels(true);
			labelEmptyAccounts.Visible = false;
			list = new UserList(dt);
			PopulateListView();
			if (list.ListItemsCount == 0) return;
			mUserID = list.AccountID[0];
			mData = mController.SelectAccount(mUserID);
		}

		private void showlabels(bool show) {
		labelLastName.Visible = show;
		labelGender.Visible = show;
		labelMobileNumber.Visible = show;
		labelFirstName.Visible = show;
		labelCreationDate.Visible = show;
		labelBirthDate.Visible = show;
		labelProductsCount.Visible = show;
		labelMoneyEarned.Visible = show;
		labelOrdersCount.Visible = show;
		labelMoneyPaid.Visible = show;
		textUserName.Visible = show;
		textFirstName.Visible = show;
		textLocation.Visible = show;
		textMobileNumber.Visible = show;
		textGender.Visible = show;
		textLastName.Visible = show;
		textCreationDate.Visible = show;
		textBirthDate.Visible = show;
		textProductsCount.Visible = show;
		textMoneyEarned.Visible = show;
		textOrdersCount.Visible = show;
		textMoneyPaid.Visible = show;
		textRating.Visible = show;
		groupBox1.Visible = show;
		groupBox2.Visible = show;
		label1.Visible = show;
	}

		private void listSellers_SelectedIndexChanged(object sender, EventArgs e) {
			if (listSellers.Items.Count == 0) {
				return;
			}
			if (listSellers.SelectedItems.Count == 0)
				return;
			int idx = listSellers.SelectedItems[0].Index;
			mUserID = list.AccountID[0];
			mData = mController.SelectAccount(mUserID);
			populate();
		}

		private void FormAccounts_Load(object sender, EventArgs e) {			
			populate();
		}

		private void populate() {
			if (mData == null) return;
			int rating = Convert.ToInt32(mData[UserEntry.DER_RATING].ToString());
			textUserName.Text = mData[AccountEntry.COL_USERNAME].ToString();
			textRating.Text = mData[UserEntry.DER_RATING].ToString();
			textFirstName.Text = mData[AccountEntry.COL_FIRST_NAME].ToString();
			textLastName.Text = mData[AccountEntry.COL_LAST_NAME].ToString();
			textLocation.Text = mData[AccountEntry.COL_COUNTRY].ToString() + ", " + mData[AccountEntry.COL_CITY].ToString();
			textMobileNumber.Text = "+2" + mData[AccountEntry.COL_MOBILE_NUMBER].ToString();
			textCreationDate.Text = mData[AccountEntry.COL_CREATION_DATE].ToString();
			textGender.Text = mData[AccountEntry.COL_GENDER].ToString();
			textBirthDate.Text = mData[AccountEntry.COL_BIRTHDATE].ToString();
			textProductsCount.Text = mData[UserEntry.DER_PRODUCTS_COUNT].ToString();
			textOrdersCount.Text = mData[UserEntry.DER_ORDERS_COUNT].ToString();
			textMoneyEarned.Text = mData[UserEntry.DER_EARNED_MONEY].ToString() + "$";
			textMoneyPaid.Text = mData[UserEntry.DER_PAID_MONEY].ToString() + "$";
		}

		private void buttonViewProducts_Click(object sender, EventArgs e) {
		}

		private void groupBox1_Enter(object sender, EventArgs e) {

		}

		private void textProductsCount_Click(object sender, EventArgs e) {
			new FormProductList(mPrivilege, mAccountID, Convert.ToInt32(mUserID)).Show(this);
		}

		private void textUserName_Click(object sender, EventArgs e) {
			new FormProfile(mAccountID, Convert.ToInt32(mUserID), mPrivilege).Show(this);
		}

		private void textGender_Click(object sender, EventArgs e) {

		}

		private void groupBox2_Enter(object sender, EventArgs e) {

		}
	}
}
