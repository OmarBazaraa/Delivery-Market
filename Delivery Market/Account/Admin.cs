using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryMarket.Account {
	class Admin {
		public string AdminID;
		public string StartDate;
		public Admin() {
			StartDate = DateTime.Now.ToString("yyyy/MM/dd");
		}
	}
}
