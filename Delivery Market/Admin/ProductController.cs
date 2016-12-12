using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryMarket.Data;
using DeliveryMarket.Data.MarketContract;
using System.Data;

namespace DeliveryMarket.Admin {

	class AdminController : Controller {

		public DataTable SelectAdmins(string name = "") {
			string query = "SELECT " +
				AccountEntry.COL_FIRST_NAME + ", " +
				AccountEntry.COL_LAST_NAME + ", " +
				AccountEntry.COL_GENDER + ", " +
				AccountEntry.COL_EMAIL + ", " +
				AccountEntry.COL_MOBILE_NUMBER + ", " +
				AccountEntry.COL_CITY + ", " +
				AdminEntry.COL_START_DATE +
				" FROM " +
				 AccountEntry.TABLE_NAME +
				 ", " + AdminEntry.TABLE_NAME +
				 " WHERE " +
				 AccountEntry.COL_ACCOUNT_ID +
				 " = " +
				 AdminEntry.COL_ACCOUNT_ID;

			if (name != "") {
				query += " And (" + AccountEntry.COL_FIRST_NAME + " LIKE '%" + name + "%' OR " + 
					AccountEntry.COL_LAST_NAME + " LIKE '%" + name + "%')";
			}
			query += ";";
			DataTable Rows = DBMan.ExecuteReader(query);
			return Rows;
		}


        public DataTable SelectNormalUsers()
        {
            string query = "SELECT * FROM " +
                            AccountEntry.TABLE_NAME +
							" WHERE " +
							AccountEntry.COL_ACCOUNT_TYPE + " = " + "'" +
							AccountType.Active_Account + "' " +
							";";
			DataTable Rows = DBMan.ExecuteReader(query);
			return Rows;                            
        }

		public int MakeAdmin(string AccountId) {
			string query1 = "UPDATE " + 
				AccountEntry.TABLE_NAME +
				" SET " + AccountEntry.COL_ACCOUNT_TYPE +
				" = '" + AccountType.Admin_Account + "' " +
				"WHERE " + AccountEntry.COL_ACCOUNT_ID + " = " +
				AccountId + " ;";

			DateTime now = DateTime.Now;
			string startDate = now.Year.ToString() + '-' + now.Month.ToString() + '-' + now.Day.ToString();

			string query2 = "INSERT INTO " +
							AdminEntry.TABLE_NAME + " VALUES (" +
							AccountId + ", '" + startDate + "');";							

			int ret = DBMan.ExecuteNonQuery(query1);
			ret &= DBMan.ExecuteNonQuery(query2);
			return ret;
		}
	}
}