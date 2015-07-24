using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

namespace MiniTest
{
    class Clocks: InventoryItem
    {

        public enum Material { gold, silver, copper, plastic }
        public enum Period { Ancient, Modern };


        private string manufacturer;
        private Material material; 
        private Period period;


        public string Manufacturer { get; set; }
    
        public Clocks(string name, string description, int price, string manufacturer, Period period, Material material)
            : base(name, description, price)
        {
            this.manufacturer = manufacturer;     
            this.material = material;
            this.period = period;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format("\nManufacturer: {0}\nMaterial: {1}\nPeriod: {2}", manufacturer, material, period);
        }



    }
}
