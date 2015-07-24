using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest
{
    class PawnShop
    {

        private List <InventoryItem> inventoryItems;
        private List<Employee> employees; 

       
        public PawnShop ()
        {
            this.inventoryItems=new List<InventoryItem>();
            this.employees = new List<Employee>();
        }
        public List<InventoryItem> InventoryItem { get { return inventoryItems; } set{inventoryItems=value;}  }
        public List<Employee> Employee { get { return employees; } set { employees = value; } }

       
        /// <summary>
        /// Adds inventory to the lost
        /// </summary>
        /// <param name="it">inventory item </param>
        public void AddInventory(InventoryItem it)
        {
            inventoryItems.Add(it);
            inventoryItems.Sort();
        }
        /// <summary>
        /// adds employees to the list
        /// </summary>
        /// <param name="e">employees</param>
        public void AddEmployee(Employee e)
        {
            employees.Add(e);
            employees.Sort();
        }
    }
}
