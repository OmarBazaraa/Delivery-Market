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

	public partial class FormProductList : Form {

		// Member variables
		private int mAccountID;
		private Privilege mPrivilege;
		private DataTable mProductsData;
		private ProductController mController;

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
			comboBoxCategory.DataSource = mController.SelectCategories();
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

		/* Search button clicked callback function */
		private void buttonSearch_Click(object sender, EventArgs e) {
			PopulateProductList();
		}

		/* Selects products from the database and insert them in the list view */
		private void PopulateProductList() {
			listProducts.Items.Clear();

			mProductsData = mController.SelectProductList(textBoxSearch.Text, comboBoxCategory.Text);

			foreach (DataRow row in mProductsData.Rows) {
				ListViewItem item = new ListViewItem(row[ProductEntry.COL_PRODUCT_NAME].ToString());
				item.SubItems.Add(row[ProductEntry.COL_SELLER_NAME].ToString());
				item.SubItems.Add(row[ProductEntry.COL_RATING].ToString());
				item.SubItems.Add(row[ProductEntry.COL_PRICE].ToString());

				listProducts.Items.Add(item);
			}
		}

		private void button1_Click(object sender, EventArgs e) {
			if (listProducts.Items.Count == 0) {
				return;
			}
			int idx = listProducts.SelectedItems[0].Index;
			int productID = Convert.ToInt32(mProductsData.Rows[idx][ProductEntry.COL_PRODUCT_ID]);
			new FormProductDetail(mAccountID, productID, mPrivilege).Show(this);
		}
	}
}
