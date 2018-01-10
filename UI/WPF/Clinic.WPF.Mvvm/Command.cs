using System;
using System.Windows.Input;

namespace Clinic.WPF.Mvvm
{
    public class Command : ICommand
    {
        private readonly Action action;

        public Command(Action action)
        {
            this.action = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public virtual void Execute(object parameter)
        {
            action();
            Executed?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler CanExecuteChanged;
        public event EventHandler Executed;
    }
}
