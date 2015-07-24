using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek10Day5
{
    class Program
    {
        public static void Print(PawnShop ps)
        {
            foreach (InventoryItem item in ps.InventoryItem )
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            PawnShop ps = new PawnShop();
          
           Cars c = new Cars("FamilyCar", "siguran i ugodan", 20.000, "Nesto", "Citroen", 2001,Cars.Details.good);

           Watches w = new Watches("SAt", "SAt", 50.0, "SAt", "SAt", 1986, Watches.Material.silver);
           ps.AddExponat(c);
           ps.AddExponat(w);

           Print(ps);
          
        }
    }
}
