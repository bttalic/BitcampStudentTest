using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {



        public static void PrintInventory(PawnShop p)
        {
            foreach (Inventory i in p.Inventory)
            {
               Console.WriteLine(i);       
            }
        }


         static void Search(PawnShop p, string s)
         {
             List<ISearchable> res = p.Find(s);
             foreach (ISearchable r in res) 
             {
                 Console.WriteLine(r);
             }
        }
        static void Main(string[] args)
        {
            PawnShop p = new PawnShop();
            Inventory i = new Inventory(1, "Painting", "Picasso's painting", 1000000);
            Vehiacle v = new Vehiacle("Sedan", 2006, "Alfa Romeo", "Weak", 2, "Car", "Sports car", 15000);
            Watches w = new Watches("Gold", "Rolex", 1978, 7, "Watch", "Expensive", 50000);
            p.AddInventory(i);
            p.AddInventory(v);
            p.AddInventory(w);

            PrintInventory(p);
        }


          
        }
    }
