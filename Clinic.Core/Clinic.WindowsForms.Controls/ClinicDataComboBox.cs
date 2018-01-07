using System;
using System.Windows.Forms;

namespace Clinic.WindowsForms.Controls
{
    public partial class ClinicDataComboBox : UserControl
    {
        public event Action SelectedValueChanged;

        public string Label
        {
            get { return label.Text; }
            set { label.Text = value; }
        }

        public string SelectedValue
        {
            get { return comboBox.Text; }
        }

        public ClinicDataComboBox()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            if (!DesignMode)
            {
                comboBox.DataSource = GetDropDownItems();
            }
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
