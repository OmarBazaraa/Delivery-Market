namespace DeliveryMarket.Product
{
    partial class FormProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.groupBoxProductDetails = new System.Windows.Forms.GroupBox();
            this.columnProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProductRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProductPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewProducts
            // 
            this.listViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnProductName,
            this.columnProductRating,
            this.columnProductPrice});
            this.listViewProducts.Location = new System.Drawing.Point(12, 12);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(427, 537);
            this.listViewProducts.TabIndex = 0;
            this.listViewProducts.TabStop = false;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            // 
            // groupBoxProductDetails
            // 
            this.groupBoxProductDetails.Location = new System.Drawing.Point(445, 12);
            this.groupBoxProductDetails.Name = "groupBoxProductDetails";
            this.groupBoxProductDetails.Size = new System.Drawing.Size(427, 537);
            this.groupBoxProductDetails.TabIndex = 0;
            this.groupBoxProductDetails.TabStop = false;
            this.groupBoxProductDetails.Text = "Product 1";
            // 
            // columnProductName
            // 
            this.columnProductName.Text = "Product Name";
            this.columnProductName.Width = 252;
            // 
            // columnProductRating
            // 
            this.columnProductRating.Text = "Rating";
            this.columnProductRating.Width = 76;
            // 
            // columnProductPrice
            // 
            this.columnProductPrice.Text = "Price";
            this.columnProductPrice.Width = 92;
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.groupBoxProductDetails);
            this.Controls.Add(this.listViewProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.ColumnHeader columnProductName;
        private System.Windows.Forms.ColumnHeader columnProductRating;
        private System.Windows.Forms.ColumnHeader columnProductPrice;
        private System.Windows.Forms.GroupBox groupBoxProductDetails;
    }
}