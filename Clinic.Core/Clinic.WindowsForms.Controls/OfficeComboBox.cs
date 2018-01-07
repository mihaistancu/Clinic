using Clinic.Core.Infrastructure;
using Clinic.DataAccess;
using System.Windows.Forms;

namespace Clinic.WindowsForms.Controls
{
    public partial class OfficeComboBox : UserControl
    {
        public OfficeComboBox()
        {
            InitializeComponent();
        }
        
        public string SelectedOfficeLocation
        {
            get
            {
                return comboBox.Text;
            }
        }

        private void OnLoad(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
            var officeRepository = new Repository<Office>();
            var offices = officeRepository.GetAll();
            comboBox.DataSource = offices;
        }
    }
}
