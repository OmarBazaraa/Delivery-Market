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

	public partial class FormSaveProduct : Form {
		// Messages
		private const string LOADING_PRODUCT_FAILED_TITLE = "Error";
		private const string LOADING_PRODUCT_FAILED_MSG = "An error occured will loading your product";
		private const string INVALID_INPUT_TITLE = "Invalid Inputs";
		private const string INVALID_INPUT_NAME_MSG = "Please make sure that product name is not null";
		private const string INSERTION_SUCCESS_TITLE = "Done";
		private const string INSERTION_SUCCESS_MSG = "Your product was inserted successfully";
		private const string INSERTION_FAILED_TITLE = "Error";
		private const string INSERTION_FAILED_MSG = "An error occured will inserting your product";
		private const string UPDATE_SUCCESS_TITLE = "Done";
		private const string UPDATE_SUCCESS_MSG = "Your product was updated successfully";
		private const string UPDATE_FAILED_TITLE = "Error";
		private const string UPDATE_FAILED_MSG = "An error occured will updating your product";
		private const string CONFIRMATION_TITLE = "Save";
		private const string CONFIRMATION_MSG = "Are you sure want to save your product?";

		// Member variables
		private int mAccountID;
		private int mProductID;
		private ProductController mController;

		/* Constructor */
		public FormSaveProduct(int accountID, int productID = -1) {
			InitializeComponent();

			mAccountID = accountID;
			mProductID = productID;
			mController = new ProductController();
		}

		/* Form load callback function */
		private void FormSaveProduct_Load(object sender, EventArgs e) {
			// Fill product categories
			comboBoxCategory.DataSource = mController.SelectCategories();
			comboBoxCategory.DisplayMember = CategoryEntry.COL_CATEGORY_NAME;

			// Load product details if given
			if (mProductID > -1) {
				DataRow product = mController.SelectProductInfo(mProductID);

				if (product == null) {
					MessageBox.Show(LOADING_PRODUCT_FAILED_MSG, LOADING_PRODUCT_FAILED_TITLE, MessageBoxButtons.OK);
					//Owner.Show();
					//Owner.Refresh();
					//Close();
					return;
				}

				textBoxName.Text = product[ProductEntry.COL_PRODUCT_NAME].ToString();
				comboBoxCategory.Text = product[ProductEntry.COL_CATEGORY].ToString();
				numericPrice.Value = Convert.ToDecimal(product[ProductEntry.COL_PRICE].ToString());
				numericStockCount.Value = Convert.ToDecimal(product[ProductEntry.COL_QUANTITY].ToString());
				textBoxDescription.Text = product[ProductEntry.COL_DESCRIPTION].ToString();
				pictureBoxImage.ImageLocation = product[ProductEntry.COL_IMAGE].ToString();
			}
		}

		/* Form closed callback function */
		private void FormSaveProduct_FormClosed(object sender, FormClosedEventArgs e) {
			if (e.CloseReason == CloseReason.UserClosing) {
				Owner.Show();
				Owner.Refresh();
			}
		}

		/* Save product button clicked callback function */
		private void buttonSave_Click(object sender, EventArgs e) {
			// Check for input validity
			if (!ValidateInput()) {
				return;
			}

			Product product = new Product();
			product.ID = mProductID.ToString();
			product.SellerID = mAccountID.ToString();
			product.Name = textBoxName.Text.Replace("'", "''");
			product.Price = numericPrice.Value.ToString();
			product.Category = comboBoxCategory.Text;
			product.Description = textBoxDescription.Text.Replace("'", "''");
			product.StockCount = numericStockCount.Value.ToString();
			product.ImagePath = System.Text.RegularExpressions.Regex.Escape(textBoxImagePath.Text);

			// Ask for confirmation
			if (MessageBox.Show(CONFIRMATION_MSG, CONFIRMATION_TITLE, MessageBoxButtons.YesNo) == DialogResult.No) {
				return;
			}

			// Save product
			if (mProductID == -1) {
				// Insert
				if (mController.InsertProduct(product) > 0) {
					MessageBox.Show(INSERTION_SUCCESS_MSG, INSERTION_SUCCESS_TITLE, MessageBoxButtons.OK);
					Owner.Show();
					Close();
				}
				else {
					MessageBox.Show(INSERTION_FAILED_MSG, INSERTION_FAILED_TITLE, MessageBoxButtons.OK);
				}
			}
			else {
				// Update
				if (mController.UpdateProduct(product) > 0) {
					MessageBox.Show(UPDATE_SUCCESS_MSG, UPDATE_SUCCESS_TITLE, MessageBoxButtons.OK);
					Owner.Show();
					Close();
				}
				else {
					MessageBox.Show(UPDATE_FAILED_MSG, UPDATE_FAILED_TITLE, MessageBoxButtons.OK);
				}
			}
		}

		/* Select image button clicked callback function */
		private void buttonSelectImage_Click(object sender, EventArgs e) {
			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				textBoxImagePath.Text = openFileDialog.FileName;
				pictureBoxImage.ImageLocation = openFileDialog.FileName;
			}
		}

		/* Cancel button clicked callback function */
		private void buttonCancel_Click(object sender, EventArgs e) {
			Owner.Show();
			Owner.Refresh();
			Close();
		}

		/* Checks if user inputs are valid or not */
		private bool ValidateInput() {
			if (textBoxName.Text == "") {
				MessageBox.Show(INVALID_INPUT_NAME_MSG, INVALID_INPUT_TITLE, MessageBoxButtons.OK);
				return false;
			}

			//TODO: validate escape character in text boxes

			return true;
		}
	}
}