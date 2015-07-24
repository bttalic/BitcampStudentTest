using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10D05_Test
{
    class Watches : InventoryItem
    {
        public enum Materials { Gold, Silver, Rubber, Other };

        private string maker;

        private int yearsOld;

        private Materials material;

        public string Maker { get {return maker;} set {maker = value;} }

        public int YearsOld { get { return yearsOld; } set { yearsOld = value; } }

        public Materials Material { get { return material; } set { material = value; } }


        public Watches(string name, string description, double price, string maker, int yearsOld, Materials material)
            : base(name, description, price)
        {
            this.maker = maker;
            this.yearsOld = yearsOld;
            this.material = material;
        }

        public override string ToString()
        {
            return string.Format("{0}:\n Name: {1}\n Description: {2}\n Price: {3}\n Maker: {4}\n Years Old: {5}\n Material: {6}", Id, Name, Description, Price, maker, yearsOld, material);
        }

    }
}
