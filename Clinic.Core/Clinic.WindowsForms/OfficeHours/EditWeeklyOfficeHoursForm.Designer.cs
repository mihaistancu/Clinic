namespace Clinic.WindowsForms.OfficeHours
{
    partial class EditWeeklyOfficeHoursForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.officeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.officeHoursDataGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.officeHoursDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Office";
            // 
            // officeComboBox
            // 
            this.officeComboBox.DisplayMember = "Location";
            this.officeComboBox.FormattingEnabled = true;
            this.officeComboBox.Location = new System.Drawing.Point(350, 30);
            this.officeComboBox.Name = "officeComboBox";
            this.officeComboBox.Size = new System.Drawing.Size(121, 21);
            this.officeComboBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Doctor";
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.doctorComboBox.DisplayMember = "Name";
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(99, 30);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(121, 21);
            this.doctorComboBox.TabIndex = 8;
            // 
            // officeHoursDataGridView
            // 
            this.officeHoursDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.officeHoursDataGridView.Location = new System.Drawing.Point(12, 80);
            this.officeHoursDataGridView.Name = "officeHoursDataGridView";
            this.officeHoursDataGridView.Size = new System.Drawing.Size(694, 263);
            this.officeHoursDataGridView.TabIndex = 12;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(552, 28);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.OnAddButtonClicked);
            // 
            // EditWeeklyOfficeHoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 355);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.officeHoursDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.officeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doctorComboBox);
            this.Name = "EditWeeklyOfficeHoursForm";
            this.Text = "Weekly Office Hours";
            ((System.ComponentModel.ISupportInitialize)(this.officeHoursDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox officeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox doctorComboBox;
        private System.Windows.Forms.DataGridView officeHoursDataGridView;
        private System.Windows.Forms.Button addButton;
    }
}