using System;
using Clinic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClinicSystemUnitTests
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void TestGetUsername()
        {
            Person p = new Person();
            Assert.AreEqual("username",p.getUsername(),false);
        }

        [TestMethod]
        public void TestSetUsername()
        {
            Person p = new Person();
            p.setUsername("newUsername");
            Assert.AreEqual("newUsername",p.getUsername(),false);
        }

        [TestMethod]
        public void TestGetIsEmployee()
        {
            Person p = new Person();
            Assert.IsFalse(p.getIsEmployee());
        }

        [TestMethod]
        public void TestGetID()
        {
            Person p = new Person();
            Assert.AreEqual(25742, p.getID());
        }

        [TestMethod]
        public void TestSetID()
        {
            Person p = new Person();
            p.setID(256622);
            Assert.AreEqual(256622, p.getID());
        }

        [TestMethod]
        public void TestGetFName()
        {
            Person p = new Person();
            Assert.AreEqual("John",p.getFName(),false);
        }

        [TestMethod]
        public void TestGetLName()
        {
            Person p = new Person();
            Assert.AreEqual("Doe",p.getLName(),false);
        }

        [TestMethod]
        public void TestGetAge()
        {
            Person p = new Person();
            Assert.AreEqual(21, p.getAge());
        }

        [TestMethod]
        public void TestGetEmail()
        {
            Person p = new Person();
            Assert.AreEqual("se3330nullpointerexception@gmail.com", p.getEmail(),false);
        }

        [TestMethod]
        public void TestGetPassword()
        {
            Person p = new Person();
            Assert.AreEqual("password",p.getPassword(),false);
        }
    }
}
