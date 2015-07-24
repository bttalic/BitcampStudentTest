using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Test
{
    class PawnShop
    {
        public List<Inventory> inventory;

        private List<Employee> employee;

        public PawnShop()
        {
            this.inventory = new List<Inventory>();
            this.employee = new List<Employee>();
        }

        public List<Inventory> AllInventory { get { return inventory; } }
        public List<Employee> AllEmployees { get { return employee; } }


    }


}
