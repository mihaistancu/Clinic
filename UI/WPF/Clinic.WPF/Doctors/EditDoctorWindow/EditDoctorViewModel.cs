using Clinic.Data;
using Clinic.Data.Persistence.EF;
using Clinic.WPF.Mvvm;

namespace Clinic.WPF.Doctors.EditDoctorWindow
{
    public class EditDoctorViewModel
    {
        public string DoctorName { get; set; }

        public Command SaveDoctorCommand { get; set; }

        public EditDoctorViewModel()
        {
            SaveDoctorCommand = new Command(SaveDoctor);
        }

        private void SaveDoctor()
        {
            var repository = new Repository<Doctor>();
            repository.Add(new Doctor {Name = DoctorName});
        }
    }
}
