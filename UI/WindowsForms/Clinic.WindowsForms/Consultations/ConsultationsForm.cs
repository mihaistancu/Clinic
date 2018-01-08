using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using Clinic.Data;
using Clinic.Data.Persistence.EF;

namespace Clinic.WindowsForms.Consultations
{
    public partial class ConsultationsForm : Form
    {
        public ConsultationsForm()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            doctorComboBox.LoadData();
            officeComboBox.LoadData();
            patientComboBox.LoadData();
            LoadConsultations();
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            var editConsultationForm = new EditConsultationForm();
            editConsultationForm.ShowDialog();
            LoadConsultations();
        }
        
        private void LoadConsultations()
        {
            var repository = new ConsultationsRepository();
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

            consultationsGridView.DataSource = results.ToList();
        }

        private IEnumerable<Expression<Func<ClinicalVisit, bool>>> GetSearchPredicates()
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
            LoadConsultations();
        }
    }
}
