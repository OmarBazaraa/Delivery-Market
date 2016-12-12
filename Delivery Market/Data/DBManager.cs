using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace DeliveryMarket.Data {

	/*
     * A class that manages interactions with database systems
     */
	public class DBManager {

		// Messages constant
		public const string DB_CONNECTION_SUCCESS = "Database connection is opened successfully";
		public const string DB_CONNECTION_FAILED = "Failed to connect to the database server";

		// MySQL database connection
		MySqlConnection mConnection;

		/* Starts a connection to the given database connection string */
		public DBManager() {
			string connectionStr = Properties.Settings.Default.MarketConnStr;
			mConnection = new MySqlConnection(connectionStr);

			try {
				mConnection.Open();
				Console.WriteLine(DB_CONNECTION_SUCCESS);
			}
			catch (Exception ex) {
				Console.WriteLine(DB_CONNECTION_FAILED);
				Console.WriteLine(ex.ToString());
			}
		}

		/* Excutes a non query command such as insert, update and delete and returns the number of affected rows */
		public int ExecuteNonQuery(string query) {
			try {
				MySqlCommand command = new MySqlCommand(query, mConnection);
				return command.ExecuteNonQuery();
			}
			catch (Exception ex) {
				Console.WriteLine(ex.Message);
				return -1;
			}
		}

		/* Excutes a query having its result as a table */
		public DataTable ExecuteReader(string query) {
			try {
				MySqlCommand command = new MySqlCommand(query, mConnection);
				MySqlDataReader reader = command.ExecuteReader();

				if (reader.HasRows) {
					DataTable dt = new DataTable();
					dt.Load(reader);
					reader.Close();
					return dt;
				}
				else {
					reader.Close();
					return null;
				}
			}
			catch (Exception ex) {
				Console.WriteLine(ex.Message);
				return null;
			}
		}

		/* Excutes a query having its result as a single scaler */
		public object ExecuteScalar(string query) {
			try {
				MySqlCommand command = new MySqlCommand(query, mConnection);
				return command.ExecuteScalar();
			}
			catch (Exception ex) {
				Console.WriteLine(ex.Message);
				return 0;
			}
		}

		/* Closes that connection to the database */
		public void CloseConnection() {
			try {
				mConnection.Close();
			}
			catch (Exception e) {
				Console.WriteLine(e.Message);
			}
		}
	}
}