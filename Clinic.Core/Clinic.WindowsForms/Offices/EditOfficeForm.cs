using Clinic.Core.Infrastructure;
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

namespace Clinic.WindowsForms.Offices
{
    public partial class EditOfficeForm : Form
    {
        public EditOfficeForm()
        {
            InitializeComponent();
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var repository = new Repository<Office>();
            repository.Add(new Office { Location = officeLocationTextBox.Text });
            Close();
        }
    }
}
