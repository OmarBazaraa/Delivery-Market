using System;
using System.Data;
using System.Windows.Forms;
using DeliveryMarket.Data.MarketContract;
using DeliveryMarket.Utils.Defs;

namespace DeliveryMarket.Product {

	public partial class FormProductList : Form {
		// Messages
		private const string CATEGORY_ALL = "All";

		// Member variables
		private int mAccountID;
		private Privilege mPrivilege;
		private DataTable mProductsData;
		private ProductController mController;

		// Product List sorting variables
		private bool mSortAsc = true;
		private int mSortedColumnIdx = 1;
		private string mSortedColumn = ProductEntry.COL_PRODUCT_NAME;

		/* Constructor */
		public FormProductList(int accountID, Privilege privilege) {
			InitializeComponent();

			mAccountID = accountID;
			mPrivilege = privilege;
			mController = new ProductController();
		}

		/* Form load callback function */
		private void FormProductList_Load(object sender, EventArgs e) {
			// Fill product categories
			DataTable dt = mController.SelectCategories();
			DataRow row = dt.NewRow();
			row[CategoryEntry.COL_CATEGORY_NAME] = CATEGORY_ALL;
			dt.Rows.InsertAt(row, 0);
			comboBoxCategory.DataSource = dt;
			comboBoxCategory.DisplayMember = CategoryEntry.COL_CATEGORY_NAME;
			
			PopulateProductList();
		}

		/* Form closed callback function */
		private void FormProductList_FormClosed(object sender, FormClosedEventArgs e) {
			if (e.CloseReason == CloseReason.UserClosing) {
				Owner.Show();
				Owner.Refresh();
			}
		}

		/* Product list item double clicked callback function */
		private void listViewProducts_MouseDoubleClick(object sender, MouseEventArgs e) {
			if (listViewProducts.Items.Count == 0) {
				return;
			}

			int idx = listViewProducts.SelectedItems[0].Index;
			int productID = Convert.ToInt32(mProductsData.Rows[idx][ProductEntry.COL_PRODUCT_ID]);
			new FormProductDetail(mAccountID, productID, mPrivilege).Show(this);
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

		/* Selects products from the database and insert them in the list view */
		private void PopulateProductList() {
			listViewProducts.Items.Clear();

			string name = textBoxSearch.Text.Replace("'", "''").Trim();
			string category = comboBoxCategory.SelectedIndex == 0 ? "" : comboBoxCategory.Text;

			mProductsData = mController.SelectProductList(name, category, mSortedColumn, mSortAsc);

			if (mProductsData == null) {
				return;
			}

			foreach (DataRow row in mProductsData.Rows) {
				ListViewItem item = new ListViewItem(row[ProductEntry.COL_PRODUCT_NAME].ToString());
				item.SubItems.Add(row[ProductEntry.COL_SELLER_NAME].ToString());
				item.SubItems.Add(row[ProductEntry.COL_RATING].ToString());
				item.SubItems.Add(row[ProductEntry.COL_PRICE].ToString());

				listViewProducts.Items.Add(item);
			}
		}

		/* Search bar text changed callback function */
		private void textBoxSearch_TextChanged(object sender, EventArgs e) {
			PopulateProductList();
		}

		/* Category box item changed callback function */
		private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e) {
			PopulateProductList();
		}
	}
}