using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek10Day5
{
    class PawnShop
    {
        private List<InventoryItem> inventoryitem;
        private List<Employee> employees;
        public PawnShop()
        {
            this.inventoryitem = new List<InventoryItem>();
            this.employees = new List<Employee>();
        }

        public List<InventoryItem> InventoryItem{ get { return inventoryitem; } }


        public void AddExponat(InventoryItem i)
        {
            inventoryitem.Add(i);
            inventoryitem.Sort();
        }

    }
}
