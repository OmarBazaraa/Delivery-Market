using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DeliveryMarket.Data;
using DeliveryMarket.Utils.Defs;

namespace DeliveryMarket
{
    public partial class FormLogin : Form
    {
        private bool _loggedin = false;
        private Controller controllerObj;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            controllerObj = new Controller();
            int account_id = controllerObj.CheckPassword_Basic(textBoxUsername.Text, textBoxPassword.Text);
            if (account_id > 0)
            {
                //Login successful
                _loggedin = true;
                FormMain func = new FormMain(Privilege.User, account_id);
                func.Show(this);
                textBoxPassword.Clear();
                textBoxUsername.Clear();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            } 
             
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            new FormRegistration().Show(this);
            this.Hide();
        }

        
    }
}
