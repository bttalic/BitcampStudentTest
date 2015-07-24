using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{  
    class Watch : InventoryItem
    {
        string manufacturer;
        string period;
        Material material;

        public enum Material { gold, silver, rubber };

        public Watch(string name, string description, double price, string manufacturer, string period, Material material)
            : base(name, description, price)
        {
            this.manufacturer = manufacturer;
            this.period = period;
            this.material = material;
        }

        public override string ToString()
        {
            return String.Format("Manufacturer: {0}\nPeriod: {1}\nMaterial: {2}",manufacturer, period, material);
        }
    }
}
