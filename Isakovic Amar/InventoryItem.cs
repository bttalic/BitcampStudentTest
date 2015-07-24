using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W10D05_minitest
{
    interface ISearchable
    {
        bool fitsSearch(string s);


    }


    class InventoryItem : IComparable<InventoryItem>, ISearchable
    {

       private static int ID = 0;
        public string ItemName;
        public string Details;
        public int price;


        public InventoryItem(string i, string d, int p)
        {
            ID = ID++;
            ItemName = i;
            this.price = p;
            this.Details = d;


        }

        public override string ToString()
        {
            return "ItemName:" + ItemName + "\n Details: " + Details + "\n Price" + price; 
        }


        public int CompareTo(InventoryItem other)
        {
            return String.Compare(this.ItemName, other.ItemName);
        }


        /// <summary>
        /// return id of object
        /// </summary>
        /// <returns></returns>
        public int GetId()
        { return ID; }
        /// <summary>
        /// Implemented by the interface, it returs weather the s contains in this object
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool fitsSearch(string s)
        {


            return this.ToString().Contains(s);
        }



        public override bool Equals(object obj)
         {
             if (obj is InventoryItem)
             {
                 InventoryItem test = (InventoryItem)obj;
                 if (this.GetId() == test.GetId()) return true;
                 else
                 { return false; }

             }
             else
             { return false; }
         }
    }

    //New class for comparison by price because default we compare it by name of the item!
     class Komparataor : IComparer<InventoryItem>
     {
       /// <summary>
       /// The way we compare the prices!
       /// </summary>
       /// <param name="price"></param>
       /// <param name="price2"></param>
       /// <returns></returns>
         public int Compare(InventoryItem price, InventoryItem price2)
        {



            if (price.price == price2.price) return 0;
            else if (price.price > price2.price) return 1;
            else return -1;


        }


         
    }

}
