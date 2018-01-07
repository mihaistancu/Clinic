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
            doctorComboBox.LoadData();
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var repository = new AppointmentsRepository();
            repository.Add(doctorComboBox.SelectedValue, appointmentDateTimePicker.Value);
            Close();
        }
    }
}
