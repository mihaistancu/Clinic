using Clinic.DataAccess;
using System;
using System.Windows.Forms;
using Clinic.Core;

namespace Clinic.WindowsForms.Offices
{
    public partial class OfficesForm : Form
    {
        public OfficesForm()
        {
            InitializeComponent();            
        }

        private void OnLoad(object sender, EventArgs e)
        {
            LoadOffices();
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            var editOfficeForm = new EditOfficeForm();
            editOfficeForm.ShowDialog();
            LoadOffices();
        }

        private void LoadOffices()
        {
            var repository = new Repository<Office>();
            var offices = repository.GetAll();
            officesGridView.DataSource = offices;
        }
    }
}
