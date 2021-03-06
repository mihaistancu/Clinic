﻿using System;
using System.Windows.Forms;
using Clinic.Data;
using Clinic.Data.Persistence.EF;

namespace Clinic.WindowsForms.Patients
{
    public partial class EditPatientForm : Form
    {
        public EditPatientForm()
        {
            InitializeComponent();
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var repository = new Repository<Patient>();
            repository.Add(new Patient { Name = patientNameTextBox.Text });
            Close();
        }
    }
}
