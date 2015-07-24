using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek10Day5
{
    class Cars:InventoryItem
    {
        public enum Details {excellent, good, bad}

        private string type;
        private string manufacturer;
        private int year;
        private Details details;

        public Cars(string itemDesc, string itemName,double itemPrice, string type, string manufacturer,int year,Details details): base
            (itemDesc, itemName, itemPrice)
        {
            this.type = type;
            this.manufacturer = manufacturer;
            this.year = year;
            this.details = details;
        }


        public override string ToString()
        {
            return base.ToString() +
                String.Format("\nType:{0}\nManufacturer:{1}\nYear:{2}\nDetails:{3}", type, manufacturer, year,details);
        }
        
    }
}
