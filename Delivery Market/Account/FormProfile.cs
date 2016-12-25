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
using DeliveryMarket.Orders;
using DeliveryMarket.Product;
using DeliveryMarket.Utils.Defs;

namespace DeliveryMarket.Account {

	public partial class FormProfile : Form {

		private const string CONFIRMATION_TITLE = "Make Admin";
		private const string CONFIRMATION_MSG = "Are you sure want to make this account admin?";

		int mUserID;
		int mAccountID;
		AccountController mController;
		DataRow mData;
		Privilege mPrivilege;

		public FormProfile(int accountID, int userID, Privilege privilege = Privilege.Other) {
			InitializeComponent();
			mUserID = userID;
			mAccountID = accountID;
			mController = new AccountController();
			mData = mController.SelectAccount(mUserID.ToString());
			mPrivilege = privilege;
		}

		private void Profile_Load(object sender, EventArgs e) {
			if (mPrivilege != Privilege.Admin) {
				buttonBan.Hide();
				buttonMakeAdmin.Hide();
			}
			if (mAccountID != mUserID) {
				buttonViewOrders.Hide();
				buttonEditAccount.Hide();
			}
			populate();
		}

		private void buttonBan_Click(object sender, EventArgs e) {
			new FormBanUser(mAccountID, mUserID).Show();
		}

		private void buttonViewProducts_Click(object sender, EventArgs e) {
			new FormProductList(mPrivilege, mAccountID, mUserID).Show(this);
		}

		private void buttonViewOrders_Click(object sender, EventArgs e) {
			new FormOrders(mUserID).Show(this);
		}

		private void populate() {
			if (mData == null) return;
			textUserName.Text = mData[AccountEntry.COL_USERNAME].ToString();
			textFirstName.Text = mData[AccountEntry.COL_FIRST_NAME].ToString();
			textLastName.Text = mData[AccountEntry.COL_LAST_NAME].ToString();
			textCountry.Text = mData[AccountEntry.COL_COUNTRY].ToString();
			textCity.Text = mData[AccountEntry.COL_CITY].ToString();
			textMobileNumber.Text = mData[AccountEntry.COL_MOBILE_NUMBER].ToString();
			textCreationDate.Text = mData[AccountEntry.COL_CREATION_DATE].ToString();
			textGender.Text = mData[AccountEntry.COL_GENDER].ToString();
			textBirthDate.Text = mData[AccountEntry.COL_BIRTHDATE].ToString();
			textRating.Text = mData[AccountEntry.DER_RATING].ToString();
			textProductsCount.Text = mData[AccountEntry.DER_PRODUCTS_COUNT].ToString();
			textOrdersCount.Text = mData[AccountEntry.DER_ORDERS_COUNT].ToString();
			textMoneyEarned.Text = mData[AccountEntry.DER_EARNED_MONEY].ToString() + "$";
			textMoneyPaid.Text = mData[AccountEntry.DER_PAID_MONEY].ToString() + "$";
			if (textGender.Text == "M") textGender.Text += "ale";
			if (textGender.Text == "F") textGender.Text += "emale";
		}

		private void buttonMakeAdmin_Click(object sender, EventArgs e) {
			if (MessageBox.Show(CONFIRMATION_MSG, CONFIRMATION_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
				return;
			}

			mController.MakeAdmin(mUserID);
		}

		private void buttonEditAccount_Click(object sender, EventArgs e) {
			new Registeration.FormRegister(mUserID).ShowDialog(this);
		}
	}
}