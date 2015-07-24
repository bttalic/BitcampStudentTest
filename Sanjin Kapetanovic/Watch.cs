using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public enum Material { Gold = 1, Rubber = 2, Other };
    class Watch : InventoryItem
    {
        private string manufacturer;
        private int productionYear;
        private Material material;
        public Watch(string name, string description, int productionYear, double price, string manufacturer, string material)
            : base(name, description, price)
        {
            this.Description = description;
            this.manufacturer = manufacturer;
            Enum.TryParse(material, out this.material);
        }
        public override string ToString()
        {
            return String.Format("Name: {0}, ID: {1}, Manufacturer name: {2}, Material: {3}, Production year: {4}, Price: {5}\nDescription: {6})", Name, Id, manufacturer, material, productionYear, Price, Description);
        }
    }
}
