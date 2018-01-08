using System;
using System.Windows.Forms;

namespace Clinic.WindowsForms.Controls.DateTimePickers
{
    public partial class DateTimePicker : UserControl
    {
        public DateTimePicker()
        {
            InitializeComponent();
        }

        public DateTime SelectedDateTime
        {
            get {
                return new DateTime(
                    datePicker.SelectedDate.Year, 
                    datePicker.SelectedDate.Month, 
                    datePicker.SelectedDate.Day,
                    timePicker.Value.Hour, 
                    timePicker.Value.Minute, 
                    timePicker.Value.Second);
            }
        }
    }
}
