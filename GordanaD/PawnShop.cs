using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W10D05PawnShopTest
{
    class PawnShop
    {
        public List<InventoryItem> inventoryItems;
        
        public PawnShop()
        {
            this.inventoryItems = new List<InventoryItem>();
        }

        public List<InventoryItem> inventoryItems { get { return inventoryItems; } }


        public void AddItem (InventoryItem ie)
        {
            inventory.Add(ie);
            inventory.Sort();
        }


        /// <summary>
        /// the method goes throught the inventory list (itemName fields only) and compares them against the string provided
        /// </summary>
        /// <param name="s">string we are comparing against the item names</param>
        /// <returns>returns a list of items meeting the criteria</returns>
        public List<MyISearchable> FindName(string s)
        {
            List<MyISearchable> inventory = new List<MyISearchable>(inventoryItems);

            List<MyISearchable> results = new List<MyISearchable>();
            foreach (MyISearchable item in inventoryItems)
            {
                if (item.NameSearch(s) != null)
                    results.Add(item);
            }
            return results;
        }


        /// <summary>
        /// the method goes throught the inventory list (prive fields only) and compares them against the int provided
        /// </summary>
        /// <param name="i">integer (price) used as a search criteria</param>
        /// <returns>returns a list of items meeting the criteria</returns>
        public List<MyISearchable> FindPrice(int i)
        {
            List<MyISearchable> inventory = new List<MyISearchable>(inventoryItems);

            List<MyISearchable> results = new List<MyISearchable>();
            foreach (MyISearchable item in inventoryItems)
            {
                if (item.PriceSearch(i) != null)
                    results.Add(item);
            }
            return results;
        }



        public IEnumerable<InventoryItem> InventoryItem { get; set; }
    }
}
