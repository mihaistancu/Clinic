using Clinic.Core.Infrastructure;
using Clinic.DataAccess;

namespace Clinic.WindowsForms.Controls
{
    public partial class OfficeComboBox : ClinicDataComboBox
    {
        public Office SelectedOffice
        {
            get { return comboBox.SelectedItem as Office; }
        }

        public OfficeComboBox()
        {
            InitializeComponent();
        }
        
        protected override object GetDropDownItems()
        {
            var repository = new Repository<Office>();
            return repository.GetAll();
        }
    }
}
