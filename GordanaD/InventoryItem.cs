using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace W10D05PawnShopTest
{
    public class InventoryItem : IComparable, MyISearchable
    {
        private static int ITEM_COUNT = 0;
        public int id { get; set; }
        public string itemName { get; set; }
        public int price { get; set; }
        public string description { get; set; }

       


        public InventoryItem(int id, string itemName, int price, string description)
        {
            this.id = ++ITEM_COUNT;
            this.itemName = itemName;
            this.price = price;
            this.description = description;
            
        }

        

        public override string ToString()
        {
            return string.Format("Item: {0}, Price: {1}, Description: {2}", itemName, price, description);
        }

        public virtual MyISearchable FitsSearch(string s)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// checking if object is falls under InventoryItem category and if it is the same as another object of the same category; we are using the id for confirmation
        /// </summary>
        /// <param name="obj">object we are verifying</param>
        /// <returns>returns true or falls</returns>

        public int CompareTo(object obj)
        {
            if (obj is InventoryItem)
            {
                InventoryItem other = (InventoryItem)obj;
                return this.itemName.CompareTo(other.itemName);
            }
            else
            {
                throw new ArgumentException("Obj is not Exponat");
            }
        }



        public virtual MyISearchable NameSearch(string s)
        {
            throw new NotImplementedException();
        }

        public virtual MyISearchable PriceSearch(int i)
        {
            throw new NotImplementedException();
        }



    }
}
