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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBanUser));
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonBan = new System.Windows.Forms.Button();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.labelDescription = new System.Windows.Forms.Label();
			this.comboBoxReasons = new System.Windows.Forms.ComboBox();
			this.labelReason = new System.Windows.Forms.Label();
			this.SuspendLayout();
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
			// buttonBan
			// 
			this.buttonBan.Location = new System.Drawing.Point(197, 214);
			this.buttonBan.Name = "buttonBan";
			this.buttonBan.Size = new System.Drawing.Size(75, 35);
			this.buttonBan.TabIndex = 0;
			this.buttonBan.TabStop = false;
			this.buttonBan.Text = "Ban";
			this.buttonBan.UseVisualStyleBackColor = true;
			this.buttonBan.Click += new System.EventHandler(this.buttonBan_Click);
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
			// labelDescription
			// 
			this.labelDescription.AutoSize = true;
			this.labelDescription.Location = new System.Drawing.Point(12, 59);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(81, 19);
			this.labelDescription.TabIndex = 5;
			this.labelDescription.Text = "Description:";
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
			// labelReason
			// 
			this.labelReason.AutoSize = true;
			this.labelReason.Location = new System.Drawing.Point(12, 9);
			this.labelReason.Name = "labelReason";
			this.labelReason.Size = new System.Drawing.Size(56, 19);
			this.labelReason.TabIndex = 6;
			this.labelReason.Text = "Reason:";
			// 
			// FormBanUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonBan);
			this.Controls.Add(this.textBoxDescription);
			this.Controls.Add(this.labelDescription);
			this.Controls.Add(this.comboBoxReasons);
			this.Controls.Add(this.labelReason);
			this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormBanUser";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Ban User";
			this.Load += new System.EventHandler(this.FormBanUser_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonBan;
		private System.Windows.Forms.TextBox textBoxDescription;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.ComboBox comboBoxReasons;
		private System.Windows.Forms.Label labelReason;
	}
}