namespace DeliveryMarket.Admin {
	partial class FormViewCompanies {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViewCompanies));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.buttonTransportCompanyRemove = new System.Windows.Forms.Button();
			this.buttonTransportCompanyAdd = new System.Windows.Forms.Button();
			this.buttonTransportCompanySearch = new System.Windows.Forms.Button();
			this.textBoxTransportCompanySearch = new System.Windows.Forms.TextBox();
			this.listViewTransportCompanies = new System.Windows.Forms.ListView();
			this.columnTransportCompanyId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnTransportCompanyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.buttonTransactionCompanyRemove = new System.Windows.Forms.Button();
			this.buttonTransactionCompanyAdd = new System.Windows.Forms.Button();
			this.buttonTransactionCompanySearch = new System.Windows.Forms.Button();
			this.textBoxTransactionCompanySearch = new System.Windows.Forms.TextBox();
			this.listViewTransactionCompanies = new System.Windows.Forms.ListView();
			this.columnTransactionCompanyId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnTransactionCompanyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 13);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(516, 742);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.Transparent;
			this.tabPage1.Controls.Add(this.buttonTransportCompanyRemove);
			this.tabPage1.Controls.Add(this.buttonTransportCompanyAdd);
			this.tabPage1.Controls.Add(this.buttonTransportCompanySearch);
			this.tabPage1.Controls.Add(this.textBoxTransportCompanySearch);
			this.tabPage1.Controls.Add(this.listViewTransportCompanies);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(508, 713);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Transport Companies";
			// 
			// buttonTransportCompanyRemove
			// 
			this.buttonTransportCompanyRemove.Location = new System.Drawing.Point(412, 12);
			this.buttonTransportCompanyRemove.Name = "buttonTransportCompanyRemove";
			this.buttonTransportCompanyRemove.Size = new System.Drawing.Size(90, 25);
			this.buttonTransportCompanyRemove.TabIndex = 4;
			this.buttonTransportCompanyRemove.Text = "Remove";
			this.buttonTransportCompanyRemove.UseVisualStyleBackColor = true;
			this.buttonTransportCompanyRemove.Click += new System.EventHandler(this.buttonTransportCompanyRemove_Click);
			// 
			// buttonTransportCompanyAdd
			// 
			this.buttonTransportCompanyAdd.Location = new System.Drawing.Point(345, 12);
			this.buttonTransportCompanyAdd.Name = "buttonTransportCompanyAdd";
			this.buttonTransportCompanyAdd.Size = new System.Drawing.Size(61, 25);
			this.buttonTransportCompanyAdd.TabIndex = 3;
			this.buttonTransportCompanyAdd.Text = "Add";
			this.buttonTransportCompanyAdd.UseVisualStyleBackColor = true;
			this.buttonTransportCompanyAdd.Click += new System.EventHandler(this.buttonTransportCompanyAdd_Click);
			// 
			// buttonTransportCompanySearch
			// 
			this.buttonTransportCompanySearch.Location = new System.Drawing.Point(194, 12);
			this.buttonTransportCompanySearch.Name = "buttonTransportCompanySearch";
			this.buttonTransportCompanySearch.Size = new System.Drawing.Size(122, 25);
			this.buttonTransportCompanySearch.TabIndex = 2;
			this.buttonTransportCompanySearch.Text = "Search";
			this.buttonTransportCompanySearch.UseVisualStyleBackColor = true;
			this.buttonTransportCompanySearch.Click += new System.EventHandler(this.buttonTransportCompanySearch_Click);
			// 
			// textBoxTransportCompanySearch
			// 
			this.textBoxTransportCompanySearch.Location = new System.Drawing.Point(8, 13);
			this.textBoxTransportCompanySearch.Name = "textBoxTransportCompanySearch";
			this.textBoxTransportCompanySearch.Size = new System.Drawing.Size(180, 22);
			this.textBoxTransportCompanySearch.TabIndex = 1;
			// 
			// listViewTransportCompanies
			// 
			this.listViewTransportCompanies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTransportCompanyId,
            this.columnTransportCompanyName});
			this.listViewTransportCompanies.FullRowSelect = true;
			this.listViewTransportCompanies.Location = new System.Drawing.Point(8, 53);
			this.listViewTransportCompanies.MultiSelect = false;
			this.listViewTransportCompanies.Name = "listViewTransportCompanies";
			this.listViewTransportCompanies.Size = new System.Drawing.Size(473, 654);
			this.listViewTransportCompanies.TabIndex = 5;
			this.listViewTransportCompanies.UseCompatibleStateImageBehavior = false;
			this.listViewTransportCompanies.View = System.Windows.Forms.View.Details;
			// 
			// columnTransportCompanyId
			// 
			this.columnTransportCompanyId.Text = "ID";
			// 
			// columnTransportCompanyName
			// 
			this.columnTransportCompanyName.Text = "Name";
			this.columnTransportCompanyName.Width = 200;
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.Transparent;
			this.tabPage2.Controls.Add(this.buttonTransactionCompanyRemove);
			this.tabPage2.Controls.Add(this.buttonTransactionCompanyAdd);
			this.tabPage2.Controls.Add(this.buttonTransactionCompanySearch);
			this.tabPage2.Controls.Add(this.textBoxTransactionCompanySearch);
			this.tabPage2.Controls.Add(this.listViewTransactionCompanies);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(508, 713);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Transaction Companies";
			// 
			// buttonTransactionCompanyRemove
			// 
			this.buttonTransactionCompanyRemove.Location = new System.Drawing.Point(412, 12);
			this.buttonTransactionCompanyRemove.Name = "buttonTransactionCompanyRemove";
			this.buttonTransactionCompanyRemove.Size = new System.Drawing.Size(90, 25);
			this.buttonTransactionCompanyRemove.TabIndex = 9;
			this.buttonTransactionCompanyRemove.Text = "Remove";
			this.buttonTransactionCompanyRemove.UseVisualStyleBackColor = true;
			this.buttonTransactionCompanyRemove.Click += new System.EventHandler(this.buttonTransactionCompanyRemove_Click);
			// 
			// buttonTransactionCompanyAdd
			// 
			this.buttonTransactionCompanyAdd.Location = new System.Drawing.Point(345, 12);
			this.buttonTransactionCompanyAdd.Name = "buttonTransactionCompanyAdd";
			this.buttonTransactionCompanyAdd.Size = new System.Drawing.Size(61, 25);
			this.buttonTransactionCompanyAdd.TabIndex = 8;
			this.buttonTransactionCompanyAdd.Text = "Add";
			this.buttonTransactionCompanyAdd.UseVisualStyleBackColor = true;
			this.buttonTransactionCompanyAdd.Click += new System.EventHandler(this.buttonTransactionCompanyAdd_Click);
			// 
			// buttonTransactionCompanySearch
			// 
			this.buttonTransactionCompanySearch.Location = new System.Drawing.Point(194, 12);
			this.buttonTransactionCompanySearch.Name = "buttonTransactionCompanySearch";
			this.buttonTransactionCompanySearch.Size = new System.Drawing.Size(122, 25);
			this.buttonTransactionCompanySearch.TabIndex = 7;
			this.buttonTransactionCompanySearch.Text = "Search";
			this.buttonTransactionCompanySearch.UseVisualStyleBackColor = true;
			this.buttonTransactionCompanySearch.Click += new System.EventHandler(this.buttonTransactionCompanySearch_Click);
			// 
			// textBoxTransactionCompanySearch
			// 
			this.textBoxTransactionCompanySearch.Location = new System.Drawing.Point(8, 13);
			this.textBoxTransactionCompanySearch.Name = "textBoxTransactionCompanySearch";
			this.textBoxTransactionCompanySearch.Size = new System.Drawing.Size(180, 22);
			this.textBoxTransactionCompanySearch.TabIndex = 6;
			// 
			// listViewTransactionCompanies
			// 
			this.listViewTransactionCompanies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTransactionCompanyId,
            this.columnTransactionCompanyName});
			this.listViewTransactionCompanies.FullRowSelect = true;
			this.listViewTransactionCompanies.Location = new System.Drawing.Point(8, 53);
			this.listViewTransactionCompanies.MultiSelect = false;
			this.listViewTransactionCompanies.Name = "listViewTransactionCompanies";
			this.listViewTransactionCompanies.Size = new System.Drawing.Size(473, 654);
			this.listViewTransactionCompanies.TabIndex = 10;
			this.listViewTransactionCompanies.UseCompatibleStateImageBehavior = false;
			this.listViewTransactionCompanies.View = System.Windows.Forms.View.Details;
			// 
			// columnTransactionCompanyId
			// 
			this.columnTransactionCompanyId.Text = "ID";
			// 
			// columnTransactionCompanyName
			// 
			this.columnTransactionCompanyName.Text = "Name";
			this.columnTransactionCompanyName.Width = 200;
			// 
			// FormViewCompanies
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 767);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormViewCompanies";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Companies";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCompanies_FormClosed);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button buttonTransportCompanyRemove;
		private System.Windows.Forms.Button buttonTransportCompanyAdd;
		private System.Windows.Forms.Button buttonTransportCompanySearch;
		private System.Windows.Forms.TextBox textBoxTransportCompanySearch;
		private System.Windows.Forms.ListView listViewTransportCompanies;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button buttonTransactionCompanyRemove;
		private System.Windows.Forms.Button buttonTransactionCompanyAdd;
		private System.Windows.Forms.Button buttonTransactionCompanySearch;
		private System.Windows.Forms.TextBox textBoxTransactionCompanySearch;
		private System.Windows.Forms.ListView listViewTransactionCompanies;
		private System.Windows.Forms.ColumnHeader columnTransportCompanyId;
		private System.Windows.Forms.ColumnHeader columnTransportCompanyName;
		private System.Windows.Forms.ColumnHeader columnTransactionCompanyId;
		private System.Windows.Forms.ColumnHeader columnTransactionCompanyName;
	}
}