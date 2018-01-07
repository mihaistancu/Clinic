using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            doctorComboBox.LoadData();
            officeComboBox.LoadData();
            LoadOfficesHours();
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
            if (!string.IsNullOrEmpty(doctorComboBox.SelectedValue))
            {
                yield return h => h.Doctor.Name == doctorComboBox.SelectedValue;
            }

            if (!string.IsNullOrEmpty(officeComboBox.SelectedValue))
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
        
        private void OnSelectedValueChanged()
        {
            LoadOfficesHours();
        }
    }
}
