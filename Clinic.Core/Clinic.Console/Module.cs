namespace Clinic.Console
{
    public abstract class Module
    {
        protected abstract void Add(string[] args);

        protected abstract void List();

        public void Execute(string[] args)
        {
            switch (args[1])
            {
                case "add": Add(args); break;
                case "list": List(); break;
            }
        }
    }
}
