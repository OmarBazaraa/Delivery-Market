using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryMarket
{
    public partial class FormMain : Form
    {
        private Controller mController;

        public FormMain()
        {
            InitializeComponent();

            mController = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = mController.TestQuery();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
