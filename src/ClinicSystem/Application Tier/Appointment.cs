using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    // The appointment class creates new appoints and gets those appointments 
    // parameters.
    public class Appointment
    {
        private string apptTime;  // The date and time of the appointment.
        private int patientID;    // The person id corresponding to the patient within the database
        private int employeeID;   // The person id corresponding to the employee within the database
        private int illnessID;    // The id corresponding to the symptom in the database

        // parametrized constructor
        public Appointment(int patient_id, int employee_id, int illness_id, string dateTime)
        {
            this.patientID = patient_id;
            this.employeeID = employee_id;
            this.illnessID = illness_id;
            this.apptTime = dateTime;
        }

        // Returns the respective patients ID
        public int getPatientID() 
        {
            return this.patientID; 
        }

        // Returns the respective employees ID
        public int getEmployeeID()
        {
            return this.employeeID;
        }

        // Returns the respective illness ID
        public int getIllnessID()
        {
            return this.illnessID;
        }

        // Returns the appointment time as a string, not a DateTime.
        public string getDate()
        {
            return this.apptTime;
        }

        // Compares two Appointment objects and returns true if all their values are the same.
        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Appointment appt = (Appointment) obj;
                return (patientID == appt.patientID) && (employeeID == appt.employeeID) && (illnessID == appt.illnessID) && (apptTime == appt.apptTime);
            }
        }
    }
}
