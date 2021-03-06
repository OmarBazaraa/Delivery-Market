﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryMarket.Data;
using DeliveryMarket.Data.MarketContract;
using System.Windows.Forms;
using System.Data;

namespace DeliveryMarket.Product {

	/*
     * A class that controls product interaction with database
     */
	class ProductController : Controller {

		/* Selects product information by its ID, to be used in editing product form */
		public DataRow SelectProductInfo(int productID) {
			string query = "SELECT * FROM " + ProductEntry.TABLE_NAME +
				" WHERE " + ProductEntry.COL_PRODUCT_ID + "=" + productID.ToString() + ";";

			DataTable dt = DBMan.ExecuteReader(query);
			return (dt == null) ? null : dt.Rows[0];
		}

		/* Selects product details by its ID, to be used in showing product details */
		public DataRow SelectProductDetails(int productID) {
			string query =
				"SELECT " + ProductEntry.TABLE_NAME + ".*, " + AccountEntry.TABLE_NAME + "." + AccountEntry.COL_ACCOUNT_ID + ", " +
				AccountEntry.COL_USERNAME + " AS " + ProductEntry.COL_SELLER_NAME + ", " +
				"COALESCE(AVG(" + RatingEntry.COL_RATING_VALUE + "), 0) AS " + ProductEntry.COL_RATING + " " +
				"FROM " + ProductEntry.TABLE_NAME + " INNER JOIN " + AccountEntry.TABLE_NAME + " ON " +
				ProductEntry.COL_SELLER_ID + "=" + AccountEntry.COL_ACCOUNT_ID + " " +
				"LEFT OUTER JOIN " + RatingEntry.TABLE_NAME + " ON " +
				ProductEntry.TABLE_NAME + "." + ProductEntry.COL_PRODUCT_ID + "=" + RatingEntry.TABLE_NAME + "." + RatingEntry.COL_PRODUCT_ID + " " +
				"WHERE " + ProductEntry.TABLE_NAME + "." + ProductEntry.COL_PRODUCT_ID + "=" + productID.ToString() + " " +
				"GROUP BY " + ProductEntry.TABLE_NAME + "." + ProductEntry.COL_PRODUCT_ID + ";";

			/*
				SELECT		product.*, CONCAT(account.first_name, ' ', account.last_name) AS seller_name, COALESCE(AVG(rate_value), 0) AS rating
				FROM		product INNER JOIN account ON seller_id=account_id LEFT OUTER JOIN rating ON product.product_id=rating.product_id
				WHERE		product.product_id=given_value
				GROUP BY	product.product_id
			*/

			DataTable dt = DBMan.ExecuteReader(query);
			return (dt == null) ? null : dt.Rows[0];
		}

		/* Selects all not deleted products to be displayed as list */
		public DataTable SelectProductList(int sellerID = -1, string name = "", string category = "", string orderby = ProductEntry.COL_PRODUCT_NAME, bool asc = true) {
			string query =
				"SELECT " + ProductEntry.COL_PRODUCT_NAME + ", " + ProductEntry.TABLE_NAME + "." + ProductEntry.COL_PRODUCT_ID + ", " +
				AccountEntry.COL_USERNAME + " AS " + ProductEntry.COL_SELLER_NAME + ", " +
				ProductEntry.COL_PRICE + ", " +
				"COALESCE(AVG(" + RatingEntry.COL_RATING_VALUE + "), 0) AS " + ProductEntry.COL_RATING + " " +
				"FROM " + ProductEntry.TABLE_NAME + " INNER JOIN " + AccountEntry.TABLE_NAME + " ON " +
				ProductEntry.COL_SELLER_ID + "=" + AccountEntry.COL_ACCOUNT_ID + " " +
				"LEFT OUTER JOIN " + RatingEntry.TABLE_NAME + " ON " +
				ProductEntry.TABLE_NAME + "." + ProductEntry.COL_PRODUCT_ID + "=" + RatingEntry.TABLE_NAME + "." + RatingEntry.COL_PRODUCT_ID + " " +
				"WHERE " + ProductEntry.COL_DELETED + "=0 " + 
				"AND " + AccountEntry.COL_ACCOUNT_TYPE + "!='Banned'";

			if (name != "") {
				query += " AND (" + ProductEntry.COL_PRODUCT_NAME + " LIKE '%" + name + "%'" + 
					" OR " + AccountEntry.COL_USERNAME + " LIKE '%" + name + "%')";
			}

			if (category != "") {
				query += " AND " + ProductEntry.COL_CATEGORY + "='" + category + "'";
			}

			if (sellerID != -1) {
				query += " AND " + AccountEntry.COL_ACCOUNT_ID + "=" + sellerID.ToString();
			}

			query += " GROUP BY " + ProductEntry.TABLE_NAME + "." + ProductEntry.COL_PRODUCT_ID +
				" ORDER BY " + orderby + (asc ? " ASC" : " DESC") + ";";

			return DBMan.ExecuteReader(query);
		}

		/* Selects the ID of the last inserted product */
		public int SelectLastProductID() {
			string query = "SELECT " + ProductEntry.COL_PRODUCT_ID +
				" FROM " + ProductEntry.TABLE_NAME +
				" ORDER BY " + ProductEntry.COL_PRODUCT_ID + " DESC" +
				" LIMIT 1;";

			object result = DBMan.ExecuteScalar(query);

			return (result == null) ? 0 : Convert.ToInt32(result);
		}

		/* Selects all product categories */
		public DataTable SelectCategories() {
			string query = "SELECT " + CategoryEntry.COL_CATEGORY_NAME +
				" FROM " + CategoryEntry.TABLE_NAME +
				" ORDER BY " + CategoryEntry.COL_CATEGORY_NAME + " ASC;";
			return DBMan.ExecuteReader(query);
		}

		/* Selects all removal reasons from the database */
		public DataTable SelectRemovalReasons() {
			string query = "SELECT " + ProductRemovalReasonsEntry.COL_REASON + 
				" FROM " + ProductRemovalReasonsEntry.TABLE_NAME +
				" ORDER BY " + ProductRemovalReasonsEntry.COL_REASON + " ASC;";
			return DBMan.ExecuteReader(query);
		}

		/* Selects all comments on a given product */
		public DataTable SelectComments(int productID) {
			string query = "SELECT " +
				CommentEntry.COL_COMMENT_ID + ", " +
                CommentEntry.COL_USER_ID + ", " +
                CommentEntry.COL_COMMENT_BODY + ", " +
                CommentEntry.COL_COMMENT_DATE + "," +
				AccountEntry.COL_USERNAME + " AS " + CommentEntry.COL_USER_NAME +
				" FROM " + CommentEntry.TABLE_NAME + ", " + AccountEntry.TABLE_NAME + 
				" WHERE " + CommentEntry.COL_USER_ID + "=" + AccountEntry.COL_ACCOUNT_ID + 
				" AND " + CommentEntry.COL_PRODUCT_ID + "=" + productID.ToString() + ";";
			
			return DBMan.ExecuteReader(query);
		}

		/* Selects the rating of a certain customer to a given product */
		public int SelectCustomerRating(int accountID, int productID) {
			string query = "SELECT " + RatingEntry.COL_RATING_VALUE + 
				" FROM " + RatingEntry.TABLE_NAME + 
				" WHERE " + RatingEntry.COL_USER_ID + "=" + accountID.ToString() +
				" AND " + RatingEntry.COL_PRODUCT_ID + "=" + productID.ToString() + ";";

			object result = DBMan.ExecuteScalar(query);

			return (result == null) ? 0 : Convert.ToInt32(result);
		}

		/* Selects all transaction companies */
		public DataTable SelectTransactionCompanies() {
			string query = "SELECT * FROM " + TransactionCompanyEntry.TABLE_NAME +
				" ORDER BY " + TransactionCompanyEntry.COL_COMPANY_NAME + " ASC;";
			return DBMan.ExecuteReader(query);
		}

		/* Selects all transport companies */
		public DataTable SelectTransportCompanies() {
			string query = "SELECT * FROM " + TransportCompanyEntry.TABLE_NAME +
				" ORDER BY " + TransportCompanyEntry.COL_COMPANY_NAME + " ASC;";
			return DBMan.ExecuteReader(query);
		}

		/* Inserts a new product into the database */
		public int InsertProduct(Product product) {
			string query = "INSERT INTO " + ProductEntry.TABLE_NAME + " (" +
				ProductEntry.COL_SELLER_ID + ", " +
				ProductEntry.COL_PRODUCT_NAME + ", " +
				ProductEntry.COL_PRICE + ", " +
				ProductEntry.COL_CATEGORY + ", " +
				ProductEntry.COL_DESCRIPTION + ", " +
				ProductEntry.COL_QUANTITY + ", " +
				ProductEntry.COL_IMAGE + ") VALUES (" +
				product.SellerID + ", " +
				"'" + product.Name + "', " +
				product.Price.ToString() + ", " +
				"'" + product.Category + "', " +
				"'" + product.Description + "', " +
				product.Quantity.ToString() + ", " +
				"'" + product.ImagePath + "'" +
				");";

			return DBMan.ExecuteNonQuery(query);
		}

		/* Inserts a new comment into the database */
		public int InsertComment(int accountID, int productID, string commentBody) {
			string query = "INSERT INTO " + CommentEntry.TABLE_NAME + " (" +
				CommentEntry.COL_USER_ID + ", " +
				CommentEntry.COL_PRODUCT_ID + ", " +
				CommentEntry.COL_COMMENT_BODY +
				") VALUES (" +
				accountID.ToString() + ", " +
				productID.ToString() + ", " +
				"'" + commentBody + "'" +
				");";

			return DBMan.ExecuteNonQuery(query);
		}

		/* Inserts a new report into the database */
		public int InsertReport(int accountID, int productID, string reason, string description) {
			string query = "INSERT INTO " + ReportEntry.TABLE_NAME + " (" +
				ReportEntry.COL_USER_ID + ", " +
				ReportEntry.COL_PRODUCT_ID + ", " +
				ReportEntry.COL_REPORT_REASON + ", " +
				ReportEntry.COL_DESCRIPTION +
				") VALUES (" +
				accountID.ToString() + ", " +
				productID.ToString() + ", " +
				"'" + reason + "', " +
				"'" + description + "'" +
				");";
			
			return DBMan.ExecuteNonQuery(query);
		}

		/* Inserts a new rating into the database */
		public int InsertRating(int accountID, int productID, int ratingValue) {
			// Try updating old user rating
			string query = "UPDATE " + RatingEntry.TABLE_NAME + " SET " +
				RatingEntry.COL_RATING_VALUE + "=" + ratingValue.ToString() +
				" WHERE " + RatingEntry.COL_USER_ID + "=" + accountID.ToString() +
				" AND " + RatingEntry.COL_PRODUCT_ID + "=" + productID.ToString() + ";";

			int result = DBMan.ExecuteNonQuery(query);

			if (result > 0) {
				return result;
			}

			// Insert new rating if updating failed
			query = "INSERT INTO " + RatingEntry.TABLE_NAME + " (" +
				RatingEntry.COL_USER_ID + ", " +
				RatingEntry.COL_PRODUCT_ID + ", " +
				RatingEntry.COL_RATING_VALUE + ") VALUES (" +
				accountID.ToString() + ", " +
				productID.ToString() + ", " +
				ratingValue.ToString() +
				");";

			return DBMan.ExecuteNonQuery(query);
		}

		/* Updates the details of a given product */
		public int UpdateProduct(Product product) {
			string query = "UPDATE " + ProductEntry.TABLE_NAME + " SET " +
				ProductEntry.COL_PRODUCT_NAME + "='" + product.Name + "', " +
				ProductEntry.COL_PRICE + "=" + product.Price.ToString() + ", " +
				ProductEntry.COL_CATEGORY + "='" + product.Category + "', " +
				ProductEntry.COL_DESCRIPTION + "='" + product.Description + "', " +
				ProductEntry.COL_QUANTITY + "=" + product.Quantity.ToString() + ", " +
				ProductEntry.COL_IMAGE + "='" + product.ImagePath + "' " +
				"WHERE " + ProductEntry.COL_PRODUCT_ID + "=" + product.ID + ";";

			return DBMan.ExecuteNonQuery(query);
		}

		/* Buys a certain product and save the order in the database */
		public int BuyProduct(Order order) {
			// First decrease the product's stock quantity by the given quantity
			string query = "UPDATE " + ProductEntry.TABLE_NAME + " SET " +
				ProductEntry.COL_QUANTITY + "=" + ProductEntry.COL_QUANTITY + "-" + order.Quantity.ToString() +
				" WHERE " + ProductEntry.COL_PRODUCT_ID + "=" + order.ProductID.ToString() + ";";
			
			if (DBMan.ExecuteNonQuery(query) <= 0) {
				return 0;	// An error occured will updating the product's quantity, no need to proceed
			}

			// Then insert the order into the database
			query = "INSERT INTO " + MarketEntry.DATABASE_NAME + "." + OrderEntry.TABLE_NAME + " (" +
				OrderEntry.COL_CUSTOMER_ID + ", " +
				OrderEntry.COL_PRODUCT_ID + ", " +
				OrderEntry.COL_PRODUCT_NAME + ", " +
				OrderEntry.COL_PRODUCT_PRICE + ", " +
				OrderEntry.COL_QUANTITY + ", " +
				OrderEntry.COL_ADDRESS + ", " +
				OrderEntry.COL_TRANSACTION_COMPANY_ID + ", " +
				OrderEntry.COL_TRANSPORT_COMPANY_ID +
				") VALUES(" +
				order.CustomerID.ToString() + ", " +
				order.ProductID.ToString() + ", " +
				"'" + order.ProductName + "', " +
				order.ProductPrice.ToString() + ", " +
				order.Quantity.ToString() + ", " +
				"'" + order.Address + "', " +
				order.TransactionCompanyID.ToString() + ", " +
				order.TransportCompanyID.ToString() +
				");";

			return DBMan.ExecuteNonQuery(query);
		}

		/* Deletes a given product */
		public int DeleteProduct(int accountID, int productID, string reason, string description) {
			string query = "UPDATE " + ProductEntry.TABLE_NAME + " SET " +
				ProductEntry.COL_DELETED + "=" + "'1' " +
				"WHERE " + ProductEntry.COL_PRODUCT_ID + "=" + productID.ToString() + ";";

			if (DBMan.ExecuteNonQuery(query) <= 0) {
				return 0;
			}

			query = "INSERT INTO " + RemovedProductsEntry.TABLE_NAME + "(" +
				RemovedProductsEntry.COL_PRODUCT_ID + ", " +
				RemovedProductsEntry.COL_ACCOUNT_ID + ", " +
				RemovedProductsEntry.COL_REMOVAL_REASON + ", " +
				RemovedProductsEntry.COL_DESCRIPTION +
				 ") VALUES (" +
				productID.ToString() + ", " +
				accountID.ToString() + ", " +
				"'" + reason + "', " +
				"'" + description + "'" +
				");";

			return DBMan.ExecuteNonQuery(query);
		}

		/* Deletes a given comment */
		public int DeleteComment(int commentID) {
			string query = "DELETE FROM " + CommentEntry.TABLE_NAME + 
				" WHERE " + CommentEntry.COL_COMMENT_ID + "=" + commentID.ToString() + ";";

			return DBMan.ExecuteNonQuery(query);
		}
	}
}