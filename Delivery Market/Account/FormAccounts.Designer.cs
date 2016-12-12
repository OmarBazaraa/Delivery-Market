﻿namespace DeliveryMarket.Account
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
			this.columnMobileNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnCountry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.labelName = new System.Windows.Forms.Label();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// listSellers
			// 
			this.listSellers.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.listSellers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnUserName,
            this.columnMobileNumber,
            this.columnCountry});
			this.listSellers.Font = new System.Drawing.Font("Tahoma", 12F);
			this.listSellers.GridLines = true;
			this.listSellers.HoverSelection = true;
			this.listSellers.Location = new System.Drawing.Point(12, 56);
			this.listSellers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.listSellers.Name = "listSellers";
			this.listSellers.Size = new System.Drawing.Size(625, 660);
			this.listSellers.TabIndex = 1;
			this.listSellers.TabStop = false;
			this.listSellers.UseCompatibleStateImageBehavior = false;
			this.listSellers.View = System.Windows.Forms.View.Details;
			// 
			// columnUserName
			// 
			this.columnUserName.Text = "User Name";
			this.columnUserName.Width = 235;
			// 
			// columnMobileNumber
			// 
			this.columnMobileNumber.Text = "Mobile Number";
			this.columnMobileNumber.Width = 167;
			// 
			// columnCountry
			// 
			this.columnCountry.Text = "Country";
			this.columnCountry.Width = 145;
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
			// FormAccounts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(649, 761);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.listSellers);
			this.Name = "FormAccounts";
			this.Text = "Sellers";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listSellers;
        private System.Windows.Forms.ColumnHeader columnUserName;
        private System.Windows.Forms.ColumnHeader columnMobileNumber;
        private System.Windows.Forms.ColumnHeader columnCountry;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox textBoxEmail;
	}
}