namespace Clinic.WindowsForms.Controls.ComboBoxes
{
    partial class PatientComboBox
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
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.DisplayMember = "Name";
            // 
            // label
            // 
            this.label.Size = new System.Drawing.Size(40, 13);
            this.label.Text = "Patient";
            // 
            // PatientComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "PatientComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
