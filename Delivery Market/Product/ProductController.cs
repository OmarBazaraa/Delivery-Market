using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryMarket.Data.MarketContract;
using System.Windows.Forms;
using System.Data;

namespace DeliveryMarket.Product
{
    /*
     * A class that controls product interaction with database
     */
    class ProductController : Controller
    { 
        /* Inserts a new product into the database */
        public int InsertProduct(Product product)
        {
            string query = "INSERT INTO " + ProductEntry.TABLE_NAME + " (" +
                ProductEntry.COL_SELLER_ID + ", " +
                ProductEntry.COL_PRODUCT_NAME + ", " +
                ProductEntry.COL_PRICE + ", " +
                ProductEntry.COL_CATEGORY + ", " +
                ProductEntry.COL_DESCRIPTION + ", " +
                ProductEntry.COL_STOCK_COUNT + ", " +
                ProductEntry.COL_IMAGE + ", " +
                ProductEntry.COL_DELETED + ") VALUES (" + 
                product.SellerID + ", " +
                "'" + product.Name + "', " +
                product.Price + ", " +
                "'" + product.Category + "', " +
                "'" + product.Description + "', " +
                product.StockCount + ", " +
                "'" + product.ImagePath + "', " +
                "'" + product.Deleted + "'" + 
                ");";
            
            return DBMan.ExecuteNonQuery(query);
        }

        /* Selects all product categories */
        public DataTable SelectCategories()
        {
            string query = "SELECT " + CategoryEntry.COL_CATEGORY_NAME + " FROM " + CategoryEntry.TABLE_NAME + ";";
            return DBMan.ExecuteReader(query);
        }
    }
}
