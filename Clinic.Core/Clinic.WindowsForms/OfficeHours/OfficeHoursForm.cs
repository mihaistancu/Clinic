using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using Clinic.Core.Infrastructure;
using Clinic.Core.OfficeHours;
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
            var searchPredicates = GetSearchPredicates().ToArray();

            var results = from x in officeHoursRepository.Search(searchPredicates)
                from h in x.OfficeHours select new
                {
                    Doctor = x.Doctor.Name,
                    Office = x.Office.Location,
                    DayOfWeek = h.DayOfWeek,
                    StartTime = h.StartTime,
                    EndTime = h.EndTime
                };

            officeHoursDataGridView.DataSource = results.ToList();
        }

        private IEnumerable<Expression<Func<WeeklyOfficeHours, bool>>> GetSearchPredicates()
        {
            if (!string.IsNullOrEmpty(doctorComboBox.Text))
            {
                yield return h => h.Doctor.Name == doctorComboBox.Text;
            }

            if (!string.IsNullOrEmpty(officeComboBox.Text))
            {
                yield return h => h.Office.Location == officeComboBox.Text;
            }
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            var editDailyOfficeHoursForm = new EditOfficeHoursForm();
            editDailyOfficeHoursForm.ShowDialog();
            LoadOfficesHours();
        }
        
        private void OnSelectedValueChanged(object sender, EventArgs e)
        {
            LoadOfficesHours();
        }
    }
}
