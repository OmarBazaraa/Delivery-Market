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
			/* string query = "SELECT " + AccountEntry.COL_ACCOUNT_ID + ", " + AccountEntry.COL_USERNAME + ", " + "COALESCE(AVG(" + RatingEntry.TABLE_NAME + "."
				+ RatingEntry.COL_RATING_VALUE + "), 0) AS " + AccountEntry.DER_RATING
				+ " , COALESCE(COUNT(" + ProductEntry.TABLE_NAME + "." + ProductEntry.COL_PRODUCT_ID + "), 0) AS " + AccountEntry.DER_PRODUCTS_COUNT
				+ " FROM " + AccountEntry.TABLE_NAME + " LEFT OUTER JOIN "
				+ RatingEntry.TABLE_NAME + " " + RatingEntry.TABLE_NAME + " INNER JOIN " + ProductEntry.TABLE_NAME + " " + ProductEntry.TABLE_NAME
				+ " ON " + ProductEntry.TABLE_NAME + "." + ProductEntry.COL_PRODUCT_ID + " = " + RatingEntry.TABLE_NAME + "." + RatingEntry.COL_PRODUCT_ID
				+ " AND " + ProductEntry.COL_DELETED + " = '0'"
				+ " ON " + AccountEntry.COL_ACCOUNT_ID + " = " + ProductEntry.TABLE_NAME + "." + ProductEntry.COL_SELLER_ID
				+ " WHERE " + AccountEntry.COL_ACCOUNT_TYPE + " != '" + AccountType.BANNED
				+ "' AND " + AccountEntry.COL_USERNAME + " LIKE '" + name + "%' ;";*/

            string temp = "SELECT " +
                AccountEntry.TABLE_NAME + "." + AccountEntry.COL_ACCOUNT_ID + ", "
                + "COUNT(*) AS Cnt "
                + "FROM " + AccountEntry.TABLE_NAME + ", " + ProductEntry.TABLE_NAME
                + " WHERE " + AccountEntry.TABLE_NAME + "." + AccountEntry.COL_ACCOUNT_ID + " = " + ProductEntry.TABLE_NAME + "." + ProductEntry.COL_SELLER_ID
                + " AND " + ProductEntry.COL_DELETED + " = 0 "
                + "GROUP BY " + AccountEntry.TABLE_NAME + "." + AccountEntry.COL_ACCOUNT_ID;

            string query = "SELECT "
                + AccountEntry.TABLE_NAME + "." + AccountEntry.COL_ACCOUNT_ID + ", "
                + AccountEntry.TABLE_NAME + "." + AccountEntry.COL_USERNAME + ", "
                + "COALESCE(AVG(" + RatingEntry.TABLE_NAME + "." + RatingEntry.COL_RATING_VALUE + "), 0) AS " + AccountEntry.DER_RATING + ", "
                + "COALESCE(AVG(temp.Cnt), 0) AS " + AccountEntry.DER_PRODUCTS_COUNT
                + " FROM " + AccountEntry.TABLE_NAME
                + " LEFT OUTER JOIN ("
                + ProductEntry.TABLE_NAME + " LEFT OUTER JOIN " + RatingEntry.TABLE_NAME
                + " ON " + ProductEntry.TABLE_NAME + "." + ProductEntry.COL_PRODUCT_ID + " = " + RatingEntry.TABLE_NAME + "." + RatingEntry.COL_PRODUCT_ID
                + ") ON " + AccountEntry.TABLE_NAME + "." + AccountEntry.COL_ACCOUNT_ID + "=" + ProductEntry.TABLE_NAME + "." + ProductEntry.COL_SELLER_ID
                + " LEFT OUTER JOIN (" + temp + ") AS temp ON "
                + AccountEntry.TABLE_NAME + "." + AccountEntry.COL_ACCOUNT_ID + " = temp." + AccountEntry.COL_ACCOUNT_ID
                + " WHERE " + AccountEntry.TABLE_NAME + "." + AccountEntry.COL_ACCOUNT_TYPE + " != '" + AccountType.BANNED + "' "
                + "AND (" + ProductEntry.TABLE_NAME + "." + ProductEntry.COL_DELETED + " IS NULL OR " + ProductEntry.TABLE_NAME + "." + ProductEntry.COL_DELETED + " = 0) "
                + "AND " + AccountEntry.TABLE_NAME + "." + AccountEntry.COL_USERNAME + " LIKE '%" + name + "%' "
                + "GROUP BY " + AccountEntry.TABLE_NAME + "." + AccountEntry.COL_ACCOUNT_ID + ";"; 

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
			//string query = "SELECT a.*, " + "COALESCE(AVG(r."
			//	+ RatingEntry.COL_RATING_VALUE + "), 0) AS " + AccountEntry.DER_RATING
			//	+ " , COALESCE(COUNT(p." + ProductEntry.COL_PRODUCT_ID + "), 0) AS " + AccountEntry.DER_PRODUCTS_COUNT
			//	+ " , COALESCE(COUNT(o." + OrderEntry.COL_ORDER_ID + "), 0) AS " + AccountEntry.DER_ORDERS_COUNT
			//	+ " , COALESCE(SUM(o." + OrderEntry.COL_PRODUCT_PRICE + " * o." + OrderEntry.COL_QUANTITY + "), 0) AS " + AccountEntry.DER_EARNED_MONEY
			//	+ " , COALESCE(SUM(d." + OrderEntry.COL_PRODUCT_PRICE + " * d." + OrderEntry.COL_QUANTITY + "), 0) AS " + AccountEntry.DER_PAID_MONEY
			//	+ " FROM " + AccountEntry.TABLE_NAME + " a, "
			//	+ RatingEntry.TABLE_NAME + " r, "
			//	+ ProductEntry.TABLE_NAME + " p, "
			//	+ MarketEntry.DATABASE_NAME + "."
			//	+ OrderEntry.TABLE_NAME + " o, "
			//	+ MarketEntry.DATABASE_NAME + "."
			//	+ OrderEntry.TABLE_NAME + " d" +
			//	" WHERE a." + AccountEntry.COL_ACCOUNT_ID + " = " + accountID + " AND "
			//	+ "d." + OrderEntry.COL_CUSTOMER_ID + " = " + accountID + " AND "
			//	+ "p." + ProductEntry.COL_SELLER_ID + " = " + accountID + " AND "
			//	+ "p." + ProductEntry.COL_PRODUCT_ID + " = o." + OrderEntry.COL_PRODUCT_ID + " AND "
			//	+ "p." + ProductEntry.COL_PRODUCT_ID + " = r." + RatingEntry.COL_PRODUCT_ID + " AND "
			//	+ "p." + ProductEntry.COL_DELETED + " = '0' ;";
			
			string products_orders_count = "SELECT " + AccountEntry.COL_ACCOUNT_ID + ", COUNT(DISTINCT " + ProductEntry.TABLE_NAME + "." + ProductEntry.COL_PRODUCT_ID +
				") AS " + AccountEntry.DER_PRODUCTS_COUNT + ", COUNT(DISTINCT " + OrderEntry.COL_ORDER_ID + ") AS " + AccountEntry.DER_ORDERS_COUNT +
				" FROM " + AccountEntry.TABLE_NAME + " LEFT OUTER JOIN " + ProductEntry.TABLE_NAME + " ON " + AccountEntry.COL_ACCOUNT_ID +
				" = " + ProductEntry.COL_SELLER_ID + " LEFT OUTER JOIN " + MarketEntry.DATABASE_NAME + "." + OrderEntry.TABLE_NAME +
				" ON " + AccountEntry.COL_ACCOUNT_ID + " = " + MarketEntry.DATABASE_NAME + "." + OrderEntry.TABLE_NAME + "." + OrderEntry.COL_CUSTOMER_ID +
				" WHERE " + AccountEntry.COL_ACCOUNT_ID + " = " + accountID + " AND (" + ProductEntry.COL_DELETED + " IS NULL OR " + ProductEntry.COL_DELETED +
				" = 0) GROUP BY " + AccountEntry.COL_ACCOUNT_ID;

			string money_paid = "SELECT " + AccountEntry.COL_ACCOUNT_ID + ", SUM(" + MarketEntry.DATABASE_NAME + "." + OrderEntry.TABLE_NAME + "." + OrderEntry.COL_PRODUCT_PRICE +
				" * " + MarketEntry.DATABASE_NAME + "." + OrderEntry.TABLE_NAME + "." + OrderEntry.COL_QUANTITY + ") AS " + AccountEntry.DER_PAID_MONEY + " FROM " + AccountEntry.TABLE_NAME + " INNER JOIN " +
				MarketEntry.DATABASE_NAME + "." + OrderEntry.TABLE_NAME + " ON " + AccountEntry.COL_ACCOUNT_ID + " = " + MarketEntry.DATABASE_NAME + "." + OrderEntry.TABLE_NAME +
				"." + OrderEntry.COL_CUSTOMER_ID + " WHERE " + AccountEntry.COL_ACCOUNT_ID + " = " + accountID + " GROUP BY " + AccountEntry.COL_ACCOUNT_ID;

			string money_earned = "SELECT " + AccountEntry.COL_ACCOUNT_ID + ", SUM(" + MarketEntry.DATABASE_NAME + "." + OrderEntry.TABLE_NAME + "." + OrderEntry.COL_PRODUCT_PRICE +
				" * " + MarketEntry.DATABASE_NAME + "." + OrderEntry.TABLE_NAME + "." + OrderEntry.COL_QUANTITY + ") AS " + AccountEntry.DER_EARNED_MONEY + " FROM " + MarketEntry.DATABASE_NAME + "." + OrderEntry.TABLE_NAME +
				" INNER JOIN " + ProductEntry.TABLE_NAME + " ON " + ProductEntry.TABLE_NAME + "." + ProductEntry.COL_PRODUCT_ID + " = " + MarketEntry.DATABASE_NAME + "." + OrderEntry.TABLE_NAME + "." + OrderEntry.COL_PRODUCT_ID +
				" INNER JOIN " + AccountEntry.TABLE_NAME + " ON " + ProductEntry.COL_SELLER_ID + " = " + AccountEntry.COL_ACCOUNT_ID + " WHERE " + AccountEntry.COL_ACCOUNT_ID + " = " + accountID +
				" GROUP BY " + AccountEntry.COL_ACCOUNT_ID;

			string user_rating = "SELECT " + AccountEntry.COL_ACCOUNT_ID + ", COALESCE(AVG(" + RatingEntry.TABLE_NAME + "." + RatingEntry.COL_RATING_VALUE + "), 0) AS " +
				AccountEntry.DER_RATING + " FROM " + AccountEntry.TABLE_NAME +
				" LEFT OUTER JOIN (" + ProductEntry.TABLE_NAME + " LEFT OUTER JOIN " + RatingEntry.TABLE_NAME +
				" ON " + ProductEntry.TABLE_NAME + "." + ProductEntry.COL_PRODUCT_ID + " = " + RatingEntry.TABLE_NAME + "." + RatingEntry.COL_PRODUCT_ID +
				") ON " + AccountEntry.TABLE_NAME + "." + AccountEntry.COL_ACCOUNT_ID + " = " + ProductEntry.TABLE_NAME + "." + ProductEntry.COL_SELLER_ID +
				" WHERE " + AccountEntry.COL_ACCOUNT_ID + " = " + accountID + " AND (" + ProductEntry.TABLE_NAME + "." + ProductEntry.COL_DELETED + " IS NULL OR " +
				ProductEntry.TABLE_NAME + "." + ProductEntry.COL_DELETED + " = 0)" +
				" GROUP BY " + AccountEntry.TABLE_NAME + "." + AccountEntry.COL_ACCOUNT_ID;

			string query = "SELECT " + AccountEntry.TABLE_NAME + "." + AccountEntry.COL_BIRTHDATE +
				", " + AccountEntry.TABLE_NAME + "." + AccountEntry.COL_CITY + ", " +
				AccountEntry.TABLE_NAME + "." + AccountEntry.COL_COUNTRY + ", " +
				AccountEntry.TABLE_NAME + "." + AccountEntry.COL_CREATION_DATE + ", " +
				AccountEntry.TABLE_NAME + "." + AccountEntry.COL_FIRST_NAME + ", " +
				AccountEntry.TABLE_NAME + "." + AccountEntry.COL_GENDER + ", " +
				AccountEntry.TABLE_NAME + "." + AccountEntry.COL_LAST_NAME + ", " +
				AccountEntry.TABLE_NAME + "." + AccountEntry.COL_MOBILE_NUMBER + ", " +
				AccountEntry.TABLE_NAME + "." + AccountEntry.COL_USERNAME + ", " +
				"COALESCE(products_orders_count." + AccountEntry.DER_PRODUCTS_COUNT +
				", 0) AS " + AccountEntry.DER_ORDERS_COUNT + ", COALESCE(products_orders_count." + AccountEntry.DER_ORDERS_COUNT +
				", 0) AS " + AccountEntry.DER_PRODUCTS_COUNT + ", COALESCE(paid." + AccountEntry.DER_PAID_MONEY +
				", 0) AS " + AccountEntry.DER_PAID_MONEY + ", COALESCE(earned." + AccountEntry.DER_EARNED_MONEY +
				", 0) AS " + AccountEntry.DER_EARNED_MONEY + ", COALESCE(user_rating." + AccountEntry.DER_RATING +
				", 0) AS " + AccountEntry.DER_RATING + " FROM " + AccountEntry.TABLE_NAME + " LEFT OUTER JOIN (" + products_orders_count + ") as products_orders_count ON " +
				"products_orders_count." + AccountEntry.COL_ACCOUNT_ID + " = " + AccountEntry.TABLE_NAME + "." + AccountEntry.COL_ACCOUNT_ID +
				" LEFT OUTER JOIN (" + money_paid + ") AS paid ON paid." + AccountEntry.COL_ACCOUNT_ID + " = " + AccountEntry.TABLE_NAME + "." + AccountEntry.COL_ACCOUNT_ID +
				" LEFT OUTER JOIN (" + money_earned + ") AS earned on earned." + AccountEntry.COL_ACCOUNT_ID + " = " + AccountEntry.TABLE_NAME + "." + AccountEntry.COL_ACCOUNT_ID +
				" LEFT OUTER JOIN (" + user_rating + ") AS user_rating ON user_rating." + AccountEntry.COL_ACCOUNT_ID + " = " + AccountEntry.TABLE_NAME + "." + AccountEntry.COL_ACCOUNT_ID +
				" WHERE " + AccountEntry.TABLE_NAME + "." + AccountEntry.COL_ACCOUNT_ID + " = " + accountID + ";";

			DataTable dt = DBMan.ExecuteReader(query);
			return dt == null ? null : dt.Rows[0];
		}



		/*
			SELECT		account.* , ftemp.products_count , ftemp.orders_count , stemp.money_paid, ttemp.money_earned, otemp.seller_rating
			FROM		account LEFT outer JOIN (

							SELECT		account_id, COUNT(DISTINCT product.product_id) AS products_count, COUNT(DISTINCT order_id) AS orders_count
							FROM		account LEFT OUTER JOIN product ON account_id=seller_id LEFT OUTER JOIN market.order ON account_id=market.order.customer_id
							WHERE		account_id=4 AND (deleted IS NULL OR deleted=0)
							GROUP BY	account_id) as ftemp on ftemp.account_id = account.account_id LEFT OUTER JOIN (

							SELECT		account_id, SUM(market.order.product_price * market.order.quantity) AS money_paid
							FROM		account INNER JOIN market.order ON account_id=market.order.customer_id
							WHERE		account_id=4
							GROUP BY	account_id) as stemp on stemp.account_id = account.account_id LEFT OUTER JOIN (

							SELECT		account_id, SUM(market.order.product_price * market.order.quantity) AS money_earned
							FROM		market.order INNER JOIN product ON product.product_id=market.order.product_id INNER JOIN account ON seller_id=account_id
							WHERE		account_id=4
							GROUP BY	account_id) as ttemp ON ttemp.account_id = account.account_id LEFT OUTER JOIN (
			
							SELECT		account_id, COALESCE(AVG(rating.rating_value), 0) AS seller_rating
							FROM		account LEFT OUTER JOIN (product LEFT OUTER JOIN rating ON product.product_id=rating.product_id) ON account.account_id=product.seller_id
							WHERE		account_id=4 AND (product.deleted IS NULL OR product.deleted=0)
							GROUP BY	account.account_id) as otemp ON otemp.account_id = account.account_id
		                
			WHERE account.account_id=4
*/

		// Products and orders count
		/*
			SELECT		account_id, COUNT(DISTINCT product.product_id) AS products_count, COUNT(DISTINCT order_id) AS orders_count
			FROM		account LEFT OUTER JOIN product ON account_id=seller_id LEFT OUTER JOIN market.order ON account_id=market.order.customer_id
			WHERE		account_id=3 AND (deleted IS NULL OR deleted=0)
			GROUP BY	account_id
		 */

		// Money paid
		/*
			SELECT		account_id, SUM(market.order.product_price * market.order.quantity) AS money_paid
			FROM		account INNER JOIN market.order ON account_id=market.order.customer_id
			WHERE		account_id=4
			GROUP BY	account_id
		 */

		// Money earned
		/*
			SELECT		account_id, SUM(market.order.product_price * market.order.quantity) AS money_earned
			FROM		market.order INNER JOIN product ON product.product_id=market.order.product_id INNER JOIN account ON seller_id=account_id
			WHERE		account_id=3
			GROUP BY	account_id
		 */

		// Rating
		/*
			SELECT				account.account_id, COALESCE(AVG(rating.rating_value), 0) AS seller_rating
			FROM				account LEFT OUTER JOIN (product LEFT OUTER JOIN rating ON product.product_id=rating.product_id) ON account.account_id=product.seller_id
			WHERE				account_id=4 AND (product.deleted IS NULL OR product.deleted=0)
			GROUP BY			account.account_id
		*/

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