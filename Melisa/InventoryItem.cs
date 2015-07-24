using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class InventoryItem : IComparable, ISearchable
    {
        private static int ID_COUNT = 0;

        private int id;
        private string name;
        private string description;
        private double price;

        public int Id { get { return id; } }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }


        public InventoryItem(string name, string description, double price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.id = ++ID_COUNT;
        }


        public override bool Equals(object obj)
        {
            if (obj is InventoryItem)
            {
                InventoryItem other = (InventoryItem)obj;
                return this.id.CompareTo(other.id) == id;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checking if the object exists, and if it doesn't throwing an argument
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is InventoryItem)
            {
                InventoryItem other = (InventoryItem)obj;
                return this.name.CompareTo(other.name);
            }
            else
            {
                throw new ArgumentException();
            }
        }
        /// <summary>
        /// True if the object is found, and false if it isn't
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>

        public bool fitsSearch(string s)
        {
            if (this.name.Contains(s))
                return true;
            else
            return false;
        }

        public override string ToString()
        {
            return String.Format("{0}: Name: {1}\nDescription: {2}\n Price: {3}$",
                id, name, description, price);
        }

      
        

    }
}
