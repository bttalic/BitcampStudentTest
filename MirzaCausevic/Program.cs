using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop
{
    class Program
    {
       

        static void Main(string[] args)
        {
            
            PwnShop shop = new PwnShop();


            Car c1 = new Car("Audi A3", "Silver Car", 21000, 2013, "Audi", (Car.Condition)2, (Car.Type)1);
            Car c2 = new Car("Ford Focus", "Red Car", 9000, 2010, "Ford", (Car.Condition)3, (Car.Type)2);
            Car c3 = new Car("Golf", "Blue Car", 2400, 1998, "VW", (Car.Condition)4, (Car.Type)2);

            Watch w1 = new Watch("Rolex", "Rare Rolex", 7000, 2000, "Rolex", (Watch.Material)1);
            Watch w2 = new Watch("Seiko", "Common Seiko Watch", 195, 2013, "Seiko", (Watch.Material)2);
            Watch w3 = new Watch("Casio", "Common Casio Watch", 25, 2014, "Casio", (Watch.Material)3);

            shop.AddToList(c1);
            shop.AddToList(c2);
            shop.AddToList(c3);
            shop.AddToList(w1);
            shop.AddToList(w2);
            shop.AddToList(w3);

            

        }
        public static void ShowInventory (PwnShop p)
        {
            foreach (Inventory a in p.inventory)
            { Console.WriteLine(a); }
        }
    }
}
