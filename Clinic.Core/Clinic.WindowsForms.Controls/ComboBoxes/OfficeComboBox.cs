using Clinic.Core;
using Clinic.DataAccess;

namespace Clinic.WindowsForms.Controls.ComboBoxes
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
