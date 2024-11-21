using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demotask
{
    class Student
    {
        private string firstname;

        // Property for FirstName
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }

        // Getter method (redundant if using properties)
        public string getFirstName()
        {
            return firstname;
        }

        // Setter method (redundant if using properties)
        public void setFirstName(string firstname)
        {
            this.firstname = firstname;
        }
    }

    internal class PropertyDemo
    {
        static void Main()
        {
            Student obj = new Student();

            // Using the property
            obj.FirstName = "ADITYA";

            // Using the setter method
            obj.setFirstName("Aditya Raj");

            // Printing the value using the getter method
            Console.WriteLine(obj.getFirstName());

            // Printing the value using the property
            Console.WriteLine(obj.FirstName);
        }
    }
}
