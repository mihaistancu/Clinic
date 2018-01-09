using System;
using System.Windows.Input;
using Clinic.WPF.Doctors.EditDoctorWindow;

namespace Clinic.WPF.Doctors.DoctorsWindow
{
    public class ShowEditDoctorViewCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var editDoctorView = new EditDoctorView();
            editDoctorView.Show();
        }

        public event EventHandler CanExecuteChanged;
    }
}
