using System;
using System.Windows.Forms;
using DeliveryMarket.Data.MarketContract;
using DeliveryMarket.Utils.Defs;

namespace DeliveryMarket.Account {

	public partial class FormBanUser : Form {
		// Messages
		private const string INVALID_INPUT_MSG = "Please make sure to write the description";
		private const string BAN_SUCCESS_MSG = "This account was banned successfully";
		private const string BAN_FAILED_MSG = "An error occured while banning this account";
		private const string CONFIRMATION_MSG = "Are you sure want to ban this account?";

		// Member variables
		int mAccountID;
		int mUserID;
		AccountController mController;

		/* Constructor */
		public FormBanUser(int adminID, int userID) {
			InitializeComponent();

			mAccountID = adminID;
			mUserID = userID;
			mController = new AccountController();
		}

		/* Form load callback function */
		private void FormBanUser_Load(object sender, EventArgs e) {
			comboBoxReasons.DataSource = mController.SelectRemovalReasons();
			comboBoxReasons.DisplayMember = BanReasonsEntry.COL_REASON;
		}

		/* Ban button clicked callback function */
		private void buttonBan_Click(object sender, EventArgs e) {
			string description = textBoxDescription.Text.Replace("'", "''").Trim();

			// Check for validation
			if (description == "") {
				MessageBox.Show(INVALID_INPUT_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Ask for confirmation
			if (MessageBox.Show(CONFIRMATION_MSG, Strings.APP_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
				return;
			}

			// Ban account
			if (mController.BanUser(mUserID, mAccountID, comboBoxReasons.Text, description) > 0) {
				MessageBox.Show(BAN_SUCCESS_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
				Close();
			}
			else {
				MessageBox.Show(BAN_FAILED_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/* Cancel button clicked callback function */
		private void buttonCancel_Click(object sender, EventArgs e) {
			Close();
		}
	}
}