using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PownShop
{
    class PawnShop
    {
        private List<InventoryItem> inventory;
        private List<Employee> employees;

        public List<InventoryItem> Inventory { get { return inventory; } }
        public List<Employee> Employees { get { return employees; } }

        public PawnShop()
        {
            this.inventory = new List<InventoryItem>();
            this.employees = new List<Employee>();
        }
        /// <summary>
        /// Method recive InventoryItem object as parameter and adds it to Inventory list.
        /// </summary>
        /// <param name="toAdd">InventoryItem object to add</param>
        public void AddItem(InventoryItem item)
        {
            Inventory.Add(item);
            Inventory.Sort();
        }
        /// <summary>
        /// Method recive Employee object as parameter and adds it to Employees list.
        /// </summary>
        /// <param name="toAdd">Employee object to add</param>
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
            Employees.Sort();
        }
    }
}
