using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Test
{
   abstract class Inventory : ISearchable<Inventory>
    {
        protected static int Inventory_Count = 0;

        private int id;
        private string name;
        private string description;
        private string price;

        public string Name { get {return name;} }
        public string Description { get { return description; } }
        public string Price { get { return price; } }

        public Inventory(string name, string description, string price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.id = Inventory_Count;
        }

        public override string ToString()
        {
            return String.Format("{0}: {1}, {2}, {3}", id, name, description, price);
        }

        /// Method from ISearchable interface
        /// Method checks if inputed string is same as
        /// inventory name,price or id
       /// </summary>
        /// <param name="s">Name,price or id</param>
       /// <returns></returns>
        public Inventory FitsSearch(string s)
        {
            if (this.name == s)
            {
                return this;
            }
            if (this.price == s)
            {
                return this;
            }
            if (this.id.ToString() == s)
            {
                return this;
            }
            return null;
        }

    }
}
