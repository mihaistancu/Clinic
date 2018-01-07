using System;
using System.Windows.Forms;

namespace Clinic.WindowsForms.Controls
{
    public partial class ClinicDataComboBox : UserControl
    {
        public event Action SelectedValueChanged;
        
        public ComboBoxStyle DropDownStyle
        {
            get { return comboBox.DropDownStyle; }
            set { comboBox.DropDownStyle = value; }
        }

        public ClinicDataComboBox()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            comboBox.DataSource = GetDropDownItems();
        }

        protected virtual object GetDropDownItems()
        {
            return null;
        }

        private void OnComboBoxTextChanged(object sender, EventArgs e)
        {
            SelectedValueChanged?.Invoke();
        }
    }
}
