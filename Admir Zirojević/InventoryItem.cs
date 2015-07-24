using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class InventoryItem : ISearchable
    {
        private static int ID = 1;

        private int inventoryID;
        private string name;
        private string description;
        private double price;
        private List<Watches> watches;
        private List<Cars> cars;

        public InventoryItem(string name,string description,double price) 
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.inventoryID = ID++;
            this.watches = new List<Watches>();
            this.cars = new List<Cars>();
        }

        public int InvetoryID { get { return inventoryID; } }
        public double Price { get { return price; } }
        public string Description { get { return description; } }
        public string Name { get { return name; } }


        public override bool Equals(object obj)
        {
            if (obj is InventoryItem)
            {
                InventoryItem other = (InventoryItem)obj;
                if (this.inventoryID.Equals(other.inventoryID))
                    return true;
                else return false;
            }
            else
            {
                return false;
            }

        }


        public override string ToString()
        {
            return String.Format("Name {0} Description {1} Price {2} ID {3} ", Name, Description, Price, InvetoryID);
        }

        public ISearchable fitsSearch(string s)
        {
            if (this.Name.Contains(s) || this.Description.Contains(s))
                return this;
            else
                return null;
        }
    }
}
