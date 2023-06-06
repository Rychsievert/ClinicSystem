using System;
using Clinic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClinicSystemUnitTests
{
    [TestClass]
    public class DatabaseTests
    {
        DBmanager dbm = new DBmanager();
        Clinic.ClinicSystem clinicSystem = Clinic.ClinicSystem.getInstance();

        [TestMethod]
        public void TestCorrectAppointmentAdd() //Test whether a good appointment gets added to the database
        {
            Appointment apt = new Appointment(2, 1, 3, "2021-04-09 03:14:00");

            dbm.AddAppointment(apt);

            int aptID = dbm.getAppointmentID(apt);

            Assert.IsTrue(aptID != -1); //Looking for a specific id doesn't work well since the appointment IDs are auto incremented.
                                        //Instead, if the appointment isn't found or isn't in the DB, a -1 is returned.
        }

        [TestMethod]
        public void TestBadAppointmentAdd() //Test to make sure an impossible appointment doesn't get added to the database.
        {
            Appointment apt = new Appointment(10, 1, 3, "2021-04-09 03:14:00"); //This patient ID does not exist.

            dbm.AddAppointment(apt);

            int aptID = dbm.getAppointmentID(apt);

            Assert.IsTrue(aptID == -1);
        }

        [TestMethod]
        public void TestAddAppointmentWithID()
        {
            Appointment appt = new Appointment(2, 1, 5, "2021-04-09 09:14:00");
            dbm.AddAppointmentWithID(appt, 99);

            Appointment checkAppt = dbm.getAppointmentFromID(99);

            Assert.AreEqual(appt, checkAppt);

            dbm.deleteAppointment(appt);
        }

        [TestMethod]
        public void TestGoodUsernameExists() //Test to make sure an existing username is found
        {
            Assert.IsTrue(dbm.checkUsernameExists("cherryryan")); // cherryryan is the username of one of the base accounts
        }

        [TestMethod]
        public void TestBadUsernameExists() //Test to make sure a non-existing username is reported as such
        {
            Assert.IsTrue(!dbm.checkUsernameExists("fakeusername")); // this username does not exist in the database
        }

        [TestMethod]
        public void TestGoodPersonAdd() //Make sure a new user gets added to the database
        {
            Person testPerson = new Person("Test", "Person", 99, "persontest", "password", "notarealemail@email.com", false);
            dbm.AddPerson(testPerson);

            Assert.IsTrue(dbm.checkUsernameExists(testPerson.getUsername())); // If the person was added there username will exist in the database.
        }

        [TestMethod]
        public void TestDeletePerson() // Test if a user is actually deleted from the database
        {
            dbm.DeleteAccount("persontest"); // For ease of use now and in the future we'll be deleting the person that was just added in the previous test

            Assert.IsTrue(!dbm.checkUsernameExists("persontest"));
        }

        [TestMethod]
        public void TestDeleteAppointment() //Test to make sure an appointment is actually deleted from the database
        {
            Appointment apt = new Appointment(2, 1, 3, "2021-04-09 05:17:00"); //For ease of use now and later, we'll use the same appointment
                                                                               //details of the appointment that was added in a previous test.
            dbm.AddAppointment(apt);
            dbm.deleteAppointment(apt);

            Assert.AreEqual(-1, dbm.getAppointmentID(apt));                    //Since the appointment no longer exists an AppointmentID of -1 is returned.
        }

        [TestMethod]
        public void TestGoodPasswordRecover1() //Test the password recovery when passing an existing username
        {
            Assert.AreEqual(dbm.recoverPassword(1, "cherryryan"), "cherrypass"); // The password for existing account with username cherryryan
                                                                                 // is cherrypass
        }

        [TestMethod]
        public void TestGoodPasswordRecover2() //Test the password recovery when passing an existing email
        {
            Assert.AreEqual(dbm.recoverPassword(2, "cherryry@uwplatt.edu"), "cherrypass"); // The password for existing account with email cherry@uwplatt.edu
                                                                                           // is cherrypass
        }

        [TestMethod]
        public void TestBadPasswordRecover1() //Test the password recovery when passing a non-existing username
        {
            Assert.AreEqual(dbm.recoverPassword(1, "thisusernamedoesnotexist"), "");  // the password return for credentials that don't exist is a blank string
        }

        [TestMethod]
        public void TestBadPasswordRecover2() //Test the password recovery when passing a non-existing email
        {
            Assert.AreEqual(dbm.recoverPassword(1, "thisemaildoesnotexist"), "");  // the password return for credentials that don't exist is a blank string
        }

        [TestMethod]
        public void TestEmailDoesExist() // Test for when an email DOES exist in the database.
        {
            int result = dbm.checkEmailExists("cherryry@uwplatt.edu"); //An email associated with one of the base accounts in the database
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void TestEmailDoesNotExist() // Test for when an email DOES NOT exist in the database.
        {
            int result = dbm.checkEmailExists("notarealemail@email.com"); //An email that is not paired with an account in the database
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void TestPatientID()
        {
            // Test for when the username exists in the database
            int expectedID = 2; // The id in the database associated with Ryan Cherry (username = cherryryan)
            int actualID = dbm.getID("cherryryan");
            Assert.AreEqual(expectedID, actualID);

            // Test for when the username does not exist in the database
            expectedID = -1; // The id in the database associated with Ryan Cherry (username = cherryryan)
            actualID = dbm.getID("thisusernamedoesnotexist");
            Assert.AreEqual(expectedID, actualID);
        }

        [TestMethod]
        public void TestGetAppointmentFromID()
        {
            // Create an appointment and add it to the database
            Appointment origAppt = new Appointment(2, 1, 3, "2021-04-09 05:00:00");
            dbm.AddAppointment(origAppt);

            // Make a new appointment using the getAppointmentFromID method
            int apptID = dbm.getAppointmentID(origAppt);
            Appointment apptCheck = dbm.getAppointmentFromID(apptID);

            // Test if they're the same
            Assert.AreEqual(origAppt, apptCheck);

            //get rid of the appointments in the database
            dbm.deleteAppointment(origAppt);
            dbm.deleteAppointment(apptCheck);
        }

        [TestMethod]
        public void TestGetOptOutEmail()
        {
            // The default value for users' opting out of email is false (0)
            Assert.AreEqual(0, dbm.getOptOutEmail(2));
        }

    }
}
