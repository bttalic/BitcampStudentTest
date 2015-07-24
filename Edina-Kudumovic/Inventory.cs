using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest
{
    class Inventory : ISearchable
    {
        private static int Inventory_Count = 1;

        private string name;
        private string description;
        private double price;
        private int id;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="description">description</param>
        /// <param name="price">price</param>
        public Inventory(string name, string description, double price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.id = Inventory_Count++;
        }

        /// <summary>
        /// Constructor's Name
        /// </summary>
        public string Name { get { return name; } set { name = value; } }

       /// <summary>
       /// Constructor Description
       /// </summary>
        public string Description { get { return description; } set { description = value; } }

        /// <summary>
        /// Constructor's price
        /// </summary>
        public double Price { get { return price; } }

        public int Id { get { return id; } }


        /// <summary>
        /// Checks if Inventory equals other
        /// </summary>
        /// <param name="obj">other object</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Inventory)
            {
                Inventory other = (Inventory)obj;
                return this.id == other.id;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns string representation of the Inventory
        /// </summary>
        /// <returns>string containing all the inventory data</returns>
        public override string ToString()
        {
            return string.Format("{0}: Name: {1}\nDescription: {2}\nPrice: {3}\n", id, name, description, price);
        }

        /// <summary>
        /// interface for search inventories
        /// </summary>
        /// <param name="s">string s</param>
        /// <returns></returns>
        public virtual ISearchable FitsSearch(string s)
        {
            throw new NotImplementedException();
        }
    }
}
