using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeliveryMarket.Data.MarketContract;

namespace DeliveryMarket.Product {

	public partial class FormBuyProduct : Form {
		// Messages
		private const string INVALID_INPUT_TITLE = "Invalid Description";
		private const string INVALID_INPUT_MSG = "Please make sure to write your address correctly";
		private const string BUY_SUCCESS_TITLE = "Done";
		private const string BUY_SUCCESS_MSG = "The product was bought successfully";
		private const string BUY_FAILED_TITLE = "Error";
		private const string BUY_FAILED_MSG = "An error occured will buying this product";
		private const string CONFIRMATION_TITLE = "Buy";
		private const string CONFIRMATION_MSG = "Are you sure want to buy this product?";

		// Member variables
		private int mAccountID;
		private int mProductID;
		private string mProductName;
		private int mProductPrice;
		private ProductController mController;

		/* Constructor */
		public FormBuyProduct(int accountID, int productID) {
			InitializeComponent();

			mAccountID = accountID;
			mProductID = productID;
			mController = new ProductController();
		}

		/* Form load callback function */
		private void FormBuyProduct_Load(object sender, EventArgs e) {
			DataRow product = mController.SelectProductInfo(mProductID);
			mProductName = product[ProductEntry.COL_PRODUCT_NAME].ToString();
			labelProductName.Text = mProductName;
			mProductPrice = Convert.ToInt32(product[ProductEntry.COL_PRICE]);
			labelPrice.Text = "Price: " + mProductPrice.ToString() + "$";
			numericQuantity.Maximum = Convert.ToDecimal(product[ProductEntry.COL_QUANTITY]);

			comboBoxTransaction.DataSource = mController.SelectTransactionCompanies();
			comboBoxTransaction.DisplayMember = TransactionCompanyEntry.COL_COMPANY_NAME;
			comboBoxTransaction.ValueMember = TransactionCompanyEntry.COL_COMPANY_ID;

			comboBoxTransport.DataSource = mController.SelectTransportCompanies();
			comboBoxTransport.DisplayMember = TransportCompanyEntry.COL_COMPANY_NAME;
			comboBoxTransport.ValueMember = TransportCompanyEntry.COL_COMPANY_ID;
		}

		/* Buy button clicked callback function */
		private void buttonBuy_Click(object sender, EventArgs e) {
			string address = textBoxAddress.Text.Replace("'", "''").Trim();

			// Check for validation
			if (address == "") {
				MessageBox.Show(INVALID_INPUT_MSG, INVALID_INPUT_TITLE, MessageBoxButtons.OK);
				return;
			}

			// Ask for confirmation
			if (MessageBox.Show(CONFIRMATION_MSG, CONFIRMATION_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
				return;
			}

			Order order = new Order();
			order.CustomerID = mAccountID;
			order.ProductID = mProductID;
			order.ProductName = mProductName;
			order.ProductPrice = mProductPrice;
			order.Quantity = Convert.ToInt32(numericQuantity.Value);
			order.Address = address;
			order.TransactionCompanyID = Convert.ToInt32(comboBoxTransaction.SelectedValue);
			order.TransportCompanyID = Convert.ToInt32(comboBoxTransport.SelectedValue);

			// Delete product
			if (mController.BuyProduct(order) > 0) {
				MessageBox.Show(BUY_SUCCESS_MSG, BUY_SUCCESS_TITLE, MessageBoxButtons.OK);

				if (Owner.GetType() == typeof(FormProductList)) {
					((FormProductList)Owner).LoadProduct();
				}
				else if (Owner.GetType() == typeof(FormProductDetail)) {
					((FormProductDetail)Owner).LoadProduct();
				}

				Close();
			}
			else {
				MessageBox.Show(BUY_FAILED_MSG, BUY_FAILED_TITLE, MessageBoxButtons.OK);
			}
		}

		/* Cancel button clicked callback function */
		private void buttonCancel_Click(object sender, EventArgs e) {
			Close();
		}
	}
}