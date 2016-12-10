namespace DeliveryMarket
{
    partial class FormMain
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
            this.labelLogo = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonViewProducts = new System.Windows.Forms.Button();
            this.buttonViewSellers = new System.Windows.Forms.Button();
            this.buttonAdminPanel = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.Location = new System.Drawing.Point(12, 9);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(215, 41);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "Delivery Market";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(15, 59);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(112, 19);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome Omar...";
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(19, 99);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(195, 40);
            this.buttonAddProduct.TabIndex = 0;
            this.buttonAddProduct.TabStop = false;
            this.buttonAddProduct.Text = "Add Product";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonViewProducts
            // 
            this.buttonViewProducts.Location = new System.Drawing.Point(19, 145);
            this.buttonViewProducts.Name = "buttonViewProducts";
            this.buttonViewProducts.Size = new System.Drawing.Size(195, 40);
            this.buttonViewProducts.TabIndex = 0;
            this.buttonViewProducts.TabStop = false;
            this.buttonViewProducts.Text = "View Products";
            this.buttonViewProducts.UseVisualStyleBackColor = true;
            this.buttonViewProducts.Click += new System.EventHandler(this.buttonViewProducts_Click);
            // 
            // buttonViewSellers
            // 
            this.buttonViewSellers.Location = new System.Drawing.Point(19, 191);
            this.buttonViewSellers.Name = "buttonViewSellers";
            this.buttonViewSellers.Size = new System.Drawing.Size(195, 40);
            this.buttonViewSellers.TabIndex = 0;
            this.buttonViewSellers.TabStop = false;
            this.buttonViewSellers.Text = "View Sellers";
            this.buttonViewSellers.UseVisualStyleBackColor = true;
            this.buttonViewSellers.Click += new System.EventHandler(this.buttonViewSellers_Click);
            // 
            // buttonAdminPanel
            // 
            this.buttonAdminPanel.Location = new System.Drawing.Point(19, 237);
            this.buttonAdminPanel.Name = "buttonAdminPanel";
            this.buttonAdminPanel.Size = new System.Drawing.Size(195, 40);
            this.buttonAdminPanel.TabIndex = 0;
            this.buttonAdminPanel.TabStop = false;
            this.buttonAdminPanel.Text = "Admin Panel";
            this.buttonAdminPanel.UseVisualStyleBackColor = true;
            this.buttonAdminPanel.Click += new System.EventHandler(this.buttonAdminPanel_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(19, 283);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(195, 40);
            this.buttonAbout.TabIndex = 0;
            this.buttonAbout.TabStop = false;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.Location = new System.Drawing.Point(19, 329);
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Size = new System.Drawing.Size(195, 40);
            this.buttonSignOut.TabIndex = 0;
            this.buttonSignOut.TabStop = false;
            this.buttonSignOut.Text = "Sign Out";
            this.buttonSignOut.UseVisualStyleBackColor = true;
            this.buttonSignOut.Click += new System.EventHandler(this.buttonSignOut_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 381);
            this.Controls.Add(this.buttonSignOut);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonAdminPanel);
            this.Controls.Add(this.buttonViewSellers);
            this.Controls.Add(this.buttonViewProducts);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.labelLogo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery Market";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonViewProducts;
        private System.Windows.Forms.Button buttonViewSellers;
        private System.Windows.Forms.Button buttonAdminPanel;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonSignOut;
    }
}

