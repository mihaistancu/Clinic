using System;
using System.Windows.Forms;

namespace Clinic.WindowsForms.Controls.DateTimePickers
{
    public partial class DateTimeRange : UserControl
    {
        public DateTime StartDateTime
        {
            get { return DateTimeFactory.Build(datePicker.SelectedDate, timeRange.StartTime); }
        }

        public DateTime EndDateTime
        {
            get { return DateTimeFactory.Build(datePicker.SelectedDate, timeRange.EndTime); }
        }

        public DateTimeRange()
        {
            InitializeComponent();
        }
    }
}
