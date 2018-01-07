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
            doctorComboBox.LoadData();
            officeComboBox.LoadData();
            patientComboBox.LoadData();
        }
        
        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var repository = new ConsultationsRepository();
            string doctorName = doctorComboBox.SelectedValue;
            string officeLocation = officeComboBox.SelectedValue;
            string patientName = patientComboBox.SelectedValue;
            DateTime startDateTime = new DateTime(datePicker.SelectedDate.Year, datePicker.SelectedDate.Month, datePicker.SelectedDate.Day, timeRange.StartTime.Hours, timeRange.StartTime.Minutes, timeRange.StartTime.Seconds);
            DateTime endDateTime = new DateTime(datePicker.SelectedDate.Year, datePicker.SelectedDate.Month, datePicker.SelectedDate.Day, timeRange.EndTime.Hours, timeRange.EndTime.Minutes, timeRange.EndTime.Seconds);
            double amountReceived = (double)amountReceivedNumericUpDown.Value;
            repository.Add(doctorName, officeLocation, patientName, startDateTime, endDateTime, amountReceived);
            Close();
        }
    }
}
