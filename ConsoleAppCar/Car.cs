using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDealership
{
    public enum Fashion
    {
            Ugly,
            Subpar,
            Average,
            Beautiful,
            Extravagant
    }
    public enum Condition
    {
        Broken,
        NeedsRepair,
        Used,
        New

    }
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public Fashion Fashion { get; set; }
        public Condition Condition { get; set; }
        
        public int ID { get; set; }
        public string Year { get; set; }
        public int Mileage { get; set; }

        public string Owner { get; set; } = "No one";
        public bool Sold { get; set; } = false;


        public Car(string make, string model, string color, Fashion fashion,Condition condition)
        {
            Make = make;
            Model = model;
            Color = color;
            Fashion = fashion;
            Condition = condition;
        }

        public void Sell(Customer customer)
        {
            if (this.Sold) { Console.WriteLine("This car has already been sold to {0}! Sorry",this.Owner); }
            else { this.Sold = true; this.Owner = customer.FirstName + " " + customer.LastName; Console.WriteLine("Successfuly sold to {0}",this.Owner); }
        }
    }
}
