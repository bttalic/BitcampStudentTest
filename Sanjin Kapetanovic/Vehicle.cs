using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public enum Type { Sedan = 1, SUV = 2, Limousine, Truck, Pickup };
    public enum Condition { Mint = 1, Good = 2 };
    class Vehicle : InventoryItem
    {
        private string manufacturer;
        private Type type;
        private int productionYear;
        private Condition condition;
        public Vehicle(string name, string description, int productionYear, double price, string manufacturer, string type, string condition)
            : base(name, description, price)
        {
            this.Description = description;
            this.manufacturer = manufacturer;
            Enum.TryParse(type, out this.type);
            Enum.TryParse(condition, out this.condition);
        }
        public override string ToString()
        {
            return String.Format("Name: {0}, ID: {1}, Manufacturer: {2}, Production year {3}, Type: {4}, Condition: {5}, Price: {6}\nDescription: {5})", Name, Id, manufacturer, productionYear, type, condition, Price, Description);
        }
    }
}
