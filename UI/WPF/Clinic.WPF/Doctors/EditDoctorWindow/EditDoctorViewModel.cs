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
        }
    }
}
