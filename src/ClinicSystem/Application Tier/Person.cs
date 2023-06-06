using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class Person // parent class to Employee
    {
        private string fName;
        private string lName;
        private int age;
        private string username;
        private string password;
        private string email;
        private int id;
        private Boolean isEmployee;

        // Default constructor for the Person class
        public Person()
        {
            fName = "John";
            lName = "Doe";
            age = 21;
            username = "username";
            password = "password";
            email = "se3330nullpointerexception@gmail.com";
            id = 25742;
            isEmployee = false;
        }

        // Parameterized constructor for the Person class excluding id
        public Person(string fName, string lName, int age, string username, string password, string email, Boolean isEmployee)
        {
            this.fName = fName;
            this.lName = lName;
            this.age = age;
            this.username = username;
            this.password = password;
            this.email = email;
            this.isEmployee = isEmployee;
        }

        // Parameterized constructor for the Person class
        public Person(string fName, string lName, int age, string username, string password, string email, int id, Boolean isEmployee)
        {
            this.fName = fName;
            this.lName = lName;
            this.age = age;
            this.username = username;
            this.password = password;
            this.email = email;
            this.id = id;
            this.isEmployee = isEmployee;
        }

        // Returns the username
        public string getUsername()
        {
            return this.username;
        }

        // Sets the value of username to the argument
        public void setUsername(string newUsername)
        {
            this.username = newUsername;
        }

        // Returns isEmployee
        public Boolean getIsEmployee()
        {
            return this.isEmployee;
        }

        // Sets the value of ID to the argument
        public void setID(int newId)
        {
            this.id = newId;
        }

        // Returns the ID
        public int getID()
        {
            return this.id;
        }

        // Returns the fName
        public string getFName()
        {
            return this.fName;
        }

        // Returns the lName
        public string getLName()
        {
            return this.lName;
        }

        // Returns the age
        public int getAge()
        {
            return this.age;
        }

        // Returns the email
        public string getEmail()
        {
            return this.email;
        }

        // Returns the password
        public string getPassword()
        {
            return this.password;
        }
    }
}
