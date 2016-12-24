using System;
using System.Data;
using System.Windows.Forms;
using DeliveryMarket.Account;
using DeliveryMarket.Data.MarketContract;
using DeliveryMarket.Utils;
using DeliveryMarket.Utils.Defs;

namespace DeliveryMarket.Registeration {

	public partial class FormLogin : Form {
		// Messages
		private const string LOGIN_FAILED_MSG = "Please check your username and password";
		private const string BANNED_ACCOUNT_MSG = "Your account has been banned";

		// Member variables
		private RegisterController mController;

		/* Constructor */
		public FormLogin() {
			InitializeComponent();

			mController = new RegisterController();
		}

		/* Form load callback function */
		private void FormLogin_Load(object sender, EventArgs e) {

		}

		/* Login button clicked callback function */
		private void buttonLogin_Click(object sender, EventArgs e) {
			string username = textBoxUsername.Text;
			string password = Utility.HashPassword(textBoxPassword.Text);

			DataRow row = mController.SelectAccountPrivilege(username, password);

			if (row == null) {
				MessageBox.Show(LOGIN_FAILED_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Get account basic details
			int accountID = Convert.ToInt32(row[AccountEntry.COL_ACCOUNT_ID]);
			username = row[AccountEntry.COL_USERNAME].ToString();
			Privilege privilege = Privilege.Other;
			string type = row[AccountEntry.COL_ACCOUNT_TYPE].ToString();

			switch (type) {
				case AccountType.ACTIVE:
					privilege = Privilege.User;
					break;
				case AccountType.ADMIN:
					privilege = Privilege.Admin;
					break;
				case AccountType.BANNED:
					privilege = Privilege.Banned;
					break;
			}

			// Account is banned
			if (privilege == Privilege.Banned) {
				DataRow ban = mController.SelectBanDetails(accountID);
				string msg = BANNED_ACCOUNT_MSG;

				if (ban != null) {
					msg += " on " + Convert.ToDateTime(ban[BannedUserEntry.COL_BAN_DATE]).ToString("dd/MM/yyyy") + "\n";
					msg += "Reason: " + ban[BannedUserEntry.COL_BAN_REASON].ToString() + "\n";
					msg += "Description: " + ban[BannedUserEntry.COL_DESCRIPTION].ToString();
				}

				MessageBox.Show(msg, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			textBoxPassword.Text = "";

			new FormMain(privilege, accountID, username).Show(this);
			Hide();
		}

		/* Register button clicked callback function */
		private void buttonRegister_Click(object sender, EventArgs e) {
			new FormRegister().Show(this);
			Hide();
		}

		/* Loses buttons focus */
		private void LoseFocus(object sender, EventArgs e) {
			labelUsername.Focus();
		}
	}
}