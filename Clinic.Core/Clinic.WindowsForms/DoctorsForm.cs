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
    public partial class DoctorsForm : Form
    {
        public DoctorsForm()
        {
            InitializeComponent();

            var repository = new Repository<Doctor>();
            var doctors = repository.GetAll();
            doctorsGridView.DataSource = doctors;
        }
    }
}
