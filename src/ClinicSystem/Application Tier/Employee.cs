using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class Employee : Person
    {

        // Paramaterized constructor
        public Employee(string username, int id)
        {
            this.setUsername(username);
            this.setID(id);
        }
    }
}
