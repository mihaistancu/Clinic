using System.Globalization;
using System.Windows.Forms;
using Clinic.Data.Persistence.EF;
using Clinic.Reports;

namespace Clinic.WindowsForms.Reports
{
    public partial class ClinicActivityForm : Form
    {
        public ClinicActivityForm()
        {
            InitializeComponent();
        }

        private void OnGenerateReportButtonClicked(object sender, System.EventArgs e)
        {
            var repository = new ConsultationsRepository();
            var report = ClinicActivityReport.For(repository, dateRange.StartDate, dateRange.EndDate);
            totalVisitsDurationTextBox.Text = report.TotalVisitsDuration.ToString();
            totalAmountReceivedTextBox.Text = report.TotalAmountReceived.ToString(CultureInfo.InvariantCulture);
        }
    }
}
