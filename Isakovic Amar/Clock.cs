using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W10D05_minitest
{
    class Clock:InventoryItem
    {
        public enum Material { gold=0, silver=1, rubber=2, rest=3}

        public int Age;
        public string Maker;
        public Material MadeOf;


        public Clock(string name, string details, int price, int age, string maker, Material m):base(name, details, price)
        {

            this.Age = age;
            this.Maker = maker;
            this.MadeOf = m;

        }

        public override string ToString()
        {
            return "ItemName:" + ItemName + "\n Details: " + Details + "\n Price" + price + "\n Age Old: " + Age + "\n Material " + MadeOf.ToString();
        }
    }
}
