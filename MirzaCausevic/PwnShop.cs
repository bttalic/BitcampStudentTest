using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop
{
    class PwnShop
    {
        public List<Inventory> inventory;
        
        public PwnShop()
        {
            this.inventory = new List<Inventory>();
        }


        public void AddToList (Inventory x)
        {
            inventory.Add(x);
            inventory.Sort();
        }
    }
}
