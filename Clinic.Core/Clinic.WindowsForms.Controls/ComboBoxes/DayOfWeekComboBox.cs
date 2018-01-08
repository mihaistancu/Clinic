using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clinic.WindowsForms.Controls.ComboBoxes
{
    public partial class DayOfWeekComboBox : UserControl
    {
        public DayOfWeek SelectedDay
        {
            get { return (DayOfWeek)comboBox.SelectedItem; }
        }

        public DayOfWeekComboBox()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            comboBox.DataSource = new List<DayOfWeek>
            {
                DayOfWeek.Monday,
                DayOfWeek.Tuesday,
                DayOfWeek.Wednesday,
                DayOfWeek.Thursday,
                DayOfWeek.Friday,
                DayOfWeek.Saturday,
                DayOfWeek.Sunday
            }; ;
        }
    }
}
