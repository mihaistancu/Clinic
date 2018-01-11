using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Clinic.Data;
using Clinic.Data.Persistence.EF;
using Clinic.WPF.Doctors.EditDoctorWindow;
using Clinic.WPF.Mvvm;

namespace Clinic.WPF.Doctors.DoctorsWindow
{
    public class DoctorsViewModel: INotifyPropertyChanged
    {
        public ShowCommand<EditDoctorViewModel> ShowEditDoctorViewCommand { get; set; }
        public Command LoadDoctorsCommand { get; set; }

        private List<Doctor> doctors;

        public List<Doctor> Doctors
        {
            get { return doctors; }
            private set { doctors = value; OnPropertyChanged(); }
        }

        public DoctorsViewModel()
        {
            ShowEditDoctorViewCommand = new ShowCommand<EditDoctorViewModel>();
            LoadDoctorsCommand = new Command(LoadDoctors);

            ShowEditDoctorViewCommand.Executed += OnEditDoctorFinished;
        }

        private void OnEditDoctorFinished(object sender, System.EventArgs e)
        {
            LoadDoctors();
        }

        private void LoadDoctors()
        {
            var repository = new Repository<Doctor>();
            Doctors = repository.GetAll();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
