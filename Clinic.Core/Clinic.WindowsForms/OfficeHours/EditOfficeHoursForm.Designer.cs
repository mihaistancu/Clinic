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
            this.label4 = new System.Windows.Forms.Label();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.doctorComboBox = new Clinic.WindowsForms.Controls.DoctorComboBox();
            this.officeComboBox = new Clinic.WindowsForms.Controls.OfficeComboBox();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Start Time";
            // 
            // startTimePicker
            // 
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTimePicker.Location = new System.Drawing.Point(146, 125);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(118, 20);
            this.startTimePicker.TabIndex = 19;
            this.startTimePicker.Value = new System.DateTime(2000, 1, 1, 21, 0, 0, 0);
            // 
            // endTimePicker
            // 
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endTimePicker.Location = new System.Drawing.Point(146, 162);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.ShowUpDown = true;
            this.endTimePicker.Size = new System.Drawing.Size(118, 20);
            this.endTimePicker.TabIndex = 21;
            this.endTimePicker.Value = new System.DateTime(2000, 1, 1, 17, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "End Time";
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
            // EditOfficeHoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 226);
            this.Controls.Add(this.officeComboBox);
            this.Controls.Add(this.doctorComboBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveButton;
        private Controls.DoctorComboBox doctorComboBox;
        private Controls.OfficeComboBox officeComboBox;
    }
}