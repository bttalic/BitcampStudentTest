using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Test
{
    /// <summary>
    /// class for testing program
    /// </summary>
    class Simulation
    {
        private static PawnShop ps = new PawnShop();

        /// <summary>
        /// main method for test
        /// </summary>
        public static void Begin()
        {
           
            while(true)
            {
                Console.Clear();
                Console.WriteLine("press 0 to order elements press 1 to list inventory press 2 to add item\npress 3 to search press 4 to add Worker press 5 to list workers press 6 to exit");
                int select = 0;
                int.TryParse(Console.ReadLine(), out select);
                switch(select)
                {
                    case 0:
                        Order();
                        break;
                    case 1:
                        ListItems();
                        break;
                    case 2:
                        AddItem();
                            break;
                    case 3:
                            Console.WriteLine("Enter KeyWord");
                            string key = Console.ReadLine();
                            ListFoundItems(key);
                            Console.ReadLine();
                            break;
                    case 4:
                            AddWorker();
                            break;
                    case 5:
                            ListWorkers();
                            break;
                    case 6:
                            return;
                    default:
                            Console.WriteLine("Wrong input");
                            return;

                }
            }
        }
        /// <summary>
        /// calls pawnshop list method and lists all items 
        /// </summary>
        private static void ListItems()
        {
            if (ps.listItems() != null)
            {
                var items = ps.listItems();
                Listing(items);
            }
            else
            {
                Console.WriteLine("No Items");
            }
        }
        /// <summary>
        /// calls pawnshop add method and adds inventoryitem
        /// </summary>
        private static void AddItem()
        {
            Console.Clear();
            Console.WriteLine("press 1 to add item,press 2 to add car, press 3 to add watch");
            int select = 0;
            int.TryParse(Console.ReadLine(), out select);
            switch(select)
            {
                case 1://adds regular InventoryItem
                    Console.Clear();
                    Console.WriteLine("Add Name");
                    string name=Console.ReadLine();
                    Console.WriteLine("Add Description");
                    string description=Console.ReadLine();
                    Console.WriteLine("Add Price");
                    double price=double.Parse(Console.ReadLine());
                    InventoryItem item=new InventoryItem(name,description,price);
                    ps.AddInventoryItem(item);
                    break;
                case 2://adds Car InventoryItem
                    Console.Clear();
                    Console.WriteLine("Add Name");
                    string cName=Console.ReadLine();
                    Console.WriteLine("Add Type");
                    string type = Console.ReadLine();
                    Console.WriteLine("Add Age");
                    int age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Add Manufacturer");
                    string manufacturer = Console.ReadLine();

                    Console.WriteLine("Add Description");
                    string cDescription=Console.ReadLine();
                    Console.WriteLine("Add Price");
                    double cPrice=double.Parse(Console.ReadLine());
                    Console.WriteLine("Add condition(0 for new, 1 to used, 2 for bad)");
                    int condition = int.Parse(Console.ReadLine());
                    Car Citem=new Car(cName,cDescription,cPrice,type,age,manufacturer,(Car.Condition)condition);
                    ps.AddCar(Citem);
                    break;
                case 3://adds Watch InventoryItem
                    Console.Clear();
                    Console.WriteLine("Add Name");
                    string wName=Console.ReadLine();
                    Console.WriteLine("Add Description");
                    string wDescription=Console.ReadLine();
                    Console.WriteLine("Add Price");
                    double wPrice=double.Parse(Console.ReadLine());
                    Console.WriteLine("Add Material(0 for gold,1 for silver 2 for rubber and 3 for other");
                    int material = int.Parse(Console.ReadLine());
                    Watch Witem=new Watch(wName,wDescription,wPrice,(Watch.Material)material);
                    ps.AddWatch(Witem);
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }
        /// <summary>
        /// adds new worker to database
        /// </summary>
        private static void AddWorker()
        {
            Console.Clear();
            Console.WriteLine("Press 1 to add Regular worker press 2 to add Expert");
            int choice = 0;
            int.TryParse(Console.ReadLine(), out choice);
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Add name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Add Surname");
                    string surname = Console.ReadLine();
                    Console.WriteLine("Add paycheck");
                    double paychech = double.Parse(Console.ReadLine());
                   ps.AddWorker(new Worker(name, surname, paychech));
                    break;
                case 2:
                    Console.WriteLine("Add name");
                    string eName = Console.ReadLine();
                    Console.WriteLine("Add Surname");
                    string eSurname = Console.ReadLine();
                    Console.WriteLine("Add paycheck");
                    double ePaychech = double.Parse(Console.ReadLine());
                    Console.WriteLine("Add Expertise");
                    string expertise = Console.ReadLine();
                   ps.AddExpert(new Experts(eName, eSurname, ePaychech,expertise));
                   break;
                default :
                   Console.WriteLine("wrong input");
                   break;
            }
        }
        /// <summary>
        /// lists all the items which forfills key value
        /// </summary>
        /// <param name="key"></param>
        private static void ListFoundItems(string key)
        {
            var list = ps.SearchItem(key);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        /// <summary>
        /// orders inventoryitems by price or name
        /// </summary>
        private static void Order()
        {
            Console.Clear();
            Console.WriteLine("press 1 to order by price press 2 to order by name");

            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                var list = ps.SortByPrice();
                Listing(list);
            }
            else
            {
              var list=ps.SortByName();
              Listing(list);
            }
        }
        /// <summary>
        /// helping method for listing ienumerable objects
        /// </summary>
        /// <param name="list"></param>
        private static void Listing(IEnumerable list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        /// <summary>
        /// lists all the workers
        /// </summary>
        private static void ListWorkers()
        {
            Listing(ps.listWorkers());
        }
    }
}
