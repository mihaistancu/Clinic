using System;
using System.Windows.Forms;
using Clinic.Data.Persistence.EF;
using Clinic.Reports;

namespace Clinic.WindowsForms.Reports
{
    public partial class OfficeActivityForm : Form
    {
        public OfficeActivityForm()
        {
            InitializeComponent();
        }

        private void OnGenerateReportButtonClicked(object sender, EventArgs e)
        {
            var repository = new ExaminationsRepository();
            var report = OfficeActivityReport.For(repository, officeComboBox.SelectedOffice, dateRange.StartDate, dateRange.EndDate);
            totalExaminationsDurationTextBox.Text = report.TotalExaminationsDuration.ToString();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            officeComboBox.LoadData();
        }
    }
}
