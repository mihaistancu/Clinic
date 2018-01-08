using System;
using System.Windows.Forms;
using Clinic.Data.OfficeHours;
using Clinic.Data.Persistence.EF;

namespace Clinic.WindowsForms.OfficeHours
{
    public partial class EditOfficeHoursForm : Form
    {
        public EditOfficeHoursForm()
        {
            InitializeComponent();            
        }

        private void OnLoad(object sender, EventArgs e)
        {
            doctorComboBox.LoadData();
            officeComboBox.LoadData();
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var repository = new OfficeHoursRepository();
            string doctorName = doctorComboBox.SelectedDoctor.Name;
            string officeLocation = officeComboBox.SelectedOffice.Location;
            var dailyOfficeHours = new DailyOfficeHours
            {
                DayOfWeek = dayOfWeekComboBox.SelectedDay,
                StartTime = timeRange.StartTime,
                EndTime = timeRange.EndTime
            };
            repository.Add(doctorName, officeLocation, dailyOfficeHours);
            Close();
        }
    }
}
