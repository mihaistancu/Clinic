namespace Clinic.WindowsForms.Controls.DateTimePickers
{
    partial class DateTimePicker
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.datePicker = new Clinic.WindowsForms.Controls.DateTimePickers.DatePicker();
            this.SuspendLayout();
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(87, 66);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(118, 20);
            this.timePicker.TabIndex = 35;
            this.timePicker.Value = new System.DateTime(2018, 1, 8, 0, 0, 0, 0);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(12, 13);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(305, 47);
            this.datePicker.TabIndex = 34;
            // 
            // DateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.datePicker);
            this.Name = "DateTimePicker";
            this.Size = new System.Drawing.Size(329, 99);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker timePicker;
        private DatePicker datePicker;
    }
}
