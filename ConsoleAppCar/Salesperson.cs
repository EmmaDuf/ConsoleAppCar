using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDealership
{
    public class Salesperson : Person
    {
        public string Position { get; set; }
        public Salesperson(string firstname, string lastname, string position)
        {
            FirstName = firstname;  
            LastName = lastname;
            Position = position;
        }

        public void PersuadeCustomer(Customer customer, int amicability)
        {
            Console.WriteLine("{0} {1} is attempting to persuade {2} {3}", this.FirstName, this.LastName, customer.FirstName, customer.LastName);
            customer.BePersuaded(amicability);
        }

        public void SellCar(Car car, Customer customer)
        {
            car.Sell(customer);
        }
    }
}
