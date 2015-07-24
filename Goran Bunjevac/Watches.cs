using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Test
{
    class Watches : Inventory
    {
        private string manufacturer;
        private enumAge age;
        private enumMaterial material;
        private int id;
        private bool parsing;

        public enum enumMaterial { Gold = 1, Silver = 2, Rubber = 3, Other = 4 };
        public enum enumAge { Modern = 1, Postmodern = 2 };
        public string Manufacturer { get { return manufacturer; } }


        public Watches(string name, string description, string price, string manufacturer, string materialstring, string agestring)
            : base(name, description, price)
        {
            this.manufacturer = manufacturer;
            this.id = ++Inventory_Count;
            this.parsing = Enum.TryParse(agestring, out age);
            this.parsing = Enum.TryParse(materialstring, out material);
        }

        public override string ToString()
        {
            return String.Format("{0}: {1}, {2}, {3}, {4}, {5}, {6}", id, Name, Description, Price, manufacturer, material, age);
        }
    }
}
