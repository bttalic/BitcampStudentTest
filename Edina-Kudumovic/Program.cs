using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest
{
    class Program
    {
        /// <summary>
        /// Method prints inventory
        /// </summary>
        /// <param name="ps"></param>
        public static void PrintInventory(PawnShop ps)
        {
            foreach (Inventory i in ps.Inventories)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }


        /// <summary>
        /// Method performs search PawnShop
        /// </summary>
        /// <param name="ps"></param>
        /// <param name="s"></param>
        static void PrintSearch(PawnShop ps, string s)
        {
            List<ISearchable> res = ps.Find(s);
            foreach (ISearchable r in res)
            {
                Console.WriteLine(r);
            }
        }

        static void Main(string[] args)
        {
            PawnShop ps = new PawnShop();

            Vehicle v = new Vehicle("Vehicle1", "Description1", 10000.5, "Type1", 2014, "Manufacturer1", Vehicle.Condition.Perfectly);
            Watch w = new Watch("Watch1", "Description2", 5000.4, Watch.Material.Silver, "Manufacturer2", 20);

            ps.AddInventory(v);
            ps.AddInventory(w);

            Employee e = new Employee("Edina", "Kudumovic", 200);
            Expert ex = new Expert("Rijad", "Memic", 200.5, "Expertise");

            ps.AddEmployee(e);
            ps.AddEmployee(ex);


            PrintInventory(ps);

            PrintSearch(ps, "Vehicle1");
        }
    }
}
