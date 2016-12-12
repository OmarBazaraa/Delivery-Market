using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryMarket.Account
{
	class BannedUser
	{
		public string UserID;
		public string Reason;
		public string Description;
		public string AdminID;
		public string Date;
		public BannedUser() {
			Date = DateTime.Now.ToString("yyyy/MM/dd");
		}
	}
}
