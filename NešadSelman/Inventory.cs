using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Inventory : ISearchable
    {

        private static int INVENTORY_COUNT = 0;

        private int id;
        private string name;
        private string description;
        private double price;


        public Inventory(int id, string name, string description, double price)
        {
            this.id = ++INVENTORY_COUNT;
            this.name = name;
            this.description = description;
            this.price = price;
        }


        public int Id { get { return id; } }

        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }
        public double Price { get { return price; } set { price = value; } }



        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}, {3}", id, name, description,price);
        }


         public override bool Equals(object obj)
       {
           if (obj is Inventory)
           {
               Inventory other = (Inventory)obj;
               return this.id == other.id;
           } else 
           {
              return false;
           }       
         }

        public virtual ISearchable Search(string s)
        {
            throw new NotImplementedException();
        }

       
       

    }
}
