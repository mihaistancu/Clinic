using Clinic.Core.Infrastructure;

namespace Clinic.Console
{
    public class OfficesModule : Module<Office>
    {
        protected override void Add(string[] args)
        {
            Repository.Add(new Office { Location = args[2] });
        }

        protected override void List()
        {
            foreach(var office in Repository.GetAll())
            {
                System.Console.WriteLine(office.Location);
            }
        }
    }
}
