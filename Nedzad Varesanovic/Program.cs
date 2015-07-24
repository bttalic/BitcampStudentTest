using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PownShop
{
    class Program
    {
        /// <summary>
        /// Method create instance of an PawnShop, and create few employees and few inventory items.
        /// </summary>
        /// <returns>Methos returns incance of an PawnShop</returns>
        static PawnShop InitShop()
        {
            PawnShop ps = new PawnShop();

            //Employee e = new Employee("John", "Doe", 1000);
            //ps.AddEmployee(e);

            //Employee e1 = new ExpertEmployee("Jane", "Doe", 1500, 0);
            //ps.AddEmployee(e1);

            ps.AddEmployee(new Employee("John", "Doe", 1000));
            ps.AddEmployee(new ExpertEmployee("Jane", "Doe", 1500, 0));

            ps.AddItem(new InventoryItem("Sony LED TV", "50 Sony Smart LED TV", 1699));
            ps.AddItem(new InventoryItem("Notebook Apple", "MacBook Pro 15 Retina", 3250));
            ps.AddItem(new Vehicle("Golf", "VW bestseller vehicle 2.0 TDI engine with 150 PS", 41566, "Passenger car", 2014, "Volkswagen", 0)); ;
            ps.AddItem(new Vehicle("Megane", "French manufacturers compact vehicle", 33000, "Passenger car", 2010, "Renault", 1));
            ps.AddItem(new Watch("Navy blue", "Moder Festin Chrono watch - 2014 collection", 999, 3, "Festina", 1));
            ps.AddItem(new Watch("7200R", "Classic style, but highly expensive wathc", 24599, 0, "Philippe Patek", 0));

            return ps;
        }
        /// <summary>
        /// Methos recive as parameter instance of a PawnShop and performs serach in objects list of inventory items by Title.
        /// </summary>
        /// <param name="ps">Instance of a PawnShop</param>
        static void SearchTitle(PawnShop ps)
        {
            Console.Clear();
            Console.Write("Enter any part of the Inventory items title : ");
            string search = Console.ReadLine();

            List<InventoryItem> list = ps.Inventory.Select(x => x.FitsSearch(search)).ToList();
            Console.WriteLine("Items found : ");
            PrintItems(list);
            
        }
        /// <summary>
        /// Methos recive as parameter instance of a PawnShop and performs serach in objects list of inventory items by Price
        /// </summary>
        /// <param name="ps">Instance of a PawnShop</param>
        static void SearchPrice(PawnShop ps)
        {
            double price = 0;
            while (true)
            {
                Console.Clear();
                Console.Write("Enter max price for item : ");
                
                try
                {
                    price = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
            List<InventoryItem> list = ps.Inventory.Select(x => x.FitsSearch(price)).ToList();
            Console.WriteLine("Items found : ");
            PrintItems(list);
        }
        /// <summary>
        /// Method recive list of inventory items, and print every item on console.
        /// </summary>
        /// <param name="list">List of Inventory items</param>
        static void PrintItems(List<InventoryItem> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            PawnShop ps = InitShop();
            
            int choice = 0;

            while (choice != 3)
            {
                Console.Clear();
                Console.WriteLine("========= PAWN SHOP============");
                Console.WriteLine();
                Console.WriteLine("1 - Search item by title");
                Console.WriteLine("2 - Search item by price");
                Console.WriteLine("3 - Exit program");
                Console.WriteLine();
                Console.WriteLine("===============================");
                Console.Write("Enter your choice : ");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException ex)
                {

                    Console.WriteLine(ex.Message);
                }

                switch (choice)
                {
                    case (1):
                        SearchTitle(ps);
                        break;
                    case (2):
                        SearchPrice(ps);
                        break;
                    case (3):
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
