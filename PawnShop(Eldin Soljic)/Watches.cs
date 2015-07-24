using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop
{
    /// <summary>
    /// Represents on watch in pawn shop
    /// </summary>
    public class Watches : InventoryItem
    {
        private Material material;
        private string manufacturer;
        private int age;

        public Watches(string name, string description, double price, int material, string manufacturer, int age) : base(name, description, price)
        {
            this.material = (Material)material;
            this.manufacturer = manufacturer;
            this.age = age;
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public Material Material
        {
            get { return material; }
            set { material = value; }
        }

        /// <summary>
        /// Overriden ToString method from object
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return string.Format("{0} \n{1} \n{2} \n{3} \n{4} \n{5}", Name, Description, Price, material, manufacturer, age);
        }
    }
}
