﻿namespace Clinic.WindowsForms
{
    partial class DoctorsForm
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
            this.doctorsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // doctorsGridView
            // 
            this.doctorsGridView.AllowUserToAddRows = false;
            this.doctorsGridView.AllowUserToDeleteRows = false;
            this.doctorsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorsGridView.Location = new System.Drawing.Point(12, 12);
            this.doctorsGridView.Name = "doctorsGridView";
            this.doctorsGridView.ReadOnly = true;
            this.doctorsGridView.Size = new System.Drawing.Size(748, 399);
            this.doctorsGridView.TabIndex = 1;
            // 
            // DoctorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 423);
            this.Controls.Add(this.doctorsGridView);
            this.Name = "DoctorsForm";
            this.Text = "Doctors";
            ((System.ComponentModel.ISupportInitialize)(this.doctorsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView doctorsGridView;
    }
}