namespace DeliveryMarket.Admin {
	partial class FormViewAccounts {
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
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.listViewAccounts = new System.Windows.Forms.ListView();
			this.columnAccountID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnAccountType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnCreationDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.labelDetails = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.labelGender = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.labelEMail = new System.Windows.Forms.Label();
			this.labelCreationDate = new System.Windows.Forms.Label();
			this.labelBirthDate = new System.Windows.Forms.Label();
			this.dateTimeBirthDate = new System.Windows.Forms.DateTimePicker();
			this.dateTimeCreationDate = new System.Windows.Forms.DateTimePicker();
			this.labelType = new System.Windows.Forms.Label();
			this.comboBoxType = new System.Windows.Forms.ComboBox();
			this.labelMobileNumber = new System.Windows.Forms.Label();
			this.textBoxMobileNumber = new System.Windows.Forms.TextBox();
			this.labelAddress = new System.Windows.Forms.Label();
			this.textBoxAddress = new System.Windows.Forms.TextBox();
			this.labelID = new System.Windows.Forms.Label();
			this.textBoxID = new System.Windows.Forms.TextBox();
			this.comboBoxGender = new System.Windows.Forms.ComboBox();
			this.labelDescription = new System.Windows.Forms.Label();
			this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
			this.labelReason = new System.Windows.Forms.Label();
			this.comboBoxReason = new System.Windows.Forms.ComboBox();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonApply = new System.Windows.Forms.Button();
			this.labelStartDate = new System.Windows.Forms.Label();
			this.dateTimeStartDate = new System.Windows.Forms.DateTimePicker();
			this.buttonCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Location = new System.Drawing.Point(13, 13);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(183, 22);
			this.textBoxSearch.TabIndex = 0;
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(242, 11);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(114, 30);
			this.buttonSearch.TabIndex = 1;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// listViewAccounts
			// 
			this.listViewAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnAccountID,
            this.columnFirstName,
            this.columnEmail,
            this.columnAccountType,
            this.columnCreationDate});
			this.listViewAccounts.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listViewAccounts.FullRowSelect = true;
			this.listViewAccounts.Location = new System.Drawing.Point(12, 62);
			this.listViewAccounts.MultiSelect = false;
			this.listViewAccounts.Name = "listViewAccounts";
			this.listViewAccounts.Size = new System.Drawing.Size(673, 665);
			this.listViewAccounts.TabIndex = 2;
			this.listViewAccounts.TabStop = false;
			this.listViewAccounts.UseCompatibleStateImageBehavior = false;
			this.listViewAccounts.View = System.Windows.Forms.View.Details;
			this.listViewAccounts.SelectedIndexChanged += new System.EventHandler(this.listViewAccounts_SelectedIndexChanged);
			// 
			// columnAccountID
			// 
			this.columnAccountID.Text = "ID";
			this.columnAccountID.Width = 70;
			// 
			// columnFirstName
			// 
			this.columnFirstName.Text = "First Name";
			this.columnFirstName.Width = 140;
			// 
			// columnEmail
			// 
			this.columnEmail.Text = "E-mail";
			this.columnEmail.Width = 128;
			// 
			// columnAccountType
			// 
			this.columnAccountType.Text = "Account Type";
			this.columnAccountType.Width = 120;
			// 
			// columnCreationDate
			// 
			this.columnCreationDate.Text = "Creation Date";
			this.columnCreationDate.Width = 138;
			// 
			// labelDetails
			// 
			this.labelDetails.AutoSize = true;
			this.labelDetails.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDetails.Location = new System.Drawing.Point(705, 13);
			this.labelDetails.Name = "labelDetails";
			this.labelDetails.Size = new System.Drawing.Size(61, 23);
			this.labelDetails.TabIndex = 3;
			this.labelDetails.Text = "Details";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(818, 96);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.ReadOnly = true;
			this.textBoxName.Size = new System.Drawing.Size(255, 22);
			this.textBoxName.TabIndex = 5;
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(709, 96);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(49, 17);
			this.labelName.TabIndex = 18;
			this.labelName.Text = "Name:";
			// 
			// labelGender
			// 
			this.labelGender.AutoSize = true;
			this.labelGender.Location = new System.Drawing.Point(709, 218);
			this.labelGender.Name = "labelGender";
			this.labelGender.Size = new System.Drawing.Size(60, 17);
			this.labelGender.TabIndex = 21;
			this.labelGender.Text = "Gender:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(1090, 57);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(223, 223);
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Location = new System.Drawing.Point(818, 136);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.ReadOnly = true;
			this.textBoxEmail.Size = new System.Drawing.Size(255, 22);
			this.textBoxEmail.TabIndex = 6;
			// 
			// labelEMail
			// 
			this.labelEMail.AutoSize = true;
			this.labelEMail.Location = new System.Drawing.Point(709, 136);
			this.labelEMail.Name = "labelEMail";
			this.labelEMail.Size = new System.Drawing.Size(51, 17);
			this.labelEMail.TabIndex = 19;
			this.labelEMail.Text = "E-Mail:";
			// 
			// labelCreationDate
			// 
			this.labelCreationDate.AutoSize = true;
			this.labelCreationDate.Location = new System.Drawing.Point(709, 306);
			this.labelCreationDate.Name = "labelCreationDate";
			this.labelCreationDate.Size = new System.Drawing.Size(100, 17);
			this.labelCreationDate.TabIndex = 23;
			this.labelCreationDate.Text = "Creation-Date:";
			// 
			// labelBirthDate
			// 
			this.labelBirthDate.AutoSize = true;
			this.labelBirthDate.Location = new System.Drawing.Point(709, 259);
			this.labelBirthDate.Name = "labelBirthDate";
			this.labelBirthDate.Size = new System.Drawing.Size(76, 17);
			this.labelBirthDate.TabIndex = 22;
			this.labelBirthDate.Text = "Birth-Date:";
			// 
			// dateTimeBirthDate
			// 
			this.dateTimeBirthDate.Enabled = false;
			this.dateTimeBirthDate.Location = new System.Drawing.Point(818, 262);
			this.dateTimeBirthDate.Name = "dateTimeBirthDate";
			this.dateTimeBirthDate.Size = new System.Drawing.Size(255, 22);
			this.dateTimeBirthDate.TabIndex = 9;
			// 
			// dateTimeCreationDate
			// 
			this.dateTimeCreationDate.Enabled = false;
			this.dateTimeCreationDate.Location = new System.Drawing.Point(818, 309);
			this.dateTimeCreationDate.Name = "dateTimeCreationDate";
			this.dateTimeCreationDate.Size = new System.Drawing.Size(255, 22);
			this.dateTimeCreationDate.TabIndex = 10;
			// 
			// labelType
			// 
			this.labelType.AutoSize = true;
			this.labelType.Location = new System.Drawing.Point(709, 387);
			this.labelType.Name = "labelType";
			this.labelType.Size = new System.Drawing.Size(44, 17);
			this.labelType.TabIndex = 25;
			this.labelType.Text = "Type:";
			// 
			// comboBoxType
			// 
			this.comboBoxType.Enabled = false;
			this.comboBoxType.FormattingEnabled = true;
			this.comboBoxType.Location = new System.Drawing.Point(818, 390);
			this.comboBoxType.Name = "comboBoxType";
			this.comboBoxType.Size = new System.Drawing.Size(255, 24);
			this.comboBoxType.TabIndex = 12;
			this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
			// 
			// labelMobileNumber
			// 
			this.labelMobileNumber.AutoSize = true;
			this.labelMobileNumber.Location = new System.Drawing.Point(709, 180);
			this.labelMobileNumber.Name = "labelMobileNumber";
			this.labelMobileNumber.Size = new System.Drawing.Size(107, 17);
			this.labelMobileNumber.TabIndex = 20;
			this.labelMobileNumber.Text = "Mobile Number:";
			// 
			// textBoxMobileNumber
			// 
			this.textBoxMobileNumber.Location = new System.Drawing.Point(818, 177);
			this.textBoxMobileNumber.Name = "textBoxMobileNumber";
			this.textBoxMobileNumber.ReadOnly = true;
			this.textBoxMobileNumber.Size = new System.Drawing.Size(255, 22);
			this.textBoxMobileNumber.TabIndex = 7;
			// 
			// labelAddress
			// 
			this.labelAddress.AutoSize = true;
			this.labelAddress.Location = new System.Drawing.Point(709, 348);
			this.labelAddress.Name = "labelAddress";
			this.labelAddress.Size = new System.Drawing.Size(64, 17);
			this.labelAddress.TabIndex = 24;
			this.labelAddress.Text = "Address:";
			// 
			// textBoxAddress
			// 
			this.textBoxAddress.Location = new System.Drawing.Point(818, 351);
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.ReadOnly = true;
			this.textBoxAddress.Size = new System.Drawing.Size(255, 22);
			this.textBoxAddress.TabIndex = 11;
			// 
			// labelID
			// 
			this.labelID.AutoSize = true;
			this.labelID.Location = new System.Drawing.Point(712, 57);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(25, 17);
			this.labelID.TabIndex = 17;
			this.labelID.Text = "ID:";
			// 
			// textBoxID
			// 
			this.textBoxID.Location = new System.Drawing.Point(818, 57);
			this.textBoxID.Name = "textBoxID";
			this.textBoxID.ReadOnly = true;
			this.textBoxID.Size = new System.Drawing.Size(255, 22);
			this.textBoxID.TabIndex = 4;
			// 
			// comboBoxGender
			// 
			this.comboBoxGender.Enabled = false;
			this.comboBoxGender.FormattingEnabled = true;
			this.comboBoxGender.Location = new System.Drawing.Point(818, 218);
			this.comboBoxGender.Name = "comboBoxGender";
			this.comboBoxGender.Size = new System.Drawing.Size(43, 24);
			this.comboBoxGender.TabIndex = 8;
			// 
			// labelDescription
			// 
			this.labelDescription.AutoSize = true;
			this.labelDescription.Location = new System.Drawing.Point(712, 445);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(83, 17);
			this.labelDescription.TabIndex = 27;
			this.labelDescription.Text = "Description:";
			// 
			// richTextBoxDescription
			// 
			this.richTextBoxDescription.Enabled = false;
			this.richTextBoxDescription.Location = new System.Drawing.Point(712, 468);
			this.richTextBoxDescription.Name = "richTextBoxDescription";
			this.richTextBoxDescription.Size = new System.Drawing.Size(601, 259);
			this.richTextBoxDescription.TabIndex = 14;
			this.richTextBoxDescription.Text = "";
			// 
			// labelReason
			// 
			this.labelReason.AutoSize = true;
			this.labelReason.Location = new System.Drawing.Point(1087, 387);
			this.labelReason.Name = "labelReason";
			this.labelReason.Size = new System.Drawing.Size(57, 17);
			this.labelReason.TabIndex = 26;
			this.labelReason.Text = "Reason";
			// 
			// comboBoxReason
			// 
			this.comboBoxReason.Enabled = false;
			this.comboBoxReason.FormattingEnabled = true;
			this.comboBoxReason.Location = new System.Drawing.Point(1150, 390);
			this.comboBoxReason.Name = "comboBoxReason";
			this.comboBoxReason.Size = new System.Drawing.Size(163, 24);
			this.comboBoxReason.TabIndex = 13;
			// 
			// buttonEdit
			// 
			this.buttonEdit.Location = new System.Drawing.Point(986, 15);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(111, 26);
			this.buttonEdit.TabIndex = 15;
			this.buttonEdit.Text = "Edit";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// buttonApply
			// 
			this.buttonApply.Enabled = false;
			this.buttonApply.Location = new System.Drawing.Point(1103, 15);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new System.Drawing.Size(111, 26);
			this.buttonApply.TabIndex = 16;
			this.buttonApply.Text = "Apply";
			this.buttonApply.UseVisualStyleBackColor = true;
			this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
			// 
			// labelStartDate
			// 
			this.labelStartDate.AutoSize = true;
			this.labelStartDate.Location = new System.Drawing.Point(712, 429);
			this.labelStartDate.Name = "labelStartDate";
			this.labelStartDate.Size = new System.Drawing.Size(72, 17);
			this.labelStartDate.TabIndex = 27;
			this.labelStartDate.Text = "Start Date";
			// 
			// dateTimeStartDate
			// 
			this.dateTimeStartDate.Enabled = false;
			this.dateTimeStartDate.Location = new System.Drawing.Point(818, 429);
			this.dateTimeStartDate.Name = "dateTimeStartDate";
			this.dateTimeStartDate.Size = new System.Drawing.Size(255, 22);
			this.dateTimeStartDate.TabIndex = 14;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Enabled = false;
			this.buttonCancel.Location = new System.Drawing.Point(1220, 15);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(111, 26);
			this.buttonCancel.TabIndex = 28;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// FormViewAccounts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1343, 742);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.dateTimeStartDate);
			this.Controls.Add(this.labelStartDate);
			this.Controls.Add(this.buttonApply);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.comboBoxReason);
			this.Controls.Add(this.labelReason);
			this.Controls.Add(this.labelDescription);
			this.Controls.Add(this.richTextBoxDescription);
			this.Controls.Add(this.comboBoxGender);
			this.Controls.Add(this.labelID);
			this.Controls.Add(this.textBoxID);
			this.Controls.Add(this.labelAddress);
			this.Controls.Add(this.textBoxAddress);
			this.Controls.Add(this.labelMobileNumber);
			this.Controls.Add(this.textBoxMobileNumber);
			this.Controls.Add(this.comboBoxType);
			this.Controls.Add(this.labelType);
			this.Controls.Add(this.dateTimeCreationDate);
			this.Controls.Add(this.dateTimeBirthDate);
			this.Controls.Add(this.labelCreationDate);
			this.Controls.Add(this.labelBirthDate);
			this.Controls.Add(this.labelEMail);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.labelGender);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.labelDetails);
			this.Controls.Add(this.listViewAccounts);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.textBoxSearch);
			this.Name = "FormViewAccounts";
			this.Text = "View Accounts";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormViewAccounts_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.ListView listViewAccounts;
		private System.Windows.Forms.ColumnHeader columnAccountID;
		private System.Windows.Forms.ColumnHeader columnFirstName;
		private System.Windows.Forms.ColumnHeader columnEmail;
		private System.Windows.Forms.ColumnHeader columnAccountType;
		private System.Windows.Forms.ColumnHeader columnCreationDate;
		private System.Windows.Forms.Label labelDetails;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelGender;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox textBoxEmail;
		private System.Windows.Forms.Label labelEMail;
		private System.Windows.Forms.Label labelCreationDate;
		private System.Windows.Forms.Label labelBirthDate;
		private System.Windows.Forms.DateTimePicker dateTimeBirthDate;
		private System.Windows.Forms.DateTimePicker dateTimeCreationDate;
		private System.Windows.Forms.Label labelType;
		private System.Windows.Forms.ComboBox comboBoxType;
		private System.Windows.Forms.Label labelMobileNumber;
		private System.Windows.Forms.TextBox textBoxMobileNumber;
		private System.Windows.Forms.Label labelAddress;
		private System.Windows.Forms.TextBox textBoxAddress;
		private System.Windows.Forms.Label labelID;
		private System.Windows.Forms.TextBox textBoxID;
		private System.Windows.Forms.ComboBox comboBoxGender;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.RichTextBox richTextBoxDescription;
		private System.Windows.Forms.Label labelReason;
		private System.Windows.Forms.ComboBox comboBoxReason;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonApply;
		private System.Windows.Forms.Label labelStartDate;
		private System.Windows.Forms.DateTimePicker dateTimeStartDate;
		private System.Windows.Forms.Button buttonCancel;
	}
}