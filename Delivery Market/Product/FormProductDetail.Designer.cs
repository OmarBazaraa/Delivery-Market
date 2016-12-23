namespace DeliveryMarket.Product {
	partial class FormProductDetail {
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
			this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
			this.pictureBoxImage = new System.Windows.Forms.PictureBox();
			this.labelProductName = new System.Windows.Forms.Label();
			this.labelCategory = new System.Windows.Forms.Label();
			this.linkSeller = new System.Windows.Forms.LinkLabel();
			this.labelPrice = new System.Windows.Forms.Label();
			this.labelQuantity = new System.Windows.Forms.Label();
			this.groupBoxRating = new System.Windows.Forms.GroupBox();
			this.labelRating = new System.Windows.Forms.Label();
			this.trackBarRating = new System.Windows.Forms.TrackBar();
			this.labelDescription = new System.Windows.Forms.Label();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.listViewComments = new System.Windows.Forms.ListView();
			this.columnComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.textBoxComment = new System.Windows.Forms.TextBox();
			this.buttonBuy = new System.Windows.Forms.Button();
			this.buttonReport = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
			this.groupBoxRating.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarRating)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxLogo
			// 
			this.pictureBoxLogo.Image = global::DeliveryMarket.Properties.Resources.logo;
			this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
			this.pictureBoxLogo.Name = "pictureBoxLogo";
			this.pictureBoxLogo.Size = new System.Drawing.Size(560, 120);
			this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxLogo.TabIndex = 0;
			this.pictureBoxLogo.TabStop = false;
			// 
			// pictureBoxImage
			// 
			this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxImage.Location = new System.Drawing.Point(12, 138);
			this.pictureBoxImage.Name = "pictureBoxImage";
			this.pictureBoxImage.Size = new System.Drawing.Size(225, 225);
			this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxImage.TabIndex = 0;
			this.pictureBoxImage.TabStop = false;
			// 
			// labelProductName
			// 
			this.labelProductName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelProductName.Location = new System.Drawing.Point(243, 135);
			this.labelProductName.Name = "labelProductName";
			this.labelProductName.Size = new System.Drawing.Size(329, 30);
			this.labelProductName.TabIndex = 0;
			this.labelProductName.Text = "Product Name";
			this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelCategory
			// 
			this.labelCategory.Location = new System.Drawing.Point(245, 165);
			this.labelCategory.Name = "labelCategory";
			this.labelCategory.Size = new System.Drawing.Size(328, 25);
			this.labelCategory.TabIndex = 0;
			this.labelCategory.Text = "Category";
			this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// linkSeller
			// 
			this.linkSeller.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.linkSeller.Location = new System.Drawing.Point(244, 190);
			this.linkSeller.Name = "linkSeller";
			this.linkSeller.Size = new System.Drawing.Size(328, 25);
			this.linkSeller.TabIndex = 0;
			this.linkSeller.TabStop = true;
			this.linkSeller.Text = "By Apple Inc.";
			this.linkSeller.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkSeller.VisitedLinkColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.linkSeller.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSeller_LinkClicked);
			// 
			// labelPrice
			// 
			this.labelPrice.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPrice.Location = new System.Drawing.Point(243, 215);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(160, 40);
			this.labelPrice.TabIndex = 0;
			this.labelPrice.Text = "Price: 99.99";
			this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelQuantity
			// 
			this.labelQuantity.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelQuantity.Location = new System.Drawing.Point(411, 215);
			this.labelQuantity.Name = "labelQuantity";
			this.labelQuantity.Size = new System.Drawing.Size(160, 40);
			this.labelQuantity.TabIndex = 0;
			this.labelQuantity.Text = "Quantity: 15";
			this.labelQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBoxRating
			// 
			this.groupBoxRating.Controls.Add(this.labelRating);
			this.groupBoxRating.Controls.Add(this.trackBarRating);
			this.groupBoxRating.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxRating.Location = new System.Drawing.Point(243, 260);
			this.groupBoxRating.Name = "groupBoxRating";
			this.groupBoxRating.Size = new System.Drawing.Size(329, 104);
			this.groupBoxRating.TabIndex = 0;
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
			this.trackBarRating.Size = new System.Drawing.Size(317, 45);
			this.trackBarRating.TabIndex = 0;
			this.trackBarRating.TabStop = false;
			this.trackBarRating.Value = 1;
			this.trackBarRating.ValueChanged += new System.EventHandler(this.trackBarRating_ValueChanged);
			// 
			// labelDescription
			// 
			this.labelDescription.AutoSize = true;
			this.labelDescription.Location = new System.Drawing.Point(8, 366);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(81, 19);
			this.labelDescription.TabIndex = 0;
			this.labelDescription.Text = "Description:";
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Location = new System.Drawing.Point(12, 388);
			this.textBoxDescription.Multiline = true;
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.ReadOnly = true;
			this.textBoxDescription.Size = new System.Drawing.Size(560, 120);
			this.textBoxDescription.TabIndex = 0;
			this.textBoxDescription.TabStop = false;
			// 
			// listViewComments
			// 
			this.listViewComments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnComment,
            this.columnName,
            this.columnDate});
			this.listViewComments.FullRowSelect = true;
			this.listViewComments.Location = new System.Drawing.Point(12, 514);
			this.listViewComments.MultiSelect = false;
			this.listViewComments.Name = "listViewComments";
			this.listViewComments.Size = new System.Drawing.Size(560, 188);
			this.listViewComments.TabIndex = 0;
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
			this.columnDate.Width = 100;
			// 
			// textBoxComment
			// 
			this.textBoxComment.Location = new System.Drawing.Point(12, 708);
			this.textBoxComment.Name = "textBoxComment";
			this.textBoxComment.Size = new System.Drawing.Size(560, 25);
			this.textBoxComment.TabIndex = 1;
			this.textBoxComment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxComment_KeyPress);
			// 
			// buttonBuy
			// 
			this.buttonBuy.Location = new System.Drawing.Point(497, 739);
			this.buttonBuy.Name = "buttonBuy";
			this.buttonBuy.Size = new System.Drawing.Size(75, 35);
			this.buttonBuy.TabIndex = 0;
			this.buttonBuy.TabStop = false;
			this.buttonBuy.Text = "Buy";
			this.buttonBuy.UseVisualStyleBackColor = true;
			this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
			this.buttonBuy.GotFocus += new System.EventHandler(this.LoseFocus);
			// 
			// buttonReport
			// 
			this.buttonReport.Location = new System.Drawing.Point(416, 739);
			this.buttonReport.Name = "buttonReport";
			this.buttonReport.Size = new System.Drawing.Size(75, 35);
			this.buttonReport.TabIndex = 0;
			this.buttonReport.TabStop = false;
			this.buttonReport.Text = "Report";
			this.buttonReport.UseVisualStyleBackColor = true;
			this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
			this.buttonReport.GotFocus += new System.EventHandler(this.LoseFocus);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(335, 739);
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
			this.buttonEdit.Location = new System.Drawing.Point(254, 739);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(75, 35);
			this.buttonEdit.TabIndex = 0;
			this.buttonEdit.TabStop = false;
			this.buttonEdit.Text = "Edit";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			this.buttonEdit.GotFocus += new System.EventHandler(this.LoseFocus);
			// 
			// FormProductDetail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 786);
			this.Controls.Add(this.pictureBoxLogo);
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
			this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "FormProductDetail";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Delivery Market";
			this.Load += new System.EventHandler(this.FormProductDetail_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
			this.groupBoxRating.ResumeLayout(false);
			this.groupBoxRating.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarRating)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox textBoxComment;
		private System.Windows.Forms.Button buttonReport;
		private System.Windows.Forms.Label labelRating;
		private System.Windows.Forms.PictureBox pictureBoxImage;
		private System.Windows.Forms.Button buttonBuy;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.LinkLabel linkSeller;
		private System.Windows.Forms.PictureBox pictureBoxLogo;
		private System.Windows.Forms.Label labelProductName;
		private System.Windows.Forms.Label labelCategory;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.Label labelQuantity;
		private System.Windows.Forms.TextBox textBoxDescription;
		private System.Windows.Forms.ListView listViewComments;
		private System.Windows.Forms.ColumnHeader columnComment;
		private System.Windows.Forms.ColumnHeader columnName;
		private System.Windows.Forms.ColumnHeader columnDate;
		private System.Windows.Forms.TrackBar trackBarRating;
		private System.Windows.Forms.GroupBox groupBoxRating;
	}
}