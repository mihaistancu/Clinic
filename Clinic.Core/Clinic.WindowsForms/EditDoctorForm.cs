using Clinic.Core.Staffing;
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

namespace Clinic.WindowsForms
{
    public partial class EditDoctorForm : Form
    {
        public EditDoctorForm()
        {
            InitializeComponent();
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var repository = new Repository<Doctor>();
            repository.Add(new Doctor { Name = doctorNameTextBox.Text });
            Close();
        }
    }
}
