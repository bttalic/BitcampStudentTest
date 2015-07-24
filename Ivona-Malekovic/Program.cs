using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Program
    {              

        static void PrintInventory(PawnShop ps)
        {
            
            foreach (var item in ps.Inventory)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
            
        }

        static void PrintSearchResults(PawnShop ps, string s)
        {
            List<InventoryItem> items = ps.Find(s);
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
        
        static void SortByName(PawnShop ps)
        {
            List<InventoryItem> sbn = ps.SortByName();
            foreach (var item in sbn)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
        }

        static void SortByPrice(PawnShop ps)
        {
            List<InventoryItem> sbp = ps.SortByPrice();
            foreach (var item in sbp)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
        }

       
     
        static void Main(string[] args)
        {
            PawnShop ps = new PawnShop();
            InventoryItem book = new InventoryItem("book", "some book", 50.00);
            InventoryItem watch = new Watch("watch", "old watch", 50.00, Watch.Material.gold, "somebody", "unknown");
            InventoryItem car = new Vehicle("car", "some car", 12000.00, "bmw", 1985, "jfa", Vehicle.Condition.bad);


            ps.Inventory.Add(book);
            ps.Inventory.Add(watch);
            ps.Inventory.Add(car);

            //PrintInventory(ps);



            //PrintSearchResults(ps, "c");

            //SortByName(ps);
            SortByPrice(ps);






           


            
        }
    }
}
