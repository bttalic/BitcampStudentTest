using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W10D05PawnShopTest
{
    class Program
    {

        /// <summary>
        /// prints the entire inventory list
        /// </summary>
        /// <param name="ps">inventory of the pawnshop</param>
        public static void PrintInventory(PawnShop ps)
        {
            foreach (InventoryItem ie in ps.inventory )
            {
                Console.WriteLine(ie);
            }
        }


        /// <summary>
        /// prints the inventory items that meet the search criteria; we are searching only the ItemName field; the method is using FindName method defined under the PawnsShop Class
        /// </summary>
        /// <param name="ps">pawnshop inventory</param>
        /// <param name="s">string used as a search criteria</param>
        static void PrintSearchResults(PawnShop ps, string s)
        {
            List<MyISearchable> result = ps.FindName(s);
            foreach (MyISearchable r in result)
            {
                Console.WriteLine(r);
            }
        }


        /// <summary>
        /// prints the inventory items that meet the search criteria; we are searching only the Price field; the method is using FindPrice method defined under the PawnsShop Class
        /// </summary>
        /// <param name="ps">pawnshop inventory</param>
        /// <param name="s">interger (price) used as a search criteria</param>
        static void PrintSearchResults(PawnShop ps, int i)
        {
            List<MyISearchable> result = ps.FindPrice(i);
            foreach (MyISearchable r in result)
            {
                Console.WriteLine(r);
            }
        }


        static void Main(string[] args)
        {
            PawnShop ps = new PawnShop();

            InventoryItem vehicle1 = new Vehicle(1,"Family Car", 10500, "CARFAX shows no accident!", "Town & Country", 2010, "Chrysler", Vehicle.Condition.mint);
            InventoryItem vehicle2 = new Vehicle(2, "Pick-Up", 7999, "Still 10 Months/10,000 Miles of warranty left", "F-150", 2010, "Ford", Vehicle.Condition.poor);
            InventoryItem vehicle3 = new Vehicle(3, "Off-The-Road", 17499, "You'll have fun with this one!", "Wrangler", 2012, "Jeep", Vehicle.Condition.wellKept);
            InventoryItem vehicle4 = new Vehicle(4, "Sedan", 4499, "", "Cavalier", 2007, "Chevrolet", Vehicle.Condition.poor);

            Watch watch1 = new Watch(5, "Men's watch", 199, "Very attractive, sleek design", "Emporio Armani", 3, Watch.Material.silver);
            Watch watch2 = new Watch(6, "Men's watch", 69, "X-Large G-Shock model in stealth black resin with black detailing.", "Casio", 4, Watch.Material.rubber);
            Watch watch3 = new Watch(7, "Women's watch", 149, "Rose plating, with a sparkling stone set bezel, mother of pearl dial and beautifully stone set hour markers.", "Michael Kors", 2, Watch.Material.gold);
            Watch watch4 = new Watch(8, "Women's watch", 149, "Elegant and stylish timepiece.", "Michael Kors", 1, Watch.Material.other);

            ps.AddItem(vehicle1);
            ps.AddItem(vehicle2);
            ps.AddItem(vehicle3);
            ps.AddItem(vehicle4);
            ps.AddItem(watch1);
            ps.AddItem(watch2);
            ps.AddItem(watch3);
            ps.AddItem(watch4);

            PrintInventory(ps);

            PrintSearchResults(ps, 69);

            PrintSearchResults(ps, "Men's watch");


        }
    }
}
