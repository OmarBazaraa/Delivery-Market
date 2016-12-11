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
using DeliveryMarket.Utils.Defs;

namespace DeliveryMarket.Product {

	public partial class FormProductDetail : Form {
		// Messages
		private const string LOADING_PRODUCT_FAILED_TITLE = "Error";
		private const string LOADING_PRODUCT_FAILED_MSG = "An error occured will loading the product";
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
		private int mSellerID;
		private int mProductID;
		private Privilege mPrivilege;
		private ProductController mController;

		/* Constructor */
		public FormProductDetail(int accountID, int productID, Privilege privilege) {
			InitializeComponent();

			mAccountID = accountID;
			mProductID = productID;
			mPrivilege = privilege;
			mController = new ProductController();
		}

		/* Form load callback function */
		private void FormProductDetail_Load(object sender, EventArgs e) {
			LoadProductDetails();
		}

		/* Load the details of the given product */
		private void LoadProductDetails() {
			DataRow product = mController.SelectProductDetails(mProductID);

			if (product == null) {
				MessageBox.Show(LOADING_PRODUCT_FAILED_MSG, LOADING_PRODUCT_FAILED_TITLE, MessageBoxButtons.OK);
				//Owner.Show();
				//Owner.Refresh();
				//Close();
				return;
			}

			mSellerID = Convert.ToInt32(product[ProductEntry.COL_SELLER_ID]);

			textProductName.Text = product[ProductEntry.COL_PRODUCT_NAME].ToString();
			textCategory.Text = product[ProductEntry.COL_CATEGORY].ToString();
			linkSeller.Text = product[ProductEntry.COL_SELLER_NAME].ToString();
			labelRating.Text = product[ProductEntry.COL_RATING].ToString() + "/5.0";
			textPrice.Text = "Price: " + product[ProductEntry.COL_PRICE].ToString() + "$";
			textStock.Text = "In Stock: " + product[ProductEntry.COL_STOCK_COUNT].ToString();
			textDescription.Text = product[ProductEntry.COL_DESCRIPTION].ToString();
			pictureBox1.ImageLocation = product[ProductEntry.COL_IMAGE].ToString();

			LoadComments();
		}

		/* Loads the comments of the given product */
		private void LoadComments() {
			DataTable dt = mController.SelectComments(mProductID);
			dataGridView1.DataSource = dt;
			dataGridView1.Refresh();
		}

		private void button1_Click(object sender, EventArgs e) {
			string comment = textBoxComment.Text.Replace("'", "''").Trim();

			if (comment != "") {
				mController.InsertComment(mAccountID, mProductID, comment);
				LoadComments();
			}
		}

		private void buttonEdit_Click(object sender, EventArgs e) {
			new FormSaveProduct(mAccountID, mProductID).Show(this);
		}

		private void button2_Click(object sender, EventArgs e) {
			int ratingValue = 0;

			if (radioButton1.Checked)
				ratingValue = 1;
			if (radioButton2.Checked)
				ratingValue = 2;
			if (radioButton3.Checked)
				ratingValue = 3;
			if (radioButton4.Checked)
				ratingValue = 4;
			if (radioButton5.Checked)
				ratingValue = 5;

			if (ratingValue != 0) {
				mController.InsertRating(mAccountID, mProductID, ratingValue);
				LoadProductDetails();
			}
		}

		private void buttonDelete_Click(object sender, EventArgs e) {
			new FormRemoveProduct(mAccountID, mProductID).ShowDialog(this);
		}

		private void buttonReport_Click(object sender, EventArgs e) {
			new FormReportProduct(mAccountID, mProductID).ShowDialog(this);
		}
	}
}
