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
			this.listViewAccounts = new System.Windows.Forms.ListView();
			this.columnAccountName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnUserRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnCountry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBoxAccountDetails = new System.Windows.Forms.GroupBox();
			this.SuspendLayout();
			// 
			// listViewAccounts
			// 
			this.listViewAccounts.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.listViewAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnAccountName,
            this.columnUserRating,
            this.columnCountry});
			this.listViewAccounts.HoverSelection = true;
			this.listViewAccounts.Location = new System.Drawing.Point(14, 15);
			this.listViewAccounts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.listViewAccounts.Name = "listViewAccounts";
			this.listViewAccounts.Size = new System.Drawing.Size(497, 660);
			this.listViewAccounts.TabIndex = 1;
			this.listViewAccounts.TabStop = false;
			this.listViewAccounts.UseCompatibleStateImageBehavior = false;
			this.listViewAccounts.View = System.Windows.Forms.View.Details;
			// 
			// columnAccountName
			// 
			this.columnAccountName.Text = "Account User Name";
			this.columnAccountName.Width = 252;
			// 
			// columnUserRating
			// 
			this.columnUserRating.Text = "Rating";
			this.columnUserRating.Width = 76;
			// 
			// columnCountry
			// 
			this.columnCountry.Text = "Country";
			this.columnCountry.Width = 92;
			// 
			// groupBoxAccountDetails
			// 
			this.groupBoxAccountDetails.Location = new System.Drawing.Point(519, 15);
			this.groupBoxAccountDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBoxAccountDetails.Name = "groupBoxAccountDetails";
			this.groupBoxAccountDetails.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBoxAccountDetails.Size = new System.Drawing.Size(498, 661);
			this.groupBoxAccountDetails.TabIndex = 2;
			this.groupBoxAccountDetails.TabStop = false;
			this.groupBoxAccountDetails.Text = "Product 1";
			// 
			// FormAccounts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1031, 690);
			this.Controls.Add(this.groupBoxAccountDetails);
			this.Controls.Add(this.listViewAccounts);
			this.Name = "FormAccounts";
			this.Text = "Accounts";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewAccounts;
        private System.Windows.Forms.ColumnHeader columnAccountName;
        private System.Windows.Forms.ColumnHeader columnUserRating;
        private System.Windows.Forms.ColumnHeader columnCountry;
		private System.Windows.Forms.GroupBox groupBoxAccountDetails;
	}
}