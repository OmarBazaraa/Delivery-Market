using System;
using System.Data;
using System.Windows.Forms;
using DeliveryMarket.Data.MarketContract;
using DeliveryMarket.Utils;
using DeliveryMarket.Utils.Defs;

namespace DeliveryMarket.Product {

	public partial class FormSaveProduct : Form {
		// Messages
		private const string LOADING_PRODUCT_FAILED_MSG = "An error occured while loading your product information";
		private const string INVALID_NAME_MSG = "Please make sure to enter a name for your product";
		private const string INVALID_DESCRIPTION_MSG = "Please make sure to enter a description for your product";
		private const string INSERTION_SUCCESS_MSG = "Your product was inserted successfully";
		private const string INSERTION_FAILED_MSG = "An error occured while inserting your product";
		private const string UPDATE_SUCCESS_MSG = "Your product was updated successfully";
		private const string UPDATE_FAILED_MSG = "An error occured while updating your product";
		private const string CONFIRMATION_MSG = "Are you sure want to save your product?";

		// Member variables
		private int mAccountID;
		private int mProductID;
		private ProductController mController;

		private string mImagePath = "";
		private string mNewImagePath = "";

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
					MessageBox.Show(LOADING_PRODUCT_FAILED_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
					Close();
					return;
				}

				textBoxName.Text = product[ProductEntry.COL_PRODUCT_NAME].ToString();
				comboBoxCategory.Text = product[ProductEntry.COL_CATEGORY].ToString();
				numericPrice.Value = Convert.ToDecimal(product[ProductEntry.COL_PRICE].ToString());
				numericQuantity.Value = Convert.ToDecimal(product[ProductEntry.COL_QUANTITY].ToString());
				textBoxDescription.Text = product[ProductEntry.COL_DESCRIPTION].ToString();
				pictureBoxImage.ImageLocation = mNewImagePath = mImagePath = product[ProductEntry.COL_IMAGE].ToString();
			}
		}

		/* Save product button clicked callback function */
		private void buttonSave_Click(object sender, EventArgs e) {
			// Check for input validity
			if (!ValidateInput()) {
				return;
			}

			// Ask for confirmation
			if (MessageBox.Show(CONFIRMATION_MSG, Strings.APP_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
				return;
			}

			Product product = new Product();
			product.ID = mProductID;
			product.SellerID = mAccountID;
			product.Name = textBoxName.Text.Replace("'", "''").Trim();
			product.Price = Convert.ToDouble(numericPrice.Value);
			product.Category = comboBoxCategory.Text;
			product.Description = textBoxDescription.Text.Replace("'", "''").Trim();
			product.Quantity = Convert.ToInt32(numericQuantity.Value);

			// Upload new image to our local system
			if (mImagePath != mNewImagePath) {
				int productID = (mProductID != -1) ? mProductID : mController.SelectLastProductID() + 1;
				product.ImagePath = mNewImagePath = mImagePath = Utility.UploadImage(mNewImagePath, productID).Replace("\\", "\\\\");

			}
			
			// Save product
			if (mProductID == -1) {
				// Insert
				if (mController.InsertProduct(product) > 0) {
					MessageBox.Show(INSERTION_SUCCESS_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);

					if (Owner.GetType() == typeof(FormProductList) || Owner.GetType() == typeof(FormProductDetail)) {
						((FormProductList)Owner).LoadProduct();
					}

					Close();
				}
				else {
					MessageBox.Show(INSERTION_FAILED_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else {
				// Update
				if (mController.UpdateProduct(product) > 0) {
					MessageBox.Show(UPDATE_SUCCESS_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);

					if (Owner.GetType() == typeof(FormProductList)) {
						((FormProductList)Owner).LoadProduct();
					}

					Close();
				}
				else {
					MessageBox.Show(UPDATE_FAILED_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		/* Browse image button clicked callback function */
		private void buttonBrowse_Click(object sender, EventArgs e) {
			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				pictureBoxImage.ImageLocation = mNewImagePath = openFileDialog.FileName;
			}
		}

		/* Cancel button clicked callback function */
		private void buttonCancel_Click(object sender, EventArgs e) {
			Close();
		}

		/* Loses buttons focus */
		private void LoseFocus(object sender, EventArgs e) {
			labelName.Focus();
		}

		/* Checks if user inputs are valid or not */
		private bool ValidateInput() {
			if (textBoxName.Text.Trim() == "") {
				MessageBox.Show(INVALID_NAME_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			if (textBoxDescription.Text.Trim() == "") {
				MessageBox.Show(INVALID_DESCRIPTION_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			return true;
		}
	}
}