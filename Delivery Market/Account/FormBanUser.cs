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

namespace DeliveryMarket.Account {
	public partial class FormBanUser : Form {

		private const string INVALID_INPUT_TITLE = "Invalid Description";
		private const string INVALID_INPUT_MSG = "Please make sure to write the description";
		private const string DELETE_SUCCESS_TITLE = "Done";
		private const string DELETE_SUCCESS_MSG = "the user was banned successfully";
		private const string DELETE_FAILED_TITLE = "Error";
		private const string DELETE_FAILED_MSG = "An error occured will banning this user";
		private const string CONFIRMATION_TITLE = "Ban";
		private const string CONFIRMATION_MSG = "Are you sure want to ban this user?";
		int mAccountID;
		int mUserID;
		AccountController mController;

		public FormBanUser(int adminID, int userID) {
			InitializeComponent();
			mAccountID = adminID;
			mUserID = userID;
			mController = new AccountController();
		}

		private void FormBanUser_Load(object sender, EventArgs e) {
			// TODO: load list of reasons
			comboBoxReasons.DataSource = mController.SelectRemovalReasons();
			comboBoxReasons.DisplayMember = ProductRemovalReasonsEntry.COL_REASON;
		}

		private void buttonBan_Click(object sender, EventArgs e) {
			string description = textBoxDescription.Text.Replace("'", "''").Trim();

			// Check for validation
			if (description == "") {
				MessageBox.Show(INVALID_INPUT_MSG, INVALID_INPUT_TITLE, MessageBoxButtons.OK);
				return;
			}

			// Ask for confirmation
			if (MessageBox.Show(CONFIRMATION_MSG, CONFIRMATION_TITLE, MessageBoxButtons.YesNo) == DialogResult.No) {
				return;
			}

			BannedUser banned = new BannedUser();
			banned.UserID = mUserID.ToString();
			banned.AdminID = mAccountID.ToString();
			banned.Description = description;
			banned.Reason = comboBoxReasons.Text;

			// Delete product
			if (mController.BanUser(banned) > 0) {
				MessageBox.Show(DELETE_SUCCESS_MSG, DELETE_SUCCESS_TITLE, MessageBoxButtons.OK);
				Close();
			}
			else {
				MessageBox.Show(DELETE_FAILED_MSG, DELETE_FAILED_TITLE, MessageBoxButtons.OK);
			}
		}
	}
}
