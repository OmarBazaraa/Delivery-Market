using System.Data;
using DeliveryMarket.Account;
using DeliveryMarket.Data;
using DeliveryMarket.Data.MarketContract;

namespace DeliveryMarket.Registeration {

	/*
     * A class that controls account registeration with database
     */
	class RegisterController : Controller {

		/* Selects account information by its ID, to be used in editing account form */
		public DataRow SelectAccountInfo(int accountID) {
			string query = "SELECT " +
				AccountEntry.COL_USERNAME + ", " +
				AccountEntry.COL_PASSWORD + ", " +
				AccountEntry.COL_FIRST_NAME + ", " +
				AccountEntry.COL_LAST_NAME + ", " +
				AccountEntry.COL_COUNTRY + ", " +
				AccountEntry.COL_CITY + ", " +
				AccountEntry.COL_BIRTHDATE + ", " +
				AccountEntry.COL_GENDER + ", " +
				AccountEntry.COL_MOBILE_NUMBER +
				" FROM " + AccountEntry.TABLE_NAME +
				" WHERE " + AccountEntry.COL_ACCOUNT_ID + "=" + accountID.ToString() + ";";

			DataTable dt = DBMan.ExecuteReader(query);
			return (dt == null) ? null : dt.Rows[0];
		}

		/* Selects the id, username and the type of the given account */
		public DataRow SelectAccountPrivilege(string username, string password) {
			string query = "SELECT " +
				AccountEntry.COL_ACCOUNT_ID + ", " +
				AccountEntry.COL_USERNAME + ", " +
				AccountEntry.COL_ACCOUNT_TYPE +
				" FROM " + AccountEntry.TABLE_NAME +
				" WHERE " + AccountEntry.COL_USERNAME + "='" + username + "'" +
				" AND " + AccountEntry.COL_PASSWORD + "='" + password + "';";

			DataTable dt = DBMan.ExecuteReader(query);
			return (dt == null) ? null : dt.Rows[0];
		}

		/* Selects the banning details of the given user */
		public DataRow SelectBanDetails(int userID) {
			string query = "SELECT " +
				BannedUserEntry.COL_BAN_REASON + ", " +
				BannedUserEntry.COL_DESCRIPTION + ", " +
				BannedUserEntry.COL_BAN_DATE +
				" FROM " + BannedUserEntry.TABLE_NAME +
				" WHERE " + BannedUserEntry.COL_USER_ID + "=" + userID.ToString() + ";";

			DataTable dt = DBMan.ExecuteReader(query);
			return (dt == null) ? null : dt.Rows[0];
		}

		/* Returns whether the given username is used or not */
		public bool IsUsedUsername(string username) {
			string query = "SELECT " + AccountEntry.COL_ACCOUNT_ID +
				" FROM " + AccountEntry.TABLE_NAME +
				" WHERE " + AccountEntry.COL_USERNAME + "='" + username + "';";

			return (DBMan.ExecuteReader(query) == null ? false : true);
		}

		/* Inserts a new account into the database */
		public int InsertAccount(User account) {
			string query = "INSERT INTO " + AccountEntry.TABLE_NAME + " (" +
				AccountEntry.COL_USERNAME + ", " +
				AccountEntry.COL_PASSWORD + ", " +
				AccountEntry.COL_FIRST_NAME + ", " +
				AccountEntry.COL_LAST_NAME + ", " +
				AccountEntry.COL_BIRTHDATE + ", " +
				AccountEntry.COL_GENDER + ", " +
				AccountEntry.COL_MOBILE_NUMBER + ", " +
				AccountEntry.COL_COUNTRY + ", " +
				AccountEntry.COL_CITY +
				") VALUES (" +
				"'" + account.Username + "', " +
				"'" + account.Password + "', " +
				"'" + account.FirstName + "', " +
				"'" + account.LastName + "', " +
				"'" + account.Birthdate + "', " +
				"'" + account.Gender + "', " +
				"'" + account.MobileNumber + "', " +
				"'" + account.Country + "', " +
				"'" + account.City + "' " +
				");";

			return DBMan.ExecuteNonQuery(query);
		}

		/* Updates the details of a given account */
		public int UpdateAccount(User account) {
			string query = "UPDATE " + AccountEntry.TABLE_NAME + " SET " +
				AccountEntry.COL_USERNAME + "=" +
				"'" + account.Username + "', " +
				AccountEntry.COL_PASSWORD + "=" +
				"'" + account.Password + "', " +
				AccountEntry.COL_FIRST_NAME + "=" +
				"'" + account.FirstName + "', " +
				AccountEntry.COL_LAST_NAME + "=" +
				"'" + account.LastName + "', " +
				AccountEntry.COL_BIRTHDATE + "=" +
				"'" + account.Birthdate + "', " +
				AccountEntry.COL_GENDER + "=" +
				"'" + account.Gender + "', " +
				AccountEntry.COL_MOBILE_NUMBER + "=" +
				"'" + account.MobileNumber + "', " +
				AccountEntry.COL_COUNTRY + "=" +
				"'" + account.Country + "', " +
				AccountEntry.COL_CITY + "=" +
				"'" + account.City + "'" +
				"WHERE " + AccountEntry.COL_ACCOUNT_ID + "=" + account.AccountID + ";";

			return DBMan.ExecuteNonQuery(query);
		}
	}
}