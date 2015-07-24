using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek10Day5
{
    abstract class InventoryItem:ISearchable
    {
        public static int INVITM_COUNT = 0;

        private int id;
        private string itemDesc;
        private string itemName;
        private double itemPrice;

        public  InventoryItem(string itemDesc, string itemName,double itemPrice)
        {
            this.id = ++INVITM_COUNT;
            this.itemDesc = itemDesc;
            this.itemName = itemName;
            this.itemPrice = itemPrice;
        }
        public int Id { get { return id; } }
        public string ItemDesc { get { return itemDesc; } set { itemDesc = value; } }
        public string ItemName{get { return itemDesc; } set { itemDesc = value; } }
        public string ItemPrice { get { return itemDesc; } set { itemDesc = value; } }


         public int CompareTo(object obj)
        {
            if (obj is InventoryItem)
            {
                InventoryItem other = (InventoryItem)obj;
                return this.itemName.CompareTo(other.itemName);
            }
            else
            {
                throw new ArgumentException("...");
            }
        }
         public ISearchable FitsSearch(string s)
         {
             if (this.ItemName.Contains(s) || this.ItemDesc.Contains(s))
                 return this;
             else
                 return null;
         }


          public override string ToString()
        {
            return string.Format("Id:{0}\nName: {1}\nDescription:{2}\nPrice:{3}", id, itemName, itemDesc, itemPrice);
        }
    }
}
    

