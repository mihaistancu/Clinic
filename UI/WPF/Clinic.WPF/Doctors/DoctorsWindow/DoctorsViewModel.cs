namespace Clinic.WPF.Doctors.DoctorsWindow
{
    public class DoctorsViewModel
    {
        public ShowEditDoctorViewCommand ShowEditDoctorView { get; set; }

        public DoctorsViewModel()
        {
            ShowEditDoctorView = new ShowEditDoctorViewCommand();
        }
    }
}
