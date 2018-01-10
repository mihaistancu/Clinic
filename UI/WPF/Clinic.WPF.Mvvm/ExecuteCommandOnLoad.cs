using System.Windows;
using System.Windows.Interactivity;

namespace Clinic.WPF.Mvvm
{
    public class ExecuteCommandOnLoad: Behavior<Window>
    {
        public static DependencyProperty CommandProperty = DependencyProperty.Register(
            "Command", typeof(Command), typeof(ExecuteCommandOnLoad));

        public Command Command
        {
            get { return (Command)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            if (Command.CanExecute(e))
            {
                Command.Execute(e);
            }
        }
    }
}
