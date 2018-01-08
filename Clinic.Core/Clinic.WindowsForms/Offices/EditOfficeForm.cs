using Clinic.DataAccess;
using System;
using System.Windows.Forms;
using Clinic.Core;

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
