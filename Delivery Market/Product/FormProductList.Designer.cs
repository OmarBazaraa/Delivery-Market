namespace DeliveryMarket.Product {
	partial class FormProductList {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductList));
			this.comboBoxCategory = new System.Windows.Forms.ComboBox();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.listViewProducts = new System.Windows.Forms.ListView();
			this.columnProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnSellerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBoxCategory
			// 
			this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCategory.FormattingEnabled = true;
			this.comboBoxCategory.Location = new System.Drawing.Point(337, 138);
			this.comboBoxCategory.Name = "comboBoxCategory";
			this.comboBoxCategory.Size = new System.Drawing.Size(135, 25);
			this.comboBoxCategory.TabIndex = 2;
			this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Location = new System.Drawing.Point(12, 138);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(319, 25);
			this.textBoxSearch.TabIndex = 1;
			this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
			// 
			// listViewProducts
			// 
			this.listViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnProductName,
            this.columnSellerName,
            this.columnRating,
            this.columnPrice});
			this.listViewProducts.FullRowSelect = true;
			this.listViewProducts.Location = new System.Drawing.Point(12, 169);
			this.listViewProducts.MultiSelect = false;
			this.listViewProducts.Name = "listViewProducts";
			this.listViewProducts.Size = new System.Drawing.Size(460, 580);
			this.listViewProducts.TabIndex = 0;
			this.listViewProducts.TabStop = false;
			this.listViewProducts.UseCompatibleStateImageBehavior = false;
			this.listViewProducts.View = System.Windows.Forms.View.Details;
			this.listViewProducts.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewProducts_ColumnClick);
			this.listViewProducts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewProducts_MouseDoubleClick);
			// 
			// columnProductName
			// 
			this.columnProductName.Text = "Product";
			this.columnProductName.Width = 148;
			// 
			// columnSellerName
			// 
			this.columnSellerName.Text = "Seller";
			this.columnSellerName.Width = 148;
			// 
			// columnRating
			// 
			this.columnRating.Text = "Rating";
			this.columnRating.Width = 80;
			// 
			// columnPrice
			// 
			this.columnPrice.Text = "Price";
			this.columnPrice.Width = 80;
			// 
			// pictureBoxLogo
			// 
			this.pictureBoxLogo.Image = global::DeliveryMarket.Properties.Resources.logo;
			this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
			this.pictureBoxLogo.Name = "pictureBoxLogo";
			this.pictureBoxLogo.Size = new System.Drawing.Size(460, 120);
			this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxLogo.TabIndex = 9;
			this.pictureBoxLogo.TabStop = false;
			// 
			// FormProductList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 761);
			this.Controls.Add(this.pictureBoxLogo);
			this.Controls.Add(this.listViewProducts);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.comboBoxCategory);
			this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "FormProductList";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Delivery Market";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormProductList_FormClosed);
			this.Load += new System.EventHandler(this.FormProductList_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ComboBox comboBoxCategory;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.ListView listViewProducts;
		private System.Windows.Forms.ColumnHeader columnProductName;
		private System.Windows.Forms.ColumnHeader columnSellerName;
		private System.Windows.Forms.ColumnHeader columnRating;
		private System.Windows.Forms.ColumnHeader columnPrice;
		private System.Windows.Forms.PictureBox pictureBoxLogo;
	}
}