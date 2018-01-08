using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using Clinic.Data;
using Clinic.Data.Persistence.EF;

namespace Clinic.WindowsForms.Examinations
{
    public partial class ExaminationsForm : Form
    {
        public ExaminationsForm()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            doctorComboBox.LoadData();
            officeComboBox.LoadData();
            patientComboBox.LoadData();
            LoadExaminations();
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            var editExaminationForm = new EditExaminationForm();
            editExaminationForm.ShowDialog();
            LoadExaminations();
        }
        
        private void LoadExaminations()
        {
            var repository = new ExaminationsRepository();
            var searchPredicates = GetSearchPredicates().ToArray();

            var results = from x in repository.Search(searchPredicates)
                          select new
                          {
                              Id = x.Id,
                              Doctor = x.Doctor.Name,
                              Office = x.Office.Location,
                              Patient = x.Patient.Name,
                              Start = x.StartDateTime,
                              End = x.EndDateTime,
                              AmountReceived = x.AmountReceived
                          };

            examinationsGridView.DataSource = results.ToList();
        }

        private IEnumerable<Expression<Func<Examination, bool>>> GetSearchPredicates()
        {
            if (doctorComboBox.SelectedDoctor != null)
            {
                yield return c => c.Doctor.Name == doctorComboBox.SelectedDoctor.Name;
            }

            if (officeComboBox.SelectedOffice != null)
            {
                yield return c => c.Office.Location == officeComboBox.SelectedOffice.Location;
            }

            if (patientComboBox.SelectedPatient != null)
            {
                yield return c => c.Patient.Name == patientComboBox.SelectedPatient.Name;
            }
        }
        
        private void OnSelectedValueChanged()
        {
            LoadExaminations();
        }
    }
}
