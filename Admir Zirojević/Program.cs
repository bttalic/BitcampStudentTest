using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        /// <summary>
        /// Prints all inventory items in PawnShop class
        /// </summary>
        /// <param name="Some object of Pawn Shop"></param>
        public static void PrintInventory(PawnShop ps)
        {
            foreach (InventoryItem item in ps.InvetoryItem)
            {
                Console.WriteLine(item);
            }        
        }


        /// <summary>
        /// Prints all employees items in PawnShop class
        /// </summary>
        /// <param name="Some object of Pawn Shop"></param>
        public static void PrintEmployee(PawnShop ps)
        {
            foreach (Employee item in ps.Employee)
            {
               
                Console.WriteLine(item);
            }
        }


        /// <summary>
        /// Searches and prints objects if found
        /// </summary>
        /// <param name="Some object of Pawn Shop"></param>
        /// <param name="string  name of the object you want to find"></param>
        static void PrintSearchResults(PawnShop ps, string s)
        {
            List<ISearchable> results = ps.Search(s);
            foreach (ISearchable item in results)
            {

                Console.WriteLine(item);
            }
        }



        
        static void PrintEnumerable<T>(IEnumerable<T> result)
        {
            foreach (T item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)    
        {
            PawnShop ps = new PawnShop();

            List<InventoryItem> ii = new List<InventoryItem>();

            Employee neko = new Employee("Zgembo", "Adislic", 2000);

            InventoryItem item = new InventoryItem("gitara", "žičana", 2500);
            InventoryItem item2 = new InventoryItem("bubanj", "obični", 2200);

            Watches w = new Watches("sat", "digitalni", 1300, Material.Gold, "swatch", 50);
            Cars c = new Cars("auto", "metalno", 1000, "audi", "a3", Condition.Good, 2000);

            InventoryItem[] inventory = new InventoryItem[3];

           
            inventory[0] = new InventoryItem("olovka", "onako", 100);
            inventory[1] = new InventoryItem("nesto", "odlicno", 26.60);
            inventory[2] = new InventoryItem("zlato", "sjaji se", 1000);

            IEnumerable<string> byName = inventory.OrderBy(x => x.Name).Select(x => x.Name);
            PrintEnumerable(byName);




            IEnumerable<double> byPrice = inventory.OrderBy(x => x.Price).Select(x => x.Price);
            PrintEnumerable(byPrice);




            ps.AddEmployee(neko);

            ps.AddInventory(item);
            ps.AddInventory(item2);

            ps.AddInventory(w);
            ps.AddInventory(c);




            PrintInventory(ps);

            PrintEmployee(ps);


            PrintSearchResults(ps, "Zge");

           

            Console.ReadLine();

           
        }
    }
}
