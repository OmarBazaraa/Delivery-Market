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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccounts));
			this.listViewSellers = new System.Windows.Forms.ListView();
			this.columnUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnProductsCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.textMoneyPaid = new System.Windows.Forms.Label();
			this.textOrdersCount = new System.Windows.Forms.Label();
			this.textMoneyEarned = new System.Windows.Forms.Label();
			this.textProductsCount = new System.Windows.Forms.Label();
			this.textBirthDate = new System.Windows.Forms.Label();
			this.textCreationDate = new System.Windows.Forms.Label();
			this.textLastName = new System.Windows.Forms.Label();
			this.textGender = new System.Windows.Forms.Label();
			this.textMobileNumber = new System.Windows.Forms.Label();
			this.textLocation = new System.Windows.Forms.Label();
			this.textFirstName = new System.Windows.Forms.Label();
			this.textUserName = new System.Windows.Forms.Label();
			this.labelMoneyPaid = new System.Windows.Forms.Label();
			this.labelOrdersCount = new System.Windows.Forms.Label();
			this.labelMoneyEarned = new System.Windows.Forms.Label();
			this.labelProductsCount = new System.Windows.Forms.Label();
			this.labelBirthDate = new System.Windows.Forms.Label();
			this.labelCreationDate = new System.Windows.Forms.Label();
			this.labelFirstName = new System.Windows.Forms.Label();
			this.labelMobileNumber = new System.Windows.Forms.Label();
			this.labelGender = new System.Windows.Forms.Label();
			this.labelLastName = new System.Windows.Forms.Label();
			this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
			this.textRating = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.labelEmptyAccounts = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.labelLocation = new System.Windows.Forms.Label();
			this.labelRating = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// listViewSellers
			// 
			this.listViewSellers.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.listViewSellers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnUserName,
            this.columnRating,
            this.columnProductsCount});
			this.listViewSellers.FullRowSelect = true;
			this.listViewSellers.HoverSelection = true;
			this.listViewSellers.Location = new System.Drawing.Point(12, 173);
			this.listViewSellers.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.listViewSellers.Name = "listViewSellers";
			this.listViewSellers.Size = new System.Drawing.Size(600, 574);
			this.listViewSellers.TabIndex = 1;
			this.listViewSellers.TabStop = false;
			this.listViewSellers.UseCompatibleStateImageBehavior = false;
			this.listViewSellers.View = System.Windows.Forms.View.Details;
			this.listViewSellers.SelectedIndexChanged += new System.EventHandler(this.listSellers_SelectedIndexChanged);
			this.listViewSellers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listSellers_MouseDoubleClick);
			// 
			// columnUserName
			// 
			this.columnUserName.Text = "User Name";
			this.columnUserName.Width = 327;
			// 
			// columnRating
			// 
			this.columnRating.Text = "Rating";
			this.columnRating.Width = 153;
			// 
			// columnProductsCount
			// 
			this.columnProductsCount.Text = "Products Count";
			this.columnProductsCount.Width = 115;
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Location = new System.Drawing.Point(12, 138);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(600, 25);
			this.textBoxSearch.TabIndex = 3;
			this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
			// 
			// textMoneyPaid
			// 
			this.textMoneyPaid.AutoSize = true;
			this.textMoneyPaid.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textMoneyPaid.Location = new System.Drawing.Point(452, 90);
			this.textMoneyPaid.Name = "textMoneyPaid";
			this.textMoneyPaid.Size = new System.Drawing.Size(41, 19);
			this.textMoneyPaid.TabIndex = 99;
			this.textMoneyPaid.Text = "115$";
			// 
			// textOrdersCount
			// 
			this.textOrdersCount.AutoSize = true;
			this.textOrdersCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textOrdersCount.Location = new System.Drawing.Point(452, 40);
			this.textOrdersCount.Name = "textOrdersCount";
			this.textOrdersCount.Size = new System.Drawing.Size(25, 19);
			this.textOrdersCount.TabIndex = 98;
			this.textOrdersCount.Text = "23";
			// 
			// textMoneyEarned
			// 
			this.textMoneyEarned.AutoSize = true;
			this.textMoneyEarned.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textMoneyEarned.Location = new System.Drawing.Point(162, 90);
			this.textMoneyEarned.Name = "textMoneyEarned";
			this.textMoneyEarned.Size = new System.Drawing.Size(41, 19);
			this.textMoneyEarned.TabIndex = 97;
			this.textMoneyEarned.Text = "128$";
			// 
			// textProductsCount
			// 
			this.textProductsCount.AutoSize = true;
			this.textProductsCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textProductsCount.Location = new System.Drawing.Point(162, 40);
			this.textProductsCount.Name = "textProductsCount";
			this.textProductsCount.Size = new System.Drawing.Size(25, 19);
			this.textProductsCount.TabIndex = 96;
			this.textProductsCount.Text = "15";
			this.textProductsCount.Click += new System.EventHandler(this.textProductsCount_Click);
			// 
			// textBirthDate
			// 
			this.textBirthDate.AutoSize = true;
			this.textBirthDate.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.textBirthDate.Location = new System.Drawing.Point(162, 91);
			this.textBirthDate.Name = "textBirthDate";
			this.textBirthDate.Size = new System.Drawing.Size(83, 19);
			this.textBirthDate.TabIndex = 94;
			this.textBirthDate.Text = "1996/11/15";
			// 
			// textCreationDate
			// 
			this.textCreationDate.AutoSize = true;
			this.textCreationDate.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.textCreationDate.Location = new System.Drawing.Point(162, 141);
			this.textCreationDate.Name = "textCreationDate";
			this.textCreationDate.Size = new System.Drawing.Size(83, 19);
			this.textCreationDate.TabIndex = 93;
			this.textCreationDate.Text = "2011/05/05";
			// 
			// textLastName
			// 
			this.textLastName.AutoSize = true;
			this.textLastName.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.textLastName.Location = new System.Drawing.Point(453, 41);
			this.textLastName.Name = "textLastName";
			this.textLastName.Size = new System.Drawing.Size(50, 19);
			this.textLastName.TabIndex = 91;
			this.textLastName.Text = "Sobeih";
			// 
			// textGender
			// 
			this.textGender.AutoSize = true;
			this.textGender.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.textGender.Location = new System.Drawing.Point(453, 91);
			this.textGender.Name = "textGender";
			this.textGender.Size = new System.Drawing.Size(39, 19);
			this.textGender.TabIndex = 90;
			this.textGender.Text = "Male";
			// 
			// textMobileNumber
			// 
			this.textMobileNumber.AutoSize = true;
			this.textMobileNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.textMobileNumber.Location = new System.Drawing.Point(162, 191);
			this.textMobileNumber.Name = "textMobileNumber";
			this.textMobileNumber.Size = new System.Drawing.Size(97, 19);
			this.textMobileNumber.TabIndex = 89;
			this.textMobileNumber.Text = "01148084758";
			// 
			// textLocation
			// 
			this.textLocation.AutoSize = true;
			this.textLocation.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textLocation.Location = new System.Drawing.Point(452, 141);
			this.textLocation.Name = "textLocation";
			this.textLocation.Size = new System.Drawing.Size(83, 19);
			this.textLocation.TabIndex = 88;
			this.textLocation.Text = "Egypt, Cairo";
			// 
			// textFirstName
			// 
			this.textFirstName.AutoSize = true;
			this.textFirstName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textFirstName.Location = new System.Drawing.Point(162, 41);
			this.textFirstName.Name = "textFirstName";
			this.textFirstName.Size = new System.Drawing.Size(44, 19);
			this.textFirstName.TabIndex = 87;
			this.textFirstName.Text = "Omar";
			// 
			// textUserName
			// 
			this.textUserName.AutoSize = true;
			this.textUserName.Font = new System.Drawing.Font("Segoe UI Light", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textUserName.Location = new System.Drawing.Point(618, 12);
			this.textUserName.Name = "textUserName";
			this.textUserName.Size = new System.Drawing.Size(268, 74);
			this.textUserName.TabIndex = 86;
			this.textUserName.Text = "Username";
			this.textUserName.Click += new System.EventHandler(this.textUserName_Click);
			// 
			// labelMoneyPaid
			// 
			this.labelMoneyPaid.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMoneyPaid.Location = new System.Drawing.Point(296, 75);
			this.labelMoneyPaid.Name = "labelMoneyPaid";
			this.labelMoneyPaid.Size = new System.Drawing.Size(150, 50);
			this.labelMoneyPaid.TabIndex = 84;
			this.labelMoneyPaid.Text = "Money Paid";
			this.labelMoneyPaid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelOrdersCount
			// 
			this.labelOrdersCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelOrdersCount.Location = new System.Drawing.Point(296, 25);
			this.labelOrdersCount.Name = "labelOrdersCount";
			this.labelOrdersCount.Size = new System.Drawing.Size(150, 50);
			this.labelOrdersCount.TabIndex = 77;
			this.labelOrdersCount.Text = "Number of Orders";
			this.labelOrdersCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelMoneyEarned
			// 
			this.labelMoneyEarned.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMoneyEarned.Location = new System.Drawing.Point(6, 75);
			this.labelMoneyEarned.Name = "labelMoneyEarned";
			this.labelMoneyEarned.Size = new System.Drawing.Size(150, 50);
			this.labelMoneyEarned.TabIndex = 76;
			this.labelMoneyEarned.Text = "Money Earned";
			this.labelMoneyEarned.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelProductsCount
			// 
			this.labelProductsCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelProductsCount.Location = new System.Drawing.Point(6, 25);
			this.labelProductsCount.Name = "labelProductsCount";
			this.labelProductsCount.Size = new System.Drawing.Size(150, 50);
			this.labelProductsCount.TabIndex = 75;
			this.labelProductsCount.Text = "Number of Products";
			this.labelProductsCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelBirthDate
			// 
			this.labelBirthDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelBirthDate.Location = new System.Drawing.Point(6, 75);
			this.labelBirthDate.Name = "labelBirthDate";
			this.labelBirthDate.Size = new System.Drawing.Size(150, 50);
			this.labelBirthDate.TabIndex = 73;
			this.labelBirthDate.Text = "Birthdate";
			this.labelBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelCreationDate
			// 
			this.labelCreationDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCreationDate.Location = new System.Drawing.Point(6, 125);
			this.labelCreationDate.Name = "labelCreationDate";
			this.labelCreationDate.Size = new System.Drawing.Size(150, 50);
			this.labelCreationDate.TabIndex = 72;
			this.labelCreationDate.Text = "Creation Date";
			this.labelCreationDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelFirstName
			// 
			this.labelFirstName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFirstName.Location = new System.Drawing.Point(6, 25);
			this.labelFirstName.Name = "labelFirstName";
			this.labelFirstName.Size = new System.Drawing.Size(150, 50);
			this.labelFirstName.TabIndex = 70;
			this.labelFirstName.Text = "First Name";
			this.labelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelMobileNumber
			// 
			this.labelMobileNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMobileNumber.Location = new System.Drawing.Point(6, 175);
			this.labelMobileNumber.Name = "labelMobileNumber";
			this.labelMobileNumber.Size = new System.Drawing.Size(150, 50);
			this.labelMobileNumber.TabIndex = 69;
			this.labelMobileNumber.Text = "Phone";
			this.labelMobileNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelGender
			// 
			this.labelGender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelGender.Location = new System.Drawing.Point(297, 75);
			this.labelGender.Name = "labelGender";
			this.labelGender.Size = new System.Drawing.Size(150, 50);
			this.labelGender.TabIndex = 68;
			this.labelGender.Text = "Gender";
			this.labelGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelLastName
			// 
			this.labelLastName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLastName.Location = new System.Drawing.Point(297, 25);
			this.labelLastName.Name = "labelLastName";
			this.labelLastName.Size = new System.Drawing.Size(150, 50);
			this.labelLastName.TabIndex = 66;
			this.labelLastName.Text = "Last Name";
			this.labelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBoxLogo
			// 
			this.pictureBoxLogo.Image = global::DeliveryMarket.Properties.Resources.logo;
			this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
			this.pictureBoxLogo.Name = "pictureBoxLogo";
			this.pictureBoxLogo.Size = new System.Drawing.Size(600, 120);
			this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxLogo.TabIndex = 100;
			this.pictureBoxLogo.TabStop = false;
			// 
			// textRating
			// 
			this.textRating.AutoSize = true;
			this.textRating.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textRating.Location = new System.Drawing.Point(735, 98);
			this.textRating.Name = "textRating";
			this.textRating.Size = new System.Drawing.Size(55, 41);
			this.textRating.TabIndex = 0;
			this.textRating.Text = "8.9";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.labelMoneyPaid);
			this.groupBox1.Controls.Add(this.labelProductsCount);
			this.groupBox1.Controls.Add(this.labelMoneyEarned);
			this.groupBox1.Controls.Add(this.textMoneyPaid);
			this.groupBox1.Controls.Add(this.labelOrdersCount);
			this.groupBox1.Controls.Add(this.textOrdersCount);
			this.groupBox1.Controls.Add(this.textProductsCount);
			this.groupBox1.Controls.Add(this.textMoneyEarned);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(624, 162);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(594, 128);
			this.groupBox1.TabIndex = 102;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Activity";
			// 
			// labelEmptyAccounts
			// 
			this.labelEmptyAccounts.Font = new System.Drawing.Font("Segoe UI Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelEmptyAccounts.Location = new System.Drawing.Point(618, 9);
			this.labelEmptyAccounts.Name = "labelEmptyAccounts";
			this.labelEmptyAccounts.Size = new System.Drawing.Size(600, 743);
			this.labelEmptyAccounts.TabIndex = 105;
			this.labelEmptyAccounts.Text = "No avalible Accounts";
			this.labelEmptyAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelEmptyAccounts.Visible = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.labelLocation);
			this.groupBox2.Controls.Add(this.labelFirstName);
			this.groupBox2.Controls.Add(this.textFirstName);
			this.groupBox2.Controls.Add(this.labelLastName);
			this.groupBox2.Controls.Add(this.textLastName);
			this.groupBox2.Controls.Add(this.textCreationDate);
			this.groupBox2.Controls.Add(this.textLocation);
			this.groupBox2.Controls.Add(this.textBirthDate);
			this.groupBox2.Controls.Add(this.textMobileNumber);
			this.groupBox2.Controls.Add(this.labelGender);
			this.groupBox2.Controls.Add(this.textGender);
			this.groupBox2.Controls.Add(this.labelBirthDate);
			this.groupBox2.Controls.Add(this.labelMobileNumber);
			this.groupBox2.Controls.Add(this.labelCreationDate);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(624, 296);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(594, 451);
			this.groupBox2.TabIndex = 103;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "About";
			// 
			// labelLocation
			// 
			this.labelLocation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLocation.Location = new System.Drawing.Point(296, 125);
			this.labelLocation.Name = "labelLocation";
			this.labelLocation.Size = new System.Drawing.Size(150, 50);
			this.labelLocation.TabIndex = 95;
			this.labelLocation.Text = "Country";
			this.labelLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelRating
			// 
			this.labelRating.AutoSize = true;
			this.labelRating.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelRating.Location = new System.Drawing.Point(624, 98);
			this.labelRating.Name = "labelRating";
			this.labelRating.Size = new System.Drawing.Size(105, 41);
			this.labelRating.TabIndex = 104;
			this.labelRating.Text = "Rating:";
			// 
			// FormAccounts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1230, 761);
			this.Controls.Add(this.labelRating);
			this.Controls.Add(this.textRating);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBoxLogo);
			this.Controls.Add(this.textUserName);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.listViewSellers);
			this.Controls.Add(this.labelEmptyAccounts);
			this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormAccounts";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Delivery Market";
			this.Load += new System.EventHandler(this.FormAccounts_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewSellers;
        private System.Windows.Forms.ColumnHeader columnUserName;
        private System.Windows.Forms.ColumnHeader columnRating;
        private System.Windows.Forms.ColumnHeader columnProductsCount;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Label labelLastName;
		private System.Windows.Forms.Label labelGender;
		private System.Windows.Forms.Label labelMobileNumber;
		private System.Windows.Forms.Label labelFirstName;
		private System.Windows.Forms.Label labelCreationDate;
		private System.Windows.Forms.Label labelBirthDate;
		private System.Windows.Forms.Label labelProductsCount;
		private System.Windows.Forms.Label labelMoneyEarned;
		private System.Windows.Forms.Label labelOrdersCount;
		private System.Windows.Forms.Label labelMoneyPaid;
		private System.Windows.Forms.Label textUserName;
		private System.Windows.Forms.Label textFirstName;
		private System.Windows.Forms.Label textLocation;
		private System.Windows.Forms.Label textMobileNumber;
		private System.Windows.Forms.Label textGender;
		private System.Windows.Forms.Label textLastName;
		private System.Windows.Forms.Label textCreationDate;
		private System.Windows.Forms.Label textBirthDate;
		private System.Windows.Forms.Label textProductsCount;
		private System.Windows.Forms.Label textMoneyEarned;
		private System.Windows.Forms.Label textOrdersCount;
		private System.Windows.Forms.Label textMoneyPaid;
		private System.Windows.Forms.PictureBox pictureBoxLogo;
		private System.Windows.Forms.Label textRating;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label labelRating;
		private System.Windows.Forms.Label labelEmptyAccounts;
		private System.Windows.Forms.Label labelLocation;
	}
}