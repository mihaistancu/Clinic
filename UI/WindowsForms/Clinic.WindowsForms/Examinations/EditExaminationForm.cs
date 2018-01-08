using System;
using System.Windows.Forms;
using Clinic.Data.Persistence.EF;

namespace Clinic.WindowsForms.Examinations
{
    public partial class EditExaminationForm : Form
    {
        public EditExaminationForm()
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
            var repository = new ExaminationsRepository();
            repository.Add(
                doctorComboBox.SelectedDoctor.Name, 
                officeComboBox.SelectedOffice.Location, 
                patientComboBox.SelectedPatient.Name,
                dateTimeRange.StartDateTime,
                dateTimeRange.EndDateTime,
                amountReceivedNumericUpDown.Value);
            Close();
        }
    }
}
