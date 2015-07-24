using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest
{
    class Vehicle : Inventory
    {
        public enum Condition {Perfectly, Preserved, Bad}

        private string type;
        private int yearBuilt;
        private string manufacturer;
        private Condition condition;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="description">description</param>
        /// <param name="price">pricfe</param>
        /// <param name="type">type</param>
        /// <param name="yearBuilt">yearBuilt</param>
        /// <param name="manufacturer">manufacturer</param>
        /// <param name="condition">condition</param>
        public Vehicle(string name, string description, double price, string type, int yearBuilt, string manufacturer, Condition condition) 
            : base(name, description, price)
        {
            this.type = type;
            this.yearBuilt = yearBuilt;
            this.manufacturer = manufacturer;
            this.condition = condition;
        }


        public string Type {get {return type;} set{type = value;} }

        public int YearBuilt {get {return yearBuilt;} set{yearBuilt = value;} }

        public string Manufacturer {get {return manufacturer;} set{manufacturer = value;} }


        /// <summary>
        /// Returns string representation of the Vehicle
        /// </summary>
        /// <returns>string containing all the vehicle data</returns>
        public override string ToString()
        {
            return String.Format("{0}: {1}, {2}, {3}, {4}, {5}, {6}, {7}", Id, Name, Description, Price, type, yearBuilt, manufacturer, condition);
        }

        /// <summary>
        /// Search for name in watches 
        /// </summary>
        /// <param name="s">some string</param>
        /// <returns></returns>
        public override ISearchable FitsSearch(string s)
        {
            if (this.Name.Contains(s))
            {
                return this;
            }
            else
            {
                return null;
            }
        }
    }
}
