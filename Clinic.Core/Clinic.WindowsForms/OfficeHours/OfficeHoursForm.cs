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
            LoadDoctors();
            LoadOffices();
            LoadOfficesHours();
        }

        private void LoadDoctors()
        {
            var doctorRepository = new Repository<Doctor>();
            var doctors = doctorRepository.GetAll();
            doctorComboBox.DataSource = doctors;
        }

        private void LoadOffices()
        {
            var officeRepository = new Repository<Office>();
            var offices = officeRepository.GetAll();
            officeComboBox.DataSource = offices;
        }

        private void LoadOfficesHours()
        {
            var officeHoursRepository = new OfficeHoursRepository();
            var officeHours = officeHoursRepository.Search(h =>
                h.Doctor.Name == doctorComboBox.Text && 
                h.Office.Location == officeComboBox.Text).SingleOrDefault();
            if (officeHours != null)
            {
                officeHoursDataGridView.DataSource = officeHours.OfficeHours;
            }
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            var editDailyOfficeHoursForm = new EditOfficeHoursForm();
            editDailyOfficeHoursForm.ShowDialog();
            LoadOfficesHours();
        }
    }
}
