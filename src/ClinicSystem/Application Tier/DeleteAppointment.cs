using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Application_Tier
{
    // A concrete implementation of the Command interface. Used to Delete an appointment from the database
    // with the ability to undo and redo this action.
    public class DeleteAppointment : Command
    {
        private DBmanager dbm;
        private Appointment appointment;
        private int appointmentID;

        // Parametrized constructor
        public DeleteAppointment(Appointment apt)
        {
            dbm = new DBmanager();
            appointment = apt;
            appointmentID = dbm.getAppointmentID(appointment);
        }

        // The method to execute the DeleteAppoint command. Removes an appointment from the database
        // based on the Appointment object passed to it.
        public void execute()
        {
            dbm.deleteAppointment(appointment);
        }

        // The method to unexecute the DeleteAppoint command. Adds an appointment to the database
        // based on the Appointment object passed to it. Restores all information including appointment id.
        public void unexecute()
        {
            dbm.AddAppointmentWithID(appointment, appointmentID);
        }
    }
}
