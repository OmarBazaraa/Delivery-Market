namespace DeliveryMarket.Orders {
	partial class FormOrders {
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
			this.listOrders = new System.Windows.Forms.ListView();
			this.columnProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textUserName = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textProductName = new System.Windows.Forms.Label();
			this.textPrice = new System.Windows.Forms.Label();
			this.textQuantity = new System.Windows.Forms.Label();
			this.textTransactionCompany = new System.Windows.Forms.Label();
			this.textTransportCompany = new System.Windows.Forms.Label();
			this.textOrderDate = new System.Windows.Forms.Label();
			this.textAddress = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textOrdersCount = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// listOrders
			// 
			this.listOrders.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.listOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnProductName,
            this.columnPrice,
            this.columnQuantity});
			this.listOrders.Font = new System.Drawing.Font("Tahoma", 12F);
			this.listOrders.GridLines = true;
			this.listOrders.HoverSelection = true;
			this.listOrders.Location = new System.Drawing.Point(12, 49);
			this.listOrders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.listOrders.Name = "listOrders";
			this.listOrders.Size = new System.Drawing.Size(610, 515);
			this.listOrders.TabIndex = 2;
			this.listOrders.TabStop = false;
			this.listOrders.UseCompatibleStateImageBehavior = false;
			this.listOrders.View = System.Windows.Forms.View.Details;
			this.listOrders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listOrders_MouseDoubleClick);
			// 
			// columnProductName
			// 
			this.columnProductName.Text = "Product Name";
			this.columnProductName.Width = 235;
			// 
			// columnPrice
			// 
			this.columnPrice.Text = "Price";
			this.columnPrice.Width = 167;
			// 
			// columnQuantity
			// 
			this.columnQuantity.Text = "Quantity";
			this.columnQuantity.Width = 155;
			// 
			// pictureBoxLogo
			// 
			this.pictureBoxLogo.Image = global::DeliveryMarket.Properties.Resources.logo;
			this.pictureBoxLogo.Location = new System.Drawing.Point(952, 13);
			this.pictureBoxLogo.Name = "pictureBoxLogo";
			this.pictureBoxLogo.Size = new System.Drawing.Size(272, 115);
			this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxLogo.TabIndex = 3;
			this.pictureBoxLogo.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(643, 104);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 24);
			this.label1.TabIndex = 4;
			this.label1.Text = "User Name:";
			// 
			// textUserName
			// 
			this.textUserName.AutoSize = true;
			this.textUserName.Font = new System.Drawing.Font("Tahoma", 12F);
			this.textUserName.Location = new System.Drawing.Point(776, 104);
			this.textUserName.Name = "textUserName";
			this.textUserName.Size = new System.Drawing.Size(111, 24);
			this.textUserName.TabIndex = 8;
			this.textUserName.Text = "hanisayd96";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(643, 206);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(137, 21);
			this.label2.TabIndex = 9;
			this.label2.Text = "Product Name:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(1062, 206);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 21);
			this.label3.TabIndex = 10;
			this.label3.Text = "Quanity:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(925, 206);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 21);
			this.label4.TabIndex = 11;
			this.label4.Text = "Price:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.label6.Location = new System.Drawing.Point(643, 264);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(201, 21);
			this.label6.TabIndex = 12;
			this.label6.Text = "Transaction Company:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.label7.Location = new System.Drawing.Point(643, 373);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(109, 21);
			this.label7.TabIndex = 13;
			this.label7.Text = "Order Date:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.label8.Location = new System.Drawing.Point(643, 320);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(184, 21);
			this.label8.TabIndex = 14;
			this.label8.Text = "Transport Company:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.label9.Location = new System.Drawing.Point(643, 425);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(85, 21);
			this.label9.TabIndex = 15;
			this.label9.Text = "Address:";
			// 
			// textProductName
			// 
			this.textProductName.AutoSize = true;
			this.textProductName.Font = new System.Drawing.Font("Tahoma", 10.5F);
			this.textProductName.Location = new System.Drawing.Point(786, 205);
			this.textProductName.Name = "textProductName";
			this.textProductName.Size = new System.Drawing.Size(39, 22);
			this.textProductName.TabIndex = 16;
			this.textProductName.Text = "Pen";
			// 
			// textPrice
			// 
			this.textPrice.AutoSize = true;
			this.textPrice.Font = new System.Drawing.Font("Tahoma", 10.5F);
			this.textPrice.Location = new System.Drawing.Point(989, 205);
			this.textPrice.Name = "textPrice";
			this.textPrice.Size = new System.Drawing.Size(50, 22);
			this.textPrice.TabIndex = 17;
			this.textPrice.Text = "115$";
			// 
			// textQuantity
			// 
			this.textQuantity.AutoSize = true;
			this.textQuantity.Font = new System.Drawing.Font("Tahoma", 10.5F);
			this.textQuantity.Location = new System.Drawing.Point(1151, 206);
			this.textQuantity.Name = "textQuantity";
			this.textQuantity.Size = new System.Drawing.Size(76, 22);
			this.textQuantity.TabIndex = 18;
			this.textQuantity.Text = "12 piece";
			// 
			// textTransactionCompany
			// 
			this.textTransactionCompany.AutoSize = true;
			this.textTransactionCompany.Font = new System.Drawing.Font("Tahoma", 10.5F);
			this.textTransactionCompany.Location = new System.Drawing.Point(850, 264);
			this.textTransactionCompany.Name = "textTransactionCompany";
			this.textTransactionCompany.Size = new System.Drawing.Size(65, 22);
			this.textTransactionCompany.TabIndex = 19;
			this.textTransactionCompany.Text = "PayPall";
			// 
			// textTransportCompany
			// 
			this.textTransportCompany.AutoSize = true;
			this.textTransportCompany.Font = new System.Drawing.Font("Tahoma", 10.5F);
			this.textTransportCompany.Location = new System.Drawing.Point(833, 319);
			this.textTransportCompany.Name = "textTransportCompany";
			this.textTransportCompany.Size = new System.Drawing.Size(95, 22);
			this.textTransportCompany.TabIndex = 20;
			this.textTransportCompany.Text = "Egypt Post";
			// 
			// textOrderDate
			// 
			this.textOrderDate.AutoSize = true;
			this.textOrderDate.Font = new System.Drawing.Font("Tahoma", 10.5F);
			this.textOrderDate.Location = new System.Drawing.Point(758, 372);
			this.textOrderDate.Name = "textOrderDate";
			this.textOrderDate.Size = new System.Drawing.Size(104, 22);
			this.textOrderDate.TabIndex = 21;
			this.textOrderDate.Text = "2015/11/01";
			// 
			// textAddress
			// 
			this.textAddress.AutoSize = true;
			this.textAddress.Font = new System.Drawing.Font("Tahoma", 10.5F);
			this.textAddress.Location = new System.Drawing.Point(734, 424);
			this.textAddress.Name = "textAddress";
			this.textAddress.Size = new System.Drawing.Size(158, 22);
			this.textAddress.TabIndex = 22;
			this.textAddress.Text = "21 - Haroon Street";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.label5.Location = new System.Drawing.Point(12, 13);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(129, 21);
			this.label5.TabIndex = 23;
			this.label5.Text = "Orders Count:";
			// 
			// textOrdersCount
			// 
			this.textOrdersCount.AutoSize = true;
			this.textOrdersCount.Font = new System.Drawing.Font("Tahoma", 10.5F);
			this.textOrdersCount.Location = new System.Drawing.Point(147, 12);
			this.textOrdersCount.Name = "textOrdersCount";
			this.textOrdersCount.Size = new System.Drawing.Size(0, 22);
			this.textOrdersCount.TabIndex = 24;
			// 
			// FormOrders
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1236, 574);
			this.Controls.Add(this.textOrdersCount);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textAddress);
			this.Controls.Add(this.textOrderDate);
			this.Controls.Add(this.textTransportCompany);
			this.Controls.Add(this.textTransactionCompany);
			this.Controls.Add(this.textQuantity);
			this.Controls.Add(this.textPrice);
			this.Controls.Add(this.textProductName);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textUserName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBoxLogo);
			this.Controls.Add(this.listOrders);
			this.Name = "FormOrders";
			this.Text = "Orders";
			this.Load += new System.EventHandler(this.FormOrders_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listOrders;
		private System.Windows.Forms.ColumnHeader columnProductName;
		private System.Windows.Forms.ColumnHeader columnPrice;
		private System.Windows.Forms.ColumnHeader columnQuantity;
		private System.Windows.Forms.PictureBox pictureBoxLogo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label textUserName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label textProductName;
		private System.Windows.Forms.Label textPrice;
		private System.Windows.Forms.Label textQuantity;
		private System.Windows.Forms.Label textTransactionCompany;
		private System.Windows.Forms.Label textTransportCompany;
		private System.Windows.Forms.Label textOrderDate;
		private System.Windows.Forms.Label textAddress;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label textOrdersCount;
	}
}