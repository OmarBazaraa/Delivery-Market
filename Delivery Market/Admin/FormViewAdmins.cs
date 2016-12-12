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
    public partial class FormViewAdmins : Form
    {
        AdminController mController;

        public FormViewAdmins()
        {
            InitializeComponent();
            mController = new AdminController();

			ViewAdmins();
        }

		public void ViewAdmins() {
			DataTable mRows = mController.SelectAdmins();
			gridViewAdmins.DataSource = mRows;
			gridViewAdmins.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			gridViewAdmins.ReadOnly = true;
			gridViewAdmins.ClearSelection();

			gridViewAdmins.Show();
			gridViewAdmins.Refresh();
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
