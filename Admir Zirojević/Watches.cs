using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public enum Material { Gold = 1, Silver, Other };
    class Watches : InventoryItem
    {
        private Material material;
        private string maker;
        private int age;

        public Watches(string name,string description,double price,Material material, string maker, int age) : base (name,description,price)
        {
            this.material = material;
            this.maker = maker;
            this.age = age;
           
        }

        public Material Material { get { return material; } }
        public string Maker { get { return maker; } }
        public int Age { get { return age; } }

       

        public override string ToString()
        {
            return String.Format("Name {0} Description {1} Price {2} ID {3} Material {4} Maker {5} Age {6}",Name,Description,Price,InvetoryID,material,maker,age);
        }


    }
}
