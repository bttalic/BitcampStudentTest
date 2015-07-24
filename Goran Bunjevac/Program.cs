using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Mini_Test
{
    class Program
    {

        /// <summary>
        /// Method prints all inventory item in pawnshop
        /// </summary>
        /// <param name="pawnshop">Object that contains list
        /// of inventory item</param>
        static void ListInventory(PawnShop pawnshop)
        {
            Console.Clear();
            Console.WriteLine("Inventory: ");
            foreach (var item in pawnshop.AllInventory)
            {
                Console.WriteLine(item);
            }
        }


        /// <summary>
        /// Method prints all pawnshop employees, usual or experts
        /// </summary>
        /// <param name="pawnshop">Object that contains list
        /// of employees</param>
        static void ListEmployees(PawnShop pawnshop)
        {
            Console.Clear();
            Console.WriteLine("Employees: ");
            foreach (var item in pawnshop.AllEmployees)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Method prints all vehicles in pawnshop
        /// </summary>
        /// <param name="pawnshop">Object that contains list
        /// of inventory items</param>
        static void AddVehicles(PawnShop pawnshop)
        {
            Console.Clear();
            Console.WriteLine("Enter vehicle name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter vehicle description: ");
            string description = Console.ReadLine();
            Console.WriteLine("Enter vehicle price: ");
            string price = Console.ReadLine();
            Console.WriteLine("Enter vehicle type: ");
            string type = Console.ReadLine();
            Console.WriteLine("Enter vehicle production year: ");
            int prodYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vehicle status: \n 1-Perfect\n 2-Preserved\n 3-Bad");
            string status = Console.ReadLine();

            Vehicle v = new Vehicle(name, description, price, type, prodYear, status);

            pawnshop.AllInventory.Add(v);

        }

        /// <summary>
        /// Method prints all watches in pawnshop
        /// </summary>
        /// <param name="pawnshop">Object that contains list
        /// of inventory items</param>
        static void AddWatches(PawnShop pawnshop)
        {
            Console.Clear();
            Console.WriteLine("Enter watch name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter watch description: ");
            string description = Console.ReadLine();
            Console.WriteLine("Enter watch price: ");
            string price = Console.ReadLine();
            Console.WriteLine("Enter watch manufacturer: ");
            string manufacturer = Console.ReadLine();
            Console.WriteLine("Enter  watch material: \n 1-Gold\n 2-Silver\n 3-Rubber\n 4-Other");
            string material = Console.ReadLine();
            Console.WriteLine("Enter watch age: \n 1-Modern\n 2-Postmodern");
            string age = Console.ReadLine();

            Watches w = new Watches(name, description, price, manufacturer, material, age);

            pawnshop.AllInventory.Add(w);


        }

        /// <summary>
        /// Method adds employees to pawnshop
        /// </summary>
        /// <param name="pawnshop">Object that contains list
        /// of employees</param>
        static void AddEmployee(PawnShop pawnshop)
        {
            Console.Clear();
            Console.WriteLine("Enter employee name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter employee surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter employee salary: ");
            double salary = Convert.ToInt32(Console.ReadLine());

            Employee e = new Employee(name, surname, salary);

            pawnshop.AllEmployees.Add(e);
        }


        /// <summary>
        /// Method adds experts (employees) to pawnshop
        /// </summary>
        /// <param name="pawnshop">Object that contains list
        /// of employees</param>
        static void AddEmployeeExperts(PawnShop pawnshop)
        {
            Console.Clear();
            Console.WriteLine("Enter experts name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter experts surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter experts salary: ");
            double salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter experts expertise:  \n 1-Watches\n 2-Vehicles");
            string expertise = Console.ReadLine();

            Experts ex = new Experts(name, surname, salary, expertise);

            pawnshop.AllEmployees.Add(ex);
        }


        /// <summary>
        /// Method searches all inventory items in museum by name,
        /// description or id
        /// <param name="pawnshop">Object that contains list
        /// of exhibits</param>
        static void SearchInventory(PawnShop pawnshop)
        {
            Console.Clear();
            Console.WriteLine("Enter inventory name: ");
            string name = Console.ReadLine();

            foreach (var item in pawnshop.AllInventory)
            {
                Inventory iv = item.FitsSearch(name);

                if (iv != null)
                {
                    Console.WriteLine(iv.ToString());
                }
            }
        }


        /// <summary>
        /// Method searches all employees in pawnshop
        /// by name,lastname or id
        /// <param name="pawnshop">Object that contains list
        /// of employees</param>
        static void SearchEmployee(PawnShop pawnshop)
        {
            Console.Clear();
            Console.WriteLine("Enter employee name or id: ");
            string name = Console.ReadLine();

            foreach (var item in pawnshop.AllEmployees)
            {
                Employee emp = item.FitsSearch(name);

                if (emp != null)
                {
                    Console.WriteLine(emp.ToString());
                }
            }
        }

        static void Main(string[] args)
        {

            PawnShop pawnshop = new PawnShop();

            while (true)
            {
                Console.WriteLine("Pawn Shop options: ");
                Console.WriteLine();
                Console.WriteLine("Enter 1 to list inventory: ");
                Console.WriteLine("Enter 2 to add vehicle: ");
                Console.WriteLine("Enter 3 to add watch: ");
                Console.WriteLine("Enter 4 to search inventory: ");
                Console.WriteLine();
                Console.WriteLine("Employee options: ");
                Console.WriteLine();
                Console.WriteLine("Enter 5 to list employees: ");
                Console.WriteLine("Enter 6 to add employees: ");
                Console.WriteLine("Enter 7 to add experts: ");
                Console.WriteLine("Enter 8 to search employees: ");

                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            ListInventory(pawnshop);
                            Thread.Sleep(2000);
                            break;
                        case 2:
                            AddVehicles(pawnshop);
                            Console.Clear();
                            break;
                        case 3:
                            AddWatches(pawnshop);
                            Console.Clear();
                            break;
                        case 4:
                            SearchInventory(pawnshop);
                            break;
                        case 5:
                            ListEmployees(pawnshop);
                            break;
                        case 6:
                            AddEmployee(pawnshop);
                            Console.Clear();
                            break;
                        case 7:
                            AddEmployeeExperts(pawnshop);
                            break;
                        case 8:
                            SearchEmployee(pawnshop);
                            break;
                        default:
                            Console.WriteLine("Wrong input, please try again");
                            break;

                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Wrong input, please try again: " + e.Message);
                }

            }
        }
    }
}