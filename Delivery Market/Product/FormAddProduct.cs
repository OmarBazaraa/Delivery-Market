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

namespace DeliveryMarket.Product
{
    public partial class FormAddProduct : Form
    {
        private const string ADD_NEW_PRODUCT        = "Add Product";
        private const string SAVE_PRODUCT           = "Save";
        private const string INVALID_INPUT_TITLE    = "Invalid Inputs";
        private const string INVALID_INPUT_MSG      = "Please make sure that all product details are valid";

        private int mAccountID;
        private bool mIsNewProduct;
        private Product mProduct;
        private ProductController mController;

        public FormAddProduct(int accountID, Product product = null)
        {
            // Initializations
            InitializeComponent();

            mAccountID = accountID;
            mIsNewProduct = (product == null) ? true : false;
            mProduct = product;
            mController = new ProductController();
        }

        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            // Fill product categories
            DataTable dt = mController.SelectCategories();
            comboBoxCategory.DataSource = dt;
            comboBoxCategory.DisplayMember = CategoryEntry.COL_CATEGORY_NAME;

            // Adapt form purpose
            if (mIsNewProduct)
            {
                buttonApply.Text = ADD_NEW_PRODUCT;
            }
            else
            {
                buttonApply.Text = SAVE_PRODUCT;
                textBoxName.Text = mProduct.Name;
                comboBoxCategory.Text = mProduct.Category;
                numericPrice.Value = Convert.ToDecimal(mProduct.Price);
                numericStockCount.Value = Convert.ToDecimal(mProduct.StockCount);
                textBoxDescription.Text = mProduct.Description;
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (mIsNewProduct)
            {
                mProduct = new Product();
            }

            mProduct.SellerID = mAccountID.ToString();
            mProduct.Name = textBoxName.Text;
            mProduct.Price = numericPrice.Value.ToString();
            mProduct.Category = comboBoxCategory.Text;
            mProduct.Description = textBoxDescription.Text;
            mProduct.StockCount = numericStockCount.Value.ToString();
            mProduct.ImagePath = "haha";
            mProduct.Deleted = "0";

            if (!IsValidateInput())
            {
                MessageBox.Show(INVALID_INPUT_MSG, INVALID_INPUT_TITLE, MessageBoxButtons.OK);
                return;
            }

            if (mIsNewProduct)
            {
                // Insert
                if (mController.InsertProduct(mProduct) > 0)
                {
                    MessageBox.Show("New product inserted successfully");
                }
            }
            else
            {
                // Update
            }
        }

        private void FormAddProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Owner.Show();
                Owner.Refresh();
            }
        }

        private bool IsValidateInput()
        {
            return true;
        }
    }
}
