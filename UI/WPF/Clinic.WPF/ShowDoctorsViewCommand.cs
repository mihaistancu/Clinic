using System;
using System.Windows.Input;
using Clinic.WPF.Doctors.DoctorsWindow;

namespace Clinic.WPF
{
    public class ShowDoctorsViewCommand : ICommand 
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var doctorsView = new DoctorsView();
            doctorsView.Show();
        }

        public event EventHandler CanExecuteChanged;
    }
}
