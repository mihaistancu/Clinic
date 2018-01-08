namespace Clinic.WindowsForms.Reports
{
    partial class ClinicActivityForm
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
            this.dateRange = new Clinic.WindowsForms.Controls.DateTimePickers.DateRange();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalVisitsDurationTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.totalAmountReceivedTextBox = new System.Windows.Forms.TextBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateRange
            // 
            this.dateRange.Location = new System.Drawing.Point(28, 23);
            this.dateRange.Name = "dateRange";
            this.dateRange.Size = new System.Drawing.Size(305, 71);
            this.dateRange.TabIndex = 0;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.totalAmountReceivedTextBox);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.totalVisitsDurationTextBox);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Location = new System.Drawing.Point(42, 100);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(394, 138);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Report";
            // 
            // generateReportButton
            // 
            this.generateReportButton.Location = new System.Drawing.Point(361, 39);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(75, 41);
            this.generateReportButton.TabIndex = 2;
            this.generateReportButton.Text = "Generate Report";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.OnGenerateReportButtonClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Visits Duration (Days)";
            // 
            // totalVisitsDurationTextBox
            // 
            this.totalVisitsDurationTextBox.Location = new System.Drawing.Point(237, 48);
            this.totalVisitsDurationTextBox.Name = "totalVisitsDurationTextBox";
            this.totalVisitsDurationTextBox.ReadOnly = true;
            this.totalVisitsDurationTextBox.Size = new System.Drawing.Size(108, 20);
            this.totalVisitsDurationTextBox.TabIndex = 1;
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
            // totalAmountReceivedTextBox
            // 
            this.totalAmountReceivedTextBox.Location = new System.Drawing.Point(237, 79);
            this.totalAmountReceivedTextBox.Name = "totalAmountReceivedTextBox";
            this.totalAmountReceivedTextBox.ReadOnly = true;
            this.totalAmountReceivedTextBox.Size = new System.Drawing.Size(108, 20);
            this.totalAmountReceivedTextBox.TabIndex = 3;
            // 
            // ClinicActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 261);
            this.Controls.Add(this.generateReportButton);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.dateRange);
            this.Name = "ClinicActivityForm";
            this.Text = "Clinic Activity";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.DateTimePickers.DateRange dateRange;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalVisitsDurationTextBox;
        private System.Windows.Forms.TextBox totalAmountReceivedTextBox;
    }
}