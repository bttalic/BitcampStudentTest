using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest
{
    class InventoryItem//:IComparable<InventoryItem>
    {
        public static int id = 0;
        public string name;
        public string details;
        public int price;


        public InventoryItem(string n, string d, int p)
        {
            name = n;
            details = d;
            price = p;
            id = id++;
        }



        /// <summary>
        /// Return id inventoryItem
        /// </summary>
        /// <returns></returns>

        public int GetId()
        { return id; }


        public override string ToString()
        {
            return "Name "+name+"Details"+details+"Price"+price;
        }

    }

}
