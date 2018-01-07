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
            doctorComboBox.LoadData();
            officeComboBox.LoadData();
            ReloadData();
        }

        private void ReloadData()
        {
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
            string doctorName = doctorComboBox.SelectedValue;
            string officeLocation = officeComboBox.SelectedValue;
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
