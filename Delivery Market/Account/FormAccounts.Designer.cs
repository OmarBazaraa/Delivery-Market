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
			this.textBoxUsername = new System.Windows.Forms.TextBox();
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
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// listSellers
			// 
			this.listSellers.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.listSellers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnUserName,
            this.columnRating,
            this.columnProductsCount});
			this.listSellers.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.listSellers.FullRowSelect = true;
			this.listSellers.HoverSelection = true;
			this.listSellers.Location = new System.Drawing.Point(12, 177);
			this.listSellers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.listSellers.Name = "listSellers";
			this.listSellers.Size = new System.Drawing.Size(600, 577);
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
			// textBoxUsername
			// 
			this.textBoxUsername.Font = new System.Drawing.Font("Tahoma", 12F);
			this.textBoxUsername.Location = new System.Drawing.Point(12, 138);
			this.textBoxUsername.Name = "textBoxUsername";
			this.textBoxUsername.Size = new System.Drawing.Size(600, 32);
			this.textBoxUsername.TabIndex = 3;
			this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
			// 
			// textMoneyPaid
			// 
			this.textMoneyPaid.AutoSize = true;
			this.textMoneyPaid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.textMoneyPaid.Location = new System.Drawing.Point(494, 86);
			this.textMoneyPaid.Name = "textMoneyPaid";
			this.textMoneyPaid.Size = new System.Drawing.Size(62, 24);
			this.textMoneyPaid.TabIndex = 99;
			this.textMoneyPaid.Text = "115$";
			// 
			// textOrdersCount
			// 
			this.textOrdersCount.AutoSize = true;
			this.textOrdersCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.textOrdersCount.Location = new System.Drawing.Point(494, 45);
			this.textOrdersCount.Name = "textOrdersCount";
			this.textOrdersCount.Size = new System.Drawing.Size(36, 24);
			this.textOrdersCount.TabIndex = 98;
			this.textOrdersCount.Text = "23";
			// 
			// textMoneyEarned
			// 
			this.textMoneyEarned.AutoSize = true;
			this.textMoneyEarned.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.textMoneyEarned.Location = new System.Drawing.Point(184, 86);
			this.textMoneyEarned.Name = "textMoneyEarned";
			this.textMoneyEarned.Size = new System.Drawing.Size(62, 24);
			this.textMoneyEarned.TabIndex = 97;
			this.textMoneyEarned.Text = "128$";
			// 
			// textProductsCount
			// 
			this.textProductsCount.AutoSize = true;
			this.textProductsCount.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textProductsCount.Location = new System.Drawing.Point(184, 41);
			this.textProductsCount.Name = "textProductsCount";
			this.textProductsCount.Size = new System.Drawing.Size(36, 24);
			this.textProductsCount.TabIndex = 96;
			this.textProductsCount.Text = "15";
			this.textProductsCount.Click += new System.EventHandler(this.textProductsCount_Click);
			// 
			// textBirthDate
			// 
			this.textBirthDate.AutoSize = true;
			this.textBirthDate.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.textBirthDate.Location = new System.Drawing.Point(120, 92);
			this.textBirthDate.Name = "textBirthDate";
			this.textBirthDate.Size = new System.Drawing.Size(96, 23);
			this.textBirthDate.TabIndex = 94;
			this.textBirthDate.Text = "1996/11/15";
			// 
			// textCreationDate
			// 
			this.textCreationDate.AutoSize = true;
			this.textCreationDate.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.textCreationDate.Location = new System.Drawing.Point(120, 140);
			this.textCreationDate.Name = "textCreationDate";
			this.textCreationDate.Size = new System.Drawing.Size(96, 23);
			this.textCreationDate.TabIndex = 93;
			this.textCreationDate.Text = "2011/05/05";
			// 
			// textLastName
			// 
			this.textLastName.AutoSize = true;
			this.textLastName.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.textLastName.Location = new System.Drawing.Point(306, 42);
			this.textLastName.Name = "textLastName";
			this.textLastName.Size = new System.Drawing.Size(62, 23);
			this.textLastName.TabIndex = 91;
			this.textLastName.Text = "Sobeih";
			// 
			// textGender
			// 
			this.textGender.AutoSize = true;
			this.textGender.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.textGender.Location = new System.Drawing.Point(498, 43);
			this.textGender.Name = "textGender";
			this.textGender.Size = new System.Drawing.Size(47, 23);
			this.textGender.TabIndex = 90;
			this.textGender.Text = "Male";
			this.textGender.Click += new System.EventHandler(this.textGender_Click);
			// 
			// textMobileNumber
			// 
			this.textMobileNumber.AutoSize = true;
			this.textMobileNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.textMobileNumber.Location = new System.Drawing.Point(713, 98);
			this.textMobileNumber.Name = "textMobileNumber";
			this.textMobileNumber.Size = new System.Drawing.Size(130, 23);
			this.textMobileNumber.TabIndex = 89;
			this.textMobileNumber.Text = "+201148084758";
			// 
			// textLocation
			// 
			this.textLocation.AutoSize = true;
			this.textLocation.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textLocation.Location = new System.Drawing.Point(647, 59);
			this.textLocation.Name = "textLocation";
			this.textLocation.Size = new System.Drawing.Size(102, 23);
			this.textLocation.TabIndex = 88;
			this.textLocation.Text = "Egypt, Cairo";
			// 
			// textFirstName
			// 
			this.textFirstName.AutoSize = true;
			this.textFirstName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textFirstName.Location = new System.Drawing.Point(101, 43);
			this.textFirstName.Name = "textFirstName";
			this.textFirstName.Size = new System.Drawing.Size(53, 23);
			this.textFirstName.TabIndex = 87;
			this.textFirstName.Text = "Omar";
			// 
			// textUserName
			// 
			this.textUserName.AutoSize = true;
			this.textUserName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textUserName.Location = new System.Drawing.Point(642, 9);
			this.textUserName.Name = "textUserName";
			this.textUserName.Size = new System.Drawing.Size(148, 41);
			this.textUserName.TabIndex = 86;
			this.textUserName.Text = "username";
			this.textUserName.Click += new System.EventHandler(this.textUserName_Click);
			// 
			// labelMoneyPaid
			// 
			this.labelMoneyPaid.AutoSize = true;
			this.labelMoneyPaid.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.labelMoneyPaid.Location = new System.Drawing.Point(317, 88);
			this.labelMoneyPaid.Name = "labelMoneyPaid";
			this.labelMoneyPaid.Size = new System.Drawing.Size(99, 23);
			this.labelMoneyPaid.TabIndex = 84;
			this.labelMoneyPaid.Text = "Money Paid";
			// 
			// labelOrdersCount
			// 
			this.labelOrdersCount.AutoSize = true;
			this.labelOrdersCount.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.labelOrdersCount.Location = new System.Drawing.Point(317, 45);
			this.labelOrdersCount.Name = "labelOrdersCount";
			this.labelOrdersCount.Size = new System.Drawing.Size(149, 23);
			this.labelOrdersCount.TabIndex = 77;
			this.labelOrdersCount.Text = "Number of Orders";
			// 
			// labelMoneyEarned
			// 
			this.labelMoneyEarned.AutoSize = true;
			this.labelMoneyEarned.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.labelMoneyEarned.Location = new System.Drawing.Point(9, 88);
			this.labelMoneyEarned.Name = "labelMoneyEarned";
			this.labelMoneyEarned.Size = new System.Drawing.Size(120, 23);
			this.labelMoneyEarned.TabIndex = 76;
			this.labelMoneyEarned.Text = "Money Earned";
			// 
			// labelProductsCount
			// 
			this.labelProductsCount.AutoSize = true;
			this.labelProductsCount.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.labelProductsCount.Location = new System.Drawing.Point(9, 43);
			this.labelProductsCount.Name = "labelProductsCount";
			this.labelProductsCount.Size = new System.Drawing.Size(165, 23);
			this.labelProductsCount.TabIndex = 75;
			this.labelProductsCount.Text = "Number of Products";
			// 
			// labelBirthDate
			// 
			this.labelBirthDate.AutoSize = true;
			this.labelBirthDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.labelBirthDate.Location = new System.Drawing.Point(9, 94);
			this.labelBirthDate.Name = "labelBirthDate";
			this.labelBirthDate.Size = new System.Drawing.Size(81, 20);
			this.labelBirthDate.TabIndex = 73;
			this.labelBirthDate.Text = "Birth Date";
			// 
			// labelCreationDate
			// 
			this.labelCreationDate.AutoSize = true;
			this.labelCreationDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.labelCreationDate.Location = new System.Drawing.Point(9, 142);
			this.labelCreationDate.Name = "labelCreationDate";
			this.labelCreationDate.Size = new System.Drawing.Size(105, 20);
			this.labelCreationDate.TabIndex = 72;
			this.labelCreationDate.Text = "Creation Date";
			// 
			// labelFirstName
			// 
			this.labelFirstName.AutoSize = true;
			this.labelFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFirstName.Location = new System.Drawing.Point(9, 45);
			this.labelFirstName.Name = "labelFirstName";
			this.labelFirstName.Size = new System.Drawing.Size(86, 20);
			this.labelFirstName.TabIndex = 70;
			this.labelFirstName.Text = "First Name";
			// 
			// labelMobileNumber
			// 
			this.labelMobileNumber.AutoSize = true;
			this.labelMobileNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMobileNumber.Location = new System.Drawing.Point(648, 98);
			this.labelMobileNumber.Name = "labelMobileNumber";
			this.labelMobileNumber.Size = new System.Drawing.Size(59, 23);
			this.labelMobileNumber.TabIndex = 69;
			this.labelMobileNumber.Text = "Phone";
			// 
			// labelGender
			// 
			this.labelGender.AutoSize = true;
			this.labelGender.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.labelGender.Location = new System.Drawing.Point(432, 46);
			this.labelGender.Name = "labelGender";
			this.labelGender.Size = new System.Drawing.Size(60, 20);
			this.labelGender.TabIndex = 68;
			this.labelGender.Text = "Gender";
			// 
			// labelLastName
			// 
			this.labelLastName.AutoSize = true;
			this.labelLastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.labelLastName.Location = new System.Drawing.Point(216, 45);
			this.labelLastName.Name = "labelLastName";
			this.labelLastName.Size = new System.Drawing.Size(84, 20);
			this.labelLastName.TabIndex = 66;
			this.labelLastName.Text = "Last Name";
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
			this.textRating.Font = new System.Drawing.Font("Segoe UI Light", 26F);
			this.textRating.Location = new System.Drawing.Point(1071, 43);
			this.textRating.Name = "textRating";
			this.textRating.Size = new System.Drawing.Size(81, 60);
			this.textRating.TabIndex = 0;
			this.textRating.Text = "8.9";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.labelEmptyAccounts);
			this.groupBox1.Controls.Add(this.labelMoneyPaid);
			this.groupBox1.Controls.Add(this.labelProductsCount);
			this.groupBox1.Controls.Add(this.labelMoneyEarned);
			this.groupBox1.Controls.Add(this.textMoneyPaid);
			this.groupBox1.Controls.Add(this.labelOrdersCount);
			this.groupBox1.Controls.Add(this.textOrdersCount);
			this.groupBox1.Controls.Add(this.textProductsCount);
			this.groupBox1.Controls.Add(this.textMoneyEarned);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(646, 177);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(566, 132);
			this.groupBox1.TabIndex = 102;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Activity";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// labelEmptyAccounts
			// 
			this.labelEmptyAccounts.Font = new System.Drawing.Font("Segoe UI Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelEmptyAccounts.Location = new System.Drawing.Point(-28, -165);
			this.labelEmptyAccounts.Name = "labelEmptyAccounts";
			this.labelEmptyAccounts.Size = new System.Drawing.Size(600, 737);
			this.labelEmptyAccounts.TabIndex = 105;
			this.labelEmptyAccounts.Text = "No avalible accounts";
			this.labelEmptyAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelEmptyAccounts.Visible = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.labelFirstName);
			this.groupBox2.Controls.Add(this.textFirstName);
			this.groupBox2.Controls.Add(this.labelLastName);
			this.groupBox2.Controls.Add(this.textLastName);
			this.groupBox2.Controls.Add(this.textCreationDate);
			this.groupBox2.Controls.Add(this.textBirthDate);
			this.groupBox2.Controls.Add(this.labelGender);
			this.groupBox2.Controls.Add(this.textGender);
			this.groupBox2.Controls.Add(this.labelBirthDate);
			this.groupBox2.Controls.Add(this.labelCreationDate);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(646, 364);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(566, 186);
			this.groupBox2.TabIndex = 103;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "About";
			this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Light", 24F);
			this.label1.Location = new System.Drawing.Point(937, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(137, 54);
			this.label1.TabIndex = 104;
			this.label1.Text = "Rating:";
			// 
			// FormAccounts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1230, 767);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textRating);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBoxLogo);
			this.Controls.Add(this.textMobileNumber);
			this.Controls.Add(this.textLocation);
			this.Controls.Add(this.textUserName);
			this.Controls.Add(this.labelMobileNumber);
			this.Controls.Add(this.textBoxUsername);
			this.Controls.Add(this.listSellers);
			this.Name = "FormAccounts";
			this.Text = "Sellers";
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

        private System.Windows.Forms.ListView listSellers;
        private System.Windows.Forms.ColumnHeader columnUserName;
        private System.Windows.Forms.ColumnHeader columnRating;
        private System.Windows.Forms.ColumnHeader columnProductsCount;
		private System.Windows.Forms.TextBox textBoxUsername;
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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelEmptyAccounts;
	}
}