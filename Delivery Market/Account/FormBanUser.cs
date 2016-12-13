using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryMarket.Account {
	public partial class FormBanUser : Form {

		private const string INVALID_INPUT_TITLE = "Invalid Description";
		private const string INVALID_INPUT_MSG = "Please make sure to write the description";
		private const string DELETE_SUCCESS_TITLE = "Done";
		private const string DELETE_SUCCESS_MSG = "the user was banned successfully";
		private const string DELETE_FAILED_TITLE = "Error";
		private const string DELETE_FAILED_MSG = "An error occured will banning this user";
		private const string CONFIRMATION_TITLE = "Ban";
		private const string CONFIRMATION_MSG = "Are you sure want to ban this user?";

		public FormBanUser() {
			InitializeComponent();
		}

		private void FormBanUser_Load(object sender, EventArgs e) {

		}
	}
}
