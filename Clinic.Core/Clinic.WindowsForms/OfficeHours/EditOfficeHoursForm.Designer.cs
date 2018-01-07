namespace Clinic.WindowsForms.OfficeHours
{
    partial class EditOfficeHoursForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.dayOfWeekComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.doctorComboBox = new Clinic.WindowsForms.Controls.DoctorComboBox();
            this.officeComboBox = new Clinic.WindowsForms.Controls.OfficeComboBox();
            this.timeRange = new Clinic.WindowsForms.Controls.TimeRange();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Day of Week";
            // 
            // dayOfWeekComboBox
            // 
            this.dayOfWeekComboBox.DisplayMember = "Location";
            this.dayOfWeekComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dayOfWeekComboBox.FormattingEnabled = true;
            this.dayOfWeekComboBox.Location = new System.Drawing.Point(143, 82);
            this.dayOfWeekComboBox.Name = "dayOfWeekComboBox";
            this.dayOfWeekComboBox.Size = new System.Drawing.Size(121, 21);
            this.dayOfWeekComboBox.TabIndex = 16;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(502, 178);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 22;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.OnSaveButtonClicked);
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorComboBox.Location = new System.Drawing.Point(56, 12);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(210, 50);
            this.doctorComboBox.TabIndex = 23;
            // 
            // officeComboBox
            // 
            this.officeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.officeComboBox.Location = new System.Drawing.Point(310, 12);
            this.officeComboBox.Name = "officeComboBox";
            this.officeComboBox.Size = new System.Drawing.Size(210, 50);
            this.officeComboBox.TabIndex = 24;
            // 
            // timeRange1
            // 
            this.timeRange.Location = new System.Drawing.Point(35, 111);
            this.timeRange.Name = "timeRange1";
            this.timeRange.Size = new System.Drawing.Size(255, 90);
            this.timeRange.TabIndex = 25;
            // 
            // EditOfficeHoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 226);
            this.Controls.Add(this.timeRange);
            this.Controls.Add(this.officeComboBox);
            this.Controls.Add(this.doctorComboBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dayOfWeekComboBox);
            this.Name = "EditOfficeHoursForm";
            this.Text = "Daily Office Hours";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox dayOfWeekComboBox;
        private System.Windows.Forms.Button saveButton;
        private Controls.DoctorComboBox doctorComboBox;
        private Controls.OfficeComboBox officeComboBox;
        private Controls.TimeRange timeRange;
    }
}