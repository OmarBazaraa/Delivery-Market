namespace DeliveryMarket {
	partial class FormMain {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
			this.labelWelcome = new System.Windows.Forms.Label();
			this.buttonAddProduct = new System.Windows.Forms.Button();
			this.buttonViewProducts = new System.Windows.Forms.Button();
			this.buttonViewSellers = new System.Windows.Forms.Button();
			this.buttonAdminPanel = new System.Windows.Forms.Button();
			this.buttonAbout = new System.Windows.Forms.Button();
			this.buttonSignOut = new System.Windows.Forms.Button();
			this.buttonViewProfile = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxLogo
			// 
			this.pictureBoxLogo.Image = global::DeliveryMarket.Properties.Resources.logo;
			this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
			this.pictureBoxLogo.Name = "pictureBoxLogo";
			this.pictureBoxLogo.Size = new System.Drawing.Size(260, 80);
			this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxLogo.TabIndex = 0;
			this.pictureBoxLogo.TabStop = false;
			// 
			// labelWelcome
			// 
			this.labelWelcome.Location = new System.Drawing.Point(12, 95);
			this.labelWelcome.Name = "labelWelcome";
			this.labelWelcome.Size = new System.Drawing.Size(260, 40);
			this.labelWelcome.TabIndex = 0;
			this.labelWelcome.Text = "Welcome guest...";
			this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonAddProduct
			// 
			this.buttonAddProduct.Location = new System.Drawing.Point(12, 139);
			this.buttonAddProduct.Name = "buttonAddProduct";
			this.buttonAddProduct.Size = new System.Drawing.Size(260, 40);
			this.buttonAddProduct.TabIndex = 0;
			this.buttonAddProduct.TabStop = false;
			this.buttonAddProduct.Text = "Add Product";
			this.buttonAddProduct.UseVisualStyleBackColor = true;
			this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
			this.buttonAddProduct.GotFocus += new System.EventHandler(this.LoseFocus);
			// 
			// buttonViewProducts
			// 
			this.buttonViewProducts.Location = new System.Drawing.Point(12, 185);
			this.buttonViewProducts.Name = "buttonViewProducts";
			this.buttonViewProducts.Size = new System.Drawing.Size(260, 40);
			this.buttonViewProducts.TabIndex = 0;
			this.buttonViewProducts.TabStop = false;
			this.buttonViewProducts.Text = "View Products";
			this.buttonViewProducts.UseVisualStyleBackColor = true;
			this.buttonViewProducts.Click += new System.EventHandler(this.buttonViewProducts_Click);
			this.buttonViewProducts.GotFocus += new System.EventHandler(this.LoseFocus);
			// 
			// buttonViewSellers
			// 
			this.buttonViewSellers.Location = new System.Drawing.Point(12, 231);
			this.buttonViewSellers.Name = "buttonViewSellers";
			this.buttonViewSellers.Size = new System.Drawing.Size(260, 40);
			this.buttonViewSellers.TabIndex = 0;
			this.buttonViewSellers.TabStop = false;
			this.buttonViewSellers.Text = "View Sellers";
			this.buttonViewSellers.UseVisualStyleBackColor = true;
			this.buttonViewSellers.Click += new System.EventHandler(this.buttonViewSellers_Click);
			this.buttonViewSellers.GotFocus += new System.EventHandler(this.LoseFocus);
			// 
			// buttonAdminPanel
			// 
			this.buttonAdminPanel.Location = new System.Drawing.Point(12, 323);
			this.buttonAdminPanel.Name = "buttonAdminPanel";
			this.buttonAdminPanel.Size = new System.Drawing.Size(260, 40);
			this.buttonAdminPanel.TabIndex = 0;
			this.buttonAdminPanel.TabStop = false;
			this.buttonAdminPanel.Text = "Admin Panel";
			this.buttonAdminPanel.UseVisualStyleBackColor = true;
			this.buttonAdminPanel.Click += new System.EventHandler(this.buttonAdminPanel_Click);
			this.buttonAdminPanel.GotFocus += new System.EventHandler(this.LoseFocus);
			// 
			// buttonAbout
			// 
			this.buttonAbout.Location = new System.Drawing.Point(12, 369);
			this.buttonAbout.Name = "buttonAbout";
			this.buttonAbout.Size = new System.Drawing.Size(260, 40);
			this.buttonAbout.TabIndex = 0;
			this.buttonAbout.TabStop = false;
			this.buttonAbout.Text = "About";
			this.buttonAbout.UseVisualStyleBackColor = true;
			this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
			this.buttonAbout.GotFocus += new System.EventHandler(this.LoseFocus);
			// 
			// buttonSignOut
			// 
			this.buttonSignOut.Location = new System.Drawing.Point(12, 415);
			this.buttonSignOut.Name = "buttonSignOut";
			this.buttonSignOut.Size = new System.Drawing.Size(260, 40);
			this.buttonSignOut.TabIndex = 0;
			this.buttonSignOut.TabStop = false;
			this.buttonSignOut.Text = "Sign Out";
			this.buttonSignOut.UseVisualStyleBackColor = true;
			this.buttonSignOut.Click += new System.EventHandler(this.buttonSignOut_Click);
			this.buttonSignOut.GotFocus += new System.EventHandler(this.LoseFocus);
			// 
			// buttonViewProfile
			// 
			this.buttonViewProfile.Location = new System.Drawing.Point(12, 277);
			this.buttonViewProfile.Name = "buttonViewProfile";
			this.buttonViewProfile.Size = new System.Drawing.Size(260, 40);
			this.buttonViewProfile.TabIndex = 1;
			this.buttonViewProfile.TabStop = false;
			this.buttonViewProfile.Text = "View Profile";
			this.buttonViewProfile.UseVisualStyleBackColor = true;
			this.buttonViewProfile.Click += new System.EventHandler(this.buttonViewOrders_Click);
			this.buttonViewProfile.GotFocus += new System.EventHandler(this.LoseFocus);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 467);
			this.Controls.Add(this.buttonViewProfile);
			this.Controls.Add(this.pictureBoxLogo);
			this.Controls.Add(this.labelWelcome);
			this.Controls.Add(this.buttonAddProduct);
			this.Controls.Add(this.buttonViewProducts);
			this.Controls.Add(this.buttonViewSellers);
			this.Controls.Add(this.buttonAdminPanel);
			this.Controls.Add(this.buttonAbout);
			this.Controls.Add(this.buttonSignOut);
			this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Delivery Market";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
			this.Load += new System.EventHandler(this.FormMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.PictureBox pictureBoxLogo;
		private System.Windows.Forms.Label labelWelcome;
		private System.Windows.Forms.Button buttonAddProduct;
		private System.Windows.Forms.Button buttonViewProducts;
		private System.Windows.Forms.Button buttonViewSellers;
		private System.Windows.Forms.Button buttonAdminPanel;
		private System.Windows.Forms.Button buttonAbout;
		private System.Windows.Forms.Button buttonSignOut;
		private System.Windows.Forms.Button buttonViewProfile;
	}
}