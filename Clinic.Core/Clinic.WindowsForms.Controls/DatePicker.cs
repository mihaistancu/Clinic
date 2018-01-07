using System;
using System.Windows.Forms;

namespace Clinic.WindowsForms.Controls
{
    public partial class DatePicker : UserControl
    {
        public DatePicker()
        {
            InitializeComponent();
        }

        public DateTime SelectedDate
        {
            get { return dateTimePicker.Value; }
        }
    }
}
