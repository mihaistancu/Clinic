using Clinic.Core.Consultations;
using Clinic.Core.Infrastructure;
using Clinic.Core.Patients;
using Clinic.Core.Staffing;
using Clinic.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            var editConsultationForm = new EditConsultationForm();
            editConsultationForm.ShowDialog();
            ReloadData();
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
            var searchPredicates = GetSearchPredicates().ToArray();

            var results = from x in repository.Search(searchPredicates)
                          select new
                          {
                              Doctor = x.Doctor.Name,
                              Office = x.Office.Location,
                              Patient = x.Patient.Name,
                              Start = x.StartDateTime,
                              End = x.EndDateTime,
                              AmountReceived = x.AmountReceived
                          };

            consultationsGridView.DataSource = results.ToList();
        }

        private IEnumerable<Expression<Func<ClinicalVisit, bool>>> GetSearchPredicates()
        {
            if (!string.IsNullOrEmpty(doctorComboBox.Text))
            {
                yield return c => c.Doctor.Name == doctorComboBox.Text;
            }

            if (!string.IsNullOrEmpty(officeComboBox.Text))
            {
                yield return c => c.Office.Location == officeComboBox.Text;
            }

            if (!string.IsNullOrEmpty(patientComboBox.Text))
            {
                yield return c => c.Patient.Name == patientComboBox.Text;
            }
        }

        private void OnComboBoxTextChanged(object sender, EventArgs e)
        {
            ReloadData();
        }
    }
}
