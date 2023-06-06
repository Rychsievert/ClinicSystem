using System;
using Clinic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;

namespace ClinicSystemUnitTests
{
    [TestClass]
    public class TestLogin
    {
        DBmanager dbmanager = new DBmanager();

        private const int PatientExpected = 0;
        private const int EmployeeExpected = 1;
        [TestMethod]
        public void TestIsPatient()
        {
            string username = "cherryryan";
            string password = "cherrypass";
            int result = dbmanager.LoginUser(username, password);

            Assert.AreEqual(PatientExpected, result);
        }

        [TestMethod]
        public void TestIsEmployee()
        {
            string username = "testemployee";
            string password = "password";
            int result = dbmanager.LoginUser(username, password);

            Assert.AreEqual(EmployeeExpected, result);
        }
    }

    [TestClass]
    public class TestSetUser
    {
        DBmanager dbmanager = new DBmanager();
        Clinic.ClinicSystem clinicSystem = Clinic.ClinicSystem.getInstance();

        
        [TestMethod]
        public void TestSetPatient()
        {
            string username = "cherryryan";

            clinicSystem.SetPatient(username, dbmanager.getID(username));
            string result = clinicSystem.GetPatient().getUsername();

            Assert.AreEqual(username, result);
        }

        [TestMethod]
        public void TestSetEmployee()
        {
            string username = "testemployee";

            clinicSystem.SetEmployee(username, dbmanager.getID(username));
            string result = clinicSystem.GetEmployee().getUsername();

            Assert.AreEqual(username, result);
        }
    }
}
