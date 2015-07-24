using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop
{
    public class PawnShop : ISearchable
    {
        //List of InventoryItem objects
        public List<InventoryItem> InventoryList { get; set; }
        //List of Employee objects
        public List<Employee> Employees { get; set; }

        public PawnShop()
        {
            InventoryList = new List<InventoryItem>();
            Employees = new List<Employee>();
        }

        /// <summary>
        /// Method creates and object of InventoryItem class and adds it to the list of InventoryItem objects (List<InventoryItem> InventoryList)
        /// </summary>
        /// <param name="name">Item name (string)</param>
        /// <param name="desc">Item description (string)</param>
        /// <param name="price">Item price (double)</param>
        public void AddItem(string name, string desc, double price)
        {
            InventoryList.Add(new InventoryItem(name, desc, price));
        }

        /// <summary>
        /// Overloaded method creates and object of Watch (inherits InventoryItem) class and adds it to the list of InventoryItem objects (List<InventoryItem> InventoryList)
        /// </summary>
        /// <param name="name">Item name (string)</param>
        /// <param name="desc">Item description (string)</param>
        /// <param name="price">Item price (double)</param>
        /// <param name="material">Item material (enum)</param>
        /// <param name="manufacturer">Item manufacturer (string)</param>
        /// <param name="age">Item age (int)</param>
        public void AddItem(string name, string desc, double price,Enum material, string manufacturer, int age)
        {
            InventoryList.Add(new Watch(name, desc, price,material,manufacturer,age));
        }

        /// <summary>
        /// Overloaded method creates and object of Car (inherits InventoryItem) class and adds it to the list of InventoryItem objects (List<InventoryItem> InventoryList)
        /// </summary>
        /// <param name="name">Item name (string)</param>
        /// <param name="desc">Item description (string)</param>
        /// <param name="price">Item price (double)</param>
        /// <param name="carType">Item car type (string)</param>
        /// <param name="yearofProd">Item year of production (int)</param>
        /// <param name="condition">Item condition (Enum)</param>
        public void AddItem(string name, string desc, double price, string carType, int yearofProd, Enum condition)
        {
            InventoryList.Add(new Car(name, desc, price, carType, yearofProd, condition));
        }

        /// <summary>
        /// Method creates and object of Employee class and adds it to the list of Employe objects (List<Employees> Employees)
        /// </summary>
        /// <param name="firstName">Employee first name (string)</param>
        /// <param name="lastName">Employee last name (string)</param>
        /// <param name="wage">Employee monthly wage (double)</param>
        public void AddEmployee(string firstName, string lastName, double wage)
        {
            Employees.Add(new Employee(firstName, lastName, wage));
        }

        /// <summary>
        /// Overloaded method creates and object of Expert (inherits Employee) class and adds it to the list of Employe objects (List<Employees> Employees)
        /// </summary>
        /// <param name="firstName">Employee first name (string)</param>
        /// <param name="lastName">Employee last name (string)</param>
        /// <param name="wage">Employee monthly wage (double)</param>
        /// <param name="expertise">Employee's expertise field (string)</param>
        public void AddEmployee(string firstName, string lastName, double wage,string expertise)
        {
            Employees.Add(new Expert(firstName, lastName, wage,expertise));
        }

        /// <summary>
        /// Method for searching through inventory list. Searches through inventry names and description and sorts it by name for displaying.
        /// </summary>
        /// <param name="s">Search string</param>
        /// <returns>Search result - true or false (bool)</returns>
        public bool fitsSearch(string s)
        {
            List<InventoryItem> searchList = InventoryList
                .Where(x => x.Name.Contains(s) || x.Description.Contains(s))
                .OrderBy(x => x.Name)
                .ToList();
            if(searchList.Count == 0)
            {
                return false;
            }
            else
            {
                Console.WriteLine("Inventory list search result: ");
                Console.WriteLine("******************************");
                foreach(var inv in searchList)
                {
                    Console.WriteLine(inv);
                }
                Console.WriteLine();
                Console.WriteLine("******************************");
                return true;
            }
        }

        /// <summary>
        /// Method for searching through inventory list by price (double) and displaying the search result by sorting item names.
        /// </summary>
        /// <param name="s">Price (double)</param>
        /// <returns>Search result - true or false (bool)</returns>
        public bool SearchProductByPrice(double price)
        {
            List<InventoryItem> searchListByPrice = InventoryList
            .Where(x => x.Price == price)
            .OrderBy(x=> x.Name)
            .ToList();
            if (searchListByPrice.Count == 0)
            {
                return false;
            }
            else
            {
                Console.WriteLine("Inventory list search result (by price): ");
                Console.WriteLine("*****************************************");
                foreach (var inv in searchListByPrice)
                {
                    Console.WriteLine(inv);
                }
                Console.WriteLine("*****************************************");
                return true;
            }
        }

        /// <summary>
        /// Method displays the inventory list to the user.
        /// </summary>
        public void ShowInventory()
        {
            foreach(var inv in InventoryList)
            {
                Console.WriteLine(inv);
            }
        }

        /// <summary>
        /// Method displays the employee list to the user.
        /// </summary>
        public void ShowEmpoloyees()
        {
            foreach (var inv in Employees)
            {
                Console.WriteLine(inv);
            }
        }

        /// <summary>
        /// Method displays to the user inventory list and the user can delete inventory item by inventory id.
        /// </summary>
        public void DeleteInventoryItem()
        {
            ShowInventory();

            Console.WriteLine();
            Console.WriteLine("Please pick inventory id:");
            int itemNumber = 0;
            try
            {
                itemNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception s)
            {
                Console.WriteLine(s.Message);
            }
            InventoryItem toRemoveItem = InventoryList
                .Where(x => x.Id == itemNumber).SingleOrDefault();

            InventoryList.Remove(toRemoveItem);
        }

        /// <summary>
        /// Method displays to the user employee list and the user can delete employee by entering its first name and last name
        /// </summary>
        public void DeleteEmployee()
        {
            ShowEmpoloyees();
            Console.WriteLine();
            Console.WriteLine("Please enter employee first name: ");
            string employeeFirstName = Console.ReadLine();
            Console.WriteLine("Please enter employee last name: ");
            string employeeLastName = Console.ReadLine();

            Employee toRemove = Employees
                .Where(x => x.FirstName.Equals(employeeFirstName) && x.LastName.Equals(employeeLastName)).SingleOrDefault();

            Employees.Remove(toRemove);
        }

       
    }
}
