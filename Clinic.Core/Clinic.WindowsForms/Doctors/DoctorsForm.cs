using Clinic.Core.Staffing;
using Clinic.DataAccess;
using System;
using System.Windows.Forms;

namespace Clinic.WindowsForms.Doctors
{
    public partial class DoctorsForm : Form
    {
        public DoctorsForm()
        {
            InitializeComponent();

            ReloadData();
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            var editDoctorForm = new EditDoctorForm();
            editDoctorForm.ShowDialog();
            ReloadData();
        }

        private void ReloadData()
        {
            var repository = new Repository<Doctor>();
            var doctors = repository.GetAll();
            doctorsGridView.DataSource = doctors;
        }
    }
}
