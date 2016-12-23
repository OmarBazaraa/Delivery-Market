using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryMarket.Data.MarketContract;
using System.Windows.Forms;
using System.Data;
using DeliveryMarket.Data;

namespace DeliveryMarket.Account
{
	/*
     * A class that controls account interaction with database
     */
	class AccountController : Controller
	{
		/* Selects all accounts */
		public DataTable SelectAllAccounts(string name) {
			string query = "SELECT " + AccountEntry.COL_ACCOUNT_ID + ", " + AccountEntry.COL_USERNAME + ", " + "COALESCE(AVG(" + RatingEntry.TABLE_NAME + "."
				+ RatingEntry.COL_RATING_VALUE + "), 0) AS " + UserEntry.DER_RATING
				+ " , COALESCE(COUNT(" + ProductEntry.TABLE_NAME + "." + ProductEntry.COL_PRODUCT_ID + "), 0) AS " + UserEntry.DER_PRODUCTS_COUNT
				+ " FROM " + AccountEntry.TABLE_NAME + " LEFT OUTER JOIN "
				+ RatingEntry.TABLE_NAME + " " + RatingEntry.TABLE_NAME + " INNER JOIN " + ProductEntry.TABLE_NAME + " " + ProductEntry.TABLE_NAME
				+ " ON " + ProductEntry.TABLE_NAME + "." + ProductEntry.COL_PRODUCT_ID + " = " + RatingEntry.TABLE_NAME + "." + RatingEntry.COL_PRODUCT_ID
				+ " AND " + ProductEntry.COL_DELETED + " = '0'"
				+ " ON " + AccountEntry.COL_ACCOUNT_ID + " = " + ProductEntry.TABLE_NAME + "." + ProductEntry.COL_SELLER_ID
				+ " WHERE " + AccountEntry.COL_ACCOUNT_TYPE + " != '" + AccountType.Banned_Account
				+ "' AND " + AccountEntry.COL_USERNAME + " LIKE '" + name + "%' ;";
			return DBMan.ExecuteReader(query);
		}

		/* Select user account */
		public DataRow SelectAccount(string account_id) {
			string query = "SELECT a.*, " + "COALESCE(AVG(r."
				+ RatingEntry.COL_RATING_VALUE + "), 0) AS " + UserEntry.DER_RATING
				+ " , COALESCE(COUNT(p." + ProductEntry.COL_PRODUCT_ID + "), 0) AS " + UserEntry.DER_PRODUCTS_COUNT
				+ " , COALESCE(COUNT(o." + OrderEntry.COL_ORDER_ID + "), 0) AS " + UserEntry.DER_ORDERS_COUNT
				+ " , COALESCE(SUM(o." + OrderEntry.COL_PRODUCT_PRICE + " * o." + OrderEntry.COL_QUANTITY + "), 0) AS " + UserEntry.DER_EARNED_MONEY
				+ " , COALESCE(SUM(d." + OrderEntry.COL_PRODUCT_PRICE + " * d." + OrderEntry.COL_QUANTITY + "), 0) AS " + UserEntry.DER_PAID_MONEY
				+ " FROM " + AccountEntry.TABLE_NAME + " a, "
				+ RatingEntry.TABLE_NAME + " r, "
				+ ProductEntry.TABLE_NAME + " p, "
				+ MarketEntry.DATABASE_NAME + "." 
				+ OrderEntry.TABLE_NAME + " o, "
				+ MarketEntry.DATABASE_NAME + "."
				+ OrderEntry.TABLE_NAME + " d" +
				" WHERE a." + AccountEntry.COL_ACCOUNT_ID + " = " + account_id + " AND "
				+ "d." + OrderEntry.COL_CUSTOMER_ID + " = " + account_id + " AND "
				+ "p." + ProductEntry.COL_SELLER_ID + " = " + account_id + " AND "
				+ "p." + ProductEntry.COL_PRODUCT_ID + " = o." + OrderEntry.COL_PRODUCT_ID + " AND "
				+ "p." + ProductEntry.COL_PRODUCT_ID + " = r." + RatingEntry.COL_PRODUCT_ID + " AND "
				+ "p." + ProductEntry.COL_DELETED + " = '0' ;";
			DataTable dt = DBMan.ExecuteReader(query);
			return dt == null ? null : dt.Rows[0];
		}

		/* Insert  account to banned table */
		public int BanUser (BannedUser banned) {

			string query = "UPDATE " + AccountEntry.TABLE_NAME + 
				" SET " + AccountEntry.COL_ACCOUNT_TYPE + " = '" + AccountType.Banned_Account + 
				"' WHERE " + AccountEntry.COL_ACCOUNT_ID + " = " + banned.UserID + " ;";
			DBMan.ExecuteNonQuery(query);


			query = "DELETE FROM " + AdminEntry.TABLE_NAME + " WHERE " + AdminEntry.COL_ACCOUNT_ID + " = " + banned.UserID + " ;";
			DBMan.ExecuteNonQuery(query);


			query = "INSERT INTO " + BannedUserEntry.TABLE_NAME + " (" +
				BannedUserEntry.COL_ADMIN_ID + ", " +
				BannedUserEntry.COL_USER_ID + ", " +
				BannedUserEntry.COL_BAN_REASON + ", " +
				BannedUserEntry.COL_DESCRIPTION + ", " +
				BannedUserEntry.COL_BAN_DATE + ") VALUES(" +
				banned.AdminID + ", " +
				"'" + banned.UserID + "', '" +
				banned.Reason + "', " +
				"'" + banned.Description + "', " +
				"'" + banned.Date + "'" +
				");";
			return DBMan.ExecuteNonQuery(query);
		}

		/* Insert account to admin table */
		public int MakeAdmin(Admin admin) {

			string query = "UPDATE " + AccountEntry.TABLE_NAME +
				" SET " + AccountEntry.COL_ACCOUNT_TYPE + " = '" + AccountType.Admin_Account +
				"' WHERE " + AccountEntry.COL_ACCOUNT_ID + " = " + admin.AdminID + " ;";
			DBMan.ExecuteNonQuery(query);

			query = "DELETE FROM " + BannedUserEntry.TABLE_NAME + " WHERE " + BannedUserEntry.COL_USER_ID + " = " + admin.AdminID + " ;";
			DBMan.ExecuteNonQuery(query);


			query = "INSERT INTO " + AdminEntry.TABLE_NAME + " (" +
				AdminEntry.COL_ACCOUNT_ID + ", " +
				AdminEntry.COL_START_DATE + ") VALUES(" +
				admin.AdminID + ", '" + admin.StartDate + "');";
			return DBMan.ExecuteNonQuery(query);
		}

		/* Selects all removal reasons from the database */
		public DataTable SelectRemovalReasons() {
			string query = "SELECT " + BanReasonsEntry.COL_REASON + " FROM " + BanReasonsEntry.TABLE_NAME + ";";
			return DBMan.ExecuteReader(query);
		}
	}
}
