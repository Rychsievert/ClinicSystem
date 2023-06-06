using System;
using System.Collections.Generic;
using System.Text;

namespace Clinic
{
    /*
     *  This class is a Singleton. This is because we only want to keep track of a single user at a time, whoever has logged in. 
     *  When a user is logged in the patient or employee is set accordingly
     */
    public class ClinicSystem
    {
        private Patient patient;
        private Employee employee;
        private static ClinicSystem instance = null;
        private ClinicSystem() { }

        // If the single instance of ClinicSystem has already been instantiated, return it.
        // Otherwise, instantiate the instance and return it.
        public static ClinicSystem getInstance()
        {
            if (instance == null)
                instance = new ClinicSystem();

            return instance;
        }

        // Sets the respective patients username and id
        public void SetPatient(string username, int id)
        {
            patient = new Patient(username, id);
        }

        // Returns this patient object
        public Patient GetPatient()
        {
            return this.patient;
        }

        // Sets the respective employees username and id
        public void SetEmployee(string username, int id)
        {
            employee = new Employee(username, id);
        }

        //-------------------------------------------------------
        // DO WE NEED THIS? WE HAVE NO REFERENCES TO IT
        //-------------------------------------------------------
        public Employee GetEmployee()
        {
            return this.employee;
        }

    }
}
