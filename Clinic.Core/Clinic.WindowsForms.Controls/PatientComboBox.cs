using System.Windows.Forms;
using Clinic.DataAccess;
using Clinic.Core.Patients;

namespace Clinic.WindowsForms.Controls
{
    public partial class PatientComboBox : UserControl
    {
        public PatientComboBox()
        {
            InitializeComponent();
        }
        
        public string SelectedPatientName
        {
            get
            {
                return comboBox.Text;
            }
        }

        private void OnLoad(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
            var patientsRepository = new Repository<Patient>();
            var patients = patientsRepository.GetAll();
            comboBox.DataSource = patients;
        }
    }
}
