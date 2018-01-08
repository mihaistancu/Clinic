namespace Clinic.WPF
{
    public class ClinicViewModel
    {
        public ShowDoctorsViewCommand ShowDoctorsView { get; set; }

        public ClinicViewModel()
        {
            ShowDoctorsView = new ShowDoctorsViewCommand();
        }
    }
}
