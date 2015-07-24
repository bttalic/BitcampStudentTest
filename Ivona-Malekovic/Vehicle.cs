using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Vehicle : InventoryItem
    {
        private string type;
        private int yearManufactured;
        private string manufacturer;
        public enum Condition { perfect, preserved, bad };
        Condition condition;

        public Vehicle(string name, string description, double price, string type, int yearManufactured, string manufacturer, Condition condition) 
            : base (name, description, price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.type = type;
            this.yearManufactured = yearManufactured;
            this.manufacturer = manufacturer;
            this.condition = condition;
        }

   


        public override string ToString()
        {
            return String.Format("Name: {0}\nDescription: {1}\nPrice: {2}\nType: {3}\nYear Manufactured: {4}\nManufacturer: {5}\nCondition: {6} ", name, description, price, type, yearManufactured, manufacturer, condition);
        }

        

 

    }
}
