namespace DeliveryMarket.Admin
{
    partial class FormViewAdmins
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
            this.gridViewAdmins = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAdmins)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewAdmins
            // 
            this.gridViewAdmins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewAdmins.Location = new System.Drawing.Point(13, 13);
            this.gridViewAdmins.Name = "gridViewAdmins";
            this.gridViewAdmins.RowTemplate.Height = 24;
            this.gridViewAdmins.Size = new System.Drawing.Size(896, 550);
            this.gridViewAdmins.TabIndex = 0;
            // 
            // FormViewAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 575);
            this.Controls.Add(this.gridViewAdmins);
            this.Name = "FormViewAdmins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormViewAdmins";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormViewAdmins_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAdmins)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewAdmins;
    }
}