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

	public partial class FormRemoveProduct : Form {
		// Messages
		private const string INVALID_INPUT_TITLE = "Invalid Description";
		private const string INVALID_INPUT_MSG = "Please make sure to write the description";
		private const string DELETE_SUCCESS_TITLE = "Done";
		private const string DELETE_SUCCESS_MSG = "the product was deleted successfully";
		private const string DELETE_FAILED_TITLE = "Error";
		private const string DELETE_FAILED_MSG = "An error occured will deleting this product";
		private const string CONFIRMATION_TITLE = "Delete";
		private const string CONFIRMATION_MSG = "Are you sure want to delete this product?";

		// Member variables
		private int mAccountID;
		private int mProductID;
		private ProductController mController;

		/* Constructor */
		public FormRemoveProduct(int accountID, int productID) {
			InitializeComponent();

			mAccountID = accountID;
			mProductID = productID;
			mController = new ProductController();
		}

		/* Form load callback function */
		private void FormRemoveProduct_Load(object sender, EventArgs e) {
			// TODO: load list of reasons
			comboBoxReasons.DataSource = mController.SelectRemovalReasons();
			comboBoxReasons.DisplayMember = RemovalReasonsEntry.COL_REASON;
		}

		/* Delete button clicked callback function */
		private void buttonDelete_Click(object sender, EventArgs e) {
			string description = textBoxDescription.Text.Replace("'", "''").Trim();

			// Check for validation
			if (description == "") {
				MessageBox.Show(INVALID_INPUT_MSG, INVALID_INPUT_TITLE, MessageBoxButtons.OK);
				return;
			}

			// Ask for confirmation
			if (MessageBox.Show(CONFIRMATION_MSG, CONFIRMATION_TITLE, MessageBoxButtons.YesNo) == DialogResult.No) {
				return;
			}

			// Delete product
			if (mController.DeleteProduct(mAccountID, mProductID, comboBoxReasons.Text, description) > 0) {
				MessageBox.Show(DELETE_SUCCESS_MSG, DELETE_SUCCESS_TITLE, MessageBoxButtons.OK);
				Close();
			}
			else {
				MessageBox.Show(DELETE_FAILED_MSG, DELETE_FAILED_TITLE, MessageBoxButtons.OK);
			}
		}

		/* Cancel button clicked callback function */
		private void buttonCancel_Click(object sender, EventArgs e) {
			Close();
		}
	}
}
