using Clinic.Core.Patients;
using Clinic.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic.WindowsForms.Patients
{
    public partial class PatientsForm : Form
    {
        public PatientsForm()
        {
            InitializeComponent();
            ReloadData();
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            var editPatientForm = new EditPatientForm();
            editPatientForm.ShowDialog();
            ReloadData();
        }

        private void ReloadData()
        {
            var repository = new Repository<Patient>();
            var patients = repository.GetAll();
            patientsGridView.DataSource = patients;
        }
    }
}
