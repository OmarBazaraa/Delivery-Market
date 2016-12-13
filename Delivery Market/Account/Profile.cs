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
	public partial class Profile : Form {
		private const string CONFIRMATION_TITLE = "Make Admin";
		private const string CONFIRMATION_MSG = "Are you sure want to make this account admin?";
		int mUserID;
		int mAccountID;
		AccountController mController;
		DataRow mData;
		Privilege mPrivilege;
		public Profile(int accountID, int userID, Privilege privilege = Privilege.Other) {
			InitializeComponent();
			mUserID = userID;
			mAccountID = accountID;
			mController = new AccountController();
			mData = null;
			mPrivilege = privilege;
		}

		private void Profile_Load(object sender, EventArgs e) {
			mData = mController.SelectAccount(mUserID.ToString());
			populate();
		}

		private void buttonBan_Click(object sender, EventArgs e) {
			new FormBanUser(mAccountID,mUserID).Show();
		}

		private void buttonViewProducts_Click(object sender, EventArgs e) {
			new FormProductList(mUserID, mPrivilege);
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
			textRating.Text = mData[UserEntry.DER_RATING].ToString();
			textProductsCount.Text = mData[UserEntry.DER_PRODUCTS_COUNT].ToString();
			textOrdersCount.Text = mData[UserEntry.DER_ORDERS_COUNT].ToString();
			textMoneyEarned.Text = mData[UserEntry.DER_EARNED_MONEY].ToString() + "$";
			textMoneyPaid.Text = mData[UserEntry.DER_PAID_MONEY].ToString() + "$";
		}

		private void buttonMakeAdmin_Click(object sender, EventArgs e) {
			if (MessageBox.Show(CONFIRMATION_MSG, CONFIRMATION_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
				return;
			}
			Admin admin = new Admin();
			admin.AdminID = mUserID.ToString();
			mController.MakeAdmin(admin);		
		}

		private void buttonEditAccount_Click(object sender, EventArgs e) {

		}
	}
}
