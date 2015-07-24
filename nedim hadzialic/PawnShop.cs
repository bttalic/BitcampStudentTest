using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniTest
{
    class PawnShop
    {

        List<Inventory> inventory;
        List<Employe> employes;


        public PawnShop()
        {
            this.employes = new List<Employe>();
            this.inventory = new List<Inventory>();
        
        }

        public List<Employe> AllEmployes { get{ return employes; }}
        public List<Inventory> AllInventory { get { return inventory; } }
    }
}
