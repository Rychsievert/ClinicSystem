using System;
using Clinic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClinicSystemUnitTests
{
   [TestClass]
   public class AppointmentTest
   {
      [TestMethod]
      public void TestGetPatientID()
      {
         Appointment appt = new Appointment(1, 2, 3, "2021-04-09 03:14:00");
         Assert.AreEqual(1, appt.getPatientID());
      }

      [TestMethod]
      public void TestGetEmployeeID()
      {
         Appointment appt = new Appointment(1, 2, 3, "2021-04-09 03:14:00");
         Assert.AreEqual(2, appt.getEmployeeID());
      }

      [TestMethod]
      public void TestGetIllnessID()
      {
         Appointment appt = new Appointment(1, 2, 3, "2021-04-09 03:14:00");
         Assert.AreEqual(3, appt.getIllnessID());
      }

      [TestMethod]
      public void TestGetDate()
      {
         Appointment appt = new Appointment(1, 2, 3, "2021-04-09 03:14:00");
         Assert.AreEqual("2021-04-09 03:14:00", appt.getDate());
      }

      [TestMethod]
      public void TestEquals()
      {
         Appointment appt = new Appointment(1, 2, 3, "2021-04-09 03:14:00");
         String input = "test";
         Assert.AreNotEqual(appt, appt.Equals(input));
         Appointment appt2 = appt;
         Assert.IsTrue(appt.Equals(appt2));
      }
   }
}
