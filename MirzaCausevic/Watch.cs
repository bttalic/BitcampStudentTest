using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop
{
    class Watch : Inventory
    {

        public enum Material {Gold, Silver, Plastic, Other }
        public int YearOfManufacture;
        public string maker;
        private Material material;
 

        public Watch(string name, string description, double price, int YearOfManufacture,
            string maker, Material material)
            : base (name,description,price)
        {
            this.YearOfManufacture = YearOfManufacture;
            this.maker = maker;
            this.material = material;
 
        }
        public override string ToString()
        {
            return base.ToString() +
                String.Format("YearOfManufacture: {0}\n Maker: {1}\n Material: {2}", YearOfManufacture, maker, material);
        }

    }
}
