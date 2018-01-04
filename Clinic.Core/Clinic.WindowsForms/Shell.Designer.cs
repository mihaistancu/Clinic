namespace Clinic.WindowsForms
{
    partial class Shell
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
            this.doctorsButton = new System.Windows.Forms.Button();
            this.officesButton = new System.Windows.Forms.Button();
            this.patientsButton = new System.Windows.Forms.Button();
            this.officeHoursButton = new System.Windows.Forms.Button();
            this.appointmentsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doctorsButton
            // 
            this.doctorsButton.Location = new System.Drawing.Point(12, 12);
            this.doctorsButton.Name = "doctorsButton";
            this.doctorsButton.Size = new System.Drawing.Size(75, 23);
            this.doctorsButton.TabIndex = 0;
            this.doctorsButton.Text = "Doctors";
            this.doctorsButton.UseVisualStyleBackColor = true;
            this.doctorsButton.Click += new System.EventHandler(this.OnDoctorsButtonClicked);
            // 
            // officesButton
            // 
            this.officesButton.Location = new System.Drawing.Point(93, 12);
            this.officesButton.Name = "officesButton";
            this.officesButton.Size = new System.Drawing.Size(75, 23);
            this.officesButton.TabIndex = 1;
            this.officesButton.Text = "Offices";
            this.officesButton.UseVisualStyleBackColor = true;
            this.officesButton.Click += new System.EventHandler(this.OnOfficesButtonClicked);
            // 
            // patientsButton
            // 
            this.patientsButton.Location = new System.Drawing.Point(174, 12);
            this.patientsButton.Name = "patientsButton";
            this.patientsButton.Size = new System.Drawing.Size(75, 23);
            this.patientsButton.TabIndex = 2;
            this.patientsButton.Text = "Patients";
            this.patientsButton.UseVisualStyleBackColor = true;
            this.patientsButton.Click += new System.EventHandler(this.OnPatientsButtonClicked);
            // 
            // officeHoursButton
            // 
            this.officeHoursButton.Location = new System.Drawing.Point(93, 53);
            this.officeHoursButton.Name = "officeHoursButton";
            this.officeHoursButton.Size = new System.Drawing.Size(75, 23);
            this.officeHoursButton.TabIndex = 3;
            this.officeHoursButton.Text = "Office Hours";
            this.officeHoursButton.UseVisualStyleBackColor = true;
            this.officeHoursButton.Click += new System.EventHandler(this.OnOfficeHoursButtonClicked);
            // 
            // appointmentsButton
            // 
            this.appointmentsButton.Location = new System.Drawing.Point(12, 93);
            this.appointmentsButton.Name = "appointmentsButton";
            this.appointmentsButton.Size = new System.Drawing.Size(114, 23);
            this.appointmentsButton.TabIndex = 4;
            this.appointmentsButton.Text = "Appointments";
            this.appointmentsButton.UseVisualStyleBackColor = true;
            this.appointmentsButton.Click += new System.EventHandler(this.OnAppointmentsClicked);
            // 
            // Shell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 353);
            this.Controls.Add(this.appointmentsButton);
            this.Controls.Add(this.officeHoursButton);
            this.Controls.Add(this.patientsButton);
            this.Controls.Add(this.officesButton);
            this.Controls.Add(this.doctorsButton);
            this.Name = "Shell";
            this.Text = "Clinic";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button doctorsButton;
        private System.Windows.Forms.Button officesButton;
        private System.Windows.Forms.Button patientsButton;
        private System.Windows.Forms.Button officeHoursButton;
        private System.Windows.Forms.Button appointmentsButton;
    }
}