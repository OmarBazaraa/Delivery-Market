namespace DeliveryMarket.Account
{
    partial class Sellers
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
			this.columnUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnMobileNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnCountry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.labelEmail = new System.Windows.Forms.Label();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// listViewAccounts
			// 
			this.listViewAccounts.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.listViewAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnUserName,
            this.columnMobileNumber,
            this.columnCountry});
			this.listViewAccounts.Font = new System.Drawing.Font("Tahoma", 12F);
			this.listViewAccounts.GridLines = true;
			this.listViewAccounts.HoverSelection = true;
			this.listViewAccounts.Location = new System.Drawing.Point(12, 56);
			this.listViewAccounts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.listViewAccounts.Name = "listViewAccounts";
			this.listViewAccounts.Size = new System.Drawing.Size(625, 660);
			this.listViewAccounts.TabIndex = 1;
			this.listViewAccounts.TabStop = false;
			this.listViewAccounts.UseCompatibleStateImageBehavior = false;
			this.listViewAccounts.View = System.Windows.Forms.View.Details;
			// 
			// columnUserName
			// 
			this.columnUserName.Text = "User Name";
			this.columnUserName.Width = 215;
			// 
			// columnMobileNumber
			// 
			this.columnMobileNumber.Text = "Mobile Number";
			this.columnMobileNumber.Width = 167;
			// 
			// columnCountry
			// 
			this.columnCountry.Text = "Country";
			this.columnCountry.Width = 92;
			// 
			// labelEmail
			// 
			this.labelEmail.AutoSize = true;
			this.labelEmail.Font = new System.Drawing.Font("Tahoma", 13F);
			this.labelEmail.Location = new System.Drawing.Point(12, 16);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(64, 27);
			this.labelEmail.TabIndex = 2;
			this.labelEmail.Text = "Email";
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
			// Sellers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(649, 761);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.labelEmail);
			this.Controls.Add(this.listViewAccounts);
			this.Name = "Sellers";
			this.Text = "Sellers";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewAccounts;
        private System.Windows.Forms.ColumnHeader columnUserName;
        private System.Windows.Forms.ColumnHeader columnMobileNumber;
        private System.Windows.Forms.ColumnHeader columnCountry;
		private System.Windows.Forms.Label labelEmail;
		private System.Windows.Forms.TextBox textBoxEmail;
	}
}