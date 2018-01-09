using System;
using System.Windows;
using System.Windows.Input;
using Clinic.WPF.Doctors.DoctorsWindow;
using Clinic.WPF.Doctors.EditDoctorWindow;

namespace Clinic.WPF
{
    public class ShowCommand<T> :ICommand 
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (typeof(T) == typeof(DoctorsViewModel))
            {
                Show<DoctorsView>();
            }
            else if (typeof(T) == typeof(EditDoctorViewModel))
            {
                Show<EditDoctorView>();
            }
        }

        private void Show<U>() where U : Window, new()
        {
            var view = new U();
            view.Show();
        }

        public event EventHandler CanExecuteChanged;
    }
}
