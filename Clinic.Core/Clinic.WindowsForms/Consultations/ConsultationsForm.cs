using Clinic.DataAccess;
using System;
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
            throw new NotImplementedException();
        }

        private void ReloadData()
        {
            var repository = new ConsultationsRepository();
            var consultations = repository.GetAll();
            consultationsGridView.DataSource = consultations;
        }
    }
}
