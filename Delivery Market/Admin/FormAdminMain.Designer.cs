namespace DeliveryMarket.Admin
{
    partial class FormAdminMain
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
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.buttonReports = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonViewEmployees = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonAddEmployee.Location = new System.Drawing.Point(47, 39);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(251, 47);
            this.buttonAddEmployee.TabIndex = 1;
            this.buttonAddEmployee.Text = "Add Employee";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonStatistics.Location = new System.Drawing.Point(47, 198);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Size = new System.Drawing.Size(251, 47);
            this.buttonStatistics.TabIndex = 2;
            this.buttonStatistics.Text = "Statisitics";
            this.buttonStatistics.UseVisualStyleBackColor = true;
            // 
            // buttonReports
            // 
            this.buttonReports.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonReports.Location = new System.Drawing.Point(47, 145);
            this.buttonReports.Name = "buttonReports";
            this.buttonReports.Size = new System.Drawing.Size(251, 47);
            this.buttonReports.TabIndex = 3;
            this.buttonReports.Text = "Reports";
            this.buttonReports.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonBack.Location = new System.Drawing.Point(47, 505);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(251, 47);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonViewEmployees
            // 
            this.buttonViewEmployees.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonViewEmployees.Location = new System.Drawing.Point(47, 92);
            this.buttonViewEmployees.Name = "buttonViewEmployees";
            this.buttonViewEmployees.Size = new System.Drawing.Size(251, 47);
            this.buttonViewEmployees.TabIndex = 0;
            this.buttonViewEmployees.Text = "View Employees";
            this.buttonViewEmployees.UseVisualStyleBackColor = true;
            // 
            // FormAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 564);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonReports);
            this.Controls.Add(this.buttonStatistics);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.buttonViewEmployees);
            this.Name = "FormAdminMain";
            this.Text = "Admin Panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdminMain_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonStatistics;
        private System.Windows.Forms.Button buttonReports;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonViewEmployees;
    }
}