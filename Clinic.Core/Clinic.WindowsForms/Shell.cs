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
    public partial class Shell : Form
    {
        public Shell()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var doctorsForm = new DoctorsForm();
            doctorsForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var officesForm = new OfficesForm();
            officesForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var patientsForm = new PatientsForm();
            patientsForm.Show();
        }
    }
}
