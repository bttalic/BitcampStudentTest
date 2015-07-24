using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniTest
{
    class Watch:Inventory
    {

        
        private string manufactuirer;
        private int age;
        public enum enumMaterial { plastika = 1, metal, guma };
        private enumMaterial material;
        private bool parsing;
        public Watch(string name, int price, string desc
            , string enumMaterial, string manufacturer, int age) : base(name,price,desc)
        {
            this.parsing = Enum.TryParse(enumMaterial, out material); ;
            this.manufactuirer = manufacturer;
            this.age = age;
        
        }

        public override string ToString()
        {
            return string.Format("{0}. {1} {2} {3} {4} {5} {6}",id,name,price,desc, material,manufactuirer,age);
        }
    }
}
