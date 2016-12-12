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
		public DataTable SelectAllAccounts() {
			string query = "SELECT " + AccountEntry.COL_ACCOUNT_ID + ", " 
				+ AccountEntry.COL_FIRST_NAME + ", " 
				+ AccountEntry.COL_LAST_NAME + ", " 
				+ AccountEntry.COL_COUNTRY + ", " 
				+ AccountEntry.COL_MOBILE_NUMBER
				+ " FROM " + AccountEntry.TABLE_NAME 
				+ " WHERE " + AccountEntry.COL_ACCOUNT_TYPE + " = '"
				+ AccountEntry.COL_ACCOUNT_TYPE_ENUM[0] + "' ;";
			return DBMan.ExecuteReader(query);
		}

		/* Select user account */
		public DataRow SelectAccount(string account_id) {
			/*
			SELECT a.*, COALESCE (AVG(r.rate_value), 0) AS rating,
			COALESCE(COUNT(p.product_id), 0) AS products_count,
			COALESCE(COUNT(o.order_id), 0) AS orders_count,
			COALESCE(SUM(o.product_price), 0) AS earned_money
			FROM account a, rating r, product p, orders o
			WHERE a.account_id = 1 AND p.seller_id = 1 AND
			p.product_id = o.product_id AND
			p.product_id = r.product_id AND p.deleted = '0' ;
			*/
			string query = "SELECT a.*, " + "COALESCE(AVG(r."
				+ RatingEntry.COL_RATE_VALUE + "), 0) AS " + UserEntry.DER_RATING
				+ " , COALESCE(COUNT(p." + ProductEntry.COL_PRODUCT_ID + "), 0) AS " + UserEntry.DER_PRODUCTS_COUNT
				+ " , COALESCE(COUNT(o." + OrdersEntry.COL_ORDER_ID + "), 0) AS " + UserEntry.DER_ORDERS_COUNT
				+ " , COALESCE(SUM(o." + OrdersEntry.COL_PRODUCT_PRICE + "), 0) AS " + UserEntry.DER_EARNED_MONEY
				+ " FROM " + AccountEntry.TABLE_NAME + " a, "
				+ RatingEntry.TABLE_NAME + " r, "
				+ ProductEntry.TABLE_NAME + " p, "
				+ OrdersEntry.TABLE_NAME + " o" +
				" WHERE a." + AccountEntry.COL_ACCOUNT_ID + " = " + account_id + " AND "
				+ "p." + ProductEntry.COL_SELLER_ID + " = " + account_id + " AND "
				+ "p." + ProductEntry.COL_PRODUCT_ID + " = o." + OrdersEntry.COL_PRODUCT_ID + " AND "
				+ "p." + ProductEntry.COL_PRODUCT_ID + " = r." + RatingEntry.COL_PRODUCT_ID + " AND "
				+ "p." + ProductEntry.COL_DELETED + " = '0' ;";
			DataTable dt = DBMan.ExecuteReader(query);
			return dt == null ? null : dt.Rows[0];
		}

		
	}
}
