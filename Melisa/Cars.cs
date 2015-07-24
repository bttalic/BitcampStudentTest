using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Cars : InventoryItem
    {
        string type;
        int year;
        string manufacturer;
        Condition condition;

        public enum Condition { perfectly, preserved, bad };

        public Cars(string name, string description, double price, string type, int year, string manufacturer, Condition condition)
            : base(name, description, price)
        {
            this.type = type;
            this.year = year;
            this.manufacturer = manufacturer;
            this.condition = condition;
        }

        public override string ToString()
        {
            return String.Format("Type: {0}\nYear: {1}\nManufacturer: {2}\nCondition: {3}", type, year, manufacturer, condition);
        }
    }
}
