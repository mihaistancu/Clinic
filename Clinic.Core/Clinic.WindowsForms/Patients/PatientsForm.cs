using Clinic.DataAccess;
using System;
using System.Windows.Forms;
using Clinic.Core;

namespace Clinic.WindowsForms.Patients
{
    public partial class PatientsForm : Form
    {
        public PatientsForm()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            LoadPatients();
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            var editPatientForm = new EditPatientForm();
            editPatientForm.ShowDialog();
            LoadPatients();
        }

        private void LoadPatients()
        {
            var repository = new Repository<Patient>();
            var patients = repository.GetAll();
            patientsGridView.DataSource = patients;
        }
    }
}
