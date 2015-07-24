using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class InventoryItem : ISearchable, IComparable
    {
        private static int ID_COUNT = 0;
        private int id;
        protected string name;
        protected string description;
        protected double price;


        public InventoryItem(string name, string description, double price)
        {
            this.id = ++ID_COUNT;
            this.name = name;
            this.description = description;
            this.price = price;

        }


        public string Name
        {
            get { return name; }
        }

        public string Description
        {
            get { return description; }
        }

        public double Price
        {
            get { return price; }
        }



        public override bool Equals(object obj)
        {
            if (obj is InventoryItem)
            {
                InventoryItem other = (InventoryItem)obj;
                if (this.id == other.id)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }



        public int CompareTo(object obj)
        {
            if (obj is InventoryItem)
            {
                InventoryItem other = (InventoryItem)obj;
                return this.name.CompareTo(other.name);
            }
            else
            {
                throw new ArgumentException("Obj is not Exponat");
            }

        }



        public override string ToString()
        {
            return String.Format("Name: {0}\nDescription: {1}\nPrice: {2}", name, description, price);
        }


        
        public bool FitsSearch(string s)
        {
            if (this.Name.Contains(s))             
                return true;
            else
                return false;
        }

       



       
    }
}
