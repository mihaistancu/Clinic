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
            this.label7 = new System.Windows.Forms.Label();
            this.amountReceivedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.doctorComboBox = new Clinic.WindowsForms.Controls.DoctorComboBox();
            this.officeComboBox = new Clinic.WindowsForms.Controls.OfficeComboBox();
            this.patientComboBox = new Clinic.WindowsForms.Controls.PatientComboBox();
            this.dateTimeRange = new Clinic.WindowsForms.Controls.DateTimeRange();
            ((System.ComponentModel.ISupportInitialize)(this.amountReceivedNumericUpDown)).BeginInit();
            this.SuspendLayout();
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
            // dateTimeRange
            // 
            this.dateTimeRange.Location = new System.Drawing.Point(78, 60);
            this.dateTimeRange.Name = "dateTimeRange";
            this.dateTimeRange.Size = new System.Drawing.Size(631, 121);
            this.dateTimeRange.TabIndex = 36;
            // 
            // EditConsultationForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 252);
            this.Controls.Add(this.dateTimeRange);
            this.Controls.Add(this.patientComboBox);
            this.Controls.Add(this.officeComboBox);
            this.Controls.Add(this.doctorComboBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.amountReceivedNumericUpDown);
            this.Controls.Add(this.label7);
            this.Name = "EditConsultationForm";
            this.Text = "Consultation";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.amountReceivedNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown amountReceivedNumericUpDown;
        private System.Windows.Forms.Button saveButton;
        private Controls.DoctorComboBox doctorComboBox;
        private Controls.OfficeComboBox officeComboBox;
        private Controls.PatientComboBox patientComboBox;
        private Controls.DateTimeRange dateTimeRange;
    }
}