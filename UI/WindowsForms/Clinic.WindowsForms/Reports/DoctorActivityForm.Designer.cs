namespace Clinic.WindowsForms.Reports
{
    partial class DoctorActivityForm
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
            this.totalAmountReceivedTextBox = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.totalExaminationsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateRange = new Clinic.WindowsForms.Controls.DateTimePickers.DateRange();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.doctorComboBox = new Clinic.WindowsForms.Controls.ComboBoxes.DoctorComboBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalAmountReceivedTextBox
            // 
            this.totalAmountReceivedTextBox.Location = new System.Drawing.Point(237, 79);
            this.totalAmountReceivedTextBox.Name = "totalAmountReceivedTextBox";
            this.totalAmountReceivedTextBox.ReadOnly = true;
            this.totalAmountReceivedTextBox.Size = new System.Drawing.Size(108, 20);
            this.totalAmountReceivedTextBox.TabIndex = 3;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.totalAmountReceivedTextBox);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.totalExaminationsTextBox);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Location = new System.Drawing.Point(47, 145);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(394, 138);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Amount Received (Dollars)";
            // 
            // totalExaminationsTextBox
            // 
            this.totalExaminationsTextBox.Location = new System.Drawing.Point(237, 48);
            this.totalExaminationsTextBox.Name = "totalExaminationsTextBox";
            this.totalExaminationsTextBox.ReadOnly = true;
            this.totalExaminationsTextBox.Size = new System.Drawing.Size(108, 20);
            this.totalExaminationsTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Examinations";
            // 
            // dateRange
            // 
            this.dateRange.Location = new System.Drawing.Point(33, 68);
            this.dateRange.Name = "dateRange";
            this.dateRange.Size = new System.Drawing.Size(305, 71);
            this.dateRange.TabIndex = 3;
            // 
            // generateReportButton
            // 
            this.generateReportButton.Location = new System.Drawing.Point(366, 84);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(75, 41);
            this.generateReportButton.TabIndex = 5;
            this.generateReportButton.Text = "Generate Report";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.OnGenerateReportButtonClicked);
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.doctorComboBox.Location = new System.Drawing.Point(50, 12);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(210, 50);
            this.doctorComboBox.TabIndex = 6;
            // 
            // DoctorActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 311);
            this.Controls.Add(this.doctorComboBox);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.dateRange);
            this.Controls.Add(this.generateReportButton);
            this.Name = "DoctorActivityForm";
            this.Text = "Doctor Activity";
            this.Load += new System.EventHandler(this.OnLoad);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox totalAmountReceivedTextBox;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalExaminationsTextBox;
        private System.Windows.Forms.Label label1;
        private Controls.DateTimePickers.DateRange dateRange;
        private System.Windows.Forms.Button generateReportButton;
        private Controls.ComboBoxes.DoctorComboBox doctorComboBox;
    }
}