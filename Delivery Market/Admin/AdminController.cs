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

		/****************************************************** 
							Accounts queries 
		******************************************************/

		/******************* Select Queries *******************/
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


		/*************** Update,Insert And Delete Queries ***************/
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


		public int BanAccount(string accountId, string adminID, string reason, string reasonDescription) {
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


		/****************************************************** 
							Reports queries 
		******************************************************/


		/******************* Select Queries *******************/
		public DataTable SelectBanReasons() {
			string query = "SELECT * FROM " +
							ProductRemovalReasonsEntry.TABLE_NAME + ";";
			DataTable rows = DBMan.ExecuteReader(query);
			return rows;
		}

		public DataTable SelectReports(string Like = "") {
			string query = "SELECT " +
							ReportEntry.COL_REPORT_ID + ", " +
							ProductEntry.COL_PRODUCT_NAME + ", " +
							AccountEntry.COL_USERNAME + ", " +
							ReportEntry.COL_REPORT_REASON + ", " +
							ReportEntry.COL_REPORT_DATE +
							" FROM " +

							ReportEntry.TABLE_NAME + " LEFT JOIN " +
							ProductEntry.TABLE_NAME + " ON " +
							ReportEntry.TABLE_NAME + "." + ReportEntry.COL_PRODUCT_ID + " = " +
							ProductEntry.TABLE_NAME + "." + ProductEntry.COL_PRODUCT_ID + " LEFT JOIN " +
							AccountEntry.TABLE_NAME + " ON " +
							ProductEntry.TABLE_NAME + "." + ProductEntry.COL_SELLER_ID + " = " +
							AccountEntry.TABLE_NAME + "." + AccountEntry.COL_ACCOUNT_ID + " WHERE NOT " +
							AccountEntry.COL_ACCOUNT_TYPE + " = '" + AccountType.Banned_Account + "' AND NOT " +
							ProductEntry.COL_DELETED;

			if (Like != "") {
				query += " AND (" + ReportEntry.COL_REPORT_ID +
					" LIKE '%" + Like + "%' OR " +
					ProductEntry.COL_PRODUCT_NAME + " LIKE '%" + Like + "%' OR " +
					AccountEntry.COL_USERNAME + " LIKE '%" + Like + "%' OR " +
					ReportEntry.COL_REPORT_REASON + " LIKE '%" + Like + "%')";
			}
			query += ";";

			DataTable rows = DBMan.ExecuteReader(query);
			return rows;
		}

		public DataTable SelectReportDetails(string reportId) {
			string query = "SELECT " +
							ReportEntry.COL_REPORT_REASON + ", " +
							ReportEntry.TABLE_NAME + "." + ReportEntry.COL_DESCRIPTION + " as '" + ReportEntry.TABLE_NAME + "." + ReportEntry.COL_DESCRIPTION + "', " +
							ProductEntry.TABLE_NAME + "." + ProductEntry.COL_PRODUCT_ID + ", " +
							ProductEntry.COL_PRODUCT_NAME + ", " +
							ProductEntry.COL_PRICE + ", " +
							ProductEntry.COL_QUANTITY + ", " +
							ProductEntry.COL_CATEGORY + ", " +
							ProductEntry.COL_SELLING_DATE + ", " +
							ProductEntry.TABLE_NAME + "." + ProductEntry.COL_DESCRIPTION + " as '" + ProductEntry.TABLE_NAME + "." + ProductEntry.COL_DESCRIPTION + "', " +
							ProductEntry.COL_IMAGE + ", " +
							AccountEntry.COL_ACCOUNT_ID + ", " +
							AccountEntry.COL_FIRST_NAME + ", " +
							AccountEntry.COL_LAST_NAME + ", " +
							AccountEntry.COL_USERNAME + ", " +
							AccountEntry.COL_MOBILE_NUMBER + ", " +
							AccountEntry.COL_GENDER + ", " +
							AccountEntry.COL_BIRTHDATE + ", " +
							AccountEntry.COL_CREATION_DATE + ", " +
							AccountEntry.COL_CITY +  ", " +
							AccountEntry.COL_COUNTRY + " FROM " +

							ReportEntry.TABLE_NAME + " LEFT JOIN " +
							ProductEntry.TABLE_NAME + " ON " +
							ReportEntry.TABLE_NAME + "." + ReportEntry.COL_PRODUCT_ID + " = " +
							ProductEntry.TABLE_NAME + "." +  ProductEntry.COL_PRODUCT_ID + " LEFT JOIN " +
							AccountEntry.TABLE_NAME + " ON " +
							ProductEntry.TABLE_NAME + "." +  ProductEntry.COL_SELLER_ID + " = " +
							AccountEntry.TABLE_NAME + "." +  AccountEntry.COL_ACCOUNT_ID + " WHERE " +

							ReportEntry.COL_REPORT_ID + " = " + reportId + ";";

			DataTable rows = DBMan.ExecuteReader(query);
			return rows;
		}


		/****************************************************** 
							Companies queries 
		******************************************************/


		/******************* Select Queries *******************/
		public DataTable SelectTransportCompanies(string Like = "") {
			string query = "SELECT * FROM " +
				TransportCompanyEntry.TABLE_NAME;

			if (Like != "") {
				query += " WHERE " + TransportCompanyEntry.COL_COMPANY_ID + " LIKE '%" + Like + "%' OR " +
					TransportCompanyEntry.COL_COMPANY_NAME + " LIKE '%" + Like + "%'";
			}
			query += ";";
			DataTable rows = DBMan.ExecuteReader(query);

			return rows;
		}

		public DataTable SelectTransactionCompanies(string Like = "") {
			string query = "SELECT * FROM " +
				TransactionCompanyEntry.TABLE_NAME;

			if (Like != "") {
				query += " WHERE " + TransactionCompanyEntry.COL_COMPANY_ID + " LIKE '%" + Like + "%' OR " +
					TransactionCompanyEntry.COL_COMPANY_NAME + " LIKE '%" + Like + "%'";
			}
			query += ";";
			return DBMan.ExecuteReader(query);
		}


		/******************* Insert Queries *******************/
		public int AddTransportCompany(string name) {
			string query = "INSERT INTO " +
				TransportCompanyEntry.TABLE_NAME + "(`" +
				TransportCompanyEntry.COL_COMPANY_NAME + "`)" +
				" VALUES ('" +
				name + "');";
			int ret = DBMan.ExecuteNonQuery(query);
			return ret;
		}
		public int AddTransactionCompany(string name) {
			string query = "INSERT INTO " +
				TransactionCompanyEntry.TABLE_NAME + "(`" +
				TransactionCompanyEntry.COL_COMPANY_NAME + "`)" +
				" VALUES ('" +
				name + "');";
			int ret = DBMan.ExecuteNonQuery(query);
			return ret;
		}


		/******************* Delete Queries *******************/
		public int RemoveTransportCompany(string id) {
			string query = "DELETE FROM " +
				TransportCompanyEntry.TABLE_NAME + " WHERE " +
				TransportCompanyEntry.COL_COMPANY_ID + " = " + id + ";";
			int ret = DBMan.ExecuteNonQuery(query);
			return ret;
		}
		public int RemoveTransactionCompany(string id) {
			string query = "DELETE FROM " +
				TransactionCompanyEntry.TABLE_NAME + " WHERE " +
				TransactionCompanyEntry.COL_COMPANY_ID + " = " + id + ";";
			int ret = DBMan.ExecuteNonQuery(query);
			return ret;
		}


		/****************************************************** 
							Extras queries 
		******************************************************/


		/******************* Select Queries *******************/
		public DataTable SelectProductCategories(string Like = "") {
			string query = "SELECT * FROM " + CategoryEntry.TABLE_NAME;

			if (Like != "") {
				query += " WHERE " + CategoryEntry.COL_CATEGORY_NAME + " LIKE '%" + Like + "%'";
			}
			query += ";";

			return DBMan.ExecuteReader(query);
		}

		public DataTable SelectRemovalReasons(string Like = "") {
			string query = "SELECT * FROM " + ProductRemovalReasonsEntry.TABLE_NAME;

			if (Like != "") {
				query += " WHERE " + ProductRemovalReasonsEntry.COL_REASON + " LIKE '%" + Like + "%'";
			}
			query += ";";

			return DBMan.ExecuteReader(query);
		}

		public DataTable SelectBanReasons(string Like = "") {
			string query = "SELECT * FROM " + BanReasonsEntry.TABLE_NAME;

			if (Like != "") {
				query += " WHERE " + BanReasonsEntry.COL_REASON + " LIKE '%" + Like + "%'";
			}
			query += ";";

			return DBMan.ExecuteReader(query);
		}


		/******************* Insert Queries *******************/
		public int AddProductCategory(string name) {
			string query = "INSERT INTO " + CategoryEntry.TABLE_NAME + " VALUES ('" + name + "');";
			return DBMan.ExecuteNonQuery(query);
		}

		public int AddRemovalReason(string name) {
			string query = "INSERT INTO " + ProductRemovalReasonsEntry.TABLE_NAME + " VALUES ('" + name + "');";
			return DBMan.ExecuteNonQuery(query);
		}

		public int AddBanReason(string name) {
			string query = "INSERT INTO " + BanReasonsEntry.TABLE_NAME + " VALUES ('" + name + "');";
			return DBMan.ExecuteNonQuery(query);
		}


		/******************* Delete Queries *******************/
		public int RemoveProductCategory(string name) {
			string query = "DELETE FROM " + CategoryEntry.TABLE_NAME + " WHERE " +
				CategoryEntry.COL_CATEGORY_NAME + " = '" + name + "';";
			return DBMan.ExecuteNonQuery(query); 
		}

		public int RemoveRemovalReason(string name) {
			string query = "DELETE FROM " + ProductRemovalReasonsEntry.TABLE_NAME + " WHERE " +
				ProductRemovalReasonsEntry.COL_REASON + " = '" + name + "';";
			return DBMan.ExecuteNonQuery(query);
		}

		public int RemoveBanReason(string name) {
			string query = "DELETE FROM " + BanReasonsEntry.TABLE_NAME + " WHERE " +
				BanReasonsEntry.COL_REASON + " = '" + name + "';";
			return DBMan.ExecuteNonQuery(query);
		}


		/******************* Update Queries *******************/
		public int EditProductCategory(string name, string originalName) {
			string query = "UPDATE " + CategoryEntry.TABLE_NAME + " SET " + 
				CategoryEntry.COL_CATEGORY_NAME + " = '" + name + "' WHERE " +
				CategoryEntry.COL_CATEGORY_NAME + " = '" + originalName + "';";
			return DBMan.ExecuteNonQuery(query);
		}

		public int EditRemovalReason(string name, string originalName) {
			string query = "UPDATE " + ProductRemovalReasonsEntry.TABLE_NAME + " SET " +
				ProductRemovalReasonsEntry.COL_REASON + " = '" + name + "' WHERE " +
				ProductRemovalReasonsEntry.COL_REASON + " = '" + originalName + "';";
			return DBMan.ExecuteNonQuery(query);
		}

		public int EditBanReason(string name, string originalName) {
			string query = "UPDATE " + BanReasonsEntry.TABLE_NAME + " SET " +
				BanReasonsEntry.COL_REASON + " = '" + name + "' WHERE " +
				BanReasonsEntry.COL_REASON + " = '" + originalName + "';";
			return DBMan.ExecuteNonQuery(query);
		}
	}
}