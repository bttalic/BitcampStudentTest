using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest
{
    class InventoryItem : ISearchable<InventoryItem>, IComparable<InventoryItem>
    {
        
        private int id;
        private string name;
        private string description;
        private double price;

        protected static int AUTO_ID = 0;

        public InventoryItem(string name, string description, double price)
        {
            id = ++AUTO_ID;
            this.name = name;
            this.description = description;
            this.price = price;

        }


        public int AID { get { return AUTO_ID; } set{  AUTO_ID = value; } }

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } }
        public string Description { get { return description; } }
        public double Price { get { return price; } }




        public InventoryItem SearchByName(string s)
        {
            if (this.name == s)
            {
                return this;
            }
            
            return null;
        }


        public InventoryItem SearchByPrice(double p)
        {
            if (this.price == p)
            {
                return this;
            }

            return null;
        }


        public int CompareTo(InventoryItem other)
        {

            return this.name.CompareTo(other.name);


        }


        public override string ToString()
        {
            return string.Format("{0}. {1} - {2} ", id, name, description, price);
        }

    }
}
