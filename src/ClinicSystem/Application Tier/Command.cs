using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Application_Tier
{
    /*
     *  This interface defines the abstract methods used in the classes for the Command Pattern.
     */
    interface Command
    {
        //Executes the specified command
        void execute();

        // Unexecutes the specified command
        void unexecute();
    }
}
