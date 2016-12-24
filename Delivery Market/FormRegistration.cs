using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DeliveryMarket.Data;
namespace DeliveryMarket
{
    public partial class FormRegistration : Form
    {
        Controller controllerObj;
        public FormRegistration()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Password = textBoxPassword.Text;
            string ConfirmPassword = textBoxConfirmPassword.Text;
            if (textBoxUsername.Text == "" || textBoxPassword.Text == "" || textBoxConfirmPassword.Text == "" || textBoxFirstName.Text == "" || textBoxLastName.Text == "" || textBoxCountry.Text == "" || textBoxCity.Text == "" || textBoxMobileNum.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }

          else if(String.Compare(Password,ConfirmPassword) != 0) 
            {
            MessageBox.Show("Passwords Mismatch");
            }
          else
            {
                char gender = radioButton_Male.Checked ? 'M' : 'F';
                string birthday = monthCalendarBirthday.SelectionStart.ToString("yyyy-MM-dd");
                Console.WriteLine(textBoxUsername.Text.ToString() + " " + textBoxPassword.Text.ToString() + " " + textBoxFirstName.Text.ToString() + " " + textBoxLastName.Text.ToString() + " " + birthday + " " + gender + " " + textBoxMobileNum.Text.ToString() + " " + textBoxCountry.Text.ToString() + " " + textBoxCity.Text.ToString());
                int r = controllerObj.InsertUser(textBoxUsername.Text.ToString(), textBoxPassword.Text.ToString(), textBoxFirstName.Text.ToString(), textBoxLastName.Text.ToString(),birthday, gender, textBoxMobileNum.Text.ToString(), textBoxCountry.Text.ToString(), textBoxCity.Text.ToString());
                    //Convert.To(comboBox1.SelectedValue))
                if (r > 0)
                    MessageBox.Show("Account registered successfully");
                else
                    MessageBox.Show("Error registering account");
            } 
        }

        private void monthCalendarBirthday_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
