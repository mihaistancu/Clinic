namespace Clinic.WindowsForms.Reports
{
    partial class OfficeActivityForm
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.totalVisitsDurationTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateRange = new Clinic.WindowsForms.Controls.DateTimePickers.DateRange();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.officeComboBox = new Clinic.WindowsForms.Controls.ComboBoxes.OfficeComboBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.totalVisitsDurationTextBox);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Location = new System.Drawing.Point(48, 153);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(394, 138);
            this.groupBox.TabIndex = 8;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Report";
            // 
            // totalVisitsDurationTextBox
            // 
            this.totalVisitsDurationTextBox.Location = new System.Drawing.Point(235, 59);
            this.totalVisitsDurationTextBox.Name = "totalVisitsDurationTextBox";
            this.totalVisitsDurationTextBox.ReadOnly = true;
            this.totalVisitsDurationTextBox.Size = new System.Drawing.Size(108, 20);
            this.totalVisitsDurationTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Visits Duration (Days)";
            // 
            // dateRange
            // 
            this.dateRange.Location = new System.Drawing.Point(34, 76);
            this.dateRange.Name = "dateRange";
            this.dateRange.Size = new System.Drawing.Size(305, 71);
            this.dateRange.TabIndex = 7;
            // 
            // generateReportButton
            // 
            this.generateReportButton.Location = new System.Drawing.Point(367, 92);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(75, 41);
            this.generateReportButton.TabIndex = 9;
            this.generateReportButton.Text = "Generate Report";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.OnGenerateReportButtonClicked);
            // 
            // officeComboBox
            // 
            this.officeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.officeComboBox.Location = new System.Drawing.Point(51, 20);
            this.officeComboBox.Name = "officeComboBox";
            this.officeComboBox.Size = new System.Drawing.Size(210, 50);
            this.officeComboBox.TabIndex = 10;
            // 
            // OfficeActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 311);
            this.Controls.Add(this.officeComboBox);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.dateRange);
            this.Controls.Add(this.generateReportButton);
            this.Name = "OfficeActivityForm";
            this.Text = "Office Activity";
            this.Load += new System.EventHandler(this.OnLoad);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox;
        private Controls.DateTimePickers.DateRange dateRange;
        private System.Windows.Forms.Button generateReportButton;
        private Controls.ComboBoxes.OfficeComboBox officeComboBox;
        private System.Windows.Forms.TextBox totalVisitsDurationTextBox;
        private System.Windows.Forms.Label label1;
    }
}