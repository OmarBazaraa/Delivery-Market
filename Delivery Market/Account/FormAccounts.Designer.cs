namespace DeliveryMarket.Account
{
    partial class FormAccounts
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
			this.listSellers = new System.Windows.Forms.ListView();
			this.columnUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnProductsCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.labelName = new System.Windows.Forms.Label();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.textMoneyPaid = new System.Windows.Forms.Label();
			this.textOrdersCount = new System.Windows.Forms.Label();
			this.textMoneyEarned = new System.Windows.Forms.Label();
			this.textProductsCount = new System.Windows.Forms.Label();
			this.textRating = new System.Windows.Forms.Label();
			this.textBirthDate = new System.Windows.Forms.Label();
			this.textCreationDate = new System.Windows.Forms.Label();
			this.textCity = new System.Windows.Forms.Label();
			this.textLastName = new System.Windows.Forms.Label();
			this.textGender = new System.Windows.Forms.Label();
			this.textMobileNumber = new System.Windows.Forms.Label();
			this.textCountry = new System.Windows.Forms.Label();
			this.textFirstName = new System.Windows.Forms.Label();
			this.textUserName = new System.Windows.Forms.Label();
			this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
			this.labelMoneyPaid = new System.Windows.Forms.Label();
			this.buttonViewProducts = new System.Windows.Forms.Button();
			this.labelRating = new System.Windows.Forms.Label();
			this.labelOrdersCount = new System.Windows.Forms.Label();
			this.labelMoneyEarned = new System.Windows.Forms.Label();
			this.labelProductsCount = new System.Windows.Forms.Label();
			this.labelUser = new System.Windows.Forms.Label();
			this.labelBirthDate = new System.Windows.Forms.Label();
			this.labelCreationDate = new System.Windows.Forms.Label();
			this.labelUserName = new System.Windows.Forms.Label();
			this.labelFirstName = new System.Windows.Forms.Label();
			this.labelMobileNumber = new System.Windows.Forms.Label();
			this.labelGender = new System.Windows.Forms.Label();
			this.labelCountry = new System.Windows.Forms.Label();
			this.labelLastName = new System.Windows.Forms.Label();
			this.labelCity = new System.Windows.Forms.Label();
			this.labelAccount = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// listSellers
			// 
			this.listSellers.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.listSellers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnUserName,
            this.columnRating,
            this.columnProductsCount});
			this.listSellers.Font = new System.Drawing.Font("Tahoma", 12F);
			this.listSellers.FullRowSelect = true;
			this.listSellers.GridLines = true;
			this.listSellers.HoverSelection = true;
			this.listSellers.Location = new System.Drawing.Point(12, 56);
			this.listSellers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.listSellers.Name = "listSellers";
			this.listSellers.Size = new System.Drawing.Size(645, 660);
			this.listSellers.TabIndex = 1;
			this.listSellers.TabStop = false;
			this.listSellers.UseCompatibleStateImageBehavior = false;
			this.listSellers.View = System.Windows.Forms.View.Details;
			this.listSellers.SelectedIndexChanged += new System.EventHandler(this.listSellers_SelectedIndexChanged);
			this.listSellers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listSellers_MouseDoubleClick);
			// 
			// columnUserName
			// 
			this.columnUserName.Text = "User Name";
			this.columnUserName.Width = 235;
			// 
			// columnRating
			// 
			this.columnRating.Text = "Rating";
			this.columnRating.Width = 167;
			// 
			// columnProductsCount
			// 
			this.columnProductsCount.Text = "Products Count";
			this.columnProductsCount.Width = 155;
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Font = new System.Drawing.Font("Tahoma", 13F);
			this.labelName.Location = new System.Drawing.Point(12, 16);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(69, 27);
			this.labelName.TabIndex = 2;
			this.labelName.Text = "Name";
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Font = new System.Drawing.Font("Tahoma", 12F);
			this.textBoxEmail.Location = new System.Drawing.Point(160, 11);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(291, 32);
			this.textBoxEmail.TabIndex = 3;
			this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
			// 
			// textMoneyPaid
			// 
			this.textMoneyPaid.AutoSize = true;
			this.textMoneyPaid.Location = new System.Drawing.Point(1172, 534);
			this.textMoneyPaid.Name = "textMoneyPaid";
			this.textMoneyPaid.Size = new System.Drawing.Size(40, 17);
			this.textMoneyPaid.TabIndex = 99;
			this.textMoneyPaid.Text = "115$";
			// 
			// textOrdersCount
			// 
			this.textOrdersCount.AutoSize = true;
			this.textOrdersCount.Location = new System.Drawing.Point(1172, 504);
			this.textOrdersCount.Name = "textOrdersCount";
			this.textOrdersCount.Size = new System.Drawing.Size(24, 17);
			this.textOrdersCount.TabIndex = 98;
			this.textOrdersCount.Text = "23";
			// 
			// textMoneyEarned
			// 
			this.textMoneyEarned.AutoSize = true;
			this.textMoneyEarned.Location = new System.Drawing.Point(864, 538);
			this.textMoneyEarned.Name = "textMoneyEarned";
			this.textMoneyEarned.Size = new System.Drawing.Size(40, 17);
			this.textMoneyEarned.TabIndex = 97;
			this.textMoneyEarned.Text = "128$";
			// 
			// textProductsCount
			// 
			this.textProductsCount.AutoSize = true;
			this.textProductsCount.Location = new System.Drawing.Point(864, 504);
			this.textProductsCount.Name = "textProductsCount";
			this.textProductsCount.Size = new System.Drawing.Size(24, 17);
			this.textProductsCount.TabIndex = 96;
			this.textProductsCount.Text = "15";
			// 
			// textRating
			// 
			this.textRating.AutoSize = true;
			this.textRating.Location = new System.Drawing.Point(864, 474);
			this.textRating.Name = "textRating";
			this.textRating.Size = new System.Drawing.Size(28, 17);
			this.textRating.TabIndex = 95;
			this.textRating.Text = "5.0";
			// 
			// textBirthDate
			// 
			this.textBirthDate.AutoSize = true;
			this.textBirthDate.Location = new System.Drawing.Point(1172, 321);
			this.textBirthDate.Name = "textBirthDate";
			this.textBirthDate.Size = new System.Drawing.Size(82, 17);
			this.textBirthDate.TabIndex = 94;
			this.textBirthDate.Text = "1996/11/15";
			// 
			// textCreationDate
			// 
			this.textCreationDate.AutoSize = true;
			this.textCreationDate.Location = new System.Drawing.Point(1172, 291);
			this.textCreationDate.Name = "textCreationDate";
			this.textCreationDate.Size = new System.Drawing.Size(82, 17);
			this.textCreationDate.TabIndex = 93;
			this.textCreationDate.Text = "2011/05/05";
			// 
			// textCity
			// 
			this.textCity.AutoSize = true;
			this.textCity.Location = new System.Drawing.Point(1172, 259);
			this.textCity.Name = "textCity";
			this.textCity.Size = new System.Drawing.Size(39, 17);
			this.textCity.TabIndex = 92;
			this.textCity.Text = "Cairo";
			// 
			// textLastName
			// 
			this.textLastName.AutoSize = true;
			this.textLastName.Location = new System.Drawing.Point(1172, 227);
			this.textLastName.Name = "textLastName";
			this.textLastName.Size = new System.Drawing.Size(49, 17);
			this.textLastName.TabIndex = 91;
			this.textLastName.Text = "Sobeih";
			// 
			// textGender
			// 
			this.textGender.AutoSize = true;
			this.textGender.Location = new System.Drawing.Point(864, 328);
			this.textGender.Name = "textGender";
			this.textGender.Size = new System.Drawing.Size(34, 17);
			this.textGender.TabIndex = 90;
			this.textGender.Text = "Male";
			// 
			// textMobileNumber
			// 
			this.textMobileNumber.AutoSize = true;
			this.textMobileNumber.Location = new System.Drawing.Point(864, 298);
			this.textMobileNumber.Name = "textMobileNumber";
			this.textMobileNumber.Size = new System.Drawing.Size(96, 17);
			this.textMobileNumber.TabIndex = 89;
			this.textMobileNumber.Text = "01148084758";
			// 
			// textCountry
			// 
			this.textCountry.AutoSize = true;
			this.textCountry.Location = new System.Drawing.Point(864, 266);
			this.textCountry.Name = "textCountry";
			this.textCountry.Size = new System.Drawing.Size(45, 17);
			this.textCountry.TabIndex = 88;
			this.textCountry.Text = "Egypt";
			// 
			// textFirstName
			// 
			this.textFirstName.AutoSize = true;
			this.textFirstName.Location = new System.Drawing.Point(864, 234);
			this.textFirstName.Name = "textFirstName";
			this.textFirstName.Size = new System.Drawing.Size(42, 17);
			this.textFirstName.TabIndex = 87;
			this.textFirstName.Text = "Omar";
			// 
			// textUserName
			// 
			this.textUserName.AutoSize = true;
			this.textUserName.Location = new System.Drawing.Point(864, 199);
			this.textUserName.Name = "textUserName";
			this.textUserName.Size = new System.Drawing.Size(135, 17);
			this.textUserName.TabIndex = 86;
			this.textUserName.Text = "omarosamasobeih96";
			// 
			// pictureBoxLogo
			// 
			this.pictureBoxLogo.Image = global::DeliveryMarket.Properties.Resources.logo;
			this.pictureBoxLogo.Location = new System.Drawing.Point(1091, 56);
			this.pictureBoxLogo.Name = "pictureBoxLogo";
			this.pictureBoxLogo.Size = new System.Drawing.Size(229, 80);
			this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxLogo.TabIndex = 85;
			this.pictureBoxLogo.TabStop = false;
			// 
			// labelMoneyPaid
			// 
			this.labelMoneyPaid.AutoSize = true;
			this.labelMoneyPaid.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
			this.labelMoneyPaid.Location = new System.Drawing.Point(1030, 534);
			this.labelMoneyPaid.Name = "labelMoneyPaid";
			this.labelMoneyPaid.Size = new System.Drawing.Size(87, 17);
			this.labelMoneyPaid.TabIndex = 84;
			this.labelMoneyPaid.Text = "Money Paid";
			// 
			// buttonViewProducts
			// 
			this.buttonViewProducts.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.buttonViewProducts.Font = new System.Drawing.Font("Tahoma", 10F);
			this.buttonViewProducts.Location = new System.Drawing.Point(1091, 629);
			this.buttonViewProducts.Name = "buttonViewProducts";
			this.buttonViewProducts.Size = new System.Drawing.Size(184, 40);
			this.buttonViewProducts.TabIndex = 82;
			this.buttonViewProducts.TabStop = false;
			this.buttonViewProducts.Text = "View Products";
			this.buttonViewProducts.UseVisualStyleBackColor = false;
			this.buttonViewProducts.Click += new System.EventHandler(this.buttonViewProducts_Click);
			// 
			// labelRating
			// 
			this.labelRating.AutoSize = true;
			this.labelRating.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
			this.labelRating.Location = new System.Drawing.Point(708, 474);
			this.labelRating.Name = "labelRating";
			this.labelRating.Size = new System.Drawing.Size(53, 17);
			this.labelRating.TabIndex = 78;
			this.labelRating.Text = "Rating";
			// 
			// labelOrdersCount
			// 
			this.labelOrdersCount.AutoSize = true;
			this.labelOrdersCount.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
			this.labelOrdersCount.Location = new System.Drawing.Point(1024, 504);
			this.labelOrdersCount.Name = "labelOrdersCount";
			this.labelOrdersCount.Size = new System.Drawing.Size(133, 17);
			this.labelOrdersCount.TabIndex = 77;
			this.labelOrdersCount.Text = "Number of Orders";
			// 
			// labelMoneyEarned
			// 
			this.labelMoneyEarned.AutoSize = true;
			this.labelMoneyEarned.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
			this.labelMoneyEarned.Location = new System.Drawing.Point(708, 538);
			this.labelMoneyEarned.Name = "labelMoneyEarned";
			this.labelMoneyEarned.Size = new System.Drawing.Size(107, 17);
			this.labelMoneyEarned.TabIndex = 76;
			this.labelMoneyEarned.Text = "Money Earned";
			// 
			// labelProductsCount
			// 
			this.labelProductsCount.AutoSize = true;
			this.labelProductsCount.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
			this.labelProductsCount.Location = new System.Drawing.Point(708, 504);
			this.labelProductsCount.Name = "labelProductsCount";
			this.labelProductsCount.Size = new System.Drawing.Size(148, 17);
			this.labelProductsCount.TabIndex = 75;
			this.labelProductsCount.Text = "Number of Products";
			// 
			// labelUser
			// 
			this.labelUser.AutoSize = true;
			this.labelUser.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelUser.Location = new System.Drawing.Point(707, 432);
			this.labelUser.Name = "labelUser";
			this.labelUser.Size = new System.Drawing.Size(138, 24);
			this.labelUser.TabIndex = 74;
			this.labelUser.Text = "User Details:";
			this.labelUser.Visible = false;
			// 
			// labelBirthDate
			// 
			this.labelBirthDate.AutoSize = true;
			this.labelBirthDate.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
			this.labelBirthDate.Location = new System.Drawing.Point(1030, 321);
			this.labelBirthDate.Name = "labelBirthDate";
			this.labelBirthDate.Size = new System.Drawing.Size(78, 17);
			this.labelBirthDate.TabIndex = 73;
			this.labelBirthDate.Text = "Birth Date";
			// 
			// labelCreationDate
			// 
			this.labelCreationDate.AutoSize = true;
			this.labelCreationDate.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
			this.labelCreationDate.Location = new System.Drawing.Point(1030, 291);
			this.labelCreationDate.Name = "labelCreationDate";
			this.labelCreationDate.Size = new System.Drawing.Size(103, 17);
			this.labelCreationDate.TabIndex = 72;
			this.labelCreationDate.Text = "Creation Date";
			// 
			// labelUserName
			// 
			this.labelUserName.AutoSize = true;
			this.labelUserName.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelUserName.Location = new System.Drawing.Point(708, 199);
			this.labelUserName.Name = "labelUserName";
			this.labelUserName.Size = new System.Drawing.Size(83, 17);
			this.labelUserName.TabIndex = 71;
			this.labelUserName.Text = "User Name";
			// 
			// labelFirstName
			// 
			this.labelFirstName.AutoSize = true;
			this.labelFirstName.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFirstName.Location = new System.Drawing.Point(708, 234);
			this.labelFirstName.Name = "labelFirstName";
			this.labelFirstName.Size = new System.Drawing.Size(82, 17);
			this.labelFirstName.TabIndex = 70;
			this.labelFirstName.Text = "First Name";
			// 
			// labelMobileNumber
			// 
			this.labelMobileNumber.AutoSize = true;
			this.labelMobileNumber.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMobileNumber.Location = new System.Drawing.Point(708, 298);
			this.labelMobileNumber.Name = "labelMobileNumber";
			this.labelMobileNumber.Size = new System.Drawing.Size(112, 17);
			this.labelMobileNumber.TabIndex = 69;
			this.labelMobileNumber.Text = "Mobile Number";
			// 
			// labelGender
			// 
			this.labelGender.AutoSize = true;
			this.labelGender.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
			this.labelGender.Location = new System.Drawing.Point(708, 328);
			this.labelGender.Name = "labelGender";
			this.labelGender.Size = new System.Drawing.Size(58, 17);
			this.labelGender.TabIndex = 68;
			this.labelGender.Text = "Gender";
			// 
			// labelCountry
			// 
			this.labelCountry.AutoSize = true;
			this.labelCountry.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCountry.Location = new System.Drawing.Point(708, 266);
			this.labelCountry.Name = "labelCountry";
			this.labelCountry.Size = new System.Drawing.Size(65, 17);
			this.labelCountry.TabIndex = 67;
			this.labelCountry.Text = "Country";
			// 
			// labelLastName
			// 
			this.labelLastName.AutoSize = true;
			this.labelLastName.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
			this.labelLastName.Location = new System.Drawing.Point(1027, 227);
			this.labelLastName.Name = "labelLastName";
			this.labelLastName.Size = new System.Drawing.Size(81, 17);
			this.labelLastName.TabIndex = 66;
			this.labelLastName.Text = "Last Name";
			// 
			// labelCity
			// 
			this.labelCity.AutoSize = true;
			this.labelCity.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
			this.labelCity.Location = new System.Drawing.Point(1030, 259);
			this.labelCity.Name = "labelCity";
			this.labelCity.Size = new System.Drawing.Size(35, 17);
			this.labelCity.TabIndex = 65;
			this.labelCity.Text = "City";
			// 
			// labelAccount
			// 
			this.labelAccount.AutoSize = true;
			this.labelAccount.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelAccount.Location = new System.Drawing.Point(707, 151);
			this.labelAccount.Name = "labelAccount";
			this.labelAccount.Size = new System.Drawing.Size(174, 24);
			this.labelAccount.TabIndex = 64;
			this.labelAccount.Text = "Account Details:";
			// 
			// FormAccounts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1355, 761);
			this.Controls.Add(this.textMoneyPaid);
			this.Controls.Add(this.textOrdersCount);
			this.Controls.Add(this.textMoneyEarned);
			this.Controls.Add(this.textProductsCount);
			this.Controls.Add(this.textRating);
			this.Controls.Add(this.textBirthDate);
			this.Controls.Add(this.textCreationDate);
			this.Controls.Add(this.textCity);
			this.Controls.Add(this.textLastName);
			this.Controls.Add(this.textGender);
			this.Controls.Add(this.textMobileNumber);
			this.Controls.Add(this.textCountry);
			this.Controls.Add(this.textFirstName);
			this.Controls.Add(this.textUserName);
			this.Controls.Add(this.pictureBoxLogo);
			this.Controls.Add(this.labelMoneyPaid);
			this.Controls.Add(this.buttonViewProducts);
			this.Controls.Add(this.labelRating);
			this.Controls.Add(this.labelOrdersCount);
			this.Controls.Add(this.labelMoneyEarned);
			this.Controls.Add(this.labelProductsCount);
			this.Controls.Add(this.labelUser);
			this.Controls.Add(this.labelBirthDate);
			this.Controls.Add(this.labelCreationDate);
			this.Controls.Add(this.labelUserName);
			this.Controls.Add(this.labelFirstName);
			this.Controls.Add(this.labelMobileNumber);
			this.Controls.Add(this.labelGender);
			this.Controls.Add(this.labelCountry);
			this.Controls.Add(this.labelLastName);
			this.Controls.Add(this.labelCity);
			this.Controls.Add(this.labelAccount);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.listSellers);
			this.Name = "FormAccounts";
			this.Text = "Sellers";
			this.Load += new System.EventHandler(this.FormAccounts_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listSellers;
        private System.Windows.Forms.ColumnHeader columnUserName;
        private System.Windows.Forms.ColumnHeader columnRating;
        private System.Windows.Forms.ColumnHeader columnProductsCount;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox textBoxEmail;
		private System.Windows.Forms.Label labelAccount;
		private System.Windows.Forms.Label labelCity;
		private System.Windows.Forms.Label labelLastName;
		private System.Windows.Forms.Label labelCountry;
		private System.Windows.Forms.Label labelGender;
		private System.Windows.Forms.Label labelMobileNumber;
		private System.Windows.Forms.Label labelFirstName;
		private System.Windows.Forms.Label labelUserName;
		private System.Windows.Forms.Label labelCreationDate;
		private System.Windows.Forms.Label labelBirthDate;
		private System.Windows.Forms.Label labelUser;
		private System.Windows.Forms.Label labelProductsCount;
		private System.Windows.Forms.Label labelMoneyEarned;
		private System.Windows.Forms.Label labelOrdersCount;
		private System.Windows.Forms.Label labelRating;
		private System.Windows.Forms.Button buttonViewProducts;
		private System.Windows.Forms.Label labelMoneyPaid;
		private System.Windows.Forms.PictureBox pictureBoxLogo;
		private System.Windows.Forms.Label textUserName;
		private System.Windows.Forms.Label textFirstName;
		private System.Windows.Forms.Label textCountry;
		private System.Windows.Forms.Label textMobileNumber;
		private System.Windows.Forms.Label textGender;
		private System.Windows.Forms.Label textLastName;
		private System.Windows.Forms.Label textCity;
		private System.Windows.Forms.Label textCreationDate;
		private System.Windows.Forms.Label textBirthDate;
		private System.Windows.Forms.Label textRating;
		private System.Windows.Forms.Label textProductsCount;
		private System.Windows.Forms.Label textMoneyEarned;
		private System.Windows.Forms.Label textOrdersCount;
		private System.Windows.Forms.Label textMoneyPaid;
	}
}