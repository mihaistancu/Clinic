using Clinic.Core.Infrastructure;
using Clinic.Core.Patients;
using Clinic.Core.Staffing;
using Clinic.DataAccess;
using System;
using System.Windows.Forms;

namespace Clinic.WindowsForms.Consultations
{
    public partial class EditConsultationForm : Form
    {
        public EditConsultationForm()
        {
            InitializeComponent();
            LoadDoctors();
            LoadOffices();
            LoadPatients();
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

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var repository = new ConsultationsRepository();
            string doctorName = ((Doctor)doctorComboBox.SelectedItem).Name;
            string officeLocation = ((Office)officeComboBox.SelectedItem).Location;
            string patientName = ((Patient)patientComboBox.SelectedItem).Name;
            DateTime startDateTime = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day, startTimePicker.Value.Hour, startTimePicker.Value.Minute, startTimePicker.Value.Second);
            DateTime endDateTime = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day, endTimePicker.Value.Hour, endTimePicker.Value.Minute, endTimePicker.Value.Second);
            double amountReceived = (double)amountReceivedNumericUpDown.Value;
            repository.Add(doctorName, officeLocation, patientName, startDateTime, endDateTime, amountReceived);
            Close();
        }
    }
}
