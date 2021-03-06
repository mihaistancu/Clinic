﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using Clinic.Data.Persistence.EF;

namespace Clinic.WindowsForms.OfficeHours
{
    public partial class OfficeHoursForm : Form
    {
        public OfficeHoursForm()
        {
            InitializeComponent();            
        }

        private void OnLoad(object sender, EventArgs e)
        {
            doctorComboBox.LoadData();
            officeComboBox.LoadData();
            LoadOfficeHours();
        }

        private void LoadOfficeHours()
        {
            var officeHoursRepository = new OfficeHoursRepository();
            var searchPredicates = GetSearchPredicates().ToArray();

            var results = from x in officeHoursRepository.Search(searchPredicates)
                orderby x.Doctor, x.Office, x.DayOfWeek
                select new
                {
                    Doctor = x.Doctor.Name,
                    Office = x.Office.Location,
                    DayOfWeek = x.DayOfWeek,
                    StartTime = x.StartTime,
                    EndTime = x.EndTime
                };

            officeHoursDataGridView.DataSource = results.ToList();
        }

        private IEnumerable<Expression<Func<Data.OfficeHours, bool>>> GetSearchPredicates()
        {
            if (doctorComboBox.SelectedDoctor != null)
            {
                yield return h => h.Doctor.Name == doctorComboBox.SelectedDoctor.Name;
            }

            if (officeComboBox.SelectedOffice != null)
            {
                yield return h => h.Office.Location == officeComboBox.SelectedOffice.Location;
            }
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            var editDailyOfficeHoursForm = new EditOfficeHoursForm();
            editDailyOfficeHoursForm.ShowDialog();
            LoadOfficeHours();
        }
        
        private void OnSelectedValueChanged()
        {
            LoadOfficeHours();
        }
    }
}
