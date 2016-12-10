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

		public DataTable SelectAdmins() {
			string query = "SELECT * FROM " +
				 AccountEntry.TABLE_NAME +
				 ", " + AdminEntry.TABLE_NAME +
				 " WHERE " +
				 AccountEntry.COL_ACCOUNT_ID +
				 " = " +
				 AdminEntry.COL_ACCOUNT_ID +
				 ";";
			DataTable Rows = DBMan.ExecuteReader(query);
			return Rows;
		}
	}
}