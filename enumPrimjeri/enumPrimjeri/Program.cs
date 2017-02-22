using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumPrimjeri
{
    class Customer
    {
        public string Name { get; set;}
        public int Gander { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[3];
            customers[0] = new Customer()
            {
                Name = "Sandro",
                Gander = 1
            };
            customers[1] = new Customer()
            {
                Name = "Jelena",
                Gander = 2
            };
            customers[2] = new Customer()
            {
                Name = "Saša",
                Gander = 0
            };

            foreach(Customer customer in customers)
            {
                Console.WriteLine("Name = {0} && Gender = {1}", customer.Name, GetGander(customer.Gander));
            }
        }
        public static string GetGander(int gender)
        {
            switch (gender)
            {
                case 0:
                    return "Unknown";
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "Invalid expresion";
            }
        }
    }
}
