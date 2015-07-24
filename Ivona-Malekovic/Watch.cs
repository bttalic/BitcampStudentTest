using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Watch : InventoryItem
    {
        public enum Material {gold, silver, rubber, other};
        Material material;
        private string manufacturer;
        private string period;

        public Watch(string name, string description, double price, Material material, string manufacturer, string period)
            : base(name, description, price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.material = material;
            this.manufacturer = manufacturer;
            this.period = period;
        }

        public override string ToString()
        {
            return String.Format("Name: {0}\nDescription: {1}\nPrice: {2}\nMaterial: {3}\nManufacturer: {4}\nPeriod: {5} ", name, description, price, material, manufacturer, period);
        }

        
    }
}
