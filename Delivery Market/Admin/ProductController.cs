﻿using System;
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
				AccountEntry.COL_USERNAME + ", " +
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


        public DataTable SelectUsers(string Like = "")
        {
			string query = "SELECT " +
							AccountEntry.COL_ACCOUNT_ID + ", " +
							AccountEntry.COL_FIRST_NAME + ", " +
							AccountEntry.COL_USERNAME + ", " +
							AccountEntry.COL_ACCOUNT_TYPE + ", " +
							AccountEntry.COL_CREATION_DATE +
							" FROM " +
							AccountEntry.TABLE_NAME;

			if (Like != "") {
				query += " WHERE (" + AccountEntry.COL_FIRST_NAME +
					" LIKE '%" + Like + "%' OR " +
					AccountEntry.COL_USERNAME + " LIKE '%" + Like + "%' OR " +
					AccountEntry.COL_ACCOUNT_ID + " LIKE '%" + Like + "%')";
			}
			query += ";";

			DataTable rows = DBMan.ExecuteReader(query);
			return rows;                            
        }

		public DataTable SelectAccountDetail(string AccountID) {
			if (AccountID == "")	return null;
			string query = "SELECT " +
						AccountEntry.COL_ACCOUNT_ID + ", " +
						AccountEntry.COL_FIRST_NAME + ", " +
						AccountEntry.COL_LAST_NAME + ", " +
						AccountEntry.COL_USERNAME + ", " +
						AccountEntry.COL_MOBILE_NUMBER + ", " +
						AccountEntry.COL_GENDER + ", " +
						AccountEntry.COL_BIRTHDATE + ", " +
						AccountEntry.COL_CREATION_DATE + ", " +
						AccountEntry.COL_CITY + ", " +
						AccountEntry.COL_COUNTRY + ", " +
						AccountEntry.COL_ACCOUNT_TYPE + ", " +
						BannedUserEntry.COL_BAN_REASON + ", " +
						BannedUserEntry.COL_DESCRIPTION + ", " +
						BannedUserEntry.COL_BAN_DATE + ", " +
						AdminEntry.COL_START_DATE + " FROM " +
						AccountEntry.TABLE_NAME + " LEFT JOIN " +
						AdminEntry.TABLE_NAME + " ON " +
						AccountEntry.COL_ACCOUNT_ID + " = " +
						AdminEntry.COL_ACCOUNT_ID + " LEFT JOIN " +
						BannedUserEntry.TABLE_NAME + " ON " +
						AccountEntry.COL_ACCOUNT_ID + " = " + 
						BannedUserEntry.COL_USER_ID + " WHERE " + 
						AccountEntry.COL_ACCOUNT_ID + " = " + 
						AccountID + ";";

			DataTable rows = DBMan.ExecuteReader(query);
			return rows;
		}

		public DataTable SelectBanReasons() {
			string query = "SELECT * FROM " +
							RemovalReasonsEntry.TABLE_NAME + ";";
			DataTable rows = DBMan.ExecuteReader(query);
			return rows;
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

			string query3 = "DELETE FROM " +
							BannedUserEntry.TABLE_NAME +
							" WHERE " +
							BannedUserEntry.COL_USER_ID + " = " +
							AccountId + ";";

			int ret = DBMan.ExecuteNonQuery(query1);
			if (ret == -1)
				return ret;

			ret = DBMan.ExecuteNonQuery(query2);
			if (ret == -1)
				return ret;

			ret = DBMan.ExecuteNonQuery(query3);
			return ret;
		}

		public int makeNormalUser(string accountId) {
			string query1 = "UPDATE " +
				AccountEntry.TABLE_NAME +
				" SET " + AccountEntry.COL_ACCOUNT_TYPE +
				" = '" + AccountType.Active_Account + "' " +
				"WHERE " + AccountEntry.COL_ACCOUNT_ID + " = " +
				accountId + " ;";

			string query2 = "DELETE FROM " +
							BannedUserEntry.TABLE_NAME +
							" WHERE " +
							BannedUserEntry.COL_USER_ID + " = " +
							accountId + ";";

			string query3 = "DELETE FROM " +
							AdminEntry.TABLE_NAME +
							" WHERE " +
							AdminEntry.COL_ACCOUNT_ID + " = " +
							accountId + ";";

			int ret = DBMan.ExecuteNonQuery(query1);
			if (ret == -1)
				return ret;

			ret = DBMan.ExecuteNonQuery(query2);
			if (ret == -1)
				return ret;

			ret = DBMan.ExecuteNonQuery(query3);
			return ret;
		}


		public int BanAccount(string accountId, string adminID,string reason, string reasonDescription) {
			string query1 = "UPDATE " +
				AccountEntry.TABLE_NAME +
				" SET " + AccountEntry.COL_ACCOUNT_TYPE +
				" = '" + AccountType.Banned_Account + "' " +
				"WHERE " + AccountEntry.COL_ACCOUNT_ID + " = " +
				accountId + " ;";

			DateTime now = DateTime.Now;
			string removalDate = now.Year.ToString() + '-' + now.Month.ToString() + '-' + now.Day.ToString();

			string query2 = "INSERT INTO " +
							BannedUserEntry.TABLE_NAME + " VALUES (" +
							accountId + ", " +
							adminID + ", '" +
							reason + "', '" + 
							reasonDescription + "', '" +							 
							removalDate + "');";

			string query3 = "DELETE FROM " +
							AdminEntry.TABLE_NAME +
							" WHERE " +
							AdminEntry.COL_ACCOUNT_ID + " = " +
							accountId + ";";

			int ret = DBMan.ExecuteNonQuery(query1);
			if (ret == -1)
				return ret;

			ret = DBMan.ExecuteNonQuery(query2);
			if (ret == -1)
				return ret;

			ret = DBMan.ExecuteNonQuery(query3);
			return ret;
		}
	}
}