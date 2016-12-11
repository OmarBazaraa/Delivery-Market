namespace DeliveryMarket.Product {
	partial class FormRemoveProduct {
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
			this.labelReason = new System.Windows.Forms.Label();
			this.comboBoxReasons = new System.Windows.Forms.ComboBox();
			this.labelDescription = new System.Windows.Forms.Label();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelReason
			// 
			this.labelReason.AutoSize = true;
			this.labelReason.Location = new System.Drawing.Point(12, 9);
			this.labelReason.Name = "labelReason";
			this.labelReason.Size = new System.Drawing.Size(56, 19);
			this.labelReason.TabIndex = 0;
			this.labelReason.Text = "Reason:";
			// 
			// comboBoxReasons
			// 
			this.comboBoxReasons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxReasons.FormattingEnabled = true;
			this.comboBoxReasons.Location = new System.Drawing.Point(16, 31);
			this.comboBoxReasons.Name = "comboBoxReasons";
			this.comboBoxReasons.Size = new System.Drawing.Size(256, 25);
			this.comboBoxReasons.TabIndex = 1;
			// 
			// labelDescription
			// 
			this.labelDescription.AutoSize = true;
			this.labelDescription.Location = new System.Drawing.Point(12, 59);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(81, 19);
			this.labelDescription.TabIndex = 0;
			this.labelDescription.Text = "Description:";
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Location = new System.Drawing.Point(16, 81);
			this.textBoxDescription.MaxLength = 500;
			this.textBoxDescription.Multiline = true;
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.Size = new System.Drawing.Size(256, 127);
			this.textBoxDescription.TabIndex = 2;
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(197, 214);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(75, 35);
			this.buttonDelete.TabIndex = 0;
			this.buttonDelete.TabStop = false;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(116, 214);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 35);
			this.buttonCancel.TabIndex = 0;
			this.buttonCancel.TabStop = false;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// FormRemoveProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.textBoxDescription);
			this.Controls.Add(this.labelDescription);
			this.Controls.Add(this.comboBoxReasons);
			this.Controls.Add(this.labelReason);
			this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "FormRemoveProduct";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Remove Product";
			this.Load += new System.EventHandler(this.FormRemoveProduct_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelReason;
		private System.Windows.Forms.ComboBox comboBoxReasons;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.TextBox textBoxDescription;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonCancel;
	}
}