using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PownShop
{
    class InventoryItem :IComparable, ISearchable<InventoryItem>
    {
        static int countId = 0;

        private int id;
        private string title;
        private string description;
        private double price;

        public int Id { get { return id; } }
        public string Title { get { return title; } set { title = value; } }
        public string Description { get { return description; } set { description = value; } }
        public double Price { get { return price;  } }

        public InventoryItem(string title,string description,double price)
        {
            this.title = title;
            this.description = description;
            this.price = price;
            this.id = ++countId;
        }

        /// <summary>
        /// Overrided ToString method which return string with basic information about InventoryItem object
        /// </summary>
        /// <returns>string (basic information)</returns>
        public override string ToString()
        {
            return String.Format("Id : {0}\nTitle : {1}\nPrice : {2}\nDescription : {3}\n",Id,Title,Price,Description);
        }
        /// <summary>
        /// Method implemented from interface ISearchable
        /// Returns object InventoryItem which contains in its title, string sended as parameter
        /// </summary>
        /// <param name="s">string sended as parameter</param>
        /// <returns>InventoryItem object</returns>
        public InventoryItem FitsSearch(string s)
        {
            if (this.Title.ToLower().Contains(s))
            {
                return this;
            }
            return null;
        }
        /// <summary>
        /// Method implemented from interface ISearchable
        /// Returns object InventoryItem which contains in its price, double price sended as parameter
        /// </summary>
        /// <param name="s">string sended as parameter</param>
        /// <returns>InventoryItem object</returns>
        public InventoryItem FitsSearch(double d)
        {
            if (this.Price<=d)
            {
                return this;
            }
            return null;
        }
        /// <summary>
        /// Method implemented from Interface IComparable
        /// return -1,0 or 1 if this object is smaller, eqal or larger than parameters object
        /// In this case, InventoryItems title
        /// </summary>
        /// <param name="obj">object as parameter</param>
        /// <returns>integer (-1,0,1)</returns>
        public int CompareTo(object obj)
        {
            if (!(obj is InventoryItem))
            {
                throw new ArgumentException("Object ic not an Inventory item.");
            }
            InventoryItem other = (InventoryItem)obj;
            return this.Title.CompareTo(other.Title);
        }
        
    }
}
