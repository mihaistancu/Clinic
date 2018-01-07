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
            DateTime startDateTime = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day, startTimePicker.Value.Hour, startTimePicker.Value.Minute, startTimePicker.Value.Second);
            DateTime endDateTime = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day, endTimePicker.Value.Hour, endTimePicker.Value.Minute, endTimePicker.Value.Second);
            double amountReceived = (double)amountReceivedNumericUpDown.Value;
            repository.Add(doctorName, officeLocation, patientName, startDateTime, endDateTime, amountReceived);
            Close();
        }
    }
}
