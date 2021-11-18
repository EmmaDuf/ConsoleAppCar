using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDealership
{
    public class Customer : Person
    {
        public int persuadability { get; set; }
        public Customer(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }

        public void BePersuaded(int value)
        {
            Console.WriteLine("{0} {1} was persuaded by {2} amicability",this.FirstName,this.LastName, value);
            persuadability += value;
        }
    }
}
