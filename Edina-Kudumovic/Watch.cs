using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest
{
    class Watch : Inventory
    {
        public enum Material { Gold, Silver, Tires}

        private Material material;
        private string manufacturer;
        private int age;


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="description">description</param>
        /// <param name="price">price</param>
        /// <param name="material">material</param>
        /// <param name="manufacturer">manufacturer</param>
        /// <param name="age">age</param>
        public Watch(string name, string description, double price, Material material, string manufacturer, int age) : base(name, description, price)
        {
            this.material = material;
            this.manufacturer = manufacturer;
            this.age = age;
        }

        public string Manufacturer { get { return manufacturer; } set { manufacturer = value; } }

        public int Age { get { return age; } }

        /// <summary>
        /// Returns string representation of the Vehicle
        /// </summary>
        /// <returns>string containing all the vehicle data</returns>
        public override string ToString()
        {
            return String.Format("{0}: {1}, {2}, {3}, {4}, {5}, {6}", Id, Name, Description, Price, material, manufacturer, age);
        }

        /// <summary>
        /// Search for name in watches 
        /// </summary>
        /// <param name="s">some string</param>
        /// <returns></returns>
        public override ISearchable FitsSearch(string s)
        {
            if (this.Name.Contains(s))
            {
                return this;
            }
            else
            {
                return null;
            }
        }
    }
}
