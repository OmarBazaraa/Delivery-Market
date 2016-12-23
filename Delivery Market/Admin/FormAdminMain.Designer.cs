namespace DeliveryMarket.Admin
{
    partial class FormAdminMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminMain));
			this.buttonViewAccounts = new System.Windows.Forms.Button();
			this.buttonReports = new System.Windows.Forms.Button();
			this.buttonBack = new System.Windows.Forms.Button();
			this.buttonStatistics = new System.Windows.Forms.Button();
			this.buttonCompanies = new System.Windows.Forms.Button();
			this.buttonExtras = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonViewAccounts
			// 
			this.buttonViewAccounts.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.buttonViewAccounts.Location = new System.Drawing.Point(47, 12);
			this.buttonViewAccounts.Name = "buttonViewAccounts";
			this.buttonViewAccounts.Size = new System.Drawing.Size(251, 47);
			this.buttonViewAccounts.TabIndex = 0;
			this.buttonViewAccounts.Text = "View Accounts";
			this.buttonViewAccounts.UseVisualStyleBackColor = true;
			this.buttonViewAccounts.Click += new System.EventHandler(this.buttonViewAdmins_Click);
			// 
			// buttonReports
			// 
			this.buttonReports.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.buttonReports.Location = new System.Drawing.Point(47, 65);
			this.buttonReports.Name = "buttonReports";
			this.buttonReports.Size = new System.Drawing.Size(251, 47);
			this.buttonReports.TabIndex = 1;
			this.buttonReports.Text = "Reports";
			this.buttonReports.UseVisualStyleBackColor = true;
			this.buttonReports.Click += new System.EventHandler(this.buttonReports_Click);
			// 
			// buttonBack
			// 
			this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.buttonBack.Location = new System.Drawing.Point(47, 505);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(251, 47);
			this.buttonBack.TabIndex = 4;
			this.buttonBack.Text = "Back";
			this.buttonBack.UseVisualStyleBackColor = true;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// buttonStatistics
			// 
			this.buttonStatistics.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.buttonStatistics.Location = new System.Drawing.Point(47, 171);
			this.buttonStatistics.Name = "buttonStatistics";
			this.buttonStatistics.Size = new System.Drawing.Size(251, 47);
			this.buttonStatistics.TabIndex = 3;
			this.buttonStatistics.Text = "Statisitics";
			this.buttonStatistics.UseVisualStyleBackColor = true;
			// 
			// buttonCompanies
			// 
			this.buttonCompanies.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.buttonCompanies.Location = new System.Drawing.Point(47, 118);
			this.buttonCompanies.Name = "buttonCompanies";
			this.buttonCompanies.Size = new System.Drawing.Size(251, 47);
			this.buttonCompanies.TabIndex = 2;
			this.buttonCompanies.Text = "View Companies";
			this.buttonCompanies.UseVisualStyleBackColor = true;
			this.buttonCompanies.Click += new System.EventHandler(this.buttonCompanies_Click);
			// 
			// buttonExtras
			// 
			this.buttonExtras.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.buttonExtras.Location = new System.Drawing.Point(47, 224);
			this.buttonExtras.Name = "buttonExtras";
			this.buttonExtras.Size = new System.Drawing.Size(251, 47);
			this.buttonExtras.TabIndex = 5;
			this.buttonExtras.Text = "Extras";
			this.buttonExtras.UseVisualStyleBackColor = true;
			this.buttonExtras.Click += new System.EventHandler(this.buttonExtras_Click);
			// 
			// FormAdminMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(351, 564);
			this.Controls.Add(this.buttonExtras);
			this.Controls.Add(this.buttonCompanies);
			this.Controls.Add(this.buttonStatistics);
			this.Controls.Add(this.buttonViewAccounts);
			this.Controls.Add(this.buttonReports);
			this.Controls.Add(this.buttonBack);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormAdminMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Admin Panel";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdminMain_FormClosed);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonViewAccounts;
        private System.Windows.Forms.Button buttonReports;
        private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.Button buttonStatistics;
		private System.Windows.Forms.Button buttonCompanies;
		private System.Windows.Forms.Button buttonExtras;
	}
}