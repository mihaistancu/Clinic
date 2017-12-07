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
            var doctor = new Doctor {Name = "Doctor"};
            var office = new Office {Location = "Office1"};
            var visit1 = Visit(doctor, office, Time(9, 0), Time(10, 0));
            var visit2 = Visit(doctor, office, Time(12, 0), Time(13, 0));
            var visit3 = Visit(doctor, office, Time(13, 0), Time(14, 0));
            var visit4 = Visit(doctor, office, Time(17, 0), Time(18, 0));

            var medicalRecordsBoook = new MedicalRecordsBook();
            medicalRecordsBoook.Add(visit1);
            medicalRecordsBoook.Add(visit2);
            medicalRecordsBoook.Add(visit3);
            medicalRecordsBoook.Add(visit4);

            var visits = medicalRecordsBoook.SearchBy(office, 
                new DateTime(2010, 1, 1, 11, 0, 0),
                new DateTime(2010, 1, 1, 15, 0, 0));

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

            var medicalRecordsBoook = new MedicalRecordsBook();
            medicalRecordsBoook.Add(visit1);
            medicalRecordsBoook.Add(visit2);
            medicalRecordsBoook.Add(visit3);

            var visits = medicalRecordsBoook.SearchBy(office2,
                new DateTime(2010, 1, 1, 10, 0, 0),
                new DateTime(2010, 1, 1, 15, 0, 0));

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

            var medicalRecordsBoook = new MedicalRecordsBook();
            medicalRecordsBoook.Add(visit1);
            medicalRecordsBoook.Add(visit2);
            medicalRecordsBoook.Add(visit3);

            var visits = medicalRecordsBoook.SearchBy(doctor2,
                new DateTime(2010, 1, 1, 10, 0, 0),
                new DateTime(2010, 1, 1, 15, 0, 0));

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
        
        private DateTime Time(int hour, int minute)
        {
            return new DateTime(2010, 1, 1, hour, minute, 0);
        }
    }
}
