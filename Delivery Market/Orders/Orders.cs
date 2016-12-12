using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryMarket.Orders {
	public partial class Orders : Form {
		private OrderController mController;
		int mAccountID;

		public Orders(int accountID) {
			InitializeComponent();
			mController = new OrderController();
			mAccountID = accountID;
			dataGridOrders.DataSource = mController.SelectAllOrders(mAccountID.ToString());
		}
	}
}
