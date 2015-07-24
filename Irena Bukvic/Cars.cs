using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

namespace MiniTest
{
    class Cars: InventoryItem
    {
        public enum Condition { excellent, good, bad };

        private string type;
        private int year;
        private string manufacturer;
        private Condition condition;
        public string  Type { get; set; }
        public int Year { get; set; }
        public string Manufacturer { get; set; }

        public Cars(string name, string description, int price, string type, int year, string manufacturer, Condition condition)
            : base(name, description, price)
        {
            this.type = type;
            this.year = year;
            this.manufacturer = manufacturer;
            this.condition = condition;
        }

        public override string ToString()
        {
            return base.ToString()+String.Format("\nType: {0}\nYear: {1}\nManufacturer: {2},\nCondition: {3}", type, year, manufacturer, condition);
        }
        /// <summary>
        /// For serching cars on the basis of ther name or description
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public override bool fitsSearch(string s)
        {
            if (this.Name.Contains(s) || this.Description.Contains(s))
               
                return true;
            else
                return false;
        }
       

    }
}
