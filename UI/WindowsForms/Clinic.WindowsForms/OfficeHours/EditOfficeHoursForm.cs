using System;
using System.Windows.Forms;
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
            repository.Add(
                doctorComboBox.SelectedDoctor.Name, 
                officeComboBox.SelectedOffice.Location, 
                dayOfWeekComboBox.SelectedDay, 
                timeRange.StartTime, 
                timeRange.EndTime);
            Close();
        }
    }
}
