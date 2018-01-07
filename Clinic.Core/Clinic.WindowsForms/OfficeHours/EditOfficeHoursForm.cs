﻿using System;
using System.Windows.Forms;
using Clinic.Core.OfficeHours;
using Clinic.DataAccess;

namespace Clinic.WindowsForms.OfficeHours
{
    public partial class EditOfficeHoursForm : Form
    {
        public EditOfficeHoursForm()
        {
            InitializeComponent();
            doctorComboBox.LoadData();
            officeComboBox.LoadData();
        }
        
        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var repository = new OfficeHoursRepository();
            string doctorName = doctorComboBox.SelectedValue;
            string officeLocation = officeComboBox.SelectedValue;
            var dailyOfficeHours = new DailyOfficeHours
            {
                DayOfWeek = dayOfWeekComboBox.SelectedDay,
                StartTime = timeRange.StartTime,
                EndTime = timeRange.EndTime
            };
            repository.Add(doctorName, officeLocation, dailyOfficeHours);
            Close();
        }
    }
}
