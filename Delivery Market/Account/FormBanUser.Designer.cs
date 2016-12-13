namespace DeliveryMarket.Account {
	partial class FormBanUser {
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.labelDescription = new System.Windows.Forms.Label();
			this.labelReason = new System.Windows.Forms.Label();
			this.buttonBan = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(115, 40);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(155, 24);
			this.comboBox1.TabIndex = 0;
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Location = new System.Drawing.Point(14, 114);
			this.textBoxDescription.MaxLength = 500;
			this.textBoxDescription.Multiline = true;
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.Size = new System.Drawing.Size(256, 127);
			this.textBoxDescription.TabIndex = 3;
			// 
			// labelDescription
			// 
			this.labelDescription.AutoSize = true;
			this.labelDescription.Location = new System.Drawing.Point(12, 78);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(76, 17);
			this.labelDescription.TabIndex = 4;
			this.labelDescription.Text = "Description";
			// 
			// labelReason
			// 
			this.labelReason.AutoSize = true;
			this.labelReason.Location = new System.Drawing.Point(11, 40);
			this.labelReason.Name = "labelReason";
			this.labelReason.Size = new System.Drawing.Size(53, 17);
			this.labelReason.TabIndex = 5;
			this.labelReason.Text = "Reason";
			// 
			// buttonBan
			// 
			this.buttonBan.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.buttonBan.Font = new System.Drawing.Font("Tahoma", 12F);
			this.buttonBan.Location = new System.Drawing.Point(15, 251);
			this.buttonBan.Name = "buttonBan";
			this.buttonBan.Size = new System.Drawing.Size(255, 40);
			this.buttonBan.TabIndex = 44;
			this.buttonBan.TabStop = false;
			this.buttonBan.Text = "Ban";
			this.buttonBan.UseVisualStyleBackColor = false;
			// 
			// FormBanUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(282, 303);
			this.Controls.Add(this.buttonBan);
			this.Controls.Add(this.labelReason);
			this.Controls.Add(this.labelDescription);
			this.Controls.Add(this.textBoxDescription);
			this.Controls.Add(this.comboBox1);
			this.Name = "FormBanUser";
			this.Text = "FormBanUser";
			this.Load += new System.EventHandler(this.FormBanUser_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBoxDescription;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.Label labelReason;
		private System.Windows.Forms.Button buttonBan;
	}
}