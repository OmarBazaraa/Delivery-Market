namespace DeliveryMarket.Product
{
    partial class FormBuyProduct
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
			this.labelProductName = new System.Windows.Forms.Label();
			this.labelPrice = new System.Windows.Forms.Label();
			this.labelQuantity = new System.Windows.Forms.Label();
			this.numericQuantity = new System.Windows.Forms.NumericUpDown();
			this.labelTransaction = new System.Windows.Forms.Label();
			this.comboBoxTransaction = new System.Windows.Forms.ComboBox();
			this.comboBoxTransport = new System.Windows.Forms.ComboBox();
			this.labelTransport = new System.Windows.Forms.Label();
			this.labelAddress = new System.Windows.Forms.Label();
			this.textBoxAddress = new System.Windows.Forms.TextBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonBuy = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
			this.SuspendLayout();
			// 
			// labelProductName
			// 
			this.labelProductName.AutoSize = true;
			this.labelProductName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelProductName.Location = new System.Drawing.Point(7, 9);
			this.labelProductName.Name = "labelProductName";
			this.labelProductName.Size = new System.Drawing.Size(133, 25);
			this.labelProductName.TabIndex = 0;
			this.labelProductName.Text = "Product Name";
			// 
			// labelPrice
			// 
			this.labelPrice.AutoSize = true;
			this.labelPrice.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPrice.Location = new System.Drawing.Point(8, 34);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(94, 21);
			this.labelPrice.TabIndex = 1;
			this.labelPrice.Text = "Price: 99.99$";
			// 
			// labelQuantity
			// 
			this.labelQuantity.AutoSize = true;
			this.labelQuantity.Location = new System.Drawing.Point(8, 71);
			this.labelQuantity.Name = "labelQuantity";
			this.labelQuantity.Size = new System.Drawing.Size(66, 19);
			this.labelQuantity.TabIndex = 2;
			this.labelQuantity.Text = "Quantity:";
			// 
			// numericQuantity
			// 
			this.numericQuantity.Location = new System.Drawing.Point(12, 93);
			this.numericQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericQuantity.Name = "numericQuantity";
			this.numericQuantity.Size = new System.Drawing.Size(260, 25);
			this.numericQuantity.TabIndex = 3;
			this.numericQuantity.ThousandsSeparator = true;
			this.numericQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// labelTransaction
			// 
			this.labelTransaction.AutoSize = true;
			this.labelTransaction.Location = new System.Drawing.Point(8, 121);
			this.labelTransaction.Name = "labelTransaction";
			this.labelTransaction.Size = new System.Drawing.Size(144, 19);
			this.labelTransaction.TabIndex = 4;
			this.labelTransaction.Text = "Transaction Company:";
			// 
			// comboBoxTransaction
			// 
			this.comboBoxTransaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTransaction.FormattingEnabled = true;
			this.comboBoxTransaction.Location = new System.Drawing.Point(12, 143);
			this.comboBoxTransaction.Name = "comboBoxTransaction";
			this.comboBoxTransaction.Size = new System.Drawing.Size(260, 25);
			this.comboBoxTransaction.TabIndex = 5;
			// 
			// comboBoxTransport
			// 
			this.comboBoxTransport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTransport.FormattingEnabled = true;
			this.comboBoxTransport.Location = new System.Drawing.Point(12, 193);
			this.comboBoxTransport.Name = "comboBoxTransport";
			this.comboBoxTransport.Size = new System.Drawing.Size(260, 25);
			this.comboBoxTransport.TabIndex = 7;
			// 
			// labelTransport
			// 
			this.labelTransport.AutoSize = true;
			this.labelTransport.Location = new System.Drawing.Point(8, 171);
			this.labelTransport.Name = "labelTransport";
			this.labelTransport.Size = new System.Drawing.Size(133, 19);
			this.labelTransport.TabIndex = 6;
			this.labelTransport.Text = "Transport Company:";
			// 
			// labelAddress
			// 
			this.labelAddress.AutoSize = true;
			this.labelAddress.Location = new System.Drawing.Point(8, 221);
			this.labelAddress.Name = "labelAddress";
			this.labelAddress.Size = new System.Drawing.Size(61, 19);
			this.labelAddress.TabIndex = 8;
			this.labelAddress.Text = "Address:";
			// 
			// textBoxAddress
			// 
			this.textBoxAddress.Location = new System.Drawing.Point(12, 243);
			this.textBoxAddress.MaxLength = 500;
			this.textBoxAddress.Multiline = true;
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.Size = new System.Drawing.Size(260, 90);
			this.textBoxAddress.TabIndex = 9;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(116, 339);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 35);
			this.buttonCancel.TabIndex = 0;
			this.buttonCancel.TabStop = false;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonBuy
			// 
			this.buttonBuy.Location = new System.Drawing.Point(197, 339);
			this.buttonBuy.Name = "buttonBuy";
			this.buttonBuy.Size = new System.Drawing.Size(75, 35);
			this.buttonBuy.TabIndex = 0;
			this.buttonBuy.TabStop = false;
			this.buttonBuy.Text = "Buy";
			this.buttonBuy.UseVisualStyleBackColor = true;
			this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
			// 
			// FormBuyProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 386);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonBuy);
			this.Controls.Add(this.textBoxAddress);
			this.Controls.Add(this.labelAddress);
			this.Controls.Add(this.comboBoxTransport);
			this.Controls.Add(this.labelTransport);
			this.Controls.Add(this.comboBoxTransaction);
			this.Controls.Add(this.labelTransaction);
			this.Controls.Add(this.numericQuantity);
			this.Controls.Add(this.labelQuantity);
			this.Controls.Add(this.labelPrice);
			this.Controls.Add(this.labelProductName);
			this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "FormBuyProduct";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Buy Product";
			this.Load += new System.EventHandler(this.FormBuyProduct_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label labelProductName;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.Label labelQuantity;
		private System.Windows.Forms.NumericUpDown numericQuantity;
		private System.Windows.Forms.Label labelTransaction;
		private System.Windows.Forms.ComboBox comboBoxTransaction;
		private System.Windows.Forms.ComboBox comboBoxTransport;
		private System.Windows.Forms.Label labelTransport;
		private System.Windows.Forms.Label labelAddress;
		private System.Windows.Forms.TextBox textBoxAddress;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonBuy;
	}
}