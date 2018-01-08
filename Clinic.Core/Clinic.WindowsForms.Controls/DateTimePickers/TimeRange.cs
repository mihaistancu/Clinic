using System;
using System.Windows.Forms;

namespace Clinic.WindowsForms.Controls.DateTimePickers
{
    public partial class TimeRange : UserControl
    {
        public TimeRange()
        {
            InitializeComponent();
        }

        public TimeSpan StartTime
        {
            get { return startTimePicker.Value.TimeOfDay; }
        }

        public TimeSpan EndTime
        {
            get { return endTimePicker.Value.TimeOfDay; }
        }
    }
}
