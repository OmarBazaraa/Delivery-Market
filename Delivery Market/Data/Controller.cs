using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DeliveryMarket.Data {

	/*
     * A class that controls our application database queries sending and retrival
     */
	public class Controller {

		protected DBManager DBMan;

		/* Constructs a new controller object */
		public Controller() {
			DBMan = new DBManager();
		}

		/* Destructor */
		~Controller() {
			DBMan.CloseConnection();
		}
                        public int InsertUser(string username, string password, string first_name, string last_name, string birthdate, char gender, string mobile_number, string country, string city)
                        {
                            string query = "INSERT INTO account (username, password, first_name, last_name, birthdate, gender, mobile_number, country, city, account_type)" +
                                            "Values ('" + username + "','" + password + "','" + first_name + "','" + last_name + "','" + birthdate + "','" + gender + "','" + mobile_number + "','" + country + "','" + city + "','Active');";
                            Console.WriteLine(query);
                            return DBMan.ExecuteNonQuery(query);
                        }

                        public int CheckPassword_Basic(string username, string password)
                        {
                            //Query the DB to check for username/password
                            string query = "SELECT account_id from account where username = '" + username + "' and password='" + password + "';";
                            object p = DBMan.ExecuteScalar(query);
                            if (p == null) return 0;
                            else return (int)p;
                        }
                        public void TerminateConnection()
                        {
                            DBMan.CloseConnection();
                        }
	}
}