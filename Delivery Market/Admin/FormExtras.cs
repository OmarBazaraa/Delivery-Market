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

namespace DeliveryMarket.Admin {
	public partial class FormExtras : Form {
		private const string TYPE_PRODUCT_CATEGORIES = "Product Categories";
		private const string TYPE_REMOVAL_REASONS = "Product Removal Reasons";
		private const string TYPE_BAN_REASONS = "Ban Reasons";
		private const string REMOVAL_FAILED = "Failed to remove, name in use or connection failed !";
		private const int NAME_IDX = 0;

		AdminController mController;
		DataTable mData;
		private string mcolName;
		private string mTableName;


		public FormExtras() {
			InitializeComponent();
			mController = new AdminController();
			InitComboBox();

			PopulateListView();
		}

		void InitComboBox() {
			comboBoxType.Items.Add(TYPE_PRODUCT_CATEGORIES);
			comboBoxType.Items.Add(TYPE_REMOVAL_REASONS);
			comboBoxType.Items.Add(TYPE_BAN_REASONS);

			comboBoxType.SelectedItem = TYPE_PRODUCT_CATEGORIES;
		}

		public void PopulateListView() {
			listView.Items.Clear();

			string type = comboBoxType.Text.ToString();
			if (type == TYPE_PRODUCT_CATEGORIES)
				mData = mController.SelectProductCategories(textBoxSearch.Text.Replace("'", "''").Trim());
			
			else if (type == TYPE_REMOVAL_REASONS)
				mData = mController.SelectRemovalReasons(textBoxSearch.Text.Replace("'", "''").Trim());
			
			else if (type == TYPE_BAN_REASONS)
				mData = mController.SelectBanReasons(textBoxSearch.Text.Replace("'", "''").Trim());

			if (mData == null)
				return;


			foreach (DataRow row in mData.Rows) {
				ListViewItem item = new ListViewItem(row[mcolName].ToString());

				listView.Items.Add(item);
			}
		}


		private void buttonSearch_Click(object sender, EventArgs e) {
			PopulateListView();
		}

		private void buttonAdd_Click(object sender, EventArgs e) {
			var childForm = new FormAddExtra(mTableName);
			childForm.mParent = this;
			childForm.Show(this);
		}

		private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e) {
			string type = comboBoxType.Text.ToString();
			if (type == TYPE_PRODUCT_CATEGORIES) {
				mcolName = CategoryEntry.COL_CATEGORY_NAME;
				mTableName = CategoryEntry.TABLE_NAME;
			}
			else if (type == TYPE_REMOVAL_REASONS) {
				mcolName = ProductRemovalReasonsEntry.COL_REASON;
				mTableName = ProductRemovalReasonsEntry.TABLE_NAME;
			}
			else if (type == TYPE_BAN_REASONS) {
				mcolName = BanReasonsEntry.COL_REASON;
				mTableName = BanReasonsEntry.TABLE_NAME;
			}
			PopulateListView();
		}

		private void buttonRemove_Click(object sender, EventArgs e) {
			if (listView.SelectedItems.Count == 0)
				return;
			string name = listView.SelectedItems[0].SubItems[NAME_IDX].Text.ToString();

			string type = comboBoxType.Text.ToString();
			int ret = 0;
			if (type == TYPE_PRODUCT_CATEGORIES)
				ret = mController.RemoveProductCategory(name);

			else if (type == TYPE_REMOVAL_REASONS)
				ret = mController.RemoveRemovalReason(name);

			else if (type == TYPE_BAN_REASONS)
				ret = mController.RemoveBanReason(name);

			if (ret == -1) {
				MessageBox.Show(REMOVAL_FAILED.Replace("name", name));
				return;
			}
			PopulateListView();
		}


		private void FormExtras_FormClosed(object sender, FormClosedEventArgs e) {
			if (e.CloseReason == CloseReason.UserClosing) {
				Owner.Show();
				Owner.Refresh();
			}
		}

		private void buttonEdit_Click(object sender, EventArgs e) {
			if (listView.SelectedItems.Count == 0)
				return;
			string name = listView.SelectedItems[0].SubItems[NAME_IDX].Text.ToString();

			var childForm = new FormEditExtra(mTableName, name);
			childForm.mParent = this;
			childForm.Show(this);
		}
	}
}
