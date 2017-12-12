using Clinic.Core.Infrastructure;

namespace Clinic.Console
{
    public class OfficesModule : Module<Office>
    {
        protected override Office Create(string[] args)
        {
            return new Office { Location = args[2] };
        }

        protected override void Display(Office item)
        {
            System.Console.WriteLine(item.Location);
        }
    }
}
