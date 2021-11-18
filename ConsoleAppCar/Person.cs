using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDealership
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }

        // Default constructor. If a derived class does not invoke a base-
        // class constructor explicitly, the default constructor is called
        // implicitly.
        public Person()
        {
            FirstName = "Default";
            LastName = "Default";
        }
        public Person(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }

    }
}
