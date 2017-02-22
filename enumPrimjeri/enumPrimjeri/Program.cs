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
        public Gender Gander { get; set; }
    }
    public enum Gender
    {
        Unknown = 0,
        Male = 1,
        Female = 2
    }
    public enum Season
    {
        Winter = 1,
        Spring = 2,
        Summer = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
           Customer[] customers = new Customer[3];
            customers[0] = new Customer()
            {
                Name = "Sandro",
                Gander = Gender.Male
            };
            customers[1] = new Customer()
            {
                Name = "Jelena",
                Gander = Gender.Female
            };
            customers[2] = new Customer()
            {
                Name = "Saša",
                Gander = Gender.Unknown
            };
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Name = {0} && Gender = {1}", customer.Name, GetGander(customer.Gander));
            }

          int[] Values =(int[])Enum.GetValues(typeof(Season));
            Console.WriteLine("Season Enum Values");

            foreach(int value in Values)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();
            string[] Names = Enum.GetNames(typeof(Season));
            Console.WriteLine("Season Enum Names");
            foreach (string Name in Names)
            {
                Console.WriteLine(Name);
            }
        }
        public static string GetGander(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unknown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid expresion";
            }
        }
    }
}
