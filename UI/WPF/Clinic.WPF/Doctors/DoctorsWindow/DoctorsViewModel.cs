using Clinic.WPF.Doctors.EditDoctorWindow;

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
