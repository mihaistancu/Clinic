using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using Clinic.Core.Appointments;
using Clinic.Core.Staffing;
using Clinic.DataAccess;

namespace Clinic.WindowsForms.Appointments
{
    public partial class AppointmentsForm : Form
    {
        public AppointmentsForm()
        {
            InitializeComponent();
            LoadAppointments();
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            var editAppointmentForm = new EditAppointmentForm();
            editAppointmentForm.ShowDialog();
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            var appointmentsRepository = new AppointmentsRepository();
            var searchPredicates = GetSearchPredicates().ToArray();

            var results = from x in appointmentsRepository.Search(searchPredicates)
                select new
                {
                    Doctor = x.Doctor.Name,
                    Date = x.StartDate
                };

            appointmentsDataGridView.DataSource = results.ToList();
        }

        private IEnumerable<Expression<Func<Appointment, bool>>> GetSearchPredicates()
        {
            if (!string.IsNullOrEmpty(doctorComboBox.SelectedValue))
            {
                yield return a => a.Doctor.Name == doctorComboBox.SelectedValue;
            }
        }

        private void OnSelectedValueChanged(object sender, EventArgs e)
        {
            LoadAppointments();
        }
    }
}
