using System;
using System.Windows.Forms;
using Clinic.Data;
using Clinic.Data.Persistence.EF;

namespace Clinic.WindowsForms.Doctors
{
    public partial class DoctorsForm : Form
    {
        public DoctorsForm()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            LoadDoctors();
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            var editDoctorForm = new EditDoctorForm();
            editDoctorForm.ShowDialog();
            LoadDoctors();
        }

        private void LoadDoctors()
        {
            var repository = new Repository<Doctor>();
            var doctors = repository.GetAll();
            doctorsGridView.DataSource = doctors;
        }
    }
}
