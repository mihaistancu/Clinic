using System;
using System.Windows.Forms;
using Clinic.Core.OfficeHours;
using Clinic.DataAccess;

namespace Clinic.WindowsForms.OfficeHours
{
    public partial class OfficeHoursForm : Form
    {
        public OfficeHoursForm()
        {
            InitializeComponent();
            ReloadData();
        }

        private void ReloadData()
        {
            var repository = new Repository<WeeklyOfficeHours>();
            var doctors = repository.GetAll();
            officeHoursDataGridView.DataSource = doctors;
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
