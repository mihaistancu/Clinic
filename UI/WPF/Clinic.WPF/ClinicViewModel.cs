using Clinic.WPF.Doctors.DoctorsWindow;
using Clinic.WPF.Mvvm;

namespace Clinic.WPF
{
    public class ClinicViewModel
    {
        public ShowCommand<DoctorsViewModel> ShowDoctorsViewCommand { get; set; }

        public ClinicViewModel()
        {
            ShowDoctorsViewCommand = new ShowCommand<DoctorsViewModel>();
        }
    }
}
