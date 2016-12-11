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

	public partial class FormProductList : Form {

		// Member variables
		private int mAccountID;
		private ProductController mController;

		/* Constructor */
		public FormProductList(int accountID) {
			InitializeComponent();

			mAccountID = accountID;
			mController = new ProductController();
		}

		/* Form load callback function */
		private void FormProductList_Load(object sender, EventArgs e) {
			// Fill product categories
			comboBoxCategory.DataSource = mController.SelectCategories();
			comboBoxCategory.DisplayMember = CategoryEntry.COL_CATEGORY_NAME;

			dataGridView1.DataSource = mController.SelectProductList();
			dataGridView1.Refresh();
		}

		/* Form closed callback function */
		private void FormProductList_FormClosed(object sender, FormClosedEventArgs e) {
			if (e.CloseReason == CloseReason.UserClosing) {
				Owner.Show();
				Owner.Refresh();
			}
		}

		private void buttonSearch_Click(object sender, EventArgs e) {
			dataGridView1.DataSource = mController.SelectProductList(textBox1.Text, comboBoxCategory.Text);
			dataGridView1.Refresh();
		}
	}
}
