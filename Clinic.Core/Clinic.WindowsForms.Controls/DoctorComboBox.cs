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
        }
        
        public string SelectedValue
        {
            get
            {
                return comboBox.Text;
            }
        }

        private void OnLoad(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
            var doctorRepository = new Repository<Doctor>();
            var doctors = doctorRepository.GetAll();
            comboBox.DataSource = doctors;
        }
    }
}
