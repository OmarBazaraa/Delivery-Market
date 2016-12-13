using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryMarket.Product {

	public class Product {

		public int ID;
		public int SellerID;
		public string Name;
		public double Price;
		public string Category;
		public string Description;
		public int Quantity;
		public string ImagePath;
		public bool Deleted;
		public DateTime Date;
	}
}