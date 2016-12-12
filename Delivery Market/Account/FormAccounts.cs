using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryMarket.Account
{
    public partial class FormAccounts : Form
    {
		private AccountController mController;
		int mAccountID;
		UserList list;
		public FormAccounts(int accountID)
        {
            InitializeComponent();

			this.mAccountID = accountID;
			mController = new AccountController();
			DataTable dt = mController.SelectAllAccounts();
			if (dt == null) return;
			list = new UserList(dt);

			ListViewItem[] l = new ListViewItem[list.ListItemsCount];
			for (int i = 0; i < list.ListItemsCount; ++i) {
				l[i] = new ListViewItem(list.Name[i]);
				l[i].SubItems.Add(list.MobileNumber[i]);
				l[i].SubItems.Add(list.Country[i]);
				listViewAccounts.Items.Add(l[i]);
			}

			DataRow dr = mController.SelectAccount(list.AccountID[0]);
			User user = new User(dr);
		}

		private void listViewAccounts_SelectedIndexChanged(object sender, EventArgs e) {

		}
	}
}
