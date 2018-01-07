﻿using Clinic.Core.Staffing;
using Clinic.DataAccess;

namespace Clinic.WindowsForms.Controls
{
    public partial class DoctorComboBox : ClinicDataComboBox
    {
        public Doctor SelectedDoctor
        {
            get { return comboBox.SelectedItem as Doctor; }
        }

        public DoctorComboBox()
        {
            InitializeComponent();
        }
        
        protected override object GetDropDownItems()
        {
            var repository = new Repository<Doctor>();
            return repository.GetAll();
        }
    }
}
