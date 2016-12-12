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
			this.buttonView = new System.Windows.Forms.Button();
			this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
			this.buttonBack = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
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
			this.listViewProducts.Size = new System.Drawing.Size(460, 556);
			this.listViewProducts.TabIndex = 0;
			this.listViewProducts.TabStop = false;
			this.listViewProducts.UseCompatibleStateImageBehavior = false;
			this.listViewProducts.View = System.Windows.Forms.View.Details;
			this.listViewProducts.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewProducts_ColumnClick);
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
			// buttonView
			// 
			this.buttonView.Location = new System.Drawing.Point(397, 731);
			this.buttonView.Name = "buttonView";
			this.buttonView.Size = new System.Drawing.Size(75, 35);
			this.buttonView.TabIndex = 0;
			this.buttonView.TabStop = false;
			this.buttonView.Text = "View";
			this.buttonView.UseVisualStyleBackColor = true;
			this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
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
			// buttonBack
			// 
			this.buttonBack.Location = new System.Drawing.Point(235, 731);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(75, 35);
			this.buttonBack.TabIndex = 0;
			this.buttonBack.TabStop = false;
			this.buttonBack.Text = "Back";
			this.buttonBack.UseVisualStyleBackColor = true;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(316, 731);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(75, 35);
			this.buttonAdd.TabIndex = 0;
			this.buttonAdd.TabStop = false;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			// 
			// FormProductList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 778);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.pictureBoxLogo);
			this.Controls.Add(this.buttonView);
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
		private System.Windows.Forms.Button buttonView;
		private System.Windows.Forms.PictureBox pictureBoxLogo;
		private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.Button buttonAdd;
	}
}