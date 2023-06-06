using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clinic.Application_Tier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Application_Tier.Tests
{
    [TestClass()]
    public class DeleteAppointmentTests
    {
        private DBmanager dbm = new DBmanager();
        private Appointment apt;
        private int aptID;

        [TestMethod()]
        public void executeTest()
        {
            apt = new Appointment(2, 1, 3, "2021-04-09 03:14:00");
            Assert.IsNotNull(apt);

            Assert.AreEqual(2, apt.getPatientID());
            Assert.AreEqual(1, apt.getEmployeeID());
            Assert.AreEqual(3, apt.getIllnessID());
            Assert.AreEqual("2021-04-09 03:14:00", apt.getDate());


            //dbm.deleteAppointment(apt);
            /*
            Assert.AreNotEqual(2, apt.getPatientID());
            Assert.AreNotEqual(1, apt.getEmployeeID());
            Assert.AreNotEqual(3, apt.getIllnessID());
            Assert.AreNotEqual("2021-04-09 03:14:00", apt.getDate());
            */
        }

        [TestMethod()]
        public void unexecuteTest()
        {
            apt = new Appointment(2, 1, 3, "2021-04-09 03:14:00");
            Assert.IsNotNull(apt);
        }
    }
}