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
	public partial class FormViewAccounts : Form {
		private const string MAKE_ADMIN_FAILED = "Failed to make account as Admin";
		private const string BAN_ACCOUNT_FAILED = "Failed to ban the account";
		private const string MAKE_NORMAL_USER_FAILED = "Failed to make account as normal user";
		private const string EMPTY_FIELD_DESCRIPTION = "Please write the description of the ban.";
		private const int AccountIdIndex = 0;
		private const int QueryFailed = -1;

		AdminController mController;
		DataTable mUserList;
		int mAdminID;


		public FormViewAccounts(int AccountID) {
			InitializeComponent();
			mAdminID = AccountID;

			mController = new AdminController();
			PopulateListView();
			PopulateDetailView();
		}


		public void PopulateListView() {
			mUserList = mController.SelectUsers(textBoxSearch.Text.Replace("'", "''").Trim());
			listViewAccounts.Items.Clear();

			if (mUserList == null) return;

			foreach (DataRow row in mUserList.Rows) {
				ListViewItem item = new ListViewItem(row[AccountEntry.COL_ACCOUNT_ID].ToString());
				item.SubItems.Add(row[AccountEntry.COL_FIRST_NAME].ToString());
				item.SubItems.Add(row[AccountEntry.COL_USERNAME].ToString());
				item.SubItems.Add(row[AccountEntry.COL_ACCOUNT_TYPE].ToString());
				item.SubItems.Add(row[AccountEntry.COL_CREATION_DATE].ToString());

				listViewAccounts.Items.Add(item);
			}
		}

		public void PopulateDetailView(string AccountID = "") {
			buttonApply.Enabled = false;
			buttonCancel.Enabled = false;
			comboBoxType.Enabled = false;
			comboBoxType.DropDownStyle = ComboBoxStyle.DropDown;
			comboBoxReason.Enabled = false;
			textBoxDescription.Enabled = false;
			labelReason.Hide();
			labelDescription.Hide();
			labelStartDate.Hide();
			comboBoxReason.Hide();
			textBoxDescription.Hide();
			dateTimeStartDate.Hide();

			if (AccountID == "") return;

			DataTable retTable = mController.SelectAccountDetail(AccountID);
			if (retTable == null) return;

			DataRow accountDetails = retTable.Rows[0];

			string accountType = accountDetails[AccountEntry.COL_ACCOUNT_TYPE].ToString();
			switch (accountType) {
				case AccountType.BANNED:
					labelReason.Show();
					labelDescription.Show();
					comboBoxReason.Show();
					textBoxDescription.Show();
					break;
				case AccountType.ADMIN:
					labelStartDate.Show();
					dateTimeStartDate.Show();
					break;
				default:
					break;
			}
			if (accountType == AccountType.BANNED) {
					labelReason.Show();
					labelDescription.Show();
					comboBoxReason.Show();
				textBoxDescription.Show();
			}
			textBoxID.Text = accountDetails[AccountEntry.COL_ACCOUNT_ID].ToString();
			textBoxName.Text = accountDetails[AccountEntry.COL_FIRST_NAME].ToString() + ", " + accountDetails[AccountEntry.COL_LAST_NAME];
			textBoxUserName.Text = accountDetails[AccountEntry.COL_USERNAME].ToString();
			textBoxMobileNumber.Text = accountDetails[AccountEntry.COL_MOBILE_NUMBER].ToString();
			comboBoxGender.Text = accountDetails[AccountEntry.COL_GENDER].ToString();
			dateTimeBirthDate.Text = accountDetails[AccountEntry.COL_BIRTHDATE].ToString();
			dateTimeCreationDate.Text = accountDetails[AccountEntry.COL_CREATION_DATE].ToString();
			textBoxAddress.Text = accountDetails[AccountEntry.COL_CITY].ToString() + ", " + accountDetails[AccountEntry.COL_COUNTRY].ToString();
			comboBoxType.Text = accountDetails[AccountEntry.COL_ACCOUNT_TYPE].ToString();
			comboBoxReason.Text = accountDetails[BannedUserEntry.COL_BAN_REASON].ToString();
			textBoxDescription.Text = accountDetails[BannedUserEntry.COL_DESCRIPTION].ToString();
			dateTimeStartDate.Text = accountDetails[AdminEntry.COL_START_DATE].ToString();
		}


		private void listViewAccounts_SelectedIndexChanged(object sender, EventArgs e) {
			if (listViewAccounts.SelectedItems.Count == 0)
				return;

			ListViewItem item = listViewAccounts.SelectedItems[0];
			string id = item.SubItems[AccountIdIndex].Text;
			PopulateDetailView(id);
		}

		private void buttonSearch_Click(object sender, EventArgs e) {
			PopulateListView();
		}

		private void buttonEdit_Click(object sender, EventArgs e) {
			if (textBoxID.Text == "")
				return;

			buttonApply.Enabled = true;
			buttonCancel.Enabled = true;
			comboBoxType.Enabled = true;
			comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxReason.Enabled = true;
			textBoxDescription.Enabled = true;

			DataTable BanReasons = mController.SelectBanReasons();
			comboBoxReason.DataSource = BanReasons;
			comboBoxReason.DisplayMember = ProductRemovalReasonsEntry.COL_REASON;

			comboBoxType.Items.Clear();
			comboBoxType.Items.Add(AccountType.ACTIVE);
			comboBoxType.Items.Add(AccountType.ADMIN);
			comboBoxType.Items.Add(AccountType.BANNED);

			comboBoxType.Show();
			comboBoxType.Refresh();

			if (comboBoxType.Text == AccountType.BANNED) {
				labelDescription.Show();
				labelReason.Show();
				comboBoxReason.Show();
				comboBoxReason.Refresh();
				textBoxDescription.Show();
			}
		}

		private void buttonApply_Click(object sender, EventArgs e) {
			if (comboBoxType.Text == AccountType.BANNED && textBoxDescription.Text == "") {
				MessageBox.Show(EMPTY_FIELD_DESCRIPTION);
				return;
			}
			switch(comboBoxType.Text) {
				case AccountType.BANNED:
					if (mController.BanAccount(textBoxID.Text, mAdminID.ToString(), comboBoxReason.Text, textBoxDescription.Text.Replace("'", "''").Trim()) == QueryFailed) {
						MessageBox.Show(BAN_ACCOUNT_FAILED);
						return;
					}
					break;
				case AccountType.ADMIN:
					if (mController.MakeAdmin(textBoxID.Text) == QueryFailed) {
						MessageBox.Show(MAKE_ADMIN_FAILED);
						return;
					}
					break;
				default:
					if (mController.makeNormalUser(textBoxID.Text) == QueryFailed) {
						MessageBox.Show(MAKE_NORMAL_USER_FAILED);
						return;
					}
					break;
			}



			PopulateListView();
			PopulateDetailView(textBoxID.Text);
		}

		private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e) {
			labelReason.Hide();
			labelDescription.Hide();
			labelStartDate.Hide();
			comboBoxReason.Hide();
			textBoxDescription.Hide();
			dateTimeStartDate.Hide();

			switch (comboBoxType.Text) {
				case AccountType.BANNED:
					labelReason.Show();
					labelDescription.Show();
					comboBoxReason.Show();
					textBoxDescription.Show();
					break;
				case AccountType.ADMIN:
					labelStartDate.Show();
					dateTimeStartDate.Show();
					break;
				default:
					break;
			}
		}

		public void FormViewAccounts_FormClosed(object sender, FormClosedEventArgs e) {
			if (e.CloseReason == CloseReason.UserClosing) {
				Owner.Show();
				Owner.Refresh();
			}
		}

		private void buttonCancel_Click(object sender, EventArgs e) {
			PopulateDetailView(textBoxID.Text);
		}
	}
}
