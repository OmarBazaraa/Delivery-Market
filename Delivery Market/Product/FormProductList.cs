using System;
using System.Data;
using System.Windows.Forms;
using DeliveryMarket.Data.MarketContract;
using DeliveryMarket.Utils.Defs;

namespace DeliveryMarket.Product {

	public partial class FormProductList : Form {
		// Messages
		private const string LABEL_CATEGORY_ALL = "All";
		private const string LABEL_PRICE = "Price: ";
		private const string LABEL_BY = "By ";
		private const string LABEL_QUANTITY = "Quantity: ";
		private const string LOADING_PRODUCT_FAILED_MSG = "An error occured while loading the product";
		private const string RATING_FAILED_MSG = "An error occured while posting your rating";
		private const string COMMENT_FAILED_MSG = "An error occured while posting your comment";
		private const string EMPTY_STOCK_MSG = "The stock is empty now\n Please check back later";
		private const string DELETE_COMMENT_FAILED_MSG = "An error occured while deleting this comment";
		private const string CONFIRMATION_MSG = "Are you sure want to delete this comment?";
		private const string LOGIN_MSG = "Please log in first";

		// Member variables
		private int mAccountID;
		private int mSellerID;                  // To be set when we want to display only the products of a certain seller
		private int mProductID;
		private Privilege mPrivilege;
		private DataRow mProductDetails;
		private DataTable mProductComments;
		private DataTable mProductsData;
		private ProductController mController;

		// Product List sorting variables
		private bool mSortAsc = true;
		private int mSortedColumnIdx = 1;
		private string mSortedColumn = ProductEntry.COL_PRODUCT_NAME;

		// Other variables
		private bool mIsBackPressed = false;

		/* Constructor */
		public FormProductList(Privilege privilege, int accountID, int sellerID = -1) {
			InitializeComponent();

			mAccountID = accountID;
			mSellerID = sellerID;
			mPrivilege = privilege;
			mController = new ProductController();
		}

		/* Form load callback function */
		private void FormProductList_Load(object sender, EventArgs e) {
			// Fill product categories
			DataTable dt = mController.SelectCategories();

			// No data
			if (dt == null) {
				return;
			}

			DataRow row = dt.NewRow();
			row[CategoryEntry.COL_CATEGORY_NAME] = LABEL_CATEGORY_ALL;
			dt.Rows.InsertAt(row, 0);
			comboBoxCategory.DataSource = dt;
			comboBoxCategory.DisplayMember = CategoryEntry.COL_CATEGORY_NAME;
			
			PopulateProductList();
		}

		/* Form closed callback function */
		private void FormProductList_FormClosed(object sender, FormClosedEventArgs e) {
			if (e.CloseReason == CloseReason.UserClosing && !mIsBackPressed) {
				Owner.Close();
			}
		}

		/* Product list selected item changed callback function */
		private void listViewProducts_SelectedIndexChanged(object sender, EventArgs e) {
			if (listViewProducts.SelectedItems.Count == 0) {
				return;
			}

			int idx = listViewProducts.SelectedItems[0].Index;
			mProductID = Convert.ToInt32(mProductsData.Rows[idx][ProductEntry.COL_PRODUCT_ID]);

			LoadProduct();
		}

		/* Product list item double clicked callback function */
		private void listViewProducts_MouseDoubleClick(object sender, MouseEventArgs e) {
			if (listViewProducts.Items.Count == 0) {
				return;
			}

			int idx = listViewProducts.SelectedItems[0].Index;
			int productID = Convert.ToInt32(mProductsData.Rows[idx][ProductEntry.COL_PRODUCT_ID]);
			new FormProductDetail(mPrivilege, mAccountID, productID).Show(this);
		}

		/* Product list column header clicked callback function */
		private void listViewProducts_ColumnClick(object sender, ColumnClickEventArgs e) {
			if (e.Column == mSortedColumnIdx) {
				mSortAsc = !mSortAsc;
				PopulateProductList();
				return;
			}

			switch (e.Column) {
				case 0:
					mSortedColumn = ProductEntry.COL_PRODUCT_NAME;
					break;
				case 1:
					mSortedColumn = ProductEntry.COL_SELLER_NAME;
					break;
				case 2:
					mSortedColumn = ProductEntry.COL_RATING;
					break;
				case 3:
					mSortedColumn = ProductEntry.COL_PRICE;
					break;
			}

			mSortAsc = true;
			mSortedColumnIdx = e.Column;
			PopulateProductList();
		}

		/* Search bar text changed callback function */
		private void textBoxSearch_TextChanged(object sender, EventArgs e) {
			PopulateProductList();
		}

		/* Category box item changed callback function */
		private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e) {
			PopulateProductList();
		}

		/* Seller button clicked callback function */
		private void linkSeller_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			int sellerID = Convert.ToInt32(mProductDetails[ProductEntry.COL_SELLER_ID]);
			new Account.FormProfile(mAccountID, sellerID, mPrivilege).ShowDialog();
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
			new FormSaveProduct(mAccountID, mProductID).ShowDialog(this);
		}

		/* Add new product button clicked callback function */
		private void buttonAddProduct_Click(object sender, EventArgs e) {
			if (mPrivilege == Privilege.Other) {
				MessageBox.Show(LOGIN_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			new FormSaveProduct(mAccountID).ShowDialog(this);
		}

		/* Back button clicked callback function */
		private void buttonBack_Click(object sender, EventArgs e) {
			mIsBackPressed = true;

			Owner.Show();
			Close();
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

		/* Comments list view key pressed callback function */
		private void listViewComments_KeyPress(object sender, KeyPressEventArgs e) {
			if (e.KeyChar != (char)Keys.Back) {
				return;
			}

			if (listViewComments.SelectedItems.Count == 0) {
				return;
			}

			int idx = listViewComments.SelectedItems[0].Index;
			int commentID = Convert.ToInt32(mProductComments.Rows[idx][CommentEntry.COL_COMMENT_ID]);
            int userID = Convert.ToInt32(mProductComments.Rows[idx][CommentEntry.COL_USER_ID]);

            if (mPrivilege != Privilege.Admin && userID != mAccountID) {
				return;
			}

			// Ask for confirmation
			if (MessageBox.Show(CONFIRMATION_MSG, Strings.APP_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
				return;
			}

			// Delete comment
			if (mController.DeleteComment(commentID) > 0) {
				LoadComments();
			}
			else {
				MessageBox.Show(DELETE_COMMENT_FAILED_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				textBoxComment.Text = "";
			}
			else {
				MessageBox.Show(COMMENT_FAILED_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		/* Selects products from the database and insert them in the list view */
		public void PopulateProductList() {
			listViewProducts.Items.Clear();

			string name = textBoxSearch.Text.Replace("'", "''").Trim();
			string category = comboBoxCategory.SelectedIndex == 0 ? "" : comboBoxCategory.Text;

			mProductsData = mController.SelectProductList(mSellerID, name, category, mSortedColumn, mSortAsc);

			// No data
			if (mProductsData == null) {
				labelEmptyProducts.BringToFront();
				labelEmptyProducts.Visible = true;
				return;
			}

			foreach (DataRow row in mProductsData.Rows) {
				ListViewItem item = new ListViewItem(row[ProductEntry.COL_PRODUCT_NAME].ToString());
				item.SubItems.Add(row[ProductEntry.COL_SELLER_NAME].ToString());

				decimal rating = Convert.ToDecimal(row[ProductEntry.COL_RATING]);
				item.SubItems.Add(Math.Round(rating, 2).ToString());
				
				decimal price = Convert.ToDecimal(row[ProductEntry.COL_PRICE]);
				item.SubItems.Add(Math.Round(price, 2).ToString());

				listViewProducts.Items.Add(item);
			}

			if (listViewProducts.Items.Count > 0) {
				labelEmptyProducts.Visible = false;
				listViewProducts.Items[0].Selected = true;
			}
		}

		/* Loads all the contents of a product */
		public void LoadProduct() {
			LoadProductDetails();
			LoadComments();
			LoadCustomerRating();
			AdaptForm();
		}

		/* Loads the details of the given product */
		private void LoadProductDetails() {
			mProductDetails = mController.SelectProductDetails(mProductID);

			if (mProductDetails == null) {
				MessageBox.Show(LOADING_PRODUCT_FAILED_MSG, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			labelProductName.Text = mProductDetails[ProductEntry.COL_PRODUCT_NAME].ToString();
			labelCategory.Text = mProductDetails[ProductEntry.COL_CATEGORY].ToString();
			linkSeller.Text = LABEL_BY + mProductDetails[ProductEntry.COL_SELLER_NAME].ToString();

			decimal rating = Convert.ToDecimal(mProductDetails[ProductEntry.COL_RATING]);
			labelRating.Text = Math.Round(rating, 2).ToString();

			decimal price = Convert.ToDecimal(mProductDetails[ProductEntry.COL_PRICE]);
			labelPrice.Text = LABEL_PRICE + Math.Round(price, 2).ToString();

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
			else {
				trackBarRating.Value = 1;
			}
		}

		/* Adapts the form to the currently active user */
		private void AdaptForm() {
			int sellerID = Convert.ToInt32(mProductDetails[ProductEntry.COL_SELLER_ID]);

			if (mAccountID != sellerID) {
				buttonEdit.Visible = false;
				buttonDelete.Visible = false;
			}
            else {
                buttonEdit.Visible = true;
                buttonDelete.Visible = true;
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