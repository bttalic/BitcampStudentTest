using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop
{
    public enum Condition { perferct, preserved, bad};  //public enums for items
    public enum Material { gold, silver, rubber, other};
    
    /// <summary>
    /// Represents inventory item in pawn shop
    /// </summary>
    public class InventoryItem : ISearchable
    {
        private static int ID = 0;
        private int id;
        private string name;
        private string description;
        private double price;

        

        public InventoryItem(string name, string description, double price)  //class constructor
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.id = ++ID;
        }

        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        /// <summary>
        /// Implemented method from interface
        /// Isearcheable
        /// </summary>
        /// <param name="s">serach key</param>
        /// <returns>true if name or price containes
        /// search key or false if they don't 
        /// contain it</returns>
        public bool FitsSearch(string s)
        {
            if (this.name.Contains(s))
                return true;
            else if (this.price.ToString().Contains(s))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Overriden Equals method from object
        /// </summary>
        /// <param name="obj">object type InventoryItem</param>
        /// <returns>true if objects are equal or false
        /// if they are not equal</returns>
        public override bool Equals(object obj)
        {
            if (obj is InventoryItem)
            {
                InventoryItem other = (InventoryItem)obj;
                if (this.id == other.id)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Overriden ToString method from object
        /// </summary>
        /// <returns>string with name, description and price
        /// of item</returns>
        public override string ToString()
        {
            return string.Format("{0} \n{1} \n{2}", name, description, price);
        }
    }
}
