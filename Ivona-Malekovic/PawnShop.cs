using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class PawnShop
    {
        private List<InventoryItem> inventory = new List<InventoryItem>();
        private List<Employee> employees = new List<Employee>();


        public PawnShop()
        {
            this.inventory = new List<InventoryItem>();
            this.employees = new List<Employee>();
        }
        public List<InventoryItem> Inventory
        {
            get { return inventory; }

        }
        public List<Employee> Employees
        {
            get { return employees; }
        }


        public void AddInventoryItem(InventoryItem item)
        {
            inventory.Add(item);
            
        }

        public void AddEmployee(Employee e)
        {
            employees.Add(e);
            
        }


        public List<InventoryItem> Find(string s)
        {
            List<InventoryItem> items = new List<InventoryItem>();
           
            foreach (var i in inventory)
            {
                if (i.FitsSearch(s) != false)
                    items.Add(i);
            }
            return items;
        }


        public List<InventoryItem> SortByName()
        {
            List<InventoryItem> sortedByName = inventory.OrderBy(x => x.Name).ToList();
            return sortedByName;
        }

        public List<InventoryItem> SortByPrice()
        {
            List<InventoryItem> sortedByPrice = inventory.OrderBy(x => x.Price).ToList();
            return sortedByPrice;
        }







    }
}
