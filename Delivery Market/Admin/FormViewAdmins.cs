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

namespace DeliveryMarket.Admin
{
    public partial class FormViewAdmins : Form
    {
        AdminController mController;
		DataTable mAdminList;

        public FormViewAdmins()
        {
            InitializeComponent();
            mController = new AdminController();

			PopulateListView();
        }

		public void PopulateListView() {
			mAdminList = mController.SelectAdmins(textBoxSearchByName.Text);
			listViewAdmins.Items.Clear();

			if (mAdminList == null) return;
			
			foreach(DataRow row in mAdminList.Rows) {
				ListViewItem item = new ListViewItem(row[AccountEntry.COL_FIRST_NAME].ToString());
				item.SubItems.Add(row[AccountEntry.COL_LAST_NAME].ToString());
				item.SubItems.Add(row[AccountEntry.COL_GENDER].ToString());
				item.SubItems.Add(row[AccountEntry.COL_EMAIL].ToString());
				item.SubItems.Add(row[AccountEntry.COL_MOBILE_NUMBER].ToString());
				item.SubItems.Add(row[AccountEntry.COL_CITY].ToString());
				item.SubItems.Add(row[AdminEntry.COL_START_DATE].ToString());


				listViewAdmins.Items.Add(item);
			}
			
		}

		private void buttonSearch_Click(object sender, EventArgs e) {
			PopulateListView();
		}


		public void FormViewAdmins_FormClosed (object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Owner.Show();
                Owner.Refresh();
            }
        }

		
	}
}
