using System;
using System.Windows.Forms;

namespace Clinic.WindowsForms.Controls.DateTimePickers
{
    public partial class DateRange : UserControl
    {
        public DateTime StartDate
        {
            get { return startDatePicker.Value; }
        }

        public DateTime EndDate
        {
            get { return endDatePicker.Value; }
        }

        public DateRange()
        {
            InitializeComponent();
        }
    }
}
