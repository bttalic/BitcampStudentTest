using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10D05_Test
{
    class InventoryItem : ISearcbable
    {
        private static int COUNT = 1;

        private string name;

        private string description;

        private double price;

        private int id;

        public string Name { get { return name; } }
        public string Description { get { return description; } }

        public double Price { get { return price; } }

        public int Id { get { return id; } }

        public InventoryItem(string name, string description, double price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.id = COUNT++;
        }

        // Search if item is in the inventory.
        public bool fitsSearch(string s)
        {
            if (s.Equals(name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
