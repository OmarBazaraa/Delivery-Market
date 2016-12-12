namespace DeliveryMarket.Product {

	partial class FormSaveProduct {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSaveProduct));
			this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
			this.labelName = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelCategory = new System.Windows.Forms.Label();
			this.comboBoxCategory = new System.Windows.Forms.ComboBox();
			this.labelPrice = new System.Windows.Forms.Label();
			this.numericPrice = new System.Windows.Forms.NumericUpDown();
			this.labelQuantity = new System.Windows.Forms.Label();
			this.numericQuantity = new System.Windows.Forms.NumericUpDown();
			this.labelDescription = new System.Windows.Forms.Label();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.labelImage = new System.Windows.Forms.Label();
			this.pictureBoxImage = new System.Windows.Forms.PictureBox();
			this.labelImagePath = new System.Windows.Forms.Label();
			this.textBoxImagePath = new System.Windows.Forms.TextBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonBrowse = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxLogo
			// 
			this.pictureBoxLogo.Image = global::DeliveryMarket.Properties.Resources.logo;
			this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
			this.pictureBoxLogo.Name = "pictureBoxLogo";
			this.pictureBoxLogo.Size = new System.Drawing.Size(410, 120);
			this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxLogo.TabIndex = 0;
			this.pictureBoxLogo.TabStop = false;
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(8, 142);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(48, 19);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Name:";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(12, 164);
			this.textBoxName.MaxLength = 50;
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(229, 25);
			this.textBoxName.TabIndex = 1;
			// 
			// labelCategory
			// 
			this.labelCategory.AutoSize = true;
			this.labelCategory.Location = new System.Drawing.Point(8, 192);
			this.labelCategory.Name = "labelCategory";
			this.labelCategory.Size = new System.Drawing.Size(68, 19);
			this.labelCategory.TabIndex = 0;
			this.labelCategory.Text = "Category:";
			// 
			// comboBoxCategory
			// 
			this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCategory.FormattingEnabled = true;
			this.comboBoxCategory.Location = new System.Drawing.Point(12, 214);
			this.comboBoxCategory.Name = "comboBoxCategory";
			this.comboBoxCategory.Size = new System.Drawing.Size(229, 25);
			this.comboBoxCategory.TabIndex = 2;
			// 
			// labelPrice
			// 
			this.labelPrice.AutoSize = true;
			this.labelPrice.Location = new System.Drawing.Point(8, 242);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(41, 19);
			this.labelPrice.TabIndex = 0;
			this.labelPrice.Text = "Price:";
			// 
			// numericPrice
			// 
			this.numericPrice.DecimalPlaces = 2;
			this.numericPrice.Location = new System.Drawing.Point(12, 264);
			this.numericPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.numericPrice.Name = "numericPrice";
			this.numericPrice.Size = new System.Drawing.Size(229, 25);
			this.numericPrice.TabIndex = 3;
			this.numericPrice.ThousandsSeparator = true;
			// 
			// labelQuantity
			// 
			this.labelQuantity.AutoSize = true;
			this.labelQuantity.Location = new System.Drawing.Point(8, 292);
			this.labelQuantity.Name = "labelQuantity";
			this.labelQuantity.Size = new System.Drawing.Size(66, 19);
			this.labelQuantity.TabIndex = 0;
			this.labelQuantity.Text = "Quantity:";
			// 
			// numericQuantity
			// 
			this.numericQuantity.Location = new System.Drawing.Point(12, 314);
			this.numericQuantity.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.numericQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericQuantity.Name = "numericQuantity";
			this.numericQuantity.Size = new System.Drawing.Size(229, 25);
			this.numericQuantity.TabIndex = 4;
			this.numericQuantity.ThousandsSeparator = true;
			this.numericQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// labelDescription
			// 
			this.labelDescription.AutoSize = true;
			this.labelDescription.Location = new System.Drawing.Point(8, 342);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(81, 19);
			this.labelDescription.TabIndex = 0;
			this.labelDescription.Text = "Description:";
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Location = new System.Drawing.Point(12, 364);
			this.textBoxDescription.Multiline = true;
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.Size = new System.Drawing.Size(410, 94);
			this.textBoxDescription.TabIndex = 5;
			// 
			// labelImage
			// 
			this.labelImage.AutoSize = true;
			this.labelImage.Location = new System.Drawing.Point(243, 142);
			this.labelImage.Name = "labelImage";
			this.labelImage.Size = new System.Drawing.Size(50, 19);
			this.labelImage.TabIndex = 0;
			this.labelImage.Text = "Image:";
			// 
			// pictureBoxImage
			// 
			this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxImage.Location = new System.Drawing.Point(247, 164);
			this.pictureBoxImage.Name = "pictureBoxImage";
			this.pictureBoxImage.Size = new System.Drawing.Size(175, 175);
			this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxImage.TabIndex = 10;
			this.pictureBoxImage.TabStop = false;
			// 
			// labelImagePath
			// 
			this.labelImagePath.AutoSize = true;
			this.labelImagePath.Location = new System.Drawing.Point(8, 461);
			this.labelImagePath.Name = "labelImagePath";
			this.labelImagePath.Size = new System.Drawing.Size(82, 19);
			this.labelImagePath.TabIndex = 0;
			this.labelImagePath.Text = "Image Path:";
			// 
			// textBoxImagePath
			// 
			this.textBoxImagePath.Location = new System.Drawing.Point(12, 483);
			this.textBoxImagePath.Name = "textBoxImagePath";
			this.textBoxImagePath.ReadOnly = true;
			this.textBoxImagePath.Size = new System.Drawing.Size(410, 25);
			this.textBoxImagePath.TabIndex = 0;
			this.textBoxImagePath.TabStop = false;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(347, 514);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 35);
			this.buttonSave.TabIndex = 0;
			this.buttonSave.TabStop = false;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			this.buttonSave.GotFocus += new System.EventHandler(this.LoseFocus);
			// 
			// buttonBrowse
			// 
			this.buttonBrowse.Location = new System.Drawing.Point(266, 514);
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.Size = new System.Drawing.Size(75, 35);
			this.buttonBrowse.TabIndex = 0;
			this.buttonBrowse.TabStop = false;
			this.buttonBrowse.Text = "Browse";
			this.buttonBrowse.UseVisualStyleBackColor = true;
			this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
			this.buttonBrowse.GotFocus += new System.EventHandler(this.LoseFocus);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(185, 514);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 35);
			this.buttonCancel.TabIndex = 0;
			this.buttonCancel.TabStop = false;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			this.buttonCancel.GotFocus += new System.EventHandler(this.LoseFocus);
			// 
			// openFileDialog
			// 
			this.openFileDialog.Filter = "Image Files|*PNG;*.JPG;*.BMP;*.GIF";
			// 
			// FormSaveProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 561);
			this.Controls.Add(this.pictureBoxLogo);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.labelCategory);
			this.Controls.Add(this.comboBoxCategory);
			this.Controls.Add(this.labelPrice);
			this.Controls.Add(this.numericPrice);
			this.Controls.Add(this.labelQuantity);
			this.Controls.Add(this.numericQuantity);
			this.Controls.Add(this.labelDescription);
			this.Controls.Add(this.textBoxDescription);
			this.Controls.Add(this.labelImage);
			this.Controls.Add(this.pictureBoxImage);
			this.Controls.Add(this.labelImagePath);
			this.Controls.Add(this.textBoxImagePath);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonBrowse);
			this.Controls.Add(this.buttonSave);
			this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "FormSaveProduct";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Delivery Market";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSaveProduct_FormClosed);
			this.Load += new System.EventHandler(this.FormSaveProduct_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.PictureBox pictureBoxLogo;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label labelCategory;
		private System.Windows.Forms.ComboBox comboBoxCategory;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.NumericUpDown numericPrice;
		private System.Windows.Forms.Label labelQuantity;
		private System.Windows.Forms.NumericUpDown numericQuantity;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.TextBox textBoxDescription;
		private System.Windows.Forms.Label labelImage;
		private System.Windows.Forms.PictureBox pictureBoxImage;
		private System.Windows.Forms.Label labelImagePath;
		private System.Windows.Forms.TextBox textBoxImagePath;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonBrowse;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
	}
}