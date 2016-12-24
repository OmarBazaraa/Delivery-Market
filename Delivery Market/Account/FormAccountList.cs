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

namespace DeliveryMarket.Account {

	public partial class FormAccountList : Form {

		private int mAccountID;
		private string mUserID;
		private Privilege mPrivilege;
		private UserList mList;
		private DataRow mData;
		private AccountController mController;

		/* Constructor */
		public FormAccountList(int accountID, Privilege privilege = Privilege.Other) {
			InitializeComponent();

			mAccountID = accountID;
			mPrivilege = privilege;
			mController = new AccountController();
		}

		/* Form load callback function */
		private void FormAccounts_Load(object sender, EventArgs e) {
			labelEmptyAccounts.BringToFront();
			labelEmptyAccounts.Visible = true;

			DataTable dt = mController.SelectAllAccounts("");
			if (dt == null) return;
			mList = new UserList(dt);

			PopulateAccountList();

			if (mList.ListItemsCount == 0) return;

			mUserID = mList.AccountID[0];
			mData = mController.SelectAccount(mUserID);
			LoadAccountDetails();

			labelEmptyAccounts.Visible = false;
		}

		/* Accounts list item double clicked callback function */
		private void listSellers_MouseDoubleClick(object sender, EventArgs e) {
			if (listViewSellers.Items.Count == 0) {
				return;
			}

			int idx = listViewSellers.SelectedItems[0].Index;
			new FormProfile(mAccountID, Convert.ToInt32(mList.AccountID[idx]), mPrivilege).Show(this);
		}

		/* Search bar text changed callback function */
		private void textBoxSearch_TextChanged(object sender, EventArgs e) {
			listViewSellers.Items.Clear();

			labelEmptyAccounts.Visible = true;

			DataTable dt = mController.SelectAllAccounts(textBoxSearch.Text);
			if (dt == null) return;
			
			labelEmptyAccounts.Visible = false;
			mList = new UserList(dt);
			PopulateAccountList();
			if (mList.ListItemsCount == 0) return;
			mUserID = mList.AccountID[0];
			mData = mController.SelectAccount(mUserID);
		}

		/* Account list selected item changed callback function */
		private void listSellers_SelectedIndexChanged(object sender, EventArgs e) {
			if (listViewSellers.SelectedItems.Count == 0) {
				return;
			}

			int idx = listViewSellers.SelectedItems[0].Index;
			mUserID = mList.AccountID[0];
			mData = mController.SelectAccount(mUserID);
			LoadAccountDetails();
		}

		private void textProductsCount_Click(object sender, EventArgs e) {
			new FormProductList(mPrivilege, mAccountID, Convert.ToInt32(mUserID)).Show(this);
		}

		private void textUserName_Click(object sender, EventArgs e) {
			new FormProfile(mAccountID, Convert.ToInt32(mUserID), mPrivilege).Show(this);
		}

		/*  */
		private void PopulateAccountList() {
			ListViewItem[] l = new ListViewItem[mList.ListItemsCount];

			for (int i = 0; i < mList.ListItemsCount; ++i) {
				l[i] = new ListViewItem(mList.UserName[i]);
				l[i].SubItems.Add(mList.Rating[i]);
				l[i].SubItems.Add(mList.ProductsCount[i]);
				listViewSellers.Items.Add(l[i]);
			}
		}

		private void LoadAccountDetails() {
			if (mData == null) {
				return;
			}

			decimal rating = Convert.ToDecimal(mData[UserEntry.DER_RATING]);
			textUserName.Text = mData[AccountEntry.COL_USERNAME].ToString();
			textRating.Text = Math.Round(rating, 2).ToString();
			textFirstName.Text = mData[AccountEntry.COL_FIRST_NAME].ToString();
			textLastName.Text = mData[AccountEntry.COL_LAST_NAME].ToString();
			textLocation.Text = mData[AccountEntry.COL_COUNTRY].ToString() + ", " + mData[AccountEntry.COL_CITY].ToString();
			textMobileNumber.Text = mData[AccountEntry.COL_MOBILE_NUMBER].ToString();
			textCreationDate.Text = mData[AccountEntry.COL_CREATION_DATE].ToString();
			textGender.Text = mData[AccountEntry.COL_GENDER].ToString();
			textBirthDate.Text = mData[AccountEntry.COL_BIRTHDATE].ToString();
			textProductsCount.Text = mData[UserEntry.DER_PRODUCTS_COUNT].ToString();
			textOrdersCount.Text = mData[UserEntry.DER_ORDERS_COUNT].ToString();
			textMoneyEarned.Text = mData[UserEntry.DER_EARNED_MONEY].ToString() + "$";
			textMoneyPaid.Text = mData[UserEntry.DER_PAID_MONEY].ToString() + "$";
		}
	}
}