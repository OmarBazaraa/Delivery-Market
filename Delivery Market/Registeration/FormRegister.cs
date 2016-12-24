using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeliveryMarket.Account;
using DeliveryMarket.Data.MarketContract;
using DeliveryMarket.Utils;
using DeliveryMarket.Utils.Defs;

namespace DeliveryMarket.Registeration {

	public partial class FormRegister : Form {
		// Messages
		private const string MALE_LABEL = "Male";
		private const string FEMALE_LABEL = "Female";
		private const string REGISTER_LABEL = "Register";
		private const string SAVE_LABEL = "Save";
		private const string OLD_PASSWORD_LABEL = "Old Password:";
		private const string NEW_PASSWORD_LABEL = "New Password:";
		private const string LOADING_ACCOUNT_FAILED_MSG = "An error occured while loading your account information";
		private const string INVALID_USERNAME_MSG = "Invalid username\nOnly letters, digits, underscores and dashes are allowed for usernames";
		private const string EMPTY_USERNAME_MSG = "Username is missing";
		private const string USED_USERNAME_MSG = "The username you have choosed is already used";
		private const string INVALID_PASSWORD_MSG = "Invalid password\nPlease make sure to repeat the password correctly";
		private const string WRONG_PASSWORD_MSG = "Wrong password\nPlease make sure to write your password correctly";
		private const string INVALID_FIRSTNAME_MSG = "Invalid first name\nOnly letters are allowed for names";
		private const string EMPTY_FIRSTNAME_MSG = "First is missing";
		private const string INVALID_LASTNAME_MSG = "Invalid last name\nOnly letters are allowed for names";
		private const string EMPTY_LASTNAME_MSG = "Last is missing";
		private const string INVALID_COUNTRY_MSG = "Invalid country name\nOnly letters are allowed for names";
		private const string INVALID_CITY_MSG = "Invalid city name\nOnly letters are allowed for names";
		private const string INVALID_MOBILE_NUMBER_MSG = "Invalid mobile number\nOnly numbers are allowed";
		private const string INSERTION_SUCCESS_MSG = "Your account was registered successfully";
		private const string INSERTION_FAILED_MSG = "An error occured while registering your account";
		private const string UPDATE_SUCCESS_MSG = "Your account was updated successfully";
		private const string UPDATE_FAILED_MSG = "An error occured while updating your account";
		private const string CONFIRMATION_MSG = "Are you sure want to save this account?";

		// Member variables
		private int mAccountID;
		private string mOldPassword = "";
		private RegisterController mController;

		/* Constructor */
		public FormRegister(int accountID = -1) {
			InitializeComponent();

			mAccountID = accountID;
			mController = new RegisterController();
		}

		/* Form load callback function */
		private void FormRegister_Load(object sender, EventArgs e) {
			// Fill in gender options
			comboBoxGender.SelectedItem = comboBoxGender.Items[0];

			// Load account details if given
			if (mAccountID > -1) {
				DataRow account = mController.SelectAccountInfo(mAccountID);

				if (account == null) {
					MessageBox.Show(LOADING_ACCOUNT_FAILED_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
					Close();
					return;
				}

				labelPassword.Text = OLD_PASSWORD_LABEL;
				labelRepeatPassword.Text = NEW_PASSWORD_LABEL;
				buttonRegister.Text = SAVE_LABEL;

				mOldPassword = account[AccountEntry.COL_PASSWORD].ToString();

				textBoxUsername.Text = account[AccountEntry.COL_USERNAME].ToString();
				textBoxFirstName.Text = account[AccountEntry.COL_FIRST_NAME].ToString();
				textBoxLastName.Text = account[AccountEntry.COL_LAST_NAME].ToString();
				textBoxCountry.Text = account[AccountEntry.COL_COUNTRY].ToString();
				textBoxCity.Text = account[AccountEntry.COL_CITY].ToString();
				dateTimePickerBirthdate.Value = Convert.ToDateTime(account[AccountEntry.COL_BIRTHDATE]);
				comboBoxGender.Text = account[AccountEntry.COL_GENDER].ToString() == "M" ? MALE_LABEL : FEMALE_LABEL;
				textBoxMobileNumber.Text = account[AccountEntry.COL_MOBILE_NUMBER].ToString();
			}
		}

		/* Form closed callback function */
		private void FormRegister_FormClosed(object sender, FormClosedEventArgs e) {
			if (e.CloseReason == CloseReason.UserClosing) {
				Owner.Show();
			}
		}

		/* Register button clicked callback function */
		private void buttonRegister_Click(object sender, EventArgs e) {
			// Check for input validity
			if (!ValidateInput()) {
				return;
			}

			// Ask for confirmation
			if (MessageBox.Show(CONFIRMATION_MSG, Strings.APP_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
				return;
			}
			
			User user = new User();
			user.AccountID = mAccountID.ToString();
			user.Username = textBoxUsername.Text;
			user.Password = Utility.HashPassword(textBoxRepeatPassword.Text);
			user.FirstName = textBoxFirstName.Text;
			user.LastName = textBoxLastName.Text;
			user.Birthdate = dateTimePickerBirthdate.Value.ToString("yyyy/MM/dd");
			user.Gender = comboBoxGender.Text == MALE_LABEL ? "M" : "F";
			user.MobileNumber = textBoxMobileNumber.Text;
			user.Country = textBoxCountry.Text;
			user.City = textBoxCity.Text;

			// Save account
			if (mAccountID == -1) {
				// Insert
				if (mController.InsertAccount(user) > 0) {
					MessageBox.Show(INSERTION_SUCCESS_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
					Close();
				}
				else {
					MessageBox.Show(INSERTION_FAILED_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else {
				// Update
				if (mController.UpdateAccount(user) > 0) {
					MessageBox.Show(UPDATE_SUCCESS_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
					Close();
				}
				else {
					MessageBox.Show(UPDATE_FAILED_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		/* Cancel button clicked callback function */
		private void buttonCancel_Click(object sender, EventArgs e) {
			Close();
		}

		/* Loses buttons focus */
		private void LoseFocus(object sender, EventArgs e) {
			labelUsername.Focus();
		}

		/* Checks if user inputs are valid or not */
		private bool ValidateInput() {
			// Check password
			if (mAccountID == -1) {
				if (textBoxPassword.Text != textBoxRepeatPassword.Text) {
					MessageBox.Show(INVALID_PASSWORD_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return false;
				}
			}
			else {
				if (mOldPassword != Utility.HashPassword(textBoxPassword.Text)) {
					MessageBox.Show(WRONG_PASSWORD_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return false;
				}
			}

			// Check username
			textBoxUsername.Text = textBoxUsername.Text.Trim();
			if (!Utility.IsUsernameValidString(textBoxUsername.Text)) {
				MessageBox.Show(INVALID_USERNAME_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (textBoxUsername.Text == "") {
				MessageBox.Show(EMPTY_USERNAME_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (mController.IsUsedUsername(textBoxUsername.Text)) {
				MessageBox.Show(USED_USERNAME_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			// Check first name
			textBoxFirstName.Text = textBoxFirstName.Text.Trim();
			if (!Utility.IsLettersString(textBoxFirstName.Text)) {
				MessageBox.Show(INVALID_FIRSTNAME_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (textBoxFirstName.Text == "") {
				MessageBox.Show(EMPTY_FIRSTNAME_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			// Check last name
			textBoxLastName.Text = textBoxLastName.Text.Trim();
			if (!Utility.IsLettersString(textBoxLastName.Text)) {
				MessageBox.Show(INVALID_LASTNAME_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (textBoxLastName.Text == "") {
				MessageBox.Show(EMPTY_LASTNAME_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			// Check country name
			textBoxCountry.Text = textBoxCountry.Text.Trim();
			if (!Utility.IsLettersString(textBoxCountry.Text)) {
				MessageBox.Show(INVALID_COUNTRY_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			// Check city name
			textBoxCity.Text = textBoxCity.Text.Trim();
			if (!Utility.IsLettersString(textBoxCity.Text)) {
				MessageBox.Show(INVALID_CITY_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			// Check mobile number
			textBoxMobileNumber.Text = textBoxMobileNumber.Text.Trim();
			if (!Utility.IsNumericString(textBoxMobileNumber.Text)) {
				MessageBox.Show(INVALID_MOBILE_NUMBER_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			return true;
		}
	}
}