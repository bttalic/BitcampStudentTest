using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    abstract class InventoryItem : IComparable<InventoryItem>, ISearchable<InventoryItem>
    {
        public static int INV_ID = 0;
        private int id;
        private string name;
        private string descritpion;
        private double price;
        public InventoryItem(string name, string description, double price)
        {
            this.Id = ++INV_ID;
            this.Name = name;
            this.Description = description;
            this.price = price;
        }
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return descritpion; } set { descritpion = value; } }
        public double Price { get { return price; } set { price = value; } }
        public override bool Equals(object obj)
        {
            if (obj is InventoryItem)
            {
                InventoryItem tmp = (InventoryItem)obj;
                if (tmp.Id == this.Id)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
        public int CompareTo(InventoryItem other)
        {
            return this.Name.CompareTo(other.Name);
        }
        /// <summary>
        /// Method that takes string and check if is matching with name, id or description
        /// </summary>
        /// <param name="s"></string>
        /// <returns></this object if matchs or null if not>
        public InventoryItem FitsSearch(string s)
        {
            if (this.Name.Contains(s)
                || this.Description.Contains(s)
                || this.Id.ToString() == s)
                return this;
            return null;
        }
    }
}
