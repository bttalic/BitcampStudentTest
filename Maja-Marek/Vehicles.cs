using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_24_07
{
    class Vehicles : InventoryItem, ISearchable
    {
        public enum Condition { Perfect, Good, Poor }

        private string type;
        private int year;
        private string manufacturer;
        private Condition condition;
        
        public Vehicles (string name, string description, int price, string type, int year, string manufacturer, Condition condition) : base (name, description, price)
        {
            this.type=type;
            this.year = year;
            this.manufacturer = manufacturer;
            this.condition = condition;
        }

        public string Type { get { return type; } set { type = value; } }
        public int Year { get { return year; } set { year = value; } }
        public string Manufacturer { get { return manufacturer; } set { manufacturer = value; } }

        public override string ToString()
        {
            return String.Format("Type: {0}\nYear: {1}\nManufacturer : {2}\nCondition: {3}", type, year, manufacturer, condition);
        }

        public override bool FitsSearch(string s)
        {
            if (this.Name.Contains(s) || this.Price.Equals(s) || this.Year.Equals(s) || this.Type.Contains(s) || this.Manufacturer.Contains(s))
                return true;
            else
                return false;
        }
    }
}
