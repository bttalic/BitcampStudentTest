using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_24_07
{
    class Program
    {

        public static void PrintItems(PawnShop shop)
        {
            foreach (InventoryItem i in shop.InItems)
            {
                Console.WriteLine(i);
            }
        }

        //public static void PrintEmployees(PawnShop emp)
        //{
        //    foreach (Employee e in emp.Employees)
        //    {
        //        Console.WriteLine(e);
        //    }
        //}

        static void Search(PawnShop p, string s)
        {
            List<ISearchable> find = p.Find(s);
            foreach (ISearchable i in find)
            {
                Console.WriteLine(i);
            }
        }


        static void Main(string[] args)
        {


            PawnShop p = new PawnShop();
            Vehicles v = new Vehicles("Car", "description", 8000, "Limusine", 2013, "Renault", (Vehicles.Condition)1);
            Clocks c = new Clocks("Pockett clock", "description", 300, "Swatch", 6, (Clocks.Material)1);
            Employee e = new Employee("John", "Doe", 3000);
            Experts x = new Experts("Joe", "Black", 6000, "Management");
            p.AddItems(v);
            p.AddItems(c);
            //p.AddEmployee(e);
            //p.AddEmployee(x);

            PrintItems(p);


        }
    }
}
