﻿using Clinic.Core.Patients;
using Clinic.DataAccess;
using System;
using System.Windows.Forms;

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