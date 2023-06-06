using System;
using Clinic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClinicSystemUnitTests
{
    [TestClass]
    public class EmailTest
    {
        EmailManager em = new EmailManager();

        [TestMethod]
        public void TestSendMail()
        {
            int result = em.sendMail("se3330nullpointerexception@gmail.com", "Test", "This email was sent by the TestMethod TestSendMail"
               + " from the test class EmailTest");

            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void TestSendBadMail() // Test to make sure an email of improper form is caught
        {
            int result = em.sendMail("bademail", "Test", "This email was sent by the TestMethod TestSendMail"
               + " from the test class EmailTest");

            Assert.AreEqual(result, -1);
        }

        [TestMethod]
        public void TestEmailAccountCreation()
        {
            em.emailAccountCreation("se3330nullpointerexception@gmail.com");
        }

        [TestMethod]
        public void TestSendReminders()
        {
            em.sendReminders();
        }

        [TestMethod]
        public void TestSendPasswordChoice1()
        {
            string username = "testemployee";
            em.sendPassword(1, username);
        }

        [TestMethod]
        public void TestSendPasswordChoice2()
        {
            string email = "se3330nullpointerexception@gmail.com";
            em.sendPassword(0, email);
        }
    }
}
