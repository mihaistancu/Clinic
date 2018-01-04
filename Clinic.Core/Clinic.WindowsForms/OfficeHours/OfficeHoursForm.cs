using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
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
            var results = from x in officeHoursRepository.Search(GetSearchCriteria())
                from h in x.OfficeHours
                select new
                {
                    Doctor = x.Doctor.Name,
                    Office = x.Office.Location,
                    DayOfWeek = h.DayOfWeek,
                    StartTime = h.StartTime,
                    EndTime = h.EndTime
                };

            officeHoursDataGridView.DataSource = results.ToList();
        }

        private Expression<Func<WeeklyOfficeHours, bool>>[] GetSearchCriteria()
        {
            var predicates = new List<Expression<Func<WeeklyOfficeHours, bool>>>();

            if (!string.IsNullOrEmpty(doctorComboBox.Text))
            {
                predicates.Add(h => h.Doctor.Name == doctorComboBox.Text);
            }

            if (!string.IsNullOrEmpty(officeComboBox.Text))
            {
                predicates.Add(h => h.Office.Location == officeComboBox.Text);
            }

            return predicates.ToArray();
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
