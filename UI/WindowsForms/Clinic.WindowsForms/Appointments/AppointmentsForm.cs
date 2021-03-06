﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using Clinic.Data;
using Clinic.Data.Persistence.EF;

namespace Clinic.WindowsForms.Appointments
{
    public partial class AppointmentsForm : Form
    {
        public AppointmentsForm()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            doctorComboBox.LoadData();
            LoadAppointments();
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            var editAppointmentForm = new EditAppointmentForm();
            editAppointmentForm.ShowDialog();
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            var appointmentsRepository = new AppointmentsRepository();
            var searchPredicates = GetSearchPredicates().ToArray();

            var results = from x in appointmentsRepository.Search(searchPredicates)
                select new
                {
                    Id = x.Id,
                    Doctor = x.Doctor.Name,
                    Date = x.StartDate
                };

            appointmentsDataGridView.DataSource = results.ToList();
        }

        private IEnumerable<Expression<Func<Appointment, bool>>> GetSearchPredicates()
        {
            if (doctorComboBox.SelectedDoctor != null)
            {
                yield return a => a.Doctor.Name == doctorComboBox.SelectedDoctor.Name;
            }
        }
        
        private void OnSelectedValueChanged()
        {
            LoadAppointments();
        }
    }
}
