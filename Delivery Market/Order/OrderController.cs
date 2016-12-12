using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryMarket.Data.MarketContract;
using System.Windows.Forms;
using System.Data;
using DeliveryMarket.Data;

namespace DeliveryMarket.Order {
	/*
     * A class that controls account interaction with database
     */
	class OrderController : Controller {
		/* Selects all accounts */
		public DataTable SelectAllOrders(string account_id) {
			string query = "SELECT * FROM " + OrderEntry.TABLE_NAME + " WHERE " + OrderEntry.COL_CUSTOMER_ID + " = " + account_id + " ;";
			return DBMan.ExecuteReader(query);
		}
	}
}
