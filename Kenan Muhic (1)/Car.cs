using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    /// <summary>
    /// inherits inventoryitem and implements isearchable
    /// </summary>
    class Car:InventoryItem
    {
        public string Type { get; set; }
        public int Age { get; set; }
        public string Manufacturer { get; set; }
        public enum Condition { novo, ocuvano, lose };
        public Condition condition { get; set; }
        /// <summary>
        /// adds values for all global variables
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="price"></param>
        /// <param name="type"></param>
        /// <param name="age"></param>
        /// <param name="manufacturer"></param>
        /// <param name="condition"></param>
        public Car(string name,string description,double price, string type,int age, string manufacturer, Condition condition)
            :base(name,description,price)
        {
            this.Type = type;
            this.Age = age;
            this.Manufacturer = manufacturer;
            this.condition = condition;
        }
        //for entity 
        public Car()
        {

        }
        /// <summary>
        /// overrides base fitssearch method for manufacturer and type string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public override bool FitsSearch(string s)
        {
            return base.FitsSearch(s) || this.Manufacturer.Contains(s) || this.Type.Contains(s);
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("\n{0},{1},{2},{3}", this.Type, Age, Manufacturer, condition);
        }
    }
}
