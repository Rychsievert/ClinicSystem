using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Application_Tier
{
    // A concrete implementation of the Command interface. Used to insert an appointment into the database
    // with the ability to undo and redo this action.
    class InsertAppointment : Command
    {
        private DBmanager dbm;
        private Appointment appointment;
        private int appointmentID;

        public InsertAppointment (Appointment apt)
        {
            dbm = new DBmanager();
            appointment = apt;
            appointmentID = -1;
        }

        // The method to execute the InsertAppointment command. Inserts an appointment into the database
        // based on the Appointment object passed to it.
        public void execute()
        {
            // if the appointment id is -1 (has not been specified) allow the database's auto-increment to determine the appointment id
            if (appointmentID == -1)
                dbm.AddAppointment(appointment);
            // if the appointment id has been specified that means that the unexecute method was called and this method is 
            // redoing the insertion of the appointment. In this case use the appointment id so that it is the same as before.
            else
                dbm.AddAppointmentWithID(appointment, appointmentID);
        }

        // The method to unexecute the InsertAppointment command. Removes an appointment from the database
        // based on the Appointment object passed to it. Keeps track of the appointment id in case the appointment is restored later.
        public void unexecute()
        {
            appointmentID = dbm.getAppointmentID(appointment);
            dbm.deleteAppointment(appointment);
        }
    }
}
