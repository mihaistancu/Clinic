using System.Collections.Generic;
using Clinic.Data;
using Clinic.Data.Persistence.EF;
using Clinic.WPF.Doctors.EditDoctorWindow;
using Clinic.WPF.Mvvm;

namespace Clinic.WPF.Doctors.DoctorsWindow
{
    public class DoctorsViewModel
    {
        public ShowCommand<EditDoctorViewModel> ShowEditDoctorViewCommand { get; set; }
        public Command LoadDoctorsCommand { get; set; }

        public List<Doctor> Doctors { get; private set; }

        public DoctorsViewModel()
        {
            ShowEditDoctorViewCommand = new ShowCommand<EditDoctorViewModel>();
            LoadDoctorsCommand = new Command(LoadDoctors);
        }

        private void LoadDoctors()
        {
            var repository = new Repository<Doctor>();
            Doctors = repository.GetAll();
        }
    }
}
