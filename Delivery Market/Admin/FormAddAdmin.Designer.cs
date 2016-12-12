namespace DeliveryMarket.Admin
{
    partial class FormAddAdmin
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonApply = new System.Windows.Forms.Button();
			this.dataGridViewAccounts = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(15, 33);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(176, 22);
			this.textBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Search By Name:";
			// 
			// buttonApply
			// 
			this.buttonApply.Location = new System.Drawing.Point(646, 573);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new System.Drawing.Size(157, 36);
			this.buttonApply.TabIndex = 3;
			this.buttonApply.Text = "Apply";
			this.buttonApply.UseVisualStyleBackColor = true;
			this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
			// 
			// dataGridViewAccounts
			// 
			this.dataGridViewAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAccounts.Location = new System.Drawing.Point(15, 79);
			this.dataGridViewAccounts.Name = "dataGridViewAccounts";
			this.dataGridViewAccounts.RowTemplate.Height = 24;
			this.dataGridViewAccounts.Size = new System.Drawing.Size(788, 488);
			this.dataGridViewAccounts.TabIndex = 4;
			// 
			// FormAddAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(812, 643);
			this.Controls.Add(this.dataGridViewAccounts);
			this.Controls.Add(this.buttonApply);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Name = "FormAddAdmin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormAddAdmin";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddAdmin_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonApply;
		private System.Windows.Forms.DataGridView dataGridViewAccounts;
	}
}