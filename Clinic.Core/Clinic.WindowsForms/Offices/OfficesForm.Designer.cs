namespace Clinic.WindowsForms.Offices
{
    partial class OfficesForm
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
            this.officesGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.officesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // officesGridView
            // 
            this.officesGridView.AllowUserToAddRows = false;
            this.officesGridView.AllowUserToDeleteRows = false;
            this.officesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.officesGridView.Location = new System.Drawing.Point(12, 50);
            this.officesGridView.Name = "officesGridView";
            this.officesGridView.ReadOnly = true;
            this.officesGridView.Size = new System.Drawing.Size(550, 273);
            this.officesGridView.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.OnAddButtonClicked);
            // 
            // OfficesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 335);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.officesGridView);
            this.Name = "OfficesForm";
            this.Text = "Offices";
            ((System.ComponentModel.ISupportInitialize)(this.officesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView officesGridView;
        private System.Windows.Forms.Button addButton;
    }
}