namespace Clinic.WindowsForms.Consultations
{
    partial class ConsultationsForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.consultationsGridView = new System.Windows.Forms.DataGridView();
            this.doctorComboBox = new Clinic.WindowsForms.Controls.DoctorComboBox();
            this.officeComboBox = new Clinic.WindowsForms.Controls.OfficeComboBox();
            this.patientComboBox = new Clinic.WindowsForms.Controls.PatientComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.consultationsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(772, 24);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.OnAddButtonClicked);
            // 
            // consultationsGridView
            // 
            this.consultationsGridView.AllowUserToAddRows = false;
            this.consultationsGridView.AllowUserToDeleteRows = false;
            this.consultationsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultationsGridView.Location = new System.Drawing.Point(12, 68);
            this.consultationsGridView.Name = "consultationsGridView";
            this.consultationsGridView.ReadOnly = true;
            this.consultationsGridView.Size = new System.Drawing.Size(848, 373);
            this.consultationsGridView.TabIndex = 3;
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.Location = new System.Drawing.Point(12, 12);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(210, 50);
            this.doctorComboBox.TabIndex = 18;
            this.doctorComboBox.SelectedValueChanged += new System.Action(this.OnSelectedValueChanged);
            // 
            // officeComboBox
            // 
            this.officeComboBox.Location = new System.Drawing.Point(228, 12);
            this.officeComboBox.Name = "officeComboBox";
            this.officeComboBox.Size = new System.Drawing.Size(210, 50);
            this.officeComboBox.TabIndex = 19;
            this.officeComboBox.SelectedValueChanged += new System.Action(this.OnSelectedValueChanged);
            // 
            // patientComboBox
            // 
            this.patientComboBox.Location = new System.Drawing.Point(444, 12);
            this.patientComboBox.Name = "patientComboBox";
            this.patientComboBox.Size = new System.Drawing.Size(210, 50);
            this.patientComboBox.TabIndex = 20;
            this.patientComboBox.SelectedValueChanged += new System.Action(this.OnSelectedValueChanged);
            // 
            // ConsultationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 453);
            this.Controls.Add(this.patientComboBox);
            this.Controls.Add(this.officeComboBox);
            this.Controls.Add(this.doctorComboBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.consultationsGridView);
            this.Name = "ConsultationsForm";
            this.Text = "Consultations";
            ((System.ComponentModel.ISupportInitialize)(this.consultationsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView consultationsGridView;
        private Controls.DoctorComboBox doctorComboBox;
        private Controls.OfficeComboBox officeComboBox;
        private Controls.PatientComboBox patientComboBox;
    }
}