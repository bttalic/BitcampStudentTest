using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop
{
    public enum Material { Gold, Silver, Rubber, Other };
    public class Watch : InventoryItem
    {
        public Enum Material { get; set;}
        public string Manufacturer { get; set; }

        public int Age { get; set; }

        public Watch(string name, string description, double price, Enum material, string manufacturer, int age)
            :base (name, description, price)
        {
            this.Material = material;
            this.Manufacturer = manufacturer;
            this.Age = age;
        }

        /// <summary>
        /// Method returns all properties from class Watch and its inherited class)
        /// </summary>
        /// <returns>String which has description about Watch object</returns>
        public override string ToString()
        {
            return String.Format("Id: {0}\nName: {1}Description: {2}\nPrice: {3} USD\nMaterial: {4}\nManufacturer: {5}\nAge: {6}\n", this.Id, this.Name, this.Description, this.Price, Material, Manufacturer, Age);
        }
    }
}
