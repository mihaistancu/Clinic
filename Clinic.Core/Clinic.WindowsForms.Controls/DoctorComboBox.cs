using Clinic.Core.Staffing;
using Clinic.DataAccess;
using System.Windows.Forms;

namespace Clinic.WindowsForms.Controls
{
    public partial class DoctorComboBox : UserControl
    {
        public DoctorComboBox()
        {
            InitializeComponent();
            LoadDoctors();
        }

        private void LoadDoctors()
        {
            var doctorRepository = new Repository<Doctor>();
            var doctors = doctorRepository.GetAll();
            comboBox.DataSource = doctors;
        }

        public string SelectedDoctorName
        {
            get
            {
                return comboBox.Text;
            }
        }
    }
}
