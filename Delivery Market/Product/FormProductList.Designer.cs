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
			this.comboBoxCategory = new System.Windows.Forms.ComboBox();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.labelLogo = new System.Windows.Forms.Label();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.listProducts = new System.Windows.Forms.ListView();
			this.columnProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnSellerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// comboBoxCategory
			// 
			this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCategory.FormattingEnabled = true;
			this.comboBoxCategory.Location = new System.Drawing.Point(333, 62);
			this.comboBoxCategory.Name = "comboBoxCategory";
			this.comboBoxCategory.Size = new System.Drawing.Size(139, 25);
			this.comboBoxCategory.TabIndex = 0;
			this.comboBoxCategory.TabStop = false;
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Location = new System.Drawing.Point(12, 62);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(315, 25);
			this.textBoxSearch.TabIndex = 0;
			this.textBoxSearch.TabStop = false;
			// 
			// labelLogo
			// 
			this.labelLogo.AutoSize = true;
			this.labelLogo.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLogo.Location = new System.Drawing.Point(5, 9);
			this.labelLogo.Name = "labelLogo";
			this.labelLogo.Size = new System.Drawing.Size(215, 41);
			this.labelLogo.TabIndex = 5;
			this.labelLogo.Text = "Delivery Market";
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(333, 21);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(139, 35);
			this.buttonSearch.TabIndex = 7;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// listProducts
			// 
			this.listProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnProductName,
            this.columnSellerName,
            this.columnRating,
            this.columnPrice});
			this.listProducts.FullRowSelect = true;
			this.listProducts.Location = new System.Drawing.Point(12, 93);
			this.listProducts.MultiSelect = false;
			this.listProducts.Name = "listProducts";
			this.listProducts.Size = new System.Drawing.Size(460, 556);
			this.listProducts.TabIndex = 0;
			this.listProducts.TabStop = false;
			this.listProducts.UseCompatibleStateImageBehavior = false;
			this.listProducts.View = System.Windows.Forms.View.Details;
			// 
			// columnProductName
			// 
			this.columnProductName.Text = "Product Name";
			this.columnProductName.Width = 148;
			// 
			// columnSellerName
			// 
			this.columnSellerName.Text = "Seller Name";
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
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(333, 655);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(139, 35);
			this.button1.TabIndex = 8;
			this.button1.Text = "View";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// FormProductList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 702);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listProducts);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.labelLogo);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.comboBoxCategory);
			this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "FormProductList";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Delivery Market";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormProductList_FormClosed);
			this.Load += new System.EventHandler(this.FormProductList_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ComboBox comboBoxCategory;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Label labelLogo;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.ListView listProducts;
		private System.Windows.Forms.ColumnHeader columnProductName;
		private System.Windows.Forms.ColumnHeader columnSellerName;
		private System.Windows.Forms.ColumnHeader columnRating;
		private System.Windows.Forms.ColumnHeader columnPrice;
		private System.Windows.Forms.Button button1;
	}
}