﻿using Clinic.Core.Staffing;
using Clinic.DataAccess;
using System;
using System.Windows.Forms;

namespace Clinic.WindowsForms.Doctors
{
    public partial class EditDoctorForm : Form
    {
        public EditDoctorForm()
        {
            InitializeComponent();
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var repository = new Repository<Doctor>();
            repository.Add(new Doctor { Name = doctorNameTextBox.Text });
            Close();
        }
    }
}
