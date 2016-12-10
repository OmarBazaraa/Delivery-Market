using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DeliveryMarket
{
    /*
     * A class that controls our application database queries sending and retrival
     */
    public class Controller
    {
        protected DBManager DBMan;

        /* Constructs a new controller object */
        public Controller()
        {
            DBMan = new DBManager();
        }
        
        /* Destructor */
        ~Controller()
        {
            DBMan.CloseConnection();
        }
    }
}
