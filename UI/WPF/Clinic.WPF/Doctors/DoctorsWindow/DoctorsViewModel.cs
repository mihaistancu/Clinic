using Clinic.WPF.Doctors.EditDoctorWindow;
using Clinic.WPF.Mvvm;

namespace Clinic.WPF.Doctors.DoctorsWindow
{
    public class DoctorsViewModel
    {
        public ShowCommand<EditDoctorViewModel> ShowEditDoctorViewCommand { get; set; }

        public DoctorsViewModel()
        {
            ShowEditDoctorViewCommand = new ShowCommand<EditDoctorViewModel>();
        }
    }
}
