using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryMarket.Utils {

	/*
	 * Contains some defenitions to be used all over the application
	 */
	namespace Defs {

		public enum Privilege {
			Admin,
			User,
			Other
		}

		public static class Strings {

			// Application global strings
			public const string APP_TITLE = "Delivery Market";

			public const string MAIN_DIRECTORY = "C:\\DeliveryMarket";
			public const string IMAGES_DIRECTORY = MAIN_DIRECTORY + "\\Images";
			public const string PRODUCT_IMAGES_DIRECTORY = IMAGES_DIRECTORY + "\\Products";

			// Applications messages
			


			// Column Return names for AdminController
			public const string ACCOUNT_TYPE = "account_type";
			public const string ACCOUNTS_COUNT = "accounts_count";
			public const string AVERAGE_ACCOUNTS_RATING = "average_accounts_rating";
			public const string ORDERS_COUNT = "orders_count";
			public const string TOTAL_MONEY_PAID = "total_money_paid";

			public const string COMPANY_NAME = "company_name";
			public const string COMPANY_ORDERS_COUNT = "orders_count";

			public const string PRODUCT_DELETION_STATE = "product_state";
			public const string PRODUCTS_COUNT = "products_count";
			public const string PRODUCTS_AVERAGE_RATE = "products_average_rate";
		}
	}
}