using System;
using System.Windows.Forms;

namespace Clinic.WindowsForms.Controls
{
    public partial class DateTimeRange : UserControl
    {
        public DateTime StartDateTime
        {
            get { return new DateTime(
                datePicker.SelectedDate.Year, 
                datePicker.SelectedDate.Month, 
                datePicker.SelectedDate.Day, 
                timeRange.StartTime.Hours, 
                timeRange.StartTime.Minutes, 
                timeRange.StartTime.Seconds); }
        }

        public DateTime EndDateTime
        {
            get { return new DateTime(
                datePicker.SelectedDate.Year, 
                datePicker.SelectedDate.Month, 
                datePicker.SelectedDate.Day, 
                timeRange.EndTime.Hours, 
                timeRange.EndTime.Minutes, 
                timeRange.EndTime.Seconds); }
        }

        public DateTimeRange()
        {
            InitializeComponent();
        }
    }
}
