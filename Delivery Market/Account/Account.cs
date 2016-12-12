using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DeliveryMarket.Data.MarketContract;

namespace DeliveryMarket.Account
{
    class User
    {
        public string AccountID;
        public string FirstName;
        public string LastName;
        public string Country;
        public string City;
        public string Email;
        public string Birthdate;
        public string Gender;
        public string MobileNumber;
        public string CreationDate;
		public string Rating;
		public string ProductsCount;
		public string OrdersCount;
		public string EarnedMoney;	
		public User(DataRow dr) {
			AccountID = dr[AccountEntry.COL_ACCOUNT_ID].ToString();
			FirstName = dr[AccountEntry.COL_FIRST_NAME].ToString();
			LastName = dr[AccountEntry.COL_LAST_NAME].ToString();
			Country = dr[AccountEntry.COL_COUNTRY].ToString();
			City = dr[AccountEntry.COL_CITY].ToString();
			Email = dr[AccountEntry.COL_EMAIL].ToString();
			Birthdate = dr[AccountEntry.COL_BIRTHDATE].ToString();
			Gender = dr[AccountEntry.COL_GENDER].ToString();
			MobileNumber = dr[AccountEntry.COL_MOBILE_NUMBER].ToString();
			CreationDate = dr[AccountEntry.COL_CREATION_DATE].ToString();
			Rating = dr[UserEntry.DER_RATING].ToString();
			ProductsCount = dr[UserEntry.DER_PRODUCTS_COUNT].ToString();
			OrdersCount = dr[UserEntry.DER_ORDERS_COUNT].ToString();
			EarnedMoney = dr[UserEntry.DER_EARNED_MONEY].ToString();
		}

	}

	class UserList {
		
		public string[] Name;
		public string[] MobileNumber;
		public string[] AccountID;
		public string[] Country;
		public int ListItemsCount;
		public UserList(DataTable dt) {
			ListItemsCount = 0;
			Name = new string[dt.Rows.Count];
			MobileNumber = new string[dt.Rows.Count];
			AccountID = new string[dt.Rows.Count];
			Country = new string[dt.Rows.Count];
			foreach (DataRow row in dt.Rows) {
				Name[ListItemsCount] = row[AccountEntry.COL_FIRST_NAME].ToString() + row[AccountEntry.COL_LAST_NAME].ToString();
				MobileNumber[ListItemsCount] = row[AccountEntry.COL_MOBILE_NUMBER].ToString();
				AccountID[ListItemsCount] = row[AccountEntry.COL_ACCOUNT_ID].ToString();
				Country[ListItemsCount] = row[AccountEntry.COL_COUNTRY].ToString();
				ListItemsCount++;
			}
		}
	}
}
