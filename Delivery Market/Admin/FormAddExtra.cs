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
	public partial class FormAddExtra : Form {
		private const string ADDING_FAILED = "Failed to add, name already exists or connection failed !";
		string mAddType;
		AdminController mController;
		public FormExtras mParent;

		public FormAddExtra(string type) {
			InitializeComponent();
			mController = new AdminController();
			mAddType = type;
		}

		private void buttonAdd_Click(object sender, EventArgs e) {
			int ret = 0;
			if (mAddType == CategoryEntry.TABLE_NAME)
				ret = mController.AddProductCategory(textBoxName.Text.Replace("'", "''").Trim());
			else if (mAddType == ProductRemovalReasonsEntry.TABLE_NAME)
				ret = mController.AddRemovalReason(textBoxName.Text.Replace("'", "''").Trim());
			else if (mAddType == BanReasonsEntry.TABLE_NAME)
				ret = mController.AddBanReason(textBoxName.Text.Replace("'", "''").Trim());
			if (ret == -1)
				MessageBox.Show(ADDING_FAILED.Replace("name", textBoxName.Text.Replace("'", "''").Trim()));

			mParent.PopulateListView();
			this.Close();
		}
	}
}
