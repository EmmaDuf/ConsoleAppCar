using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDealership
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car truck = new Car("Truck", "Ford", "Green",Fashion.Average, Condition.New);
            Salesperson jerrythesalesguy = new Salesperson("Jerry", "Salesguy", "CEO");
            Customer fordlover3000 = new Customer("Theo", "Fitzgerald");
            jerrythesalesguy.PersuadeCustomer(fordlover3000, 10);
            jerrythesalesguy.SellCar(truck,fordlover3000);
            Customer anotherfordlover = new Customer("Mr.", "Ford");
            jerrythesalesguy.SellCar(truck, anotherfordlover);

            Console.ReadLine();
        }
    }
}
