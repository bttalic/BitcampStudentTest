using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop
{
    public abstract class Inventory 
    {
        private static int numberOfInventoryItems = 0;

        public int id;
        public string name;
        public string description;
        public double price;

        public Inventory(string name,string description, double price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.id = ++numberOfInventoryItems;
        }
        public override string ToString()
        {
            return String.Format("{0}: Name: {1}\n Description: {2}\n Price: {3} ", id, name, description, price);
        }
    }
}
