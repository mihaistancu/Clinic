using Clinic.Core.Infrastructure;
using Clinic.Core.Patients;
using Clinic.Core.Staffing;
using Clinic.DataAccess;
using System;
using System.Windows.Forms;

namespace Clinic.WindowsForms.Consultations
{
    public partial class ConsultationsForm : Form
    {
        public ConsultationsForm()
        {
            InitializeComponent();
            LoadDoctors();
            LoadOffices();
            LoadPatients();
            ReloadData();
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadDoctors()
        {
            var doctorRepository = new Repository<Doctor>();
            var doctors = doctorRepository.GetAll();
            doctorComboBox.DataSource = doctors;
        }

        private void LoadOffices()
        {
            var officeRepository = new Repository<Office>();
            var offices = officeRepository.GetAll();
            officeComboBox.DataSource = offices;
        }

        private void LoadPatients()
        {
            var patientsRepository = new Repository<Patient>();
            var patients = patientsRepository.GetAll();
            patientComboBox.DataSource = patients;
        }

        private void ReloadData()
        {
            var repository = new ConsultationsRepository();
            var consultations = repository.GetAll();
            consultationsGridView.DataSource = consultations;
        }
    }
}
