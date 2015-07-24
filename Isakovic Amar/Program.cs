using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W10D05_minitest
{
    class Program
    {
        static void Main(string[] args)
        {
            //test items for inventory
            InventoryItem item1 = new InventoryItem("zeko", "mali zeko", 20);
            InventoryItem item2 = new InventoryItem("autic", "mali crveni", 24);
            InventoryItem item3 = new InventoryItem("pingvin", "plisani medvjedic", 28);
            InventoryItem item4 = new InventoryItem("Samsung mobile", "mobitel pametni smarthphone", 2);
            var Item5 = new Car("Golf", "crne boje", 12500, "Limuzina", "VW", 2008, (Car.Conditions)1 );
             var Item6 = new Car("Golf 5", "crne i bijele boje", 10500, "Limuzina", "VW", 2005, (Car.Conditions)2 );
            //Test employee
            Employee Amar = new Employee("Amar", "Isakovic", 55);
            PawnShop TesasnjiPawn = new PawnShop("Tesanjski pawn shop");
            TesasnjiPawn.AddEmployee(Amar);
            TesasnjiPawn.AddItem(item1);
            TesasnjiPawn.AddItem(item2);
            TesasnjiPawn.AddItem(item3);
            TesasnjiPawn.AddItem(item4);
            TesasnjiPawn.AddItem(Item5);
             TesasnjiPawn.AddItem(Item6);
            Console.WriteLine(TesasnjiPawn);
            //Sorting NO.2
            TesasnjiPawn.PrintSortedByName();

            Console.WriteLine("ovo je sada soritanje po cijeni");


            //sorting
            TesasnjiPawn.PrintSortedByPrice();
            string SEARCHTERM = "Golf";

            //Search Method test
            TesasnjiPawn.Search(SEARCHTERM);


            Console.ReadLine();

        }
    }
}
