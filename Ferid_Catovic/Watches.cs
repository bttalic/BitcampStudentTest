using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest
{
    class Watches : InventoryItem
    {
        private string material { get; set; }
        private string wfact { get; set; }
        private int age { get; set; }


        public Watches(string name, string desc, int price, string material, string wfact, int age)
            : base(name, desc, price)
        {
            this.material = material;
            this.wfact = wfact;
            this.age = age;
        }


        public override string ToString()
        {
            return String.Format("Material: {0}\nManufacturer: {1}\nAge: {2}", material, wfact, age);
        }



        public override ISearchable FitsSearch(string s)
        {
            if (this.material.Contains(s) || this.wfact.Contains(s))
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
