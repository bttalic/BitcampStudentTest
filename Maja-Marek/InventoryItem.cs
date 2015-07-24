using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_24_07
{
    public abstract class InventoryItem : ISearchable
    { 
         private static int ID_Count = 0;

         private int id;
         private string name;
         private string description;
         private int price;
         

        public InventoryItem (string name, string description, int price)
        {
            this.id = ++ID_Count;
            this.name = name;
            this.description = description;
            this.price = price;
           
        }

        public string Name {get {return name;} set {name = value;}}
        public string Description { get { return description; } set { description = value; } }
        public int Price { get { return price; } set { price = value; } }
        private int Id { get { return id; } }

        public override bool Equals(object obj)
        {
            if (obj is InventoryItem)
            {
                InventoryItem other = (InventoryItem)obj;
                return this.id == other.id;
            }
            else
            {
                return false;
            }
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
                throw new ArgumentException("Not in inventory!");
            }
        }

        public override string ToString()
        {
            return String.Format("{0}: Name: {1}\nDescription: {2}\nPrice : {3}", id, name, description, price);
        }

        public virtual ISearchable FitsSearch(string s)
        {
            throw new NotImplementedException();
        }
    }
}
