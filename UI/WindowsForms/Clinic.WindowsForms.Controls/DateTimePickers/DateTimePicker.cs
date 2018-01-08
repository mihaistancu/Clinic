using System;
using System.Windows.Forms;

namespace Clinic.WindowsForms.Controls.DateTimePickers
{
    public partial class DateTimePicker : UserControl
    {
        public DateTime SelectedDateTime
        {
            get { return DateTimeFactory.Build(datePicker.SelectedDate, timePicker.Value.TimeOfDay); }
        }

        public DateTimePicker()
        {
            InitializeComponent();
        }
    }
}
