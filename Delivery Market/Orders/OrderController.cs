using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryMarket.Data.MarketContract;
using System.Windows.Forms;
using System.Data;
using DeliveryMarket.Data;

namespace DeliveryMarket.Orders {
	/*
     * A class that controls account interaction with database
     */
	class OrderController : Controller {
		/* Selects all accounts */
		public DataTable SelectAllOrders(string account_id) {
			string query = "SELECT "			
				+ OrderEntry.COL_ORDER_ID + ", "
				+ OrderEntry.COL_PRODUCT_NAME + ", "
				+ OrderEntry.COL_PRODUCT_PRICE + ", "
				+ OrderEntry.COL_QUANTITY
				+ " FROM " + MarketEntry.DATABASE_NAME + "." + OrderEntry.TABLE_NAME + " WHERE " + OrderEntry.COL_CUSTOMER_ID + " = " + account_id + " ;";
			return DBMan.ExecuteReader(query);
		}

		public DataRow SelectOrder (string order_id) {
			string query = "SELECT " + MarketEntry.DATABASE_NAME + "." + OrderEntry.TABLE_NAME + ".*, "
				+ AccountEntry.COL_USERNAME + ", "
				+ TransactionCompanyEntry.TABLE_NAME + "." + TransactionCompanyEntry.COL_COMPANY_NAME + " AS `" + TransactionCompanyEntry.TABLE_NAME + "." + TransactionCompanyEntry.COL_COMPANY_NAME + "`, " 
				+ TransportCompanyEntry.TABLE_NAME + "." + TransportCompanyEntry.COL_COMPANY_NAME + " AS `" + TransportCompanyEntry.TABLE_NAME + "." + TransportCompanyEntry.COL_COMPANY_NAME + "`"
                + " FROM " + MarketEntry.DATABASE_NAME + "." + OrderEntry.TABLE_NAME + ", " + AccountEntry.TABLE_NAME
				+ ", " + TransportCompanyEntry.TABLE_NAME + ", " + TransactionCompanyEntry.TABLE_NAME
				+ " WHERE " + OrderEntry.COL_ORDER_ID + " = " + order_id
				+ " AND " + AccountEntry.COL_ACCOUNT_ID + " = " + OrderEntry.COL_CUSTOMER_ID
				+ " AND " + OrderEntry.TABLE_NAME + "." + OrderEntry.COL_TRANSACTION_COMPANY_ID + " = " + TransactionCompanyEntry.TABLE_NAME + "." + TransactionCompanyEntry.COL_COMPANY_ID
				+" AND " + OrderEntry.TABLE_NAME + "." + OrderEntry.COL_TRANSPORT_COMPANY_ID + " = " + TransportCompanyEntry.TABLE_NAME + "." + TransportCompanyEntry.COL_COMPANY_ID + " ;";
			DataTable dt = DBMan.ExecuteReader(query);
			if (dt == null) return null;
			return dt.Rows[0];
		}
	}
}