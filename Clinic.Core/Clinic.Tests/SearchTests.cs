using System;
using Clinic.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Clinic.Tests
{
    [TestClass]
    public class SearchTests
    {
        [TestMethod]
        public void SearchByTimeInterval()
        {
            var office = new Office {Location = "Office1"};
            var visit1 = new ClinicalVisit
            {
                Patient = new Patient {Name = "Patient1"},
                Office = office,
                StartDateTime = new DateTime(2010, 1, 1, 12, 0, 0),
                EndDateTime = new DateTime(2010, 1, 1, 13, 0, 0)
            };
            var visit2 = new ClinicalVisit
            {
                Patient = new Patient { Name = "Patient2" },
                Office = office,
                StartDateTime = new DateTime(2010, 1, 1, 13, 0, 0),
                EndDateTime = new DateTime(2010, 1, 1, 14, 0, 0)
            };
            var visit3 = new ClinicalVisit
            {
                Patient = new Patient {Name = "Patient3"},
                Office = office,
                StartDateTime = new DateTime(2010, 1, 1, 17, 0, 0),
                EndDateTime = new DateTime(2010, 1, 1, 18, 0, 0)
            };
            var medicalRecordsBoook = new MedicalRecordsBook();
            medicalRecordsBoook.Add(visit1);
            medicalRecordsBoook.Add(visit2);
            medicalRecordsBoook.Add(visit3);

            var visits = medicalRecordsBoook.SearchBy(office, 
                new DateTime(2010, 1, 1, 10, 0, 0),
                new DateTime(2010, 1, 1, 15, 0, 0));

            CollectionAssert.AreEquivalent(new [] {visit1, visit2}, visits);
        }
    }
}
