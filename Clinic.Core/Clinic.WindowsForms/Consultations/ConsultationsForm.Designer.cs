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
            this.label3 = new System.Windows.Forms.Label();
            this.patientComboBox = new System.Windows.Forms.ComboBox();
            this.doctorComboBox = new Clinic.WindowsForms.Controls.DoctorComboBox();
            this.officeComboBox = new Clinic.WindowsForms.Controls.OfficeComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.consultationsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(775, 12);
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
            this.consultationsGridView.Location = new System.Drawing.Point(12, 48);
            this.consultationsGridView.Name = "consultationsGridView";
            this.consultationsGridView.ReadOnly = true;
            this.consultationsGridView.Size = new System.Drawing.Size(848, 393);
            this.consultationsGridView.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Patient";
            // 
            // patientComboBox
            // 
            this.patientComboBox.DisplayMember = "Name";
            this.patientComboBox.FormattingEnabled = true;
            this.patientComboBox.Location = new System.Drawing.Point(597, 14);
            this.patientComboBox.Name = "patientComboBox";
            this.patientComboBox.Size = new System.Drawing.Size(121, 21);
            this.patientComboBox.TabIndex = 16;
            this.patientComboBox.TextChanged += new System.EventHandler(this.OnComboBoxTextChanged);
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.Location = new System.Drawing.Point(12, -2);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(213, 50);
            this.doctorComboBox.TabIndex = 18;
            // 
            // officeComboBox
            // 
            this.officeComboBox.Location = new System.Drawing.Point(266, -4);
            this.officeComboBox.Name = "officeComboBox";
            this.officeComboBox.Size = new System.Drawing.Size(222, 52);
            this.officeComboBox.TabIndex = 19;
            // 
            // ConsultationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 453);
            this.Controls.Add(this.officeComboBox);
            this.Controls.Add(this.doctorComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.patientComboBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.consultationsGridView);
            this.Name = "ConsultationsForm";
            this.Text = "Consultations";
            ((System.ComponentModel.ISupportInitialize)(this.consultationsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView consultationsGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox patientComboBox;
        private Controls.DoctorComboBox doctorComboBox;
        private Controls.OfficeComboBox officeComboBox;
    }
}