using System;
using Clinic.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Clinic.Tests
{
    [TestClass]
    public class SearchTests
    {
        private MedicalRecordsBook medicalRecordsBook;

        [TestInitialize]
        public void Setup()
        {
            medicalRecordsBook = new MedicalRecordsBook();
        }

        [TestMethod]
        public void SearchByTimeInterval()
        {
            var doctor = new Doctor {Name = "Doctor"};
            var office = new Office {Location = "Office1"};
            var visit1 = Visit(doctor, office, Time(9, 0), Time(10, 0));
            var visit2 = Visit(doctor, office, Time(12, 0), Time(13, 0));
            var visit3 = Visit(doctor, office, Time(13, 0), Time(14, 0));
            var visit4 = Visit(doctor, office, Time(17, 0), Time(18, 0));

            Record(visit1, visit2, visit3, visit4);

            var visits = medicalRecordsBook.Search(Filter.ByTimeframe(Time(11, 0), Time(15, 0)));

            CollectionAssert.AreEquivalent(new [] {visit2, visit3}, visits);
        }

        [TestMethod]
        public void SearchByOffice()
        {
            var doctor = new Doctor { Name = "Doctor" };
            var office1 = new Office { Location = "Office1" };
            var office2 = new Office { Location = "Office2" };

            var visit1 = Visit(doctor, office1, Time(12, 0), Time(13, 0));
            var visit2 = Visit(doctor, office2, Time(12, 0), Time(13, 0));
            var visit3 = Visit(doctor, office2, Time(13, 0), Time(14, 0));

            Record(visit1, visit2, visit3);

            var visits = medicalRecordsBook.Search(Filter.ByOffice(office2));

            CollectionAssert.AreEquivalent(new[] { visit2, visit3 }, visits);
        }

        [TestMethod]
        public void SearchByDoctor()
        {
            var doctor1 = new Doctor { Name = "Doctor1" };
            var doctor2 = new Doctor { Name = "Doctor2" };
            var office = new Office{ Location = "Location" };

            var visit1 = Visit(doctor1, office, Time(12, 0), Time(13, 0));
            var visit2 = Visit(doctor2, office, Time(12, 0), Time(13, 0));
            var visit3 = Visit(doctor2, office, Time(13, 0), Time(14, 0));
            
            Record(visit1, visit2, visit3);

            var visits = medicalRecordsBook.Search(Filter.ByDoctor(doctor2));

            CollectionAssert.AreEquivalent(new[] { visit2, visit3 }, visits);
        }

        private ClinicalVisit Visit(Doctor doctor, Office office, DateTime startDateTime, DateTime endDateTime)
        {
            return new ClinicalVisit
            {
                Patient = new Patient { Name = "Patient" },
                Doctor = doctor,
                Office = office,
                StartDateTime = startDateTime,
                EndDateTime = endDateTime
            };
        }

        private void Record(params ClinicalVisit[] visits)
        {
            foreach (var visit in visits)
            {
                medicalRecordsBook.Add(visit);
            }
        }
        
        private DateTime Time(int hour, int minute)
        {
            return new DateTime(2010, 1, 1, hour, minute, 0);
        }
    }
}
