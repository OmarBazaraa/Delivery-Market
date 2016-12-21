namespace DeliveryMarket.Admin {
	partial class FormReports {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReports));
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.tabControlDetails = new System.Windows.Forms.TabControl();
			this.tabPageReportDetails = new System.Windows.Forms.TabPage();
			this.textBoxReportReason = new System.Windows.Forms.TextBox();
			this.labelReportDescription = new System.Windows.Forms.Label();
			this.labelReportReason = new System.Windows.Forms.Label();
			this.dateTimeProductSellingDate = new System.Windows.Forms.DateTimePicker();
			this.labelDescription = new System.Windows.Forms.Label();
			this.comboBoxProductCategory = new System.Windows.Forms.ComboBox();
			this.buttonRemoveProduct = new System.Windows.Forms.Button();
			this.labelProductId = new System.Windows.Forms.Label();
			this.textBoxProductId = new System.Windows.Forms.TextBox();
			this.labelQuantity = new System.Windows.Forms.Label();
			this.textBoxProductQuantity = new System.Windows.Forms.TextBox();
			this.labelSellingDate = new System.Windows.Forms.Label();
			this.labelProductCategory = new System.Windows.Forms.Label();
			this.labelPrice = new System.Windows.Forms.Label();
			this.textBoxProductPrice = new System.Windows.Forms.TextBox();
			this.pictureBoxProductImage = new System.Windows.Forms.PictureBox();
			this.labelProductName = new System.Windows.Forms.Label();
			this.textBoxProductName = new System.Windows.Forms.TextBox();
			this.tabPageSellerDetails = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxBanSellerReason = new System.Windows.Forms.ComboBox();
			this.labelBanSellerReason = new System.Windows.Forms.Label();
			this.labelBanSellerDescription = new System.Windows.Forms.Label();
			this.richTextBoxBanSellerDescription = new System.Windows.Forms.RichTextBox();
			this.buttonBanSeller = new System.Windows.Forms.Button();
			this.comboBoxSellerGender = new System.Windows.Forms.ComboBox();
			this.labelSellerId = new System.Windows.Forms.Label();
			this.textBoxSellerId = new System.Windows.Forms.TextBox();
			this.labelSellerAddress = new System.Windows.Forms.Label();
			this.textBoxSellerAddress = new System.Windows.Forms.TextBox();
			this.labelSellerMobileNumber = new System.Windows.Forms.Label();
			this.textBoxSellerMobileNumber = new System.Windows.Forms.TextBox();
			this.dateTimeSellerCreationDate = new System.Windows.Forms.DateTimePicker();
			this.dateTimeSellerBirthDate = new System.Windows.Forms.DateTimePicker();
			this.labelSellerCreationDate = new System.Windows.Forms.Label();
			this.labelSellerBirthDate = new System.Windows.Forms.Label();
			this.labelSellerUserName = new System.Windows.Forms.Label();
			this.textBoxSellerUserName = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.labelSellerGender = new System.Windows.Forms.Label();
			this.labelSellerName = new System.Windows.Forms.Label();
			this.textBoxSellerName = new System.Windows.Forms.TextBox();
			this.listViewReports = new System.Windows.Forms.ListView();
			this.columnReportId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnSellerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnReportReason = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnReportDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.textBoxReportDescription = new System.Windows.Forms.TextBox();
			this.textBoxProductDescription = new System.Windows.Forms.TextBox();
			this.tabControlDetails.SuspendLayout();
			this.tabPageReportDetails.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductImage)).BeginInit();
			this.tabPageSellerDetails.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Location = new System.Drawing.Point(12, 33);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(160, 22);
			this.textBoxSearch.TabIndex = 0;
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(197, 22);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(148, 33);
			this.buttonSearch.TabIndex = 1;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// tabControlDetails
			// 
			this.tabControlDetails.Controls.Add(this.tabPageReportDetails);
			this.tabControlDetails.Controls.Add(this.tabPageSellerDetails);
			this.tabControlDetails.Location = new System.Drawing.Point(561, 22);
			this.tabControlDetails.Name = "tabControlDetails";
			this.tabControlDetails.SelectedIndex = 0;
			this.tabControlDetails.Size = new System.Drawing.Size(667, 823);
			this.tabControlDetails.TabIndex = 3;
			// 
			// tabPageReportDetails
			// 
			this.tabPageReportDetails.BackColor = System.Drawing.Color.Transparent;
			this.tabPageReportDetails.Controls.Add(this.textBoxProductDescription);
			this.tabPageReportDetails.Controls.Add(this.textBoxReportDescription);
			this.tabPageReportDetails.Controls.Add(this.textBoxReportReason);
			this.tabPageReportDetails.Controls.Add(this.labelReportDescription);
			this.tabPageReportDetails.Controls.Add(this.labelReportReason);
			this.tabPageReportDetails.Controls.Add(this.dateTimeProductSellingDate);
			this.tabPageReportDetails.Controls.Add(this.labelDescription);
			this.tabPageReportDetails.Controls.Add(this.comboBoxProductCategory);
			this.tabPageReportDetails.Controls.Add(this.buttonRemoveProduct);
			this.tabPageReportDetails.Controls.Add(this.labelProductId);
			this.tabPageReportDetails.Controls.Add(this.textBoxProductId);
			this.tabPageReportDetails.Controls.Add(this.labelQuantity);
			this.tabPageReportDetails.Controls.Add(this.textBoxProductQuantity);
			this.tabPageReportDetails.Controls.Add(this.labelSellingDate);
			this.tabPageReportDetails.Controls.Add(this.labelProductCategory);
			this.tabPageReportDetails.Controls.Add(this.labelPrice);
			this.tabPageReportDetails.Controls.Add(this.textBoxProductPrice);
			this.tabPageReportDetails.Controls.Add(this.pictureBoxProductImage);
			this.tabPageReportDetails.Controls.Add(this.labelProductName);
			this.tabPageReportDetails.Controls.Add(this.textBoxProductName);
			this.tabPageReportDetails.Location = new System.Drawing.Point(4, 25);
			this.tabPageReportDetails.Name = "tabPageReportDetails";
			this.tabPageReportDetails.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageReportDetails.Size = new System.Drawing.Size(659, 794);
			this.tabPageReportDetails.TabIndex = 0;
			this.tabPageReportDetails.Text = "Report Details";
			// 
			// textBoxReportReason
			// 
			this.textBoxReportReason.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBoxReportReason.Location = new System.Drawing.Point(126, 15);
			this.textBoxReportReason.Name = "textBoxReportReason";
			this.textBoxReportReason.ReadOnly = true;
			this.textBoxReportReason.Size = new System.Drawing.Size(242, 22);
			this.textBoxReportReason.TabIndex = 5;
			// 
			// labelReportDescription
			// 
			this.labelReportDescription.AutoSize = true;
			this.labelReportDescription.Location = new System.Drawing.Point(43, 51);
			this.labelReportDescription.Name = "labelReportDescription";
			this.labelReportDescription.Size = new System.Drawing.Size(83, 17);
			this.labelReportDescription.TabIndex = 6;
			this.labelReportDescription.Text = "Description:";
			// 
			// labelReportReason
			// 
			this.labelReportReason.AutoSize = true;
			this.labelReportReason.Location = new System.Drawing.Point(17, 15);
			this.labelReportReason.Name = "labelReportReason";
			this.labelReportReason.Size = new System.Drawing.Size(65, 17);
			this.labelReportReason.TabIndex = 4;
			this.labelReportReason.Text = "Reason: ";
			// 
			// dateTimeProductSellingDate
			// 
			this.dateTimeProductSellingDate.Enabled = false;
			this.dateTimeProductSellingDate.Location = new System.Drawing.Point(126, 524);
			this.dateTimeProductSellingDate.Name = "dateTimeProductSellingDate";
			this.dateTimeProductSellingDate.Size = new System.Drawing.Size(242, 22);
			this.dateTimeProductSellingDate.TabIndex = 19;
			// 
			// labelDescription
			// 
			this.labelDescription.AutoSize = true;
			this.labelDescription.Location = new System.Drawing.Point(43, 559);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(83, 17);
			this.labelDescription.TabIndex = 20;
			this.labelDescription.Text = "Description:";
			// 
			// comboBoxProductCategory
			// 
			this.comboBoxProductCategory.Enabled = false;
			this.comboBoxProductCategory.FormattingEnabled = true;
			this.comboBoxProductCategory.Location = new System.Drawing.Point(126, 477);
			this.comboBoxProductCategory.Name = "comboBoxProductCategory";
			this.comboBoxProductCategory.Size = new System.Drawing.Size(242, 24);
			this.comboBoxProductCategory.TabIndex = 17;
			// 
			// buttonRemoveProduct
			// 
			this.buttonRemoveProduct.Location = new System.Drawing.Point(518, 749);
			this.buttonRemoveProduct.Name = "buttonRemoveProduct";
			this.buttonRemoveProduct.Size = new System.Drawing.Size(135, 25);
			this.buttonRemoveProduct.TabIndex = 22;
			this.buttonRemoveProduct.Text = "Remove Product";
			this.buttonRemoveProduct.UseVisualStyleBackColor = true;
			this.buttonRemoveProduct.Click += new System.EventHandler(this.buttonRemoveProduct_Click);
			// 
			// labelProductId
			// 
			this.labelProductId.AutoSize = true;
			this.labelProductId.Location = new System.Drawing.Point(17, 320);
			this.labelProductId.Name = "labelProductId";
			this.labelProductId.Size = new System.Drawing.Size(78, 17);
			this.labelProductId.TabIndex = 8;
			this.labelProductId.Text = "Product ID:";
			// 
			// textBoxProductId
			// 
			this.textBoxProductId.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBoxProductId.Location = new System.Drawing.Point(126, 317);
			this.textBoxProductId.Name = "textBoxProductId";
			this.textBoxProductId.ReadOnly = true;
			this.textBoxProductId.Size = new System.Drawing.Size(242, 22);
			this.textBoxProductId.TabIndex = 9;
			// 
			// labelQuantity
			// 
			this.labelQuantity.AutoSize = true;
			this.labelQuantity.Location = new System.Drawing.Point(17, 440);
			this.labelQuantity.Name = "labelQuantity";
			this.labelQuantity.Size = new System.Drawing.Size(65, 17);
			this.labelQuantity.TabIndex = 14;
			this.labelQuantity.Text = "Quantity:";
			// 
			// textBoxProductQuantity
			// 
			this.textBoxProductQuantity.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBoxProductQuantity.Location = new System.Drawing.Point(126, 437);
			this.textBoxProductQuantity.Name = "textBoxProductQuantity";
			this.textBoxProductQuantity.ReadOnly = true;
			this.textBoxProductQuantity.Size = new System.Drawing.Size(242, 22);
			this.textBoxProductQuantity.TabIndex = 15;
			// 
			// labelSellingDate
			// 
			this.labelSellingDate.AutoSize = true;
			this.labelSellingDate.Location = new System.Drawing.Point(17, 524);
			this.labelSellingDate.Name = "labelSellingDate";
			this.labelSellingDate.Size = new System.Drawing.Size(88, 17);
			this.labelSellingDate.TabIndex = 18;
			this.labelSellingDate.Text = "Selling Date:";
			// 
			// labelProductCategory
			// 
			this.labelProductCategory.AutoSize = true;
			this.labelProductCategory.Location = new System.Drawing.Point(17, 477);
			this.labelProductCategory.Name = "labelProductCategory";
			this.labelProductCategory.Size = new System.Drawing.Size(69, 17);
			this.labelProductCategory.TabIndex = 16;
			this.labelProductCategory.Text = "Category:";
			// 
			// labelPrice
			// 
			this.labelPrice.AutoSize = true;
			this.labelPrice.Location = new System.Drawing.Point(17, 396);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(44, 17);
			this.labelPrice.TabIndex = 12;
			this.labelPrice.Text = "Price:";
			// 
			// textBoxProductPrice
			// 
			this.textBoxProductPrice.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBoxProductPrice.Location = new System.Drawing.Point(126, 396);
			this.textBoxProductPrice.Name = "textBoxProductPrice";
			this.textBoxProductPrice.ReadOnly = true;
			this.textBoxProductPrice.Size = new System.Drawing.Size(242, 22);
			this.textBoxProductPrice.TabIndex = 13;
			// 
			// pictureBoxProductImage
			// 
			this.pictureBoxProductImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxProductImage.Location = new System.Drawing.Point(421, 317);
			this.pictureBoxProductImage.Name = "pictureBoxProductImage";
			this.pictureBoxProductImage.Size = new System.Drawing.Size(210, 169);
			this.pictureBoxProductImage.TabIndex = 99;
			this.pictureBoxProductImage.TabStop = false;
			// 
			// labelProductName
			// 
			this.labelProductName.AutoSize = true;
			this.labelProductName.Location = new System.Drawing.Point(17, 356);
			this.labelProductName.Name = "labelProductName";
			this.labelProductName.Size = new System.Drawing.Size(102, 17);
			this.labelProductName.TabIndex = 10;
			this.labelProductName.Text = "Product Name:";
			// 
			// textBoxProductName
			// 
			this.textBoxProductName.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBoxProductName.Location = new System.Drawing.Point(126, 356);
			this.textBoxProductName.Name = "textBoxProductName";
			this.textBoxProductName.ReadOnly = true;
			this.textBoxProductName.Size = new System.Drawing.Size(242, 22);
			this.textBoxProductName.TabIndex = 11;
			// 
			// tabPageSellerDetails
			// 
			this.tabPageSellerDetails.BackColor = System.Drawing.Color.Transparent;
			this.tabPageSellerDetails.Controls.Add(this.label1);
			this.tabPageSellerDetails.Controls.Add(this.comboBoxBanSellerReason);
			this.tabPageSellerDetails.Controls.Add(this.labelBanSellerReason);
			this.tabPageSellerDetails.Controls.Add(this.labelBanSellerDescription);
			this.tabPageSellerDetails.Controls.Add(this.richTextBoxBanSellerDescription);
			this.tabPageSellerDetails.Controls.Add(this.buttonBanSeller);
			this.tabPageSellerDetails.Controls.Add(this.comboBoxSellerGender);
			this.tabPageSellerDetails.Controls.Add(this.labelSellerId);
			this.tabPageSellerDetails.Controls.Add(this.textBoxSellerId);
			this.tabPageSellerDetails.Controls.Add(this.labelSellerAddress);
			this.tabPageSellerDetails.Controls.Add(this.textBoxSellerAddress);
			this.tabPageSellerDetails.Controls.Add(this.labelSellerMobileNumber);
			this.tabPageSellerDetails.Controls.Add(this.textBoxSellerMobileNumber);
			this.tabPageSellerDetails.Controls.Add(this.dateTimeSellerCreationDate);
			this.tabPageSellerDetails.Controls.Add(this.dateTimeSellerBirthDate);
			this.tabPageSellerDetails.Controls.Add(this.labelSellerCreationDate);
			this.tabPageSellerDetails.Controls.Add(this.labelSellerBirthDate);
			this.tabPageSellerDetails.Controls.Add(this.labelSellerUserName);
			this.tabPageSellerDetails.Controls.Add(this.textBoxSellerUserName);
			this.tabPageSellerDetails.Controls.Add(this.pictureBox1);
			this.tabPageSellerDetails.Controls.Add(this.labelSellerGender);
			this.tabPageSellerDetails.Controls.Add(this.labelSellerName);
			this.tabPageSellerDetails.Controls.Add(this.textBoxSellerName);
			this.tabPageSellerDetails.Location = new System.Drawing.Point(4, 25);
			this.tabPageSellerDetails.Name = "tabPageSellerDetails";
			this.tabPageSellerDetails.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageSellerDetails.Size = new System.Drawing.Size(659, 794);
			this.tabPageSellerDetails.TabIndex = 1;
			this.tabPageSellerDetails.Text = "Seller Details";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(24, 366);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 23);
			this.label1.TabIndex = 63;
			this.label1.Text = "Ban";
			// 
			// comboBoxBanSellerReason
			// 
			this.comboBoxBanSellerReason.FormattingEnabled = true;
			this.comboBoxBanSellerReason.Location = new System.Drawing.Point(130, 406);
			this.comboBoxBanSellerReason.Name = "comboBoxBanSellerReason";
			this.comboBoxBanSellerReason.Size = new System.Drawing.Size(242, 24);
			this.comboBoxBanSellerReason.TabIndex = 62;
			// 
			// labelBanSellerReason
			// 
			this.labelBanSellerReason.AutoSize = true;
			this.labelBanSellerReason.Location = new System.Drawing.Point(24, 406);
			this.labelBanSellerReason.Name = "labelBanSellerReason";
			this.labelBanSellerReason.Size = new System.Drawing.Size(61, 17);
			this.labelBanSellerReason.TabIndex = 61;
			this.labelBanSellerReason.Text = "Reason:";
			// 
			// labelBanSellerDescription
			// 
			this.labelBanSellerDescription.AutoSize = true;
			this.labelBanSellerDescription.Location = new System.Drawing.Point(21, 442);
			this.labelBanSellerDescription.Name = "labelBanSellerDescription";
			this.labelBanSellerDescription.Size = new System.Drawing.Size(83, 17);
			this.labelBanSellerDescription.TabIndex = 60;
			this.labelBanSellerDescription.Text = "Description:";
			// 
			// richTextBoxBanSellerDescription
			// 
			this.richTextBoxBanSellerDescription.Location = new System.Drawing.Point(24, 465);
			this.richTextBoxBanSellerDescription.Name = "richTextBoxBanSellerDescription";
			this.richTextBoxBanSellerDescription.Size = new System.Drawing.Size(585, 221);
			this.richTextBoxBanSellerDescription.TabIndex = 59;
			this.richTextBoxBanSellerDescription.Text = "";
			// 
			// buttonBanSeller
			// 
			this.buttonBanSeller.Location = new System.Drawing.Point(477, 723);
			this.buttonBanSeller.Name = "buttonBanSeller";
			this.buttonBanSeller.Size = new System.Drawing.Size(135, 25);
			this.buttonBanSeller.TabIndex = 39;
			this.buttonBanSeller.Text = "Ban Seller";
			this.buttonBanSeller.UseVisualStyleBackColor = true;
			this.buttonBanSeller.Click += new System.EventHandler(this.buttonBanSeller_Click);
			// 
			// comboBoxSellerGender
			// 
			this.comboBoxSellerGender.Enabled = false;
			this.comboBoxSellerGender.FormattingEnabled = true;
			this.comboBoxSellerGender.Location = new System.Drawing.Point(130, 174);
			this.comboBoxSellerGender.Name = "comboBoxSellerGender";
			this.comboBoxSellerGender.Size = new System.Drawing.Size(48, 24);
			this.comboBoxSellerGender.TabIndex = 32;
			// 
			// labelSellerId
			// 
			this.labelSellerId.AutoSize = true;
			this.labelSellerId.Location = new System.Drawing.Point(24, 14);
			this.labelSellerId.Name = "labelSellerId";
			this.labelSellerId.Size = new System.Drawing.Size(65, 17);
			this.labelSellerId.TabIndex = 23;
			this.labelSellerId.Text = "Seller ID:";
			// 
			// textBoxSellerId
			// 
			this.textBoxSellerId.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBoxSellerId.Location = new System.Drawing.Point(130, 14);
			this.textBoxSellerId.Name = "textBoxSellerId";
			this.textBoxSellerId.ReadOnly = true;
			this.textBoxSellerId.Size = new System.Drawing.Size(242, 22);
			this.textBoxSellerId.TabIndex = 24;
			// 
			// labelSellerAddress
			// 
			this.labelSellerAddress.AutoSize = true;
			this.labelSellerAddress.Location = new System.Drawing.Point(21, 304);
			this.labelSellerAddress.Name = "labelSellerAddress";
			this.labelSellerAddress.Size = new System.Drawing.Size(64, 17);
			this.labelSellerAddress.TabIndex = 37;
			this.labelSellerAddress.Text = "Address:";
			// 
			// textBoxSellerAddress
			// 
			this.textBoxSellerAddress.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBoxSellerAddress.Enabled = false;
			this.textBoxSellerAddress.Location = new System.Drawing.Point(130, 307);
			this.textBoxSellerAddress.Name = "textBoxSellerAddress";
			this.textBoxSellerAddress.ReadOnly = true;
			this.textBoxSellerAddress.Size = new System.Drawing.Size(242, 22);
			this.textBoxSellerAddress.TabIndex = 38;
			// 
			// labelSellerMobileNumber
			// 
			this.labelSellerMobileNumber.AutoSize = true;
			this.labelSellerMobileNumber.Location = new System.Drawing.Point(21, 136);
			this.labelSellerMobileNumber.Name = "labelSellerMobileNumber";
			this.labelSellerMobileNumber.Size = new System.Drawing.Size(107, 17);
			this.labelSellerMobileNumber.TabIndex = 29;
			this.labelSellerMobileNumber.Text = "Mobile Number:";
			// 
			// textBoxSellerMobileNumber
			// 
			this.textBoxSellerMobileNumber.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBoxSellerMobileNumber.Location = new System.Drawing.Point(130, 133);
			this.textBoxSellerMobileNumber.Name = "textBoxSellerMobileNumber";
			this.textBoxSellerMobileNumber.ReadOnly = true;
			this.textBoxSellerMobileNumber.Size = new System.Drawing.Size(242, 22);
			this.textBoxSellerMobileNumber.TabIndex = 30;
			// 
			// dateTimeSellerCreationDate
			// 
			this.dateTimeSellerCreationDate.Enabled = false;
			this.dateTimeSellerCreationDate.Location = new System.Drawing.Point(130, 265);
			this.dateTimeSellerCreationDate.Name = "dateTimeSellerCreationDate";
			this.dateTimeSellerCreationDate.Size = new System.Drawing.Size(242, 22);
			this.dateTimeSellerCreationDate.TabIndex = 36;
			// 
			// dateTimeSellerBirthDate
			// 
			this.dateTimeSellerBirthDate.Enabled = false;
			this.dateTimeSellerBirthDate.Location = new System.Drawing.Point(130, 218);
			this.dateTimeSellerBirthDate.Name = "dateTimeSellerBirthDate";
			this.dateTimeSellerBirthDate.Size = new System.Drawing.Size(242, 22);
			this.dateTimeSellerBirthDate.TabIndex = 34;
			// 
			// labelSellerCreationDate
			// 
			this.labelSellerCreationDate.AutoSize = true;
			this.labelSellerCreationDate.Location = new System.Drawing.Point(21, 262);
			this.labelSellerCreationDate.Name = "labelSellerCreationDate";
			this.labelSellerCreationDate.Size = new System.Drawing.Size(100, 17);
			this.labelSellerCreationDate.TabIndex = 35;
			this.labelSellerCreationDate.Text = "Creation-Date:";
			// 
			// labelSellerBirthDate
			// 
			this.labelSellerBirthDate.AutoSize = true;
			this.labelSellerBirthDate.Location = new System.Drawing.Point(21, 215);
			this.labelSellerBirthDate.Name = "labelSellerBirthDate";
			this.labelSellerBirthDate.Size = new System.Drawing.Size(76, 17);
			this.labelSellerBirthDate.TabIndex = 33;
			this.labelSellerBirthDate.Text = "Birth-Date:";
			// 
			// labelSellerUserName
			// 
			this.labelSellerUserName.AutoSize = true;
			this.labelSellerUserName.Location = new System.Drawing.Point(21, 92);
			this.labelSellerUserName.Name = "labelSellerUserName";
			this.labelSellerUserName.Size = new System.Drawing.Size(83, 17);
			this.labelSellerUserName.TabIndex = 27;
			this.labelSellerUserName.Text = "User Name:";
			// 
			// textBoxSellerUserName
			// 
			this.textBoxSellerUserName.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBoxSellerUserName.Location = new System.Drawing.Point(130, 92);
			this.textBoxSellerUserName.Name = "textBoxSellerUserName";
			this.textBoxSellerUserName.ReadOnly = true;
			this.textBoxSellerUserName.Size = new System.Drawing.Size(242, 22);
			this.textBoxSellerUserName.TabIndex = 28;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(402, 14);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(210, 169);
			this.pictureBox1.TabIndex = 58;
			this.pictureBox1.TabStop = false;
			// 
			// labelSellerGender
			// 
			this.labelSellerGender.AutoSize = true;
			this.labelSellerGender.Location = new System.Drawing.Point(21, 174);
			this.labelSellerGender.Name = "labelSellerGender";
			this.labelSellerGender.Size = new System.Drawing.Size(60, 17);
			this.labelSellerGender.TabIndex = 31;
			this.labelSellerGender.Text = "Gender:";
			// 
			// labelSellerName
			// 
			this.labelSellerName.AutoSize = true;
			this.labelSellerName.Location = new System.Drawing.Point(21, 52);
			this.labelSellerName.Name = "labelSellerName";
			this.labelSellerName.Size = new System.Drawing.Size(89, 17);
			this.labelSellerName.TabIndex = 25;
			this.labelSellerName.Text = "Seller Name:";
			// 
			// textBoxSellerName
			// 
			this.textBoxSellerName.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBoxSellerName.Location = new System.Drawing.Point(130, 52);
			this.textBoxSellerName.Name = "textBoxSellerName";
			this.textBoxSellerName.ReadOnly = true;
			this.textBoxSellerName.Size = new System.Drawing.Size(242, 22);
			this.textBoxSellerName.TabIndex = 26;
			// 
			// listViewReports
			// 
			this.listViewReports.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnReportId,
            this.columnProductName,
            this.columnSellerName,
            this.columnReportReason,
            this.columnReportDate});
			this.listViewReports.FullRowSelect = true;
			this.listViewReports.Location = new System.Drawing.Point(12, 62);
			this.listViewReports.Name = "listViewReports";
			this.listViewReports.Size = new System.Drawing.Size(543, 779);
			this.listViewReports.TabIndex = 2;
			this.listViewReports.UseCompatibleStateImageBehavior = false;
			this.listViewReports.View = System.Windows.Forms.View.Details;
			this.listViewReports.SelectedIndexChanged += new System.EventHandler(this.listViewReports_SelectedIndexChanged);
			// 
			// columnReportId
			// 
			this.columnReportId.Text = "ID";
			// 
			// columnProductName
			// 
			this.columnProductName.Text = "Product Name";
			this.columnProductName.Width = 120;
			// 
			// columnSellerName
			// 
			this.columnSellerName.Text = "Seller Name";
			this.columnSellerName.Width = 120;
			// 
			// columnReportReason
			// 
			this.columnReportReason.Text = "Reason";
			this.columnReportReason.Width = 120;
			// 
			// columnReportDate
			// 
			this.columnReportDate.Text = "Report Date";
			this.columnReportDate.Width = 120;
			// 
			// textBoxReportDescription
			// 
			this.textBoxReportDescription.Location = new System.Drawing.Point(46, 83);
			this.textBoxReportDescription.Multiline = true;
			this.textBoxReportDescription.Name = "textBoxReportDescription";
			this.textBoxReportDescription.Size = new System.Drawing.Size(585, 210);
			this.textBoxReportDescription.TabIndex = 100;
			// 
			// textBoxProductDescription
			// 
			this.textBoxProductDescription.Location = new System.Drawing.Point(46, 578);
			this.textBoxProductDescription.Multiline = true;
			this.textBoxProductDescription.Name = "textBoxProductDescription";
			this.textBoxProductDescription.Size = new System.Drawing.Size(585, 165);
			this.textBoxProductDescription.TabIndex = 101;
			// 
			// FormReports
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1240, 857);
			this.Controls.Add(this.listViewReports);
			this.Controls.Add(this.tabControlDetails);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.textBoxSearch);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormReports";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reports";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormReports_FormClosed);
			this.tabControlDetails.ResumeLayout(false);
			this.tabPageReportDetails.ResumeLayout(false);
			this.tabPageReportDetails.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductImage)).EndInit();
			this.tabPageSellerDetails.ResumeLayout(false);
			this.tabPageSellerDetails.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.TabControl tabControlDetails;
		private System.Windows.Forms.TabPage tabPageReportDetails;
		private System.Windows.Forms.TabPage tabPageSellerDetails;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.ComboBox comboBoxProductCategory;
		private System.Windows.Forms.Button buttonRemoveProduct;
		private System.Windows.Forms.Label labelProductId;
		private System.Windows.Forms.TextBox textBoxProductId;
		private System.Windows.Forms.Label labelQuantity;
		private System.Windows.Forms.TextBox textBoxProductQuantity;
		private System.Windows.Forms.Label labelSellingDate;
		private System.Windows.Forms.Label labelProductCategory;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.TextBox textBoxProductPrice;
		private System.Windows.Forms.PictureBox pictureBoxProductImage;
		private System.Windows.Forms.Label labelProductName;
		private System.Windows.Forms.TextBox textBoxProductName;
		private System.Windows.Forms.Button buttonBanSeller;
		private System.Windows.Forms.ComboBox comboBoxSellerGender;
		private System.Windows.Forms.Label labelSellerId;
		private System.Windows.Forms.TextBox textBoxSellerId;
		private System.Windows.Forms.Label labelSellerAddress;
		private System.Windows.Forms.TextBox textBoxSellerAddress;
		private System.Windows.Forms.Label labelSellerMobileNumber;
		private System.Windows.Forms.TextBox textBoxSellerMobileNumber;
		private System.Windows.Forms.DateTimePicker dateTimeSellerCreationDate;
		private System.Windows.Forms.DateTimePicker dateTimeSellerBirthDate;
		private System.Windows.Forms.Label labelSellerCreationDate;
		private System.Windows.Forms.Label labelSellerBirthDate;
		private System.Windows.Forms.Label labelSellerUserName;
		private System.Windows.Forms.TextBox textBoxSellerUserName;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label labelSellerGender;
		private System.Windows.Forms.Label labelSellerName;
		private System.Windows.Forms.TextBox textBoxSellerName;
		private System.Windows.Forms.ListView listViewReports;
		private System.Windows.Forms.ColumnHeader columnReportId;
		private System.Windows.Forms.ColumnHeader columnProductName;
		private System.Windows.Forms.ColumnHeader columnSellerName;
		private System.Windows.Forms.ColumnHeader columnReportReason;
		private System.Windows.Forms.DateTimePicker dateTimeProductSellingDate;
		private System.Windows.Forms.TextBox textBoxReportReason;
		private System.Windows.Forms.Label labelReportDescription;
		private System.Windows.Forms.Label labelReportReason;
		private System.Windows.Forms.ColumnHeader columnReportDate;
		private System.Windows.Forms.ComboBox comboBoxBanSellerReason;
		private System.Windows.Forms.Label labelBanSellerReason;
		private System.Windows.Forms.Label labelBanSellerDescription;
		private System.Windows.Forms.RichTextBox richTextBoxBanSellerDescription;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxProductDescription;
		private System.Windows.Forms.TextBox textBoxReportDescription;
	}
}