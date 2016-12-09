using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DeliveryMarket
{
    /*
     * A class that controls our application database quries sending and retrival
     */
    public class Controller
    {
        DBManager dbMan;

        /* Constructs a new controller object */
        public Controller()
        {
            dbMan = new DBManager();
        }
        
        /* Destructor */
        ~Controller()
        {
            dbMan.CloseConnection();
        }

        /* Dummy function for testing database connection */
        public DataTable TestQuery()
        {
            // No hardcoded strings PLEASE! ^_^
            string query = "SELECT * FROM product;";
            return dbMan.ExecuteReader(query);
        }
    }
}
