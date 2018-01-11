namespace Clinic.WPF.Mvvm
{
    public class ShowCommand<T> :Command 
    {
        public ShowCommand() : base(OpenView)
        {
        }

        private static void OpenView()
        {
            View.For<T>().ShowDialog();
        }
    }
}
