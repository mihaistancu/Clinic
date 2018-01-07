using System;
using System.Windows.Forms;
using Clinic.DataAccess;

namespace Clinic.WindowsForms.Appointments
{
    public partial class EditAppointmentForm : Form
    {
        public EditAppointmentForm()
        {
            InitializeComponent();
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var repository = new AppointmentsRepository();
            repository.Add(doctorComboBox.SelectedDoctor.Name, datePicker.SelectedDate);
            Close();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            doctorComboBox.LoadData();
        }
    }
}
