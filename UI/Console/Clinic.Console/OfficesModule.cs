﻿using Clinic.Data;
using Clinic.Data.Persistence.EF;

namespace Clinic.Console
{
    public class OfficesModule : Module
    {
        readonly Repository<Office> repository;

        public OfficesModule(Repository<Office> repository)
        {
            this.repository = repository;
        }

        protected override void Add(string[] args)
        {
            repository.Add(new Office { Location = args[2] });
        }

        protected override void List()
        {
            foreach(var office in repository.GetAll())
            {
                System.Console.WriteLine(office.Location);
            }
        }
    }
}
