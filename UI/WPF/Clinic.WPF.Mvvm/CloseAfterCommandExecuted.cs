using System.Windows;
using System.Windows.Interactivity;

namespace Clinic.WPF.Mvvm
{
    public class CloseAfterCommandExecuted : Behavior<Window>
    {
        public static DependencyProperty CommandProperty = DependencyProperty.Register(
            "Command", typeof(Command), typeof(CloseAfterCommandExecuted));

        public Command Command
        {
            get { return (Command)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        protected override void OnAttached()
        {
            base.OnAttached();
            Command.Executed += OnCommandExecuted;
        }

        private void OnCommandExecuted(object sender, System.EventArgs e)
        {
            AssociatedObject.Close();
        }
    }
}
