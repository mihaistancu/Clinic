using System;
using System.Windows.Forms;
using Clinic.WindowsForms.Doctors;
using Clinic.WindowsForms.OfficeHours;
using Clinic.WindowsForms.Offices;
using Clinic.WindowsForms.Patients;

namespace Clinic.WindowsForms
{
    public partial class Shell : Form
    {
        public Shell()
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
    }
}
