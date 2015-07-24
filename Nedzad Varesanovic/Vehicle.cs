using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PownShop
{
    public enum Condition { Perfect, Ok, Poor }
    class Vehicle : InventoryItem
    {
        private string type;
        private int productionYear;
        private string manufacturer;
        private Condition condition;

        public string Type { get { return type; } }
        public int ProductionYear { get { return productionYear; } }
        public string Manufacturer { get { return manufacturer; } }
        public Condition Condition { get { return condition; } set { condition = value; } }

        public Vehicle(string title,string description,double price,string type,int productionYear,string manufacturer, int condition):base(title,description,price)
        {
            this.type = type;
            this.productionYear = productionYear;
            this.manufacturer = manufacturer;
            this.condition = (Condition)condition;
        }
        /// <summary>
        /// Overrided ToString method which return string with basic information about Vehicle object
        /// </summary>
        /// <returns>string (basic information)</returns>
        public override string ToString()
        {
            string item = base.ToString();
            return String.Format(item + "Type : {0}\nYear of production : {1}\nManufacturer : {2}\nCondition : {3}", Type, ProductionYear, Manufacturer, Condition);
        }

    }
}
