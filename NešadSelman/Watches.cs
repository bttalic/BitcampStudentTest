using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Watches : Inventory          //klasa watches nasljedjuje klasu inventory
    {
        private string material;
        private string manufacturer;
        private int age;
       


        public Watches(string material, string manufacturer, int age,int id, string name, string description, double price  ) : base (id, name,description,price)
        {
            this.material = material;
            this.manufacturer = manufacturer;
            this.age = age;
          
        }



        public string Material { get { return material; } }
        public string Manufacturer { get { return manufacturer; } }
        public int Age { get { return age; } }



        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}", material, manufacturer, age);
        }
    }
}
