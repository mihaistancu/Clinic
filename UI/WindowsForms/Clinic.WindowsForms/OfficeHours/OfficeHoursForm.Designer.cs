using Clinic.WindowsForms.Controls.ComboBoxes;

namespace Clinic.WindowsForms.OfficeHours
{
    partial class OfficeHoursForm
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
            this.officeHoursDataGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.doctorComboBox = new DoctorComboBox();
            this.officeComboBox = new OfficeComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.officeHoursDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // officeHoursDataGridView
            // 
            this.officeHoursDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.officeHoursDataGridView.Location = new System.Drawing.Point(12, 70);
            this.officeHoursDataGridView.Name = "officeHoursDataGridView";
            this.officeHoursDataGridView.Size = new System.Drawing.Size(694, 273);
            this.officeHoursDataGridView.TabIndex = 12;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(554, 25);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.OnAddButtonClicked);
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.doctorComboBox.Location = new System.Drawing.Point(12, 12);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(210, 50);
            this.doctorComboBox.TabIndex = 14;
            this.doctorComboBox.SelectedValueChanged += new System.Action(this.OnSelectedValueChanged);
            // 
            // officeComboBox
            // 
            this.officeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.officeComboBox.Location = new System.Drawing.Point(228, 12);
            this.officeComboBox.Name = "officeComboBox";
            this.officeComboBox.Size = new System.Drawing.Size(210, 50);
            this.officeComboBox.TabIndex = 15;
            this.officeComboBox.SelectedValueChanged += new System.Action(this.OnSelectedValueChanged);
            // 
            // OfficeHoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 355);
            this.Controls.Add(this.officeComboBox);
            this.Controls.Add(this.doctorComboBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.officeHoursDataGridView);
            this.Name = "OfficeHoursForm";
            this.Text = "Weekly Office Hours";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.officeHoursDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView officeHoursDataGridView;
        private System.Windows.Forms.Button addButton;
        private DoctorComboBox doctorComboBox;
        private OfficeComboBox officeComboBox;
    }
}