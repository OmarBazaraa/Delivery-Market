using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryMarket.Product {
	public partial class FormReportProduct : Form {
		// Messages
		private const string INVALID_INPUT_TITLE = "Invalid Description";
		private const string INVALID_INPUT_MSG = "Please make sure to write the description";
		private const string REPORT_SUCCESS_TITLE = "Done";
		private const string REPORT_SUCCESS_MSG = "the report was delivered successfully";
		private const string REPORT_FAILED_TITLE = "Error";
		private const string REPORT_FAILED_MSG = "An error occured will reporting this product";
		private const string CONFIRMATION_TITLE = "Report";
		private const string CONFIRMATION_MSG = "Are you sure want to report this product?";

		// Member variables
		private int mAccountID;
		private int mProductID;
		private ProductController mController;

		/* Constructor */
		public FormReportProduct(int accountID, int productID) {
			InitializeComponent();

			mAccountID = accountID;
			mProductID = productID;
			mController = new ProductController();
		}

		/* Form load callback function */
		private void FormReportProduct_Load(object sender, EventArgs e) {

		}

		/* Delete button clicked callback function */
		private void buttonReport_Click(object sender, EventArgs e) {
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

			// Send report
			if (mController.InsertReport(mAccountID, mProductID, description) > 0) {
				MessageBox.Show(REPORT_SUCCESS_MSG, REPORT_SUCCESS_TITLE, MessageBoxButtons.OK);
				Close();
			}
			else {
				MessageBox.Show(REPORT_FAILED_MSG, REPORT_FAILED_TITLE, MessageBoxButtons.OK);
			}
		}

		/* Cancel button clicked callback function */
		private void buttonCancel_Click(object sender, EventArgs e) {
			Close();
		}
	}
}
