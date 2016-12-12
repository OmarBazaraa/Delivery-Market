namespace DeliveryMarket.Order {
	partial class Orders {
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
			this.dataGridOrders = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridOrders
			// 
			this.dataGridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridOrders.Location = new System.Drawing.Point(12, 12);
			this.dataGridOrders.Name = "dataGridOrders";
			this.dataGridOrders.RowTemplate.Height = 26;
			this.dataGridOrders.ShowRowErrors = false;
			this.dataGridOrders.Size = new System.Drawing.Size(740, 622);
			this.dataGridOrders.TabIndex = 0;
			// 
			// Orders
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(764, 646);
			this.Controls.Add(this.dataGridOrders);
			this.Name = "Orders";
			this.Text = "Orders";
			((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridOrders;
	}
}