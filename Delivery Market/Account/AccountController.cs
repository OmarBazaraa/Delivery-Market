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
			string query = "SELECT a.*, " + "AVG(r."
				+ RatingEntry.COL_RATE_VALUE + ") AS " + UserEntry.DER_RATING
				+ " COUNT(p." + ProductEntry.COL_PRODUCT_ID + ") AS " + UserEntry.DER_PRODUCTS_COUNT
				+ " COUNT(o." + OrderEntry.COL_ORDER_ID + ") AS " + UserEntry.DER_ORDERS_COUNT
				+ " SUM(o." + ProductEntry.COL_PRICE + ") AS " + UserEntry.DER_EARNED_MONEY
				+ " FROM " + AccountEntry.TABLE_NAME + " a, "
				+ RatingEntry.TABLE_NAME + " r, "
				+ ProductEntry.TABLE_NAME + " p, "
				+ OrderEntry.TABLE_NAME + " o, " +
				" WHERE a." + AccountEntry.COL_ACCOUNT_ID + " = " + account_id + " AND "
				+ "p." + ProductEntry.COL_SELLER_ID + " = " + account_id + " AND "
				+ "p." + ProductEntry.COL_PRODUCT_ID + " = o." + OrderEntry.COL_PRODUCT_ID
				+ "p." + ProductEntry.COL_PRODUCT_ID + " = r." + RatingEntry.COL_PRODUCT_ID
				+ "p." + ProductEntry.COL_DELETED + " = '0' ;";
			DataTable dt = DBMan.ExecuteReader(query);
			return dt == null ? null : dt.Rows[0];
		}

		
	}
}
