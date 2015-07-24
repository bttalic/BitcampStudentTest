using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek10Day5
{
    class Watches:InventoryItem
    {
        public enum Material { gold, silver, rubber, etc }

        private string type;
        private string manufacturer;
        private int year;
        private Material material;
         public Watches(string itemDesc, string itemName,double itemPrice,string type, string manufacturer,int year,Material material): base
            (itemDesc, itemName, itemPrice)
        {
            this.type = type;
            this.manufacturer = manufacturer;
            this.year = year;
            this.material = material;
        }
         public override string ToString()
         {
             return base.ToString() +
                 String.Format("\nType:{0}\nManufacturer:{1}\nYear:{2}\nMaterial:{3}", type, manufacturer, year, material);
         }

    }
}
