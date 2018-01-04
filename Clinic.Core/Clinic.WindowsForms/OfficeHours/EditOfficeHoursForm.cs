using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Clinic.Core.Infrastructure;
using Clinic.Core.OfficeHours;
using Clinic.Core.Staffing;
using Clinic.DataAccess;

namespace Clinic.WindowsForms.OfficeHours
{
    public partial class EditOfficeHoursForm : Form
    {
        public EditOfficeHoursForm()
        {
            InitializeComponent();
            ReloadData();
        }

        private void ReloadData()
        {
            var doctorRepository = new Repository<Doctor>();
            var doctors = doctorRepository.GetAll();
            doctorComboBox.DataSource = doctors;

            var officeRepository = new Repository<Office>();
            var offices = officeRepository.GetAll();
            officeComboBox.DataSource = offices;

            var daysOfWeek = new List<DayOfWeek>
            {
                DayOfWeek.Monday,
                DayOfWeek.Tuesday,
                DayOfWeek.Wednesday,
                DayOfWeek.Thursday,
                DayOfWeek.Friday,
                DayOfWeek.Saturday,
                DayOfWeek.Sunday
            };
            dayOfWeekComboBox.DataSource = daysOfWeek;
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var repository = new OfficeHoursRepository();
            string doctorName = ((Doctor)doctorComboBox.SelectedItem).Name;
            string officeLocation = ((Office)officeComboBox.SelectedItem).Location;
            var dailyOfficeHours = new DailyOfficeHours
            {
                DayOfWeek = (DayOfWeek) dayOfWeekComboBox.SelectedItem,
                StartTime = startTimePicker.Value.TimeOfDay,
                EndTime = endTimePicker.Value.TimeOfDay
            };
            repository.Add(doctorName, officeLocation, dailyOfficeHours);
            Close();
        }
    }
}
