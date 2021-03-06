﻿using Clinic.Data;
using Clinic.Data.Persistence.EF;

namespace Clinic.WindowsForms.Controls.ComboBoxes
{
    public partial class PatientComboBox : ClinicDataComboBox
    {
        public Patient SelectedPatient
        {
            get { return comboBox.SelectedItem as Patient; }
        }

        public PatientComboBox()
        {
            InitializeComponent();
        }

        protected override object GetDropDownItems()
        {
            var repository = new Repository<Patient>();
            return repository.GetAll();
        }
    }
}
