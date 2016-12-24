namespace DeliveryMarket.Data {
	/* 
	 * A contract namespace containing information about our Delivery Market database 
	 */
	namespace MarketContract {

		public static class MarketEntry {
			// Database name
			public const string DATABASE_NAME = "market";
		}
		
		public static class AccountType {
			// Account Types
			public const string ACTIVE = "Active";
			public const string ADMIN = "Admin";
			public const string BANNED = "Banned";
		}

		public static class AccountEntry {
			// Table name
			public const string TABLE_NAME = "account";

			// Columns names
			public const string COL_ACCOUNT_ID = "account_id";
			public const string COL_USERNAME = "username";
			public const string COL_PASSWORD = "password";
			public const string COL_FIRST_NAME = "first_name";
			public const string COL_LAST_NAME = "last_name";
			public const string COL_BIRTHDATE = "birthdate";
			public const string COL_GENDER = "gender";
			public const string COL_MOBILE_NUMBER = "mobile_number";
			public const string COL_COUNTRY = "country";
			public const string COL_CITY = "city";
			public const string COL_CREATION_DATE = "creation_date";
			public const string COL_ACCOUNT_TYPE = "account_type";
		}

		public static class AdminEntry {
			// Table name
			public const string TABLE_NAME = "admin";

			// Columns names
			public const string COL_ACCOUNT_ID = "admin_id";
			public const string COL_START_DATE = "start_date";
		}

		public static class UserEntry {
			// Table name
			public const string TABLE_NAME = "user";

			// Columns names
			public const string COL_ACCOUNT_ID = "user_id";

			// Derived attributes names
			public const string DER_RATING = "rating";
			public const string DER_PRODUCTS_COUNT = "products_count";
			public const string DER_ORDERS_COUNT = "orders_count";
			public const string DER_EARNED_MONEY = "earned_money";
			public const string DER_PAID_MONEY = "paid_money";
		}

		public static class BannedUserEntry {
			// Table name
			public const string TABLE_NAME = "banned_users";

			// Columns names
			public const string COL_USER_ID = "user_id";
			public const string COL_ADMIN_ID = "admin_id";
			public const string COL_BAN_REASON = "reason";
			public const string COL_DESCRIPTION = "description";
			public const string COL_BAN_DATE = "removal_date";
		}

		public static class ProductEntry {
			// Table name
			public const string TABLE_NAME = "product";

			// Columns names
			public const string COL_PRODUCT_ID = "product_id";
			public const string COL_SELLER_ID = "seller_id";
			public const string COL_SELLER_NAME = "seller_name";
			public const string COL_PRODUCT_NAME = "product_name";
			public const string COL_PRICE = "price";
			public const string COL_RATING = "rating";
			public const string COL_CATEGORY = "category";
			public const string COL_DESCRIPTION = "description";
			public const string COL_QUANTITY = "quantity";
			public const string COL_IMAGE = "image";
			public const string COL_SELLING_DATE = "selling_date";
			public const string COL_DELETED = "deleted";
		}

		public static class CategoryEntry {
			// Table name
			public const string TABLE_NAME = "product_category";

			// Columns names
			public const string COL_CATEGORY_NAME = "category_name";
		}

		public static class CommentEntry {
			// Table name
			public const string TABLE_NAME = "comment";

			// Columns names
			public const string COL_COMMENT_ID = "comment_id";
			public const string COL_USER_ID = "user_id";
			public const string COL_USER_NAME = "user_name";
			public const string COL_PRODUCT_ID = "product_id";
			public const string COL_COMMENT_BODY = "body";
			public const string COL_COMMENT_DATE = "comment_date";
		}

		public static class RatingEntry {
			// Table name
			public const string TABLE_NAME = "rating";

			// Columns names
			public const string COL_USER_ID = "user_id";
			public const string COL_PRODUCT_ID = "product_id";
			public const string COL_RATING_VALUE = "rating_value";
		}

		public static class ReportEntry {
			// Table name
			public const string TABLE_NAME = "report";

			// Columns names
			public const string COL_REPORT_ID = "report_id";
			public const string COL_USER_ID = "user_id";
			public const string COL_PRODUCT_ID = "product_id";
			public const string COL_REPORT_REASON = "report_reason";
			public const string COL_DESCRIPTION = "description";
			public const string COL_REPORT_DATE = "report_date";
		}

		public static class OrderEntry {
			// Table name
			public const string TABLE_NAME = "order";

			// Columns names
			public const string COL_ORDER_ID = "order_id";
			public const string COL_CUSTOMER_ID = "customer_id";
			public const string COL_PRODUCT_ID = "product_id";
			public const string COL_PRODUCT_NAME = "product_name";
			public const string COL_PRODUCT_PRICE = "product_price";
			public const string COL_QUANTITY = "quantity";
			public const string COL_ADDRESS = "address";
			public const string COL_TRANSACTION_COMPANY_ID = "transaction_company_id";
			public const string COL_TRANSPORT_COMPANY_ID = "transport_company_id";
			public const string COL_ORDER_DATE = "order_date";
		}

		public static class ProductRemovalReasonsEntry {
			// Table name
			public const string TABLE_NAME = "product_removal_reasons";

			// Columns names
			public const string COL_REASON = "reason";
		}

		public static class BanReasonsEntry {
			// Table name
			public const string TABLE_NAME = "user_ban_reasons";

			// Columns names
			public const string COL_REASON = "reason";
		}

		public static class RemovedProductsEntry {
			// Table name
			public const string TABLE_NAME = "removed_products";

			// Columns names
			public const string COL_PRODUCT_ID = "product_id";
			public const string COL_ACCOUNT_ID = "account_id";
			public const string COL_REMOVAL_REASON = "reason";
			public const string COL_DESCRIPTION = "description";
			public const string COL_REMOVAL_DATE = "removal_date";
		}

		public static class TransactionCompanyEntry {
			// Table name
			public const string TABLE_NAME = "transaction_company";

			// Columns names
			public const string COL_COMPANY_ID = "transaction_company_id";
			public const string COL_COMPANY_NAME = "company_name";
		}

		public static class TransportCompanyEntry {
			// Table name
			public const string TABLE_NAME = "transport_company";

			// Columns names
			public const string COL_COMPANY_ID = "transport_company_id";
			public const string COL_COMPANY_NAME = "company_name";
		}
	}
}