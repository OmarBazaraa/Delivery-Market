namespace DeliveryMarket.Admin
{
    partial class FormViewAdmins
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
			this.listViewAdmins = new System.Windows.Forms.ListView();
			this.columnAdminFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnAdminLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnAdminGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnAdminEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnAdminMobileNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnAdminCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.textBoxSearchByName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listViewAdmins
			// 
			this.listViewAdmins.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnAdminFirstName,
            this.columnAdminLastName,
            this.columnAdminGender,
            this.columnAdminEmail,
            this.columnAdminMobileNumber,
            this.columnAdminCity,
            this.columnStartDate});
			this.listViewAdmins.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.listViewAdmins.Location = new System.Drawing.Point(12, 84);
			this.listViewAdmins.MultiSelect = false;
			this.listViewAdmins.Name = "listViewAdmins";
			this.listViewAdmins.Size = new System.Drawing.Size(896, 550);
			this.listViewAdmins.TabIndex = 0;
			this.listViewAdmins.TabStop = false;
			this.listViewAdmins.UseCompatibleStateImageBehavior = false;
			this.listViewAdmins.View = System.Windows.Forms.View.Details;
			// 
			// columnAdminFirstName
			// 
			this.columnAdminFirstName.Text = "First Name";
			this.columnAdminFirstName.Width = 130;
			// 
			// columnAdminLastName
			// 
			this.columnAdminLastName.Text = "Last Name";
			this.columnAdminLastName.Width = 130;
			// 
			// columnAdminGender
			// 
			this.columnAdminGender.Text = "Gender";
			this.columnAdminGender.Width = 70;
			// 
			// columnAdminEmail
			// 
			this.columnAdminEmail.Text = "E-Mail";
			this.columnAdminEmail.Width = 150;
			// 
			// columnAdminMobileNumber
			// 
			this.columnAdminMobileNumber.Text = "Mobile Number";
			this.columnAdminMobileNumber.Width = 150;
			// 
			// columnAdminCity
			// 
			this.columnAdminCity.Text = "City";
			this.columnAdminCity.Width = 130;
			// 
			// columnStartDate
			// 
			this.columnStartDate.Text = "Start Date";
			this.columnStartDate.Width = 132;
			// 
			// textBoxSearchByName
			// 
			this.textBoxSearchByName.Location = new System.Drawing.Point(12, 35);
			this.textBoxSearchByName.Name = "textBoxSearchByName";
			this.textBoxSearchByName.Size = new System.Drawing.Size(219, 22);
			this.textBoxSearchByName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(135, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Search By Name";
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(397, 33);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(252, 27);
			this.buttonSearch.TabIndex = 3;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// FormViewAdmins
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(921, 646);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxSearchByName);
			this.Controls.Add(this.listViewAdmins);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FormViewAdmins";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "View Admins";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormViewAdmins_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.ListView listViewAdmins;
		private System.Windows.Forms.ColumnHeader columnAdminFirstName;
		private System.Windows.Forms.ColumnHeader columnAdminLastName;
		private System.Windows.Forms.ColumnHeader columnAdminEmail;
		private System.Windows.Forms.ColumnHeader columnAdminGender;
		private System.Windows.Forms.ColumnHeader columnAdminMobileNumber;
		private System.Windows.Forms.ColumnHeader columnAdminCity;
		private System.Windows.Forms.ColumnHeader columnStartDate;
		private System.Windows.Forms.TextBox textBoxSearchByName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonSearch;
	}
}