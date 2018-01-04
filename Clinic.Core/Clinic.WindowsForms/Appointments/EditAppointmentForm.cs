using System;
using System.Windows.Forms;
using Clinic.Core.Staffing;
using Clinic.DataAccess;

namespace Clinic.WindowsForms.Appointments
{
    public partial class EditAppointmentForm : Form
    {
        public EditAppointmentForm()
        {
            InitializeComponent();
            LoadDoctors();
        }
        private void LoadDoctors()
        {
            var doctorRepository = new Repository<Doctor>();
            var doctors = doctorRepository.GetAll();
            doctorComboBox.DataSource = doctors;
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var repository = new AppointmentsRepository();
            repository.Add(doctorComboBox.Text, appointmentDateTimePicker.Value);
            Close();
        }
    }
}
