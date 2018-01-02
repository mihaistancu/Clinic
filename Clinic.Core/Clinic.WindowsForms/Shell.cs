using System;
using System.Windows.Forms;
using Clinic.WindowsForms.Doctors;
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

        private void button1_Click(object sender, EventArgs e)
        {
            var doctorsForm = new DoctorsForm();
            doctorsForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var officesForm = new OfficesForm();
            officesForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var patientsForm = new PatientsForm();
            patientsForm.Show();
        }
    }
}
