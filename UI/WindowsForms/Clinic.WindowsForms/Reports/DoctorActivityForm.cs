using System;
using System.Globalization;
using System.Windows.Forms;
using Clinic.Data;
using Clinic.Data.Persistence.EF;
using Clinic.Reports;

namespace Clinic.WindowsForms.Reports
{
    public partial class DoctorActivityForm : Form
    {
        public DoctorActivityForm()
        {
            InitializeComponent();
        }

        private void OnGenerateReportButtonClicked(object sender, EventArgs e)
        {
            var repository = new ConsultationsRepository();
            var report = DoctorActivityReport.For(repository, doctorComboBox.SelectedDoctor, dateRange.StartDate, dateRange.EndDate);
            totalClinicalVisitsTextBox.Text = report.ClinicalVisitsCount.ToString();
            totalAmountReceivedTextBox.Text = report.TotalAmountReceived.ToString(CultureInfo.InvariantCulture);
        }

        private void OnLoad(object sender, EventArgs e)
        {
            doctorComboBox.LoadData();
        }
    }
}
