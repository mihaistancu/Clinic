using Clinic.Core.Infrastructure;
using Clinic.DataAccess;
using System;
using System.Windows.Forms;

namespace Clinic.WindowsForms.Offices
{
    public partial class OfficesForm : Form
    {
        public OfficesForm()
        {
            InitializeComponent();
            ReloadData();
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            var editOfficeForm = new EditOfficeForm();
            editOfficeForm.ShowDialog();
            ReloadData();
        }

        private void ReloadData()
        {
            var repository = new Repository<Office>();
            var offices = repository.GetAll();
            officesGridView.DataSource = offices;
        }
    }
}
