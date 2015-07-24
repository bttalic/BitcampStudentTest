using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest
{
    class Program
    {
        //public static void PrintInventory(PawnShop p)
        //{
        //    foreach (InventoryItem i in p.inventory)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

       

      
      



        static void Main(string[] args)
        {

            PawnShop p = new PawnShop();
            InventoryItem i = new InventoryItem("Auto","Some Descrition", 2000);
            
            Console.WriteLine(i);
            Cars c = new Cars("Car","Some Descrition ",2000,"Auto",1964,"Golf","Very Bad");
            
            Console.WriteLine(c);
       

           
            

            
            
            
            
        }
    }
}
