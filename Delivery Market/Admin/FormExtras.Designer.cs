namespace DeliveryMarket.Admin {
	partial class FormExtras {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExtras));
			this.listView = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.buttonRemove = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.comboBoxType = new System.Windows.Forms.ComboBox();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listView
			// 
			this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			this.listView.FullRowSelect = true;
			this.listView.Location = new System.Drawing.Point(12, 96);
			this.listView.MultiSelect = false;
			this.listView.Name = "listView";
			this.listView.Size = new System.Drawing.Size(524, 672);
			this.listView.TabIndex = 20;
			this.listView.UseCompatibleStateImageBehavior = false;
			this.listView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Name";
			this.columnHeader1.Width = 200;
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Location = new System.Drawing.Point(12, 68);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(180, 22);
			this.textBoxSearch.TabIndex = 16;
			// 
			// buttonRemove
			// 
			this.buttonRemove.Location = new System.Drawing.Point(308, 774);
			this.buttonRemove.Name = "buttonRemove";
			this.buttonRemove.Size = new System.Drawing.Size(111, 23);
			this.buttonRemove.TabIndex = 19;
			this.buttonRemove.Text = "Remove";
			this.buttonRemove.UseVisualStyleBackColor = true;
			this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(425, 68);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(111, 23);
			this.buttonAdd.TabIndex = 18;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(198, 67);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(122, 23);
			this.buttonSearch.TabIndex = 17;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// comboBoxType
			// 
			this.comboBoxType.FormattingEnabled = true;
			this.comboBoxType.Location = new System.Drawing.Point(12, 12);
			this.comboBoxType.Name = "comboBoxType";
			this.comboBoxType.Size = new System.Drawing.Size(308, 24);
			this.comboBoxType.TabIndex = 21;
			this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
			// 
			// buttonEdit
			// 
			this.buttonEdit.Location = new System.Drawing.Point(425, 774);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(111, 23);
			this.buttonEdit.TabIndex = 22;
			this.buttonEdit.Text = "Edit";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// FormExtras
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(548, 809);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.comboBoxType);
			this.Controls.Add(this.listView);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.buttonRemove);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.buttonSearch);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormExtras";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Extras";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormExtras_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Button buttonRemove;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.ComboBox comboBoxType;
		private System.Windows.Forms.Button buttonEdit;
	}
}