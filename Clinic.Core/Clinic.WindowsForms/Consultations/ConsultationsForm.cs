using Clinic.Core.Consultations;
using Clinic.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Clinic.WindowsForms.Consultations
{
    public partial class ConsultationsForm : Form
    {
        public ConsultationsForm()
        {
            InitializeComponent();
            ReloadData();
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            var editConsultationForm = new EditConsultationForm();
            editConsultationForm.ShowDialog();
            ReloadData();
        }
        
        private void ReloadData()
        {
            var repository = new ConsultationsRepository();
            var searchPredicates = GetSearchPredicates().ToArray();

            var results = from x in repository.Search(searchPredicates)
                          select new
                          {
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
            if (!string.IsNullOrEmpty(doctorComboBox.SelectedValue))
            {
                yield return c => c.Doctor.Name == doctorComboBox.SelectedValue;
            }

            if (!string.IsNullOrEmpty(officeComboBox.Text))
            {
                yield return c => c.Office.Location == officeComboBox.Text;
            }

            if (!string.IsNullOrEmpty(patientComboBox.Text))
            {
                yield return c => c.Patient.Name == patientComboBox.Text;
            }
        }
        
        private void OnSelectedValueChanged()
        {
            ReloadData();
        }
    }
}
