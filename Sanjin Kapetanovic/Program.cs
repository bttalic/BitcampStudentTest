
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
        /// Method that take from user name,description,productionYear,price,manufacturer,material and send to method in clas pawnShop
        /// </summary>
        /// <param name="pawnShop"></object>
        static void AddWatch(PawnShop pawnShop)
        {
            Console.Clear();
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter description");
            string description = Console.ReadLine();
            Console.WriteLine("Enter year of production");
            int productionYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter price of watch");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter manufacturer");
            string manufacturer = Console.ReadLine();
            Console.WriteLine("Enter material (1 - gold, 2 - rubber, 3 - other)");
            string material = Console.ReadLine();
            pawnShop.AddWatch(name,description,productionYear,price,manufacturer,material);
        }
        /// <summary>
        /// Method that take from user name,description,productionYear,price,manufacturer,type,condition and send to method in clas pawnShop
        /// </summary>
        /// <param name="pawnShop"></object>
        static void AddVehicle(PawnShop pawnShop)
        {
            Console.Clear();
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter description");
            string description = Console.ReadLine();
            Console.WriteLine("Enter year of production");
            int productionYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter price of vehicle");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter manufacturer");
            string manufacturer = Console.ReadLine();
            Console.WriteLine("Enter type (1 - Sedan, 2 - SUV, 3 - Limousine, 4 - Truck, 5 - Pickup )");
            string type = Console.ReadLine();
            Console.WriteLine("Enter condition (1 - Mint, 2 - Repaired, 3 - Damaged)");
            string condition = Console.ReadLine();
            pawnShop.AddVehicle(name,description,productionYear,price,manufacturer,type,condition);
        }
        /// <summary>
        /// Method for calling methods for printing inventoryItems in class pawnShop
        /// </summary>
        /// <param name="pawnShop"></object>
        static void PrintInventoryItems(PawnShop pawnShop)
        {
            {
                int option = 0;
                while (option != 99)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("<<<<<Welcome to pawn shop print inventory menu>>>>>\n");
                    Console.ResetColor();
                    Console.WriteLine("1  :  Print by name");
                    Console.WriteLine("2  :  Print by price");
                    Console.WriteLine("99 :  Leave print menu\n");
                    Console.WriteLine("Enter your choice");
                    int.TryParse(Console.ReadLine(), out option);
                    switch (option)
                    {
                        case 1:
                            pawnShop.SortbyName();
                            pawnShop.PrintInventoryItems();
                            option = 99;
                            break;
                        case 2:
                            pawnShop.SortbyPrice();
                            pawnShop.PrintInventoryItems();
                            option = 99;
                            break;
                        case 99:
                            break;
                        default:
                            break;
                    }
                    BackToMainMenuOption();
                }
            }
        }
        /// <summary>
        /// Method for calling methods for printing employees in class pawnShop
        /// </summary>
        /// <param name="pawnShop"></param>
        static void PrintEmployees(PawnShop pawnShop)
        {
            int option = 0;
            while (option != 99)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("<<<<<Welcome to pawn shop print employees menu>>>>>\n");
                Console.ResetColor();
                Console.WriteLine("1  :  Print by name");
                Console.WriteLine("2  :  Print by salary");
                Console.WriteLine("99 :  Leave sort menu\n");
                Console.WriteLine("Enter your choice");
                int.TryParse(Console.ReadLine(), out option);
                switch (option)
                {
                    case 1:
                        pawnShop.SortEmployeebyName();
                        pawnShop.PrintEmployees();
                        option = 99;
                        break;
                    case 2:
                        pawnShop.SortbyPrice();
                        pawnShop.PrintEmployees();
                        option = 99;
                        break;
                    case 99:
                        break;
                    default:
                        break;
                }
                BackToMainMenuOption();
            }
        }
        /// <summary>
        /// Method that takes firstname and lastname from user
        /// </summary>
        /// <param name="pawnShop"></object>
        static void AddCasualEmployee(PawnShop pawnShop)
        {
            Console.Clear();
            Console.WriteLine("Enter firstname");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter lastname");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter salary for this worker");
            double payCheck = Convert.ToDouble(Console.ReadLine());
            pawnShop.AddCasualEmployee(firstName, lastName,payCheck);
        }
        /// <summary>
        /// Method that takes firstname, lastname and expertise from user
        /// </summary>
        /// <param name="pawnShop"></object>
        static void AddExpertEmployee(PawnShop pawnShop)
        {
            Console.Clear();
            Console.WriteLine("Enter firstname");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter lastname");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter expertise");
            string expertise = Console.ReadLine();
            Console.WriteLine("Enter salary for this worker");
            double payCheck = Convert.ToDouble(Console.ReadLine());
            pawnShop.AddExpertEmployee(firstName, lastName,expertise, payCheck);
        }
        /// <summary>
        /// Method for calling method for searching inventoryItems in class pawnShop
        /// </summary>
        /// <param name="pawnShop"></object>
        static void SearchInventoryItem(PawnShop pawnShop)
        {
            Console.Clear();
            Console.WriteLine("Enter information for searching inventoryItem");
            Console.WriteLine(pawnShop.SearchInventoryItem(Console.ReadLine()));
            BackToMainMenuOption();
        }
        /// <summary>
        /// Method for calling method for searching employee in class pawnShop
        /// </summary>
        /// <param name="pawnShop"></object>
        static void SearchEmployee(PawnShop pawnShop)
        {
            Console.Clear();
            Console.WriteLine("Enter information for searching employee");
            Console.WriteLine(pawnShop.SearchEmployee(Console.ReadLine()));
            BackToMainMenuOption();
        }
        /// <summary>
        /// Method for calling methods for sorting inventory items in class pawnShop
        /// </summary>
        /// <param name="pawnShop"></object>
        static void SortInventoryItems(PawnShop pawnShop)
        {
            int option = 0;
            while (option != 99)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("<<<<<Welcome to pawn shop sort menu>>>>>\n");
                Console.ResetColor();
                Console.WriteLine("1  :  Sort by name");
                Console.WriteLine("2  :  Sort by price");
                Console.WriteLine("99 :  Leave sort menu\n");
                Console.WriteLine("Enter your choice");
                int.TryParse(Console.ReadLine(), out option);
                switch (option)
                {
                    case 1:
                        pawnShop.SortbyName();
                        Console.WriteLine("InventoryItems sorted by name!");
                        option = 99;
                        break;
                    case 2:
                        pawnShop.SortbyPrice();
                        Console.WriteLine("InventoryItems sorted by price!");
                        option = 99;
                        break;
                    case 99:
                        break;
                    default:
                        break;
                }
                BackToMainMenuOption();
            }
        }
        /// <summary>
        /// Method for calling methods for sorting employes in class pawnShop
        /// </summary>
        /// <param name="pawnShop"></object>
        static void SortEmployees(PawnShop pawnShop)
        {
            int option = 0;
            while (option != 99)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("<<<<<Welcome to pawn shop sort menu>>>>>\n");
                Console.ResetColor();
                Console.WriteLine("1  :  Sort by name");
                Console.WriteLine("2  :  Sort by salary");
                Console.WriteLine("99 :  Leave sort menu\n");
                Console.WriteLine("Enter your choice");
                int.TryParse(Console.ReadLine(), out option);
                switch (option)
                {
                    case 1:
                        pawnShop.SortEmployeebyName();
                        Console.WriteLine("Employees sorted by name!");
                        option = 99;
                        break;
                    case 2:
                        pawnShop.SortbyPrice();
                        Console.WriteLine("Employees sorted by salary!");
                        option = 99;
                        break;
                    case 99:
                        break;
                    default:
                        break;
                }
                BackToMainMenuOption();
            }
        }
        /// <summary>
        /// Option to pause before returning to while loop
        /// </summary>
        static void BackToMainMenuOption()
        {
            Console.WriteLine("Press enter to back in main menu");
            Console.ReadLine();
        }
        /// <summary>
        /// Prints main menu on first screen
        /// </summary>
        static void FirstScreen()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("<<<<<Welcome to pawn shop>>>>>\n");
            Console.ResetColor();
            Console.WriteLine("1  :  Menu for printing inventory items");
            Console.WriteLine("2  :  Menu for printing employees");
            Console.WriteLine("3  :  Add watch");
            Console.WriteLine("4  :  Add vehicle");
            Console.WriteLine("5  :  Add casual employee");
            Console.WriteLine("6  :  Add expert employee");
            Console.WriteLine("7  :  Sort inventoryItems");
            Console.WriteLine("8  :  Sort employees");
            Console.WriteLine("9  :  Find inventoryItem");
            Console.WriteLine("10 :  Find employee");
            Console.WriteLine("99 :  Leave pawn shop\n");
        }
        static void Main(string[] args)
        {
            PawnShop pawnShop = new PawnShop();
            int option = 0;
            while (option != 99)
            {
                FirstScreen();
                Console.WriteLine("Enter your choice");
                int.TryParse(Console.ReadLine(), out option);
                switch (option)
                {
                    case 1:
                        PrintInventoryItems(pawnShop);
                        break;
                    case 2:
                        PrintEmployees(pawnShop);
                        break;
                    case 3:
                        AddWatch(pawnShop);
                        break;
                    case 4:
                        AddVehicle(pawnShop);
                        break;
                    case 5:
                        AddCasualEmployee(pawnShop);
                        break;
                    case 6:
                        AddExpertEmployee(pawnShop);
                        break;
                    case 7:
                        SortInventoryItems(pawnShop);
                        break;
                    case 8:
                        SortEmployees(pawnShop);
                        break;
                    case 9:
                        SearchInventoryItem(pawnShop);
                        break;
                    case 10:
                        SearchEmployee(pawnShop);
                        break;
                    case 99:
                        Console.WriteLine("Leaving pawn shop");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
