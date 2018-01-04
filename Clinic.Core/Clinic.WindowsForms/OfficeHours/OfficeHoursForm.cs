using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinic.Core.Infrastructure;
using Clinic.Core.Staffing;
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
            var doctorRepository = new Repository<Doctor>();
            var doctors = doctorRepository.GetAll();
            doctorComboBox.DataSource = doctors;

            var officeRepository = new Repository<Office>();
            var offices = officeRepository.GetAll();
            officeComboBox.DataSource = offices;

            var officeHoursRepository = new OfficeHoursRepository();
            var officeHours = officeHoursRepository.GetAll();
            officeHoursDataGridView.DataSource = officeHours;
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            var editDailyOfficeHoursForm = new EditOfficeHoursForm();
            editDailyOfficeHoursForm.ShowDialog();
            ReloadData();
        }
    }
}
