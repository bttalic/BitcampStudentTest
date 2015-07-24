using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniTest
{
    class Inventory:IComparable<Inventory>
    {

        static int INV_ID = 0;

        protected string name;
        protected string desc;
        protected int price;
        protected int id;


        public Inventory(string name,int price,string desc)
        {
            this.name = name;
            this.price = price;
            this.desc = desc;
            this.id = ++INV_ID;
        
        }
        public string Name { get; set; }
        public int Id { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return string.Format("{0}. {1} {2} {3}",id,name,desc,price);
        }
        public int CompareTo(Inventory other)
        {
            return this.Name.CompareTo(other.Name);
        }
       

        
    }
}
