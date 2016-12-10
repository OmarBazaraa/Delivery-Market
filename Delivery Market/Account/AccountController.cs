using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryMarket.Data.MarketContract;
using System.Windows.Forms;
using System.Data;


namespace DeliveryMarket.Account
{
	/*
     * A class that controls account interaction with database
     */
	class AccountController : Controller
	{
		/* Selects all accounts */
		public DataTable SelectAllAccounts() {
			string query = "SELECT " + AccountEntry.COL_ACCOUNT_ID + ", " +
				AccountEntry.COL_FIRST_NAME + ", " +
				AccountEntry.COL_LAST_NAME + ", " +
				AccountEntry.COL_COUNTRY + ", " +
				"FROM " + AccountEntry.TABLE_NAME + " ;";
			return DBMan.ExecuteReader(query);
		}

		/* Select account */
		public DataTable SelectAccount() {
			string query = "SELECT * FROM " + AccountEntry.TABLE_NAME + " ;";
			return DBMan.ExecuteReader(query);
		}
	}
}
