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
	public partial class FormAddCompany : Form {
		string mCompanyType;
		AdminController mController;
		public FormViewCompanies mParent;

		public FormAddCompany(string type) {
			InitializeComponent();
			mController = new AdminController();
			mCompanyType = type;
		}

		private void buttonAdd_Click(object sender, EventArgs e) {
			if (mCompanyType == TransportCompanyEntry.TABLE_NAME.ToString()) {
				mController.AddTransportCompany(textBoxName.Text.Replace("'","''").Trim());
				mParent.PopulateListViewTransportCompany();
			}
			else {
				mController.AddTransactionCompany(textBoxName.Text.Replace("'", "''").Trim());
				mParent.PopulateListViewTransactionCompany();
			}
			this.Close();
		}
	}
}
