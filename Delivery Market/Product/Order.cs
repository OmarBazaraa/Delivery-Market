using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryMarket.Product {

	class Order {

		public int CustomerID;
		public int ProductID;
		public string ProductName;
		public double ProductPrice;
		public int Quantity;
		public string Address;
		public int TransactionCompanyID;
		public int TransportCompanyID;
	}
}