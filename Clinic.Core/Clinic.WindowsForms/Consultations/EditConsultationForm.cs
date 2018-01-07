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
        }

        private void OnLoad(object sender, EventArgs e)
        {
            doctorComboBox.LoadData();
            officeComboBox.LoadData();
            patientComboBox.LoadData();
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var repository = new ConsultationsRepository();
            string doctorName = doctorComboBox.SelectedDoctor.Name;
            string officeLocation = officeComboBox.SelectedOffice.Location;
            string patientName = patientComboBox.SelectedPatient.Name;
            DateTime startDateTime = dateTimeRange.StartDateTime;
            DateTime endDateTime = dateTimeRange.EndDateTime;
            double amountReceived = (double)amountReceivedNumericUpDown.Value;
            repository.Add(doctorName, officeLocation, patientName, startDateTime, endDateTime, amountReceived);
            Close();
        }
    }
}
