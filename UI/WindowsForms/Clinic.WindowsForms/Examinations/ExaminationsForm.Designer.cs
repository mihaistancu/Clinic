using Clinic.WindowsForms.Controls.ComboBoxes;

namespace Clinic.WindowsForms.Examinations
{
    partial class ExaminationsForm
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
            this.examinationsGridView = new System.Windows.Forms.DataGridView();
            this.doctorComboBox = new DoctorComboBox();
            this.officeComboBox = new OfficeComboBox();
            this.patientComboBox = new PatientComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.examinationsGridView)).BeginInit();
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
            // examinationsGridView
            // 
            this.examinationsGridView.AllowUserToAddRows = false;
            this.examinationsGridView.AllowUserToDeleteRows = false;
            this.examinationsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examinationsGridView.Location = new System.Drawing.Point(12, 68);
            this.examinationsGridView.Name = "examinationsGridView";
            this.examinationsGridView.ReadOnly = true;
            this.examinationsGridView.Size = new System.Drawing.Size(848, 373);
            this.examinationsGridView.TabIndex = 3;
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.doctorComboBox.Location = new System.Drawing.Point(12, 12);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(210, 50);
            this.doctorComboBox.TabIndex = 18;
            this.doctorComboBox.SelectedValueChanged += new System.Action(this.OnSelectedValueChanged);
            // 
            // officeComboBox
            // 
            this.officeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.officeComboBox.Location = new System.Drawing.Point(228, 12);
            this.officeComboBox.Name = "officeComboBox";
            this.officeComboBox.Size = new System.Drawing.Size(210, 50);
            this.officeComboBox.TabIndex = 19;
            this.officeComboBox.SelectedValueChanged += new System.Action(this.OnSelectedValueChanged);
            // 
            // patientComboBox
            // 
            this.patientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.patientComboBox.Location = new System.Drawing.Point(444, 12);
            this.patientComboBox.Name = "patientComboBox";
            this.patientComboBox.Size = new System.Drawing.Size(210, 50);
            this.patientComboBox.TabIndex = 20;
            this.patientComboBox.SelectedValueChanged += new System.Action(this.OnSelectedValueChanged);
            // 
            // ExaminationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 453);
            this.Controls.Add(this.patientComboBox);
            this.Controls.Add(this.officeComboBox);
            this.Controls.Add(this.doctorComboBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.examinationsGridView);
            this.Name = "ExaminationsForm";
            this.Text = "Examinations";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.examinationsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView examinationsGridView;
        private DoctorComboBox doctorComboBox;
        private OfficeComboBox officeComboBox;
        private PatientComboBox patientComboBox;
    }
}