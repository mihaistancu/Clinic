using Clinic.Core;
using Clinic.DataAccess;

namespace Clinic.WindowsForms.Controls.ComboBoxes
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
