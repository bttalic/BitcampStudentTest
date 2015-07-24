using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_24_07
{
    class Clocks : InventoryItem, ISearchable
    {
        public enum Material { Gold, Silver, Rubber, Other }

        private string manufacturer;
        private int age;
        private Material material;

        public Clocks (string name, string description, int price, string manufacturer, int age, Material material) : base (name, description, price)
        {
            this.manufacturer = manufacturer;
            this.age = age;
            this.material = material;
        }

        public string Manufacturer { get { return manufacturer; } set { manufacturer = value; } }
        public int Age { get { return age; } set { age = value; } }

        public override string ToString()
        {
            return String.Format("Manufacturer: {0}\nAge: {1}\nMaterial : {2}", manufacturer, age, material);
        }

        public override bool FitsSearch(string s)
        {
            if (this.Name.Contains(s) || this.Price.Equals(s) || this.Manufacturer.Contains(s) || this.Age.Equals(s))
                return true;
            else
                return false;
        }
    }
}
