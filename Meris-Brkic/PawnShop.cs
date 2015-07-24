using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest
{
    class PawnShop
    {
        
        private string names;
        private List<Employees> employees;
        public List<InventoryItem> inventoryItems;


        public PawnShop(string name)
        {
            this.names = name;
            employees = new List<Employees>();
            inventoryItems = new List<InventoryItem>();
        }

        /// <summary>
        /// method that adds employeee int the list
        /// </summary>
        /// <param name="a"></param>
        public void AddEmployee(Employees a)
        {
            employees.Add(a);
        
        }
        /// <summary>
        /// method that adds inventoyItems on the list
        /// </summary>
        /// <param name="a"></param>
        public void AddTtem(InventoryItem a)
        {
            inventoryItems.Add(a);
        }

        /// <summary>
        /// it sorts list InventoryItems
        /// </summary>
        public void SortInventoryItem()
        {

            inventoryItems.Sort();

        }

    }
}
