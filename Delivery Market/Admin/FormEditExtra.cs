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
	public partial class FormEditExtra : Form {
		private const string EDITING_FAILED = "Failed to edit, name already exists or connection failed !";
		string mEditType;
		AdminController mController;
		public FormExtras mParent;
		string mOriginalName;


		public FormEditExtra(string type, string name) {
			InitializeComponent();
			mController = new AdminController();
			mEditType = type;
			mOriginalName = name;
			textBoxName.Text = mOriginalName;
		}

		private void buttonEdit_Click(object sender, EventArgs e) {
			int ret = 0;
			if (mEditType == CategoryEntry.TABLE_NAME)
				ret = mController.EditProductCategory(textBoxName.Text.Replace("'", "''").Trim(), mOriginalName);
			else if (mEditType == ProductRemovalReasonsEntry.TABLE_NAME)
				ret = mController.EditRemovalReason(textBoxName.Text.Replace("'", "''").Trim(), mOriginalName);
			else if (mEditType == BanReasonsEntry.TABLE_NAME)
				ret = mController.EditBanReason(textBoxName.Text.Replace("'", "''").Trim(), mOriginalName);
			if (ret == -1)
				MessageBox.Show(EDITING_FAILED.Replace("name", textBoxName.Text.Replace("'", "''").Trim()));

			mParent.PopulateListView();
			this.Close();
		}
	}
}
