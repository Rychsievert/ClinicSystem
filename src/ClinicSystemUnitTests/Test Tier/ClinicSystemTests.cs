using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clinic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Tests
{
    [TestClass()]
    public class ClinicSystemTests
    {
        ClinicSystem clinic = ClinicSystem.getInstance();

        Patient patient = new Patient("testPat", 5);
        Employee employee = new Employee("testEmp", 1);

        [TestMethod()]
        public void getInstanceTest()
        {
            Assert.That.Equals(clinic); // Cannot be anything else due to clinic being a singleton
        }

        public void setPatientTest()
        {
            Assert.IsNotNull(patient);
            Assert.AreEqual("testPat", patient.getUsername());
            Assert.AreEqual(5, patient.getID());
        }

        public void getPatientTest()
        {
            Assert.IsNotNull(patient);
            Assert.AreEqual(patient, clinic.GetPatient());
        }

        public void setEmployeeTest()
        {
            Assert.IsNotNull(employee);
            Assert.AreEqual("testEmp", employee.getUsername());
            Assert.AreEqual(1, employee.getID());
        }

        public void getEmployeeTest()
        {
            Assert.IsNotNull(employee);
            Assert.AreEqual(employee, clinic.GetEmployee());
        }
    }
}