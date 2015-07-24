using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop
{
    /// <summary>
    /// Represents pawn shop
    /// </summary>
    public class PawnShop
    {
        private string name;
        private List<Employee> employees;
        private List<InventoryItem> items;

        public PawnShop(string name)  //class constructor
        {
            this.name = name;
            this.employees = new List<Employee>();
            this.items = new List<InventoryItem>();
        }

        public string Name  //class properties
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Adds new inventory item to pawn shop
        /// </summary>
        /// <param name="item">item to add</param>
        public void AddItem(InventoryItem item)
        {
            items.Add(item);
            items.OrderBy(x => x.Name);
        }

        /// <summary>
        /// Removes one inventory item from pawn shop
        /// </summary>
        /// <param name="id">id with which we will find 
        /// item in list</param>
        public void RemoveItem(int id)
        {
                InventoryItem item = items.Find(x => x.Id == id);
                if (item == null)
                {
                    Console.WriteLine("That item doesn't exist.");
                    return;
                }
                items.Remove(item);
        }

        /// <summary>
        /// Adds new employee to the pawn shop
        /// </summary>
        /// <param name="employee">employee to add</param>
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
            employees.OrderBy(x => x.Name);
        }

        /// <summary>
        /// Removes employee from pawn shop
        /// </summary>
        /// <param name="id">id to find employee</param>
        public void RemoveEmployee(int id)
        {
            Employee employee = employees.Find(x => x.Id == id);
            if (employee == null)
            {
                Console.WriteLine("That employee doesn't exist.");
                return;
            }
            employees.Remove(employee);
        }

        /// <summary>
        /// Filters items by search key
        /// </summary>
        /// <param name="key">search key</param>
        /// <returns>list with items which matches 
        /// search key</returns>
        public List<InventoryItem> FindItems(string key)
        {
            List<InventoryItem> findItems = new List<InventoryItem>();
            foreach (var item in items)
            {
                if (item.FitsSearch(key))  
                    findItems.Add(item);
            }

            if (findItems.Count == 0)
            {
                Console.WriteLine("Couldn't find any items that match search key.");
                return null;
            }
            else
                return findItems;
        }

        /// <summary>
        /// Prints all items in pawn shop
        /// </summary>
        public void PrintItems()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Prints all employees in pawn shop
        /// </summary>
        public void PrintEmployees()
        {
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Overriden Equlas method from object
        /// </summary>
        /// <param name="obj">object type PawnShop</param>
        /// <returns>true if objescts are equal or false
        /// if they are not equal</returns>
        public override bool Equals(object obj)
        {
            if (obj is PawnShop)
            {
                PawnShop other = (PawnShop)obj;
                if (this.name == other.name)
                    return true;
            }
            return false;
        }
    }
}
