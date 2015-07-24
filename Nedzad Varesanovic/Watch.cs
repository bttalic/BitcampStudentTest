using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PownShop
{
    public enum Material{Gold,Silver,Rubber,Other}
    public enum Age { Classic, Modern }
    class Watch : InventoryItem
    {
        private Material material;
        private string manufacturer;
        private Age dateOrigin;

        public Material Material { get { return material; } }
        public string Manufacturer { get { return manufacturer; } }
        public Age DateOrigin { get { return dateOrigin; } }

        public Watch(string title, string description, double price,int material,string manufacturer, int dateOrigin):base(title,description,price)
        {
            this.material = (Material)material;
            this.manufacturer = manufacturer;
            this.dateOrigin = (Age)dateOrigin;
        }
        /// <summary>
        /// Overrided ToString method which return string with basic information about Watch object
        /// </summary>
        /// <returns>string (basic information)</returns>
        public override string ToString()
        {
            string item = base.ToString();
            return String.Format(item + "Material : {0}\nManufacturer : {1}\nTime of origin : {2}", Material, Manufacturer, DateOrigin);
        }
    }
}
