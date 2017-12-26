using System;
using Clinic.Core.OfficeHours;
using Clinic.DataAccess;

namespace Clinic.Console
{
    public class OfficeHoursModule : Module
    {
        Repository<WeeklyOfficeHours> repository;

        public OfficeHoursModule(Repository<WeeklyOfficeHours> repository)
        {
            this.repository = repository;
        }

        protected override void Add(string[] args)
        {
            throw new NotImplementedException();
        }

        protected override void List()
        {
            throw new NotImplementedException();
        }
    }
}
