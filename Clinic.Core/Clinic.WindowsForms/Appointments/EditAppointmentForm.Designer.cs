namespace Clinic.WindowsForms.Appointments
{
    partial class EditAppointmentForm
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
            this.appointmentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.doctorComboBox = new Clinic.WindowsForms.Controls.DoctorComboBox();
            this.SuspendLayout();
            // 
            // appointmentDateTimePicker
            // 
            this.appointmentDateTimePicker.Location = new System.Drawing.Point(103, 76);
            this.appointmentDateTimePicker.Name = "appointmentDateTimePicker";
            this.appointmentDateTimePicker.Size = new System.Drawing.Size(190, 20);
            this.appointmentDateTimePicker.TabIndex = 21;
            this.appointmentDateTimePicker.Value = new System.DateTime(2000, 1, 1, 21, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Date";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(274, 119);
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
            this.doctorComboBox.Location = new System.Drawing.Point(29, 12);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(210, 50);
            this.doctorComboBox.TabIndex = 23;
            // 
            // EditAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 182);
            this.Controls.Add(this.doctorComboBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.appointmentDateTimePicker);
            this.Controls.Add(this.label4);
            this.Name = "EditAppointmentForm";
            this.Text = "Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker appointmentDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveButton;
        private Controls.DoctorComboBox doctorComboBox;
    }
}