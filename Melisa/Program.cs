using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {

        /// <summary>
        /// Printing Inventory Items
        /// </summary>
        /// <param name="ps"></param>

        public static void PrintInventoryItems(PawnShop ps)
        {
            foreach (var item in ps.InventoryItemList)
            {
                Console.WriteLine(item);
            }
        }


        /// <summary>
        /// Searching items, if they exist, writing then on the console
        /// </summary>
        /// <param name="ps"></param>
        /// <param name="s"></param>

        static void PrintSearchResults(PawnShop ps, string s)
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
            Cars c1 = new Cars("Car", "Modern. Striking. Sporty. The Audi A1 sets new benchmarks in its class", 50.000, "Audi A1", 2005, "Volkswagen Group UK Ltd", Cars.Condition.preserved);
            Cars c2 = new Cars("Car", "The BMW M3 is a high-performance version of the BMW 3-Series, developed by BMW's in-house motorsport division, BMW M3", 30.000, "BMW M3", 1985, "BMW M GmbH", Cars.Condition.perfectly);

            Watch w1 = new Watch("DUO watch","The DUO allows this border to be easily overcome. A dual one-hand watch, it shows both the local time and the time at one additional time zone, using just one hand in each case.", 398.00, "BOTADesign", "2005", Watch.Material.rubber);
            Watch w2 = new Watch("NOCA Carbon watch", "The watch face of the new NOVA Carbon comprises two main elements: an hour hand and a 12-hour scale. There are no subscales.", 890.00, "BOTADesign", "2014", Watch.Material.silver);


            Employee e1 = new Employee("Chris", "Smith");
            Employee e2 = new Employee("John", "Doe");

            ps.AddEmployees(e1);
 
            ps.AddInventoryItem(c1);
                     
            PrintSearchResults(ps, "John");
           
            Console.WriteLine("--------------------------");
            PrintInventoryItems(ps);
            
        }
    }
}
