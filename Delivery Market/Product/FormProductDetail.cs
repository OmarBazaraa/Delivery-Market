﻿using System;
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
		private const string LOADING_PRODUCT_FAILED_MSG = "An error occured while loading the product";
		private const string RATING_FAILED_MSG = "An error occured while posting your rating";
		private const string COMMENT_FAILED_MSG = "An error occured while posting your comment";
		private const string EMPTY_STOCK_MSG = "The stock is empty now\n Please check back later";
		private const string LOGIN_MSG = "Please log in first";
		private const string LABEL_PRICE = "Price: ";
		private const string LABEL_QUANTITY = "Quantity: ";
		private const string LABEL_BY = "By ";

		// Member variables
		private int mAccountID;
		private int mProductID;
		private Privilege mPrivilege;
		private DataRow mProductDetails;
		private DataTable mProductComments;
		private ProductController mController;

		/* Constructor */
		public FormProductDetail(Privilege privilege, int accountID, int productID) {
			InitializeComponent();

			mAccountID = accountID;
			mProductID = productID;
			mPrivilege = privilege;
			mController = new ProductController();
		}

		/* Form load callback function */
		private void FormProductDetail_Load(object sender, EventArgs e) {
			LoadProductDetails();
			LoadComments();
			LoadCustomerRating();
			AdaptForm();
		}

		/* Seller button clicked callback function */
		private void linkSeller_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			//TODO: Show seller's profile page
			MessageBox.Show("TODO");
		}

		/* Buy product button clicked callback function */
		private void buttonBuy_Click(object sender, EventArgs e) {
			if (mPrivilege == Privilege.Other) {
				MessageBox.Show(LOGIN_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			int quantity = Convert.ToInt32(mProductDetails[ProductEntry.COL_QUANTITY]);

			if (quantity <= 0) {
				MessageBox.Show(EMPTY_STOCK_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			new FormBuyProduct(mAccountID, mProductID).ShowDialog(this);
		}

		/* Report product button clicked callback function */
		private void buttonReport_Click(object sender, EventArgs e) {
			if (mPrivilege == Privilege.Other) {
				MessageBox.Show(LOGIN_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			new FormReportProduct(mAccountID, mProductID).ShowDialog(this);
		}

		/* Delete product button clicked callback function */
		private void buttonDelete_Click(object sender, EventArgs e) {
			new FormRemoveProduct(mAccountID, mProductID).ShowDialog(this);
		}

		/* Edit product button clicked callback function */
		private void buttonEdit_Click(object sender, EventArgs e) {
			new FormSaveProduct(mAccountID, mProductID).Show(this);
		}

		/* Rating bar value changed callback function */
		private void trackBarRating_ValueChanged(object sender, EventArgs e) {
			if (mController.InsertRating(mAccountID, mProductID, trackBarRating.Value) > 0) {
				LoadProductDetails();
			}
			else {
				MessageBox.Show(RATING_FAILED_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/* Comment text box key pressed callback function */
		private void textBoxComment_KeyPress(object sender, KeyPressEventArgs e) {
			// The pressed key is not Enter key
			if (e.KeyChar != (char)Keys.Enter) {
				return;
			}

			string comment = textBoxComment.Text.Replace("'", "''").Trim();

			// No comment is written
			if (comment == "") {
				return;
			}

			if (mController.InsertComment(mAccountID, mProductID, comment) > 0) {
				LoadComments();
			}
			else {
				MessageBox.Show(COMMENT_FAILED_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/* Loads the details of the given product */
		private void LoadProductDetails() {
			mProductDetails = mController.SelectProductDetails(mProductID);

			if (mProductDetails == null) {
				MessageBox.Show(LOADING_PRODUCT_FAILED_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
				Owner.Show();
				Owner.Refresh();
				Close();
				return;
			}
			
			labelProductName.Text = mProductDetails[ProductEntry.COL_PRODUCT_NAME].ToString();
			labelCategory.Text = mProductDetails[ProductEntry.COL_CATEGORY].ToString();
			linkSeller.Text = LABEL_BY + mProductDetails[ProductEntry.COL_SELLER_NAME].ToString();
			labelRating.Text = mProductDetails[ProductEntry.COL_RATING].ToString();
			labelPrice.Text = LABEL_PRICE + mProductDetails[ProductEntry.COL_PRICE].ToString();
			labelQuantity.Text = LABEL_QUANTITY + mProductDetails[ProductEntry.COL_QUANTITY].ToString();
			textBoxDescription.Text = mProductDetails[ProductEntry.COL_DESCRIPTION].ToString();
			pictureBoxImage.ImageLocation = mProductDetails[ProductEntry.COL_IMAGE].ToString();
		}

		/* Loads the comments of the given product */
		private void LoadComments() {
			listViewComments.Items.Clear();
			
			mProductComments = mController.SelectComments(mProductID);

			// No data
			if (mProductComments == null) {
				return;
			}

			foreach (DataRow row in mProductComments.Rows) {
				ListViewItem item = new ListViewItem(row[CommentEntry.COL_COMMENT_BODY].ToString());
				item.SubItems.Add(row[CommentEntry.COL_USER_NAME].ToString());
				item.SubItems.Add(row[CommentEntry.COL_COMMENT_DATE].ToString());

				listViewComments.Items.Add(item);
			}
		}

		/* Loads the previous rating of the customer to this product */
		private void LoadCustomerRating() {
			int rating = mController.SelectCustomerRating(mAccountID, mProductID);

			if (rating > 0) {
				trackBarRating.Value = rating;
			}
		}

		/* Adapts the form to the currently active user */
		private void AdaptForm() {
			int sellerID = Convert.ToInt32(mProductDetails[ProductEntry.COL_SELLER_ID]);

			if (mAccountID != sellerID) {
				buttonEdit.Visible = false;
				buttonDelete.Visible = false;
			}

			if (mPrivilege == Privilege.Admin) {
				buttonDelete.Visible = true;
			}

			if (mPrivilege == Privilege.Other) {
				trackBarRating.Enabled = false;
				textBoxComment.Enabled = false;
			}
		}

		/* Loses buttons focus */
		private void LoseFocus(object sender, EventArgs e) {
			labelProductName.Focus();
		}
	}
}
