using Clinic.DataAccess;
using Clinic.Core.Patients;

namespace Clinic.WindowsForms.Controls
{
    public partial class PatientComboBox : ClinicDataComboBox
    {
        public Patient SelectedPatient
        {
            get { return comboBox.SelectedItem as Patient; }
        }

        public PatientComboBox()
        {
            InitializeComponent();
        }

        protected override object GetDropDownItems()
        {
            var repository = new Repository<Patient>();
            return repository.GetAll();
        }
    }
}
