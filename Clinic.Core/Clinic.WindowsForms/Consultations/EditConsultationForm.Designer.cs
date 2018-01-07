namespace Clinic.WindowsForms.Consultations
{
    partial class EditConsultationForm
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
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.amountReceivedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.doctorComboBox = new Clinic.WindowsForms.Controls.DoctorComboBox();
            this.officeComboBox = new Clinic.WindowsForms.Controls.OfficeComboBox();
            this.patientComboBox = new Clinic.WindowsForms.Controls.PatientComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.amountReceivedNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(169, 106);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Date";
            // 
            // endTimePicker
            // 
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endTimePicker.Location = new System.Drawing.Point(499, 123);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.ShowUpDown = true;
            this.endTimePicker.Size = new System.Drawing.Size(118, 20);
            this.endTimePicker.TabIndex = 29;
            this.endTimePicker.Value = new System.DateTime(2000, 1, 1, 17, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "End Time";
            // 
            // startTimePicker
            // 
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTimePicker.Location = new System.Drawing.Point(499, 86);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(118, 20);
            this.startTimePicker.TabIndex = 27;
            this.startTimePicker.Value = new System.DateTime(2000, 1, 1, 21, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Start Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Amount Received";
            // 
            // amountReceivedNumericUpDown
            // 
            this.amountReceivedNumericUpDown.Location = new System.Drawing.Point(169, 187);
            this.amountReceivedNumericUpDown.Name = "amountReceivedNumericUpDown";
            this.amountReceivedNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.amountReceivedNumericUpDown.TabIndex = 31;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(692, 200);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 32;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.OnSaveButtonClicked);
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorComboBox.Location = new System.Drawing.Point(37, 12);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(210, 50);
            this.doctorComboBox.TabIndex = 33;
            // 
            // officeComboBox
            // 
            this.officeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.officeComboBox.Location = new System.Drawing.Point(293, 12);
            this.officeComboBox.Name = "officeComboBox";
            this.officeComboBox.Size = new System.Drawing.Size(210, 50);
            this.officeComboBox.TabIndex = 34;
            // 
            // patientComboBox
            // 
            this.patientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patientComboBox.Location = new System.Drawing.Point(557, 12);
            this.patientComboBox.Name = "patientComboBox";
            this.patientComboBox.Size = new System.Drawing.Size(210, 50);
            this.patientComboBox.TabIndex = 35;
            // 
            // EditConsultationForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 252);
            this.Controls.Add(this.patientComboBox);
            this.Controls.Add(this.officeComboBox);
            this.Controls.Add(this.doctorComboBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.amountReceivedNumericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datePicker);
            this.Name = "EditConsultationForm";
            this.Text = "Consultation";
            ((System.ComponentModel.ISupportInitialize)(this.amountReceivedNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown amountReceivedNumericUpDown;
        private System.Windows.Forms.Button saveButton;
        private Controls.DoctorComboBox doctorComboBox;
        private Controls.OfficeComboBox officeComboBox;
        private Controls.PatientComboBox patientComboBox;
    }
}