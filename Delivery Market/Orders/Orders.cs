using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeliveryMarket.Data;
using DeliveryMarket.Data.MarketContract;

namespace DeliveryMarket.Orders {
	public partial class FormOrders : Form {
		private OrderController mController;
		int mAccountID;
		DataTable mOrdersData;
		DataRow mSelectedOrder;

		public FormOrders(int accountID) {
			InitializeComponent();
			mController = new OrderController();
			mAccountID = accountID;
			mOrdersData = null;
			mSelectedOrder = null;
		}

		private void listOrders_SelectedIndexChanged(object sender, EventArgs e) {
			if (listOrders.Items.Count == 0) {
				return;
			}
			int idx = listOrders.SelectedItems[0].Index;
			mSelectedOrder = mController.SelectOrder(mOrdersData.Rows[idx][OrderEntry.COL_ORDER_ID].ToString());
			populateDetails();
		}

		private void listOrders_MouseDoubleClick(object sender, MouseEventArgs e) {
			if (listOrders.Items.Count == 0) {
				return;
			}
			int idx = listOrders.SelectedItems[0].Index;
			mSelectedOrder = mController.SelectOrder(mOrdersData.Rows[idx][OrderEntry.COL_ORDER_ID].ToString());
			populateDetails();
		}

		private void populateList() {
			if (mOrdersData == null) return;
			listOrders.Items.Clear();
			foreach (DataRow row in mOrdersData.Rows) {
				ListViewItem listViewItem = new ListViewItem(row[OrderEntry.COL_PRODUCT_NAME].ToString());
				listViewItem.SubItems.Add(row[OrderEntry.COL_PRODUCT_PRICE].ToString());
				listViewItem.SubItems.Add(row[OrderEntry.COL_QUANTITY].ToString());
				listOrders.Items.Add(listViewItem);
			}
		}

		private void populateDetails() {
			if (mSelectedOrder == null) return;
			textUserName.Text = mSelectedOrder[AccountEntry.COL_USERNAME].ToString();
			textProductName.Text = mSelectedOrder[OrderEntry.COL_PRODUCT_NAME].ToString();
			textPrice.Text = mSelectedOrder[OrderEntry.COL_PRODUCT_PRICE].ToString();
			textQuantity.Text = mSelectedOrder[OrderEntry.COL_QUANTITY].ToString();
			textTransactionCompany.Text = mSelectedOrder[TransactionCompanyEntry.COL_COMPANY_NAME].ToString();
			textTransportCompany.Text = mSelectedOrder[TransportCompanyEntry.COL_COMPANY_NAME].ToString();
			textOrderDate.Text = mSelectedOrder[OrderEntry.COL_ORDER_DATE].ToString();
			textAddress.Text = mSelectedOrder[OrderEntry.COL_ADDRESS].ToString();
		}

		private void FormOrders_Load(object sender, EventArgs e) {
			mOrdersData = mController.SelectAllOrders(mAccountID.ToString());
			populateList();
			textOrdersCount.Text = listOrders.Items.Count.ToString();
			if (listOrders.Items.Count == 0) return;			
			mSelectedOrder = mController.SelectOrder(mOrdersData.Rows[0][OrderEntry.COL_ORDER_ID].ToString());
			populateDetails();
		}
	}
}
