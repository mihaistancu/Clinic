using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinic.Core.Staffing;
using Clinic.DataAccess;

namespace Clinic.WindowsForms.OfficeHours
{
    public partial class EditWeeklyOfficeHoursForm : Form
    {
        public EditWeeklyOfficeHoursForm()
        {
            InitializeComponent();
            ReloadData();
        }

        private void ReloadData()
        {
            var repository = new OfficeHoursRepository();
            var officeHours = repository.GetAll();
            officeHoursDataGridView.DataSource = officeHours;
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
