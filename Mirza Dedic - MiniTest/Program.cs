using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest
{
    class Program
    {

        /// <summary>
        /// Adds new car to list
        /// </summary>
        /// <param name="ps">pawnShop ps</param>
        static void AddCar (PawnShop ps)
        {
            
            string name = "-";
            Console.Write("Enter description: ");
            string description = Console.ReadLine();
            Console.Write("Enter price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter type: ");
            string type = Console.ReadLine();
            Console.Write("Enter  year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter maker: ");
            string maker = Console.ReadLine();
            Console.Write("Enter condition - Perfect = 1, Preserved = 2, Bad = 3 ");
            string condition = Console.ReadLine();

            Cars c = new Cars(name, description,price,type,year,maker, condition);
            ps.items.Add(c);

        }

        /// <summary>
        /// Adds new watch to item list
        /// </summary>
        /// <param name="ps">PawnShop ps</param>
        static void AddWatch(PawnShop ps)
        {

            string name = "-";
            Console.Write("Enter description: ");
            string description = Console.ReadLine();
            Console.Write("Enter price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter material - Gold = 1, Plastic = 2, Metal = 3: ");
            string material = Console.ReadLine();
            Console.Write("Enter how old: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter maker: ");
            string maker = Console.ReadLine();

            Watches w = new Watches(name, description, price, material, maker, year);
            ps.items.Add(w);

        }


        /// <summary>
        /// Searches items by name
        /// </summary>
        /// <param name="ps">PawnShop ps</param>
        static void SearchByName(PawnShop ps)
        {
            Console.Write("Enter your search: ");
            string name = Console.ReadLine();

            foreach (var item in ps.items)
            {
                InventoryItem result = item.SearchByName(name);
                if (result != null)
                {
                    Console.WriteLine("No item found!");
                }
                else
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }

        /// <summary>
        /// Searches items by price
        /// </summary>
        /// <param name="ps">PawnShop ps</param>
        static void SearchByPrice(PawnShop ps)
        {
            Console.Write("Enter your search: ");
            double price = Convert.ToDouble(Console.ReadLine());

            foreach (var item in ps.items)
            {
                InventoryItem result = item.SearchByPrice(price);
                if (result != null)
                {
                    Console.WriteLine("No item found!");
                }
                else
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }



        /// <summary>
        /// Prints all items
        /// </summary>
        /// <param name="ps">PawnShop ps</param>
        static void PrintItems(PawnShop ps)
        {
            foreach(var item in ps.items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------");
        }


        /// <summary>
        /// Print all employees 
        /// </summary>
        /// <param name="ps">PawnShop ps</param>
        static void PrintStaff(PawnShop ps)
        {
            foreach (var member in ps.employees)
            {
                Console.WriteLine(member);
            }
            Console.WriteLine("----------------");
        }







        static void Main(string[] args)
        {

            InventoryItem ii = new InventoryItem("name1", "some item", 33.1);
            Cars c1 = new Cars("car1", "some description", 345.2, "some type", 1999, "ford", "1");
            Watches w1 = new Watches("watch1", "some description", 500, "2", "some maker", 50);

            PawnShop ps = new PawnShop();
            ps.items.Add(ii);
            ps.items.Add(c1);
            ps.items.Add(w1);


            Staff s1 = new Staff("Name1","Surname1", 700);
            StaffExpert s2 = new StaffExpert("Name2", "Surname2", 700, "Watches");
            StaffExpert s3 = new StaffExpert("Name3", "Surname3", 700, "Cars");

            ps.employees.Add(s1);
            ps.employees.Add(s2);
            ps.employees.Add(s3);


            //AddCar(ps);
            //AddWatch(ps);

            //SearchByName(ps);
            //SearchByPrice(ps);


            PrintItems(ps);
            PrintStaff(ps);

        }
    }
}
