using System;
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

		/* Selects a product by its ID */
		public DataRow SelectProductByID(int productID) {
			string query = "SELECT * FROM " + ProductEntry.TABLE_NAME +
				" WHERE " + ProductEntry.COL_PRODUCT_ID + "=" + productID.ToString() + ";";

			DataTable dt = DBMan.ExecuteReader(query);

			return (dt == null) ? null : dt.Rows[0];
		}

		/* Selects all product categories */
		public DataTable SelectCategories() {
			string query = "SELECT " + CategoryEntry.COL_CATEGORY_NAME + " FROM " + CategoryEntry.TABLE_NAME + ";";
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
				ProductEntry.COL_STOCK_COUNT + ", " +
				ProductEntry.COL_IMAGE + ") VALUES (" +
				product.SellerID + ", " +
				"'" + product.Name + "', " +
				product.Price + ", " +
				"'" + product.Category + "', " +
				"'" + product.Description + "', " +
				product.StockCount + ", " +
				"'" + product.ImagePath + "'" +
				");";

			return DBMan.ExecuteNonQuery(query);
		}

		/* Updates a product details */
		public int UpdateProduct(Product product) {
			string query = "UPDATE " + ProductEntry.TABLE_NAME + " SET " +
				ProductEntry.COL_PRODUCT_NAME + "='" + product.Name + "', " +
				ProductEntry.COL_PRICE + "=" + product.Price + ", " +
				ProductEntry.COL_CATEGORY + "='" + product.Category + "', " +
				ProductEntry.COL_DESCRIPTION + "='" + product.Description + "', " +
				ProductEntry.COL_STOCK_COUNT + "=" + product.StockCount + ", " +
				ProductEntry.COL_IMAGE + "='" + product.ImagePath + "' " +
				"WHERE " + ProductEntry.COL_PRODUCT_ID + "=" + product.ID + ";";

			MessageBox.Show(query);

			return DBMan.ExecuteNonQuery(query);
		}
	}
}