using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryMarket.Admin
{
    public partial class FormAddAdmin : Form
    {
		public const string MAKE_ADMIN_FAILED = "Failed to make an Admin with account id = ";
		public const string MAKE_ADMIN_FAILED_MESSAGE = "Failed to make some of the accounts as Admins";
		public const string MAKE_ADMIN_SUCCESS = "The selected accounts have been made Admins";

		AdminController mController;
        public FormAddAdmin()
        {
            InitializeComponent();
			mController = new AdminController();
			ViewAccounts();
        }

		public void ViewAccounts() {
			DataTable mRows = mController.SelectNormalUsers();

			dataGridViewAccounts.DataSource = mRows;
			dataGridViewAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridViewAccounts.ReadOnly = true;
			dataGridViewAccounts.ClearSelection();

			dataGridViewAccounts.Show();
			dataGridViewAccounts.Refresh();
		}


        public void FormAddAdmin_FormClosed (object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Owner.Show();
                Owner.Refresh();
            }
        }

		private void buttonApply_Click(object sender, EventArgs e) {
			bool Failed = false;
			foreach(DataGridViewRow row in dataGridViewAccounts.SelectedRows) {
				string id = row.Cells[0].Value.ToString(); 
				if (mController.MakeAdmin(id) == 0) {
					Console.Write(MAKE_ADMIN_FAILED + id);
					Failed = true;
				}
			}
			if (Failed)
				MessageBox.Show(MAKE_ADMIN_FAILED_MESSAGE);
			else
				MessageBox.Show(MAKE_ADMIN_SUCCESS);

			ViewAccounts();
		}
	}
}
