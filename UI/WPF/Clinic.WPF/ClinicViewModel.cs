using Clinic.WPF.Doctors.DoctorsWindow;
using Clinic.WPF.Mvvm;

namespace Clinic.WPF
{
    public class ClinicViewModel
    {
        public Command ShowDoctorsViewCommand { get; set; }

        public ClinicViewModel()
        {
            ShowDoctorsViewCommand = new Command(ShowDoctorsView);
        }

        private void ShowDoctorsView()
        {
            var doctorsView = new DoctorsView();
            doctorsView.Show();
        }
    }
}
