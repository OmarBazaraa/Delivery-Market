using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryMarket.Data.MarketContract;
using System.Windows.Forms;
using System.Data;
using DeliveryMarket.Data;

namespace DeliveryMarket.Account {

	/*
	 * A class that controls account interaction with database
	 */
	class AccountController : Controller {

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
				+ " WHERE " + AccountEntry.COL_ACCOUNT_TYPE + " != '" + AccountType.BANNED
				+ "' AND " + AccountEntry.COL_USERNAME + " LIKE '" + name + "%' ;";

			/*
				SELECT				account.account_id, account.username, COALESCE(AVG(rating.rating_value), 0) AS seller_rating, COALESCE(temp.cnt, 0) AS products_count
				FROM				account LEFT OUTER JOIN (product LEFT OUTER JOIN rating ON product.product_id=rating.product_id) ON account.account_id=product.seller_id
									LEFT OUTER JOIN
									(SELECT		account.account_id, COUNT(*) AS cnt
									FROM		account, product
									WHERE		account.account_id=product.seller_id AND product.deleted=0
									GROUP BY	account.account_id) AS temp
				                    ON account.account_id = temp.account_id
				WHERE				account.account_type!='Banned' AND (product.deleted IS NULL OR product.deleted=0)
				GROUP BY			account.account_id
			 */

			return DBMan.ExecuteReader(query);
		}

		/* Selects user account */
		public DataRow SelectAccount(string accountID) {
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
				" WHERE a." + AccountEntry.COL_ACCOUNT_ID + " = " + accountID + " AND "
				+ "d." + OrderEntry.COL_CUSTOMER_ID + " = " + accountID + " AND "
				+ "p." + ProductEntry.COL_SELLER_ID + " = " + accountID + " AND "
				+ "p." + ProductEntry.COL_PRODUCT_ID + " = o." + OrderEntry.COL_PRODUCT_ID + " AND "
				+ "p." + ProductEntry.COL_PRODUCT_ID + " = r." + RatingEntry.COL_PRODUCT_ID + " AND "
				+ "p." + ProductEntry.COL_DELETED + " = '0' ;";
			DataTable dt = DBMan.ExecuteReader(query);
			return dt == null ? null : dt.Rows[0];
		}

		/* Selects all removal reasons from the database */
		public DataTable SelectRemovalReasons() {
			string query = "SELECT " + BanReasonsEntry.COL_REASON + " FROM " + BanReasonsEntry.TABLE_NAME + ";";
			return DBMan.ExecuteReader(query);
		}

		/* Inserts account to banned users table */
		public int BanUser(int userID, int adminID, string reason, string description) {
			string query = "UPDATE " + AccountEntry.TABLE_NAME +
				" SET " + AccountEntry.COL_ACCOUNT_TYPE + "='" + AccountType.BANNED + "'" +
				" WHERE " + AccountEntry.COL_ACCOUNT_ID + "=" + userID.ToString() + ";";

			// If an error occured while updating the account type then no need to continue
			if (DBMan.ExecuteNonQuery(query) <= 0) {
				return -1;
			}

			query = "DELETE FROM " + AdminEntry.TABLE_NAME + " WHERE " + AdminEntry.COL_ACCOUNT_ID + "=" + userID.ToString() + ";";
			DBMan.ExecuteNonQuery(query);

			query = "INSERT INTO " + BannedUserEntry.TABLE_NAME + " (" +
				BannedUserEntry.COL_USER_ID + ", " +
				BannedUserEntry.COL_ADMIN_ID + ", " +
				BannedUserEntry.COL_BAN_REASON + ", " +
				BannedUserEntry.COL_DESCRIPTION + ") VALUES(" +
				userID.ToString() + ", " +
				adminID.ToString() + ", " +
				"'" + reason + "', " +
				"'" + description + "'" +
				");";

			return DBMan.ExecuteNonQuery(query);
		}

		/* Inserts account to admin table */
		public int MakeAdmin(int accountID) {
			string query = "UPDATE " + AccountEntry.TABLE_NAME +
				" SET " + AccountEntry.COL_ACCOUNT_TYPE + "='" + AccountType.ADMIN + "'" +
				" WHERE " + AccountEntry.COL_ACCOUNT_ID + "=" + accountID + ";";

			// If an error occured while updating the account type then no need to continue
			if (DBMan.ExecuteNonQuery(query) <= 0) {
				return -1;
			}

			query = "DELETE FROM " + BannedUserEntry.TABLE_NAME + " WHERE " + BannedUserEntry.COL_USER_ID + "=" + accountID + ";";
			DBMan.ExecuteNonQuery(query);

			query = "INSERT INTO " + AdminEntry.TABLE_NAME + " (" +
				AdminEntry.COL_ACCOUNT_ID + ") VALUES(" +
				accountID +
				");";

			return DBMan.ExecuteNonQuery(query);
		}
	}
}