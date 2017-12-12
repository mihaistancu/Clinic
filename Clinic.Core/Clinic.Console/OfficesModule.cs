using Clinic.Core.Infrastructure;
using Clinic.DataAccess;
using System.Collections.Generic;

namespace Clinic.Console
{
    public class OfficesModule
    {
        public void Execute(string[] args)
        {
            var officeRepository = new Repository<Office>();

            if (args[1] == "add")
            {
                string officeLocation = args[2];

                officeRepository.Add(new Office { Location = officeLocation });

                return;
            }

            if (args[1] == "list")
            {
                List<Office> offices = officeRepository.GetAll();

                offices.ForEach(d => System.Console.WriteLine(d.Location));

                return;
            }
        }
    }
}
