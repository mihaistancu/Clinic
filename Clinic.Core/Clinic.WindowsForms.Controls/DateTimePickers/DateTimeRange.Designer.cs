namespace Clinic.WindowsForms.Controls.DateTimePickers
{
    partial class DateTimeRange
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
            this.timeRange = new TimeRange();
            this.datePicker = new DatePicker();
            this.SuspendLayout();
            // 
            // timeRange
            // 
            this.timeRange.Location = new System.Drawing.Point(359, 14);
            this.timeRange.Name = "timeRange";
            this.timeRange.Size = new System.Drawing.Size(255, 90);
            this.timeRange.TabIndex = 39;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(16, 38);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(305, 47);
            this.datePicker.TabIndex = 38;
            // 
            // DateTimeRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.timeRange);
            this.Controls.Add(this.datePicker);
            this.Name = "DateTimeRange";
            this.Size = new System.Drawing.Size(631, 121);
            this.ResumeLayout(false);

        }

        #endregion

        private TimeRange timeRange;
        private DatePicker datePicker;
    }
}
