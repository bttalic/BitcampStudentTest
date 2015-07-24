using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;


namespace MiniTest
{
    public abstract class InventoryItem : IComparable
    {
        private static int COUNT = 0;

        private int id;
        private string name;
        private string description;
        private int price;

        public string  Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }


        public InventoryItem(string name, string description, int price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.id = ++COUNT;

        }
        /// <summary>
        /// compares inventory items in a list
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
                throw new ArgumentException("...");
            }
        }

          public override string ToString()
        {
            return string.Format("Id {0}: Name: {1}\nDescription:{2}\nPrice:{3}",id, Name,Description,Price);
        }

          public virtual bool fitsSearch(string s)
          {
              throw new NotImplementedException();
          }
    }
}
