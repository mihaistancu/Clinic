﻿using System;
using System.Windows.Forms;
using Clinic.WindowsForms.Appointments;
using Clinic.WindowsForms.Doctors;
using Clinic.WindowsForms.OfficeHours;
using Clinic.WindowsForms.Offices;
using Clinic.WindowsForms.Patients;
using Clinic.WindowsForms.Examinations;
using Clinic.WindowsForms.Reports;

namespace Clinic.WindowsForms
{
    public partial class ClinicForm : Form
    {
        public ClinicForm()
        {
            InitializeComponent();
        }

        private void OnDoctorsButtonClicked(object sender, EventArgs e)
        {
            var doctorsForm = new DoctorsForm();
            doctorsForm.Show();
        }

        private void OnOfficesButtonClicked(object sender, EventArgs e)
        {
            var officesForm = new OfficesForm();
            officesForm.Show();
        }

        private void OnPatientsButtonClicked(object sender, EventArgs e)
        {
            var patientsForm = new PatientsForm();
            patientsForm.Show();
        }

        private void OnOfficeHoursButtonClicked(object sender, EventArgs e)
        {
            var officeHoursForm = new OfficeHoursForm();
            officeHoursForm.Show();
        }

        private void OnAppointmentsClicked(object sender, EventArgs e)
        {
            var appointmentsForm = new AppointmentsForm();
            appointmentsForm.Show();
        }

        private void OnExaminationsClicked(object sender, EventArgs e)
        {
            var examinationsForm = new ExaminationsForm();
            examinationsForm.Show();
        }

        private void OnClinicActivityButtonClicked(object sender, EventArgs e)
        {
            var clinicActivityForm = new ClinicActivityForm();
            clinicActivityForm.Show();
        }

        private void OnDoctorActivityButtonClicked(object sender, EventArgs e)
        {
            var doctorActivityForm = new DoctorActivityForm();
            doctorActivityForm.Show();
        }

        private void OnOfficeActivityButtonClicked(object sender, EventArgs e)
        {
            var officeActivityForm = new OfficeActivityForm();
            officeActivityForm.Show();
        }
    }
}
