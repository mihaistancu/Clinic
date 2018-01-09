using Clinic.WPF.Doctors.EditDoctorWindow;
using Clinic.WPF.Mvvm;

namespace Clinic.WPF.Doctors.DoctorsWindow
{
    public class DoctorsViewModel
    {
        public Command ShowEditDoctorViewCommand { get; set; }

        public DoctorsViewModel()
        {
            ShowEditDoctorViewCommand = new Command(ShowEditDoctorView);
        }

        private void ShowEditDoctorView()
        {
            var editDoctorView = new EditDoctorView();
            editDoctorView.Show();
        }
    }
}
