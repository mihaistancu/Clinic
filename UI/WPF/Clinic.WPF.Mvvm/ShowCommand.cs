using System;
using System.Windows.Input;

namespace Clinic.WPF.Mvvm
{
    public class ShowCommand<T> :ICommand 
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            View.For<T>().Show();
        }
        
        public event EventHandler CanExecuteChanged;
    }
}
