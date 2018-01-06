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
            this.label3 = new System.Windows.Forms.Label();
            this.patientComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.officeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.amountReceivedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amountReceivedNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(558, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Patient";
            // 
            // patientComboBox
            // 
            this.patientComboBox.DisplayMember = "Name";
            this.patientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patientComboBox.FormattingEnabled = true;
            this.patientComboBox.Location = new System.Drawing.Point(617, 28);
            this.patientComboBox.Name = "patientComboBox";
            this.patientComboBox.Size = new System.Drawing.Size(121, 21);
            this.patientComboBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Office";
            // 
            // officeComboBox
            // 
            this.officeComboBox.DisplayMember = "Location";
            this.officeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.officeComboBox.FormattingEnabled = true;
            this.officeComboBox.Location = new System.Drawing.Point(353, 28);
            this.officeComboBox.Name = "officeComboBox";
            this.officeComboBox.Size = new System.Drawing.Size(121, 21);
            this.officeComboBox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Doctor";
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.doctorComboBox.DisplayMember = "Name";
            this.doctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(102, 28);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(121, 21);
            this.doctorComboBox.TabIndex = 18;
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
            // EditConsultationForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 252);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.amountReceivedNumericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.patientComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.officeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doctorComboBox);
            this.Name = "EditConsultationForm";
            this.Text = "Consultation";
            ((System.ComponentModel.ISupportInitialize)(this.amountReceivedNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox patientComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox officeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox doctorComboBox;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown amountReceivedNumericUpDown;
        private System.Windows.Forms.Button saveButton;
    }
}