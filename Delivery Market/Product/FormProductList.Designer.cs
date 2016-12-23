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
			this.listViewComments = new System.Windows.Forms.ListView();
			this.columnComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.labelQuantity = new System.Windows.Forms.Label();
			this.labelPrice = new System.Windows.Forms.Label();
			this.labelCategory = new System.Windows.Forms.Label();
			this.labelProductName = new System.Windows.Forms.Label();
			this.linkSeller = new System.Windows.Forms.LinkLabel();
			this.textBoxComment = new System.Windows.Forms.TextBox();
			this.groupBoxRating = new System.Windows.Forms.GroupBox();
			this.labelRating = new System.Windows.Forms.Label();
			this.trackBarRating = new System.Windows.Forms.TrackBar();
			this.buttonReport = new System.Windows.Forms.Button();
			this.pictureBoxImage = new System.Windows.Forms.PictureBox();
			this.buttonBuy = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.labelDescription = new System.Windows.Forms.Label();
			this.labelEmptyProducts = new System.Windows.Forms.Label();
			this.buttonBack = new System.Windows.Forms.Button();
			this.buttonAddProduct = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
			this.groupBoxRating.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarRating)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBoxCategory
			// 
			this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCategory.FormattingEnabled = true;
			this.comboBoxCategory.Location = new System.Drawing.Point(477, 138);
			this.comboBoxCategory.Name = "comboBoxCategory";
			this.comboBoxCategory.Size = new System.Drawing.Size(135, 25);
			this.comboBoxCategory.TabIndex = 2;
			this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Location = new System.Drawing.Point(12, 138);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(459, 25);
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
			this.listViewProducts.HideSelection = false;
			this.listViewProducts.Location = new System.Drawing.Point(12, 169);
			this.listViewProducts.MultiSelect = false;
			this.listViewProducts.Name = "listViewProducts";
			this.listViewProducts.Size = new System.Drawing.Size(600, 580);
			this.listViewProducts.TabIndex = 0;
			this.listViewProducts.TabStop = false;
			this.listViewProducts.UseCompatibleStateImageBehavior = false;
			this.listViewProducts.View = System.Windows.Forms.View.Details;
			this.listViewProducts.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewProducts_ColumnClick);
			this.listViewProducts.SelectedIndexChanged += new System.EventHandler(this.listViewProducts_SelectedIndexChanged);
			// 
			// columnProductName
			// 
			this.columnProductName.Text = "Product";
			this.columnProductName.Width = 288;
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
			this.pictureBoxLogo.Size = new System.Drawing.Size(600, 120);
			this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxLogo.TabIndex = 9;
			this.pictureBoxLogo.TabStop = false;
			// 
			// listViewComments
			// 
			this.listViewComments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnComment,
            this.columnName,
            this.columnDate});
			this.listViewComments.FullRowSelect = true;
			this.listViewComments.Location = new System.Drawing.Point(618, 418);
			this.listViewComments.MultiSelect = false;
			this.listViewComments.Name = "listViewComments";
			this.listViewComments.Size = new System.Drawing.Size(600, 259);
			this.listViewComments.TabIndex = 10;
			this.listViewComments.TabStop = false;
			this.listViewComments.UseCompatibleStateImageBehavior = false;
			this.listViewComments.View = System.Windows.Forms.View.Details;
			// 
			// columnComment
			// 
			this.columnComment.Text = "Comment";
			this.columnComment.Width = 343;
			// 
			// columnName
			// 
			this.columnName.Text = "Name";
			this.columnName.Width = 100;
			// 
			// columnDate
			// 
			this.columnDate.Text = "Date";
			this.columnDate.Width = 150;
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Location = new System.Drawing.Point(618, 262);
			this.textBoxDescription.Multiline = true;
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.ReadOnly = true;
			this.textBoxDescription.Size = new System.Drawing.Size(600, 150);
			this.textBoxDescription.TabIndex = 11;
			this.textBoxDescription.TabStop = false;
			// 
			// labelQuantity
			// 
			this.labelQuantity.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelQuantity.Location = new System.Drawing.Point(807, 89);
			this.labelQuantity.Name = "labelQuantity";
			this.labelQuantity.Size = new System.Drawing.Size(180, 40);
			this.labelQuantity.TabIndex = 12;
			this.labelQuantity.Text = "Quantity: 15";
			this.labelQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelPrice
			// 
			this.labelPrice.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPrice.Location = new System.Drawing.Point(618, 89);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(180, 40);
			this.labelPrice.TabIndex = 13;
			this.labelPrice.Text = "Price: 99.99";
			this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelCategory
			// 
			this.labelCategory.Location = new System.Drawing.Point(620, 39);
			this.labelCategory.Name = "labelCategory";
			this.labelCategory.Size = new System.Drawing.Size(367, 25);
			this.labelCategory.TabIndex = 14;
			this.labelCategory.Text = "Category";
			this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelProductName
			// 
			this.labelProductName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelProductName.Location = new System.Drawing.Point(618, 9);
			this.labelProductName.Name = "labelProductName";
			this.labelProductName.Size = new System.Drawing.Size(369, 30);
			this.labelProductName.TabIndex = 15;
			this.labelProductName.Text = "Product Name";
			this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// linkSeller
			// 
			this.linkSeller.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.linkSeller.Location = new System.Drawing.Point(619, 64);
			this.linkSeller.Name = "linkSeller";
			this.linkSeller.Size = new System.Drawing.Size(368, 25);
			this.linkSeller.TabIndex = 16;
			this.linkSeller.TabStop = true;
			this.linkSeller.Text = "By Apple Inc.";
			this.linkSeller.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkSeller.VisitedLinkColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.linkSeller.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSeller_LinkClicked);
			this.linkSeller.GotFocus += new System.EventHandler(this.LoseFocus);
			// 
			// textBoxComment
			// 
			this.textBoxComment.Location = new System.Drawing.Point(618, 685);
			this.textBoxComment.Name = "textBoxComment";
			this.textBoxComment.Size = new System.Drawing.Size(600, 25);
			this.textBoxComment.TabIndex = 24;
			this.textBoxComment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxComment_KeyPress);
			// 
			// groupBoxRating
			// 
			this.groupBoxRating.Controls.Add(this.labelRating);
			this.groupBoxRating.Controls.Add(this.trackBarRating);
			this.groupBoxRating.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxRating.Location = new System.Drawing.Point(618, 134);
			this.groupBoxRating.Name = "groupBoxRating";
			this.groupBoxRating.Size = new System.Drawing.Size(369, 104);
			this.groupBoxRating.TabIndex = 17;
			this.groupBoxRating.TabStop = false;
			this.groupBoxRating.Text = "Rating";
			// 
			// labelRating
			// 
			this.labelRating.AutoSize = true;
			this.labelRating.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelRating.Location = new System.Drawing.Point(6, 25);
			this.labelRating.Name = "labelRating";
			this.labelRating.Size = new System.Drawing.Size(36, 25);
			this.labelRating.TabIndex = 0;
			this.labelRating.Text = "8.9";
			// 
			// trackBarRating
			// 
			this.trackBarRating.Location = new System.Drawing.Point(6, 53);
			this.trackBarRating.Minimum = 1;
			this.trackBarRating.Name = "trackBarRating";
			this.trackBarRating.Size = new System.Drawing.Size(357, 45);
			this.trackBarRating.TabIndex = 0;
			this.trackBarRating.TabStop = false;
			this.trackBarRating.Value = 1;
			this.trackBarRating.ValueChanged += new System.EventHandler(this.trackBarRating_ValueChanged);
			// 
			// buttonReport
			// 
			this.buttonReport.Location = new System.Drawing.Point(1062, 714);
			this.buttonReport.Name = "buttonReport";
			this.buttonReport.Size = new System.Drawing.Size(75, 35);
			this.buttonReport.TabIndex = 0;
			this.buttonReport.TabStop = false;
			this.buttonReport.Text = "Report";
			this.buttonReport.UseVisualStyleBackColor = true;
			this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
			this.buttonReport.GotFocus += new System.EventHandler(this.LoseFocus);
			// 
			// pictureBoxImage
			// 
			this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxImage.Location = new System.Drawing.Point(993, 12);
			this.pictureBoxImage.Name = "pictureBoxImage";
			this.pictureBoxImage.Size = new System.Drawing.Size(225, 225);
			this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxImage.TabIndex = 0;
			this.pictureBoxImage.TabStop = false;
			// 
			// buttonBuy
			// 
			this.buttonBuy.Location = new System.Drawing.Point(1143, 714);
			this.buttonBuy.Name = "buttonBuy";
			this.buttonBuy.Size = new System.Drawing.Size(75, 35);
			this.buttonBuy.TabIndex = 0;
			this.buttonBuy.TabStop = false;
			this.buttonBuy.Text = "Buy";
			this.buttonBuy.UseVisualStyleBackColor = true;
			this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
			this.buttonBuy.GotFocus += new System.EventHandler(this.LoseFocus);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(981, 714);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(75, 35);
			this.buttonDelete.TabIndex = 0;
			this.buttonDelete.TabStop = false;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			this.buttonDelete.GotFocus += new System.EventHandler(this.LoseFocus);
			// 
			// buttonEdit
			// 
			this.buttonEdit.Location = new System.Drawing.Point(900, 714);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(75, 35);
			this.buttonEdit.TabIndex = 0;
			this.buttonEdit.TabStop = false;
			this.buttonEdit.Text = "Edit";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			this.buttonEdit.GotFocus += new System.EventHandler(this.LoseFocus);
			// 
			// labelDescription
			// 
			this.labelDescription.AutoSize = true;
			this.labelDescription.Location = new System.Drawing.Point(614, 240);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(81, 19);
			this.labelDescription.TabIndex = 0;
			this.labelDescription.Text = "Description:";
			// 
			// labelEmptyProducts
			// 
			this.labelEmptyProducts.Font = new System.Drawing.Font("Segoe UI Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelEmptyProducts.Location = new System.Drawing.Point(618, 12);
			this.labelEmptyProducts.Name = "labelEmptyProducts";
			this.labelEmptyProducts.Size = new System.Drawing.Size(600, 737);
			this.labelEmptyProducts.TabIndex = 0;
			this.labelEmptyProducts.Text = "No avalible products";
			this.labelEmptyProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelEmptyProducts.Visible = false;
			// 
			// buttonBack
			// 
			this.buttonBack.Location = new System.Drawing.Point(618, 714);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(75, 35);
			this.buttonBack.TabIndex = 0;
			this.buttonBack.TabStop = false;
			this.buttonBack.Text = "Back";
			this.buttonBack.UseVisualStyleBackColor = true;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// buttonAddProduct
			// 
			this.buttonAddProduct.Location = new System.Drawing.Point(699, 714);
			this.buttonAddProduct.Name = "buttonAddProduct";
			this.buttonAddProduct.Size = new System.Drawing.Size(75, 35);
			this.buttonAddProduct.TabIndex = 0;
			this.buttonAddProduct.TabStop = false;
			this.buttonAddProduct.Text = "Add";
			this.buttonAddProduct.UseVisualStyleBackColor = true;
			this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
			// 
			// FormProductList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1230, 761);
			this.Controls.Add(this.buttonAddProduct);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.listViewComments);
			this.Controls.Add(this.textBoxDescription);
			this.Controls.Add(this.labelQuantity);
			this.Controls.Add(this.labelPrice);
			this.Controls.Add(this.labelCategory);
			this.Controls.Add(this.labelProductName);
			this.Controls.Add(this.linkSeller);
			this.Controls.Add(this.textBoxComment);
			this.Controls.Add(this.groupBoxRating);
			this.Controls.Add(this.buttonReport);
			this.Controls.Add(this.pictureBoxImage);
			this.Controls.Add(this.buttonBuy);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.labelDescription);
			this.Controls.Add(this.pictureBoxLogo);
			this.Controls.Add(this.listViewProducts);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.comboBoxCategory);
			this.Controls.Add(this.labelEmptyProducts);
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
			this.groupBoxRating.ResumeLayout(false);
			this.groupBoxRating.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarRating)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
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
		private System.Windows.Forms.ListView listViewComments;
		private System.Windows.Forms.ColumnHeader columnComment;
		private System.Windows.Forms.ColumnHeader columnName;
		private System.Windows.Forms.ColumnHeader columnDate;
		private System.Windows.Forms.TextBox textBoxDescription;
		private System.Windows.Forms.Label labelQuantity;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.Label labelCategory;
		private System.Windows.Forms.Label labelProductName;
		private System.Windows.Forms.LinkLabel linkSeller;
		private System.Windows.Forms.TextBox textBoxComment;
		private System.Windows.Forms.GroupBox groupBoxRating;
		private System.Windows.Forms.Label labelRating;
		private System.Windows.Forms.TrackBar trackBarRating;
		private System.Windows.Forms.Button buttonReport;
		private System.Windows.Forms.PictureBox pictureBoxImage;
		private System.Windows.Forms.Button buttonBuy;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.Label labelEmptyProducts;
		private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.Button buttonAddProduct;
	}
}