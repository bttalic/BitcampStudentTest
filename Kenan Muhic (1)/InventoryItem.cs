using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    /// <summary>
    /// implements isearchable
    /// </summary>
    class InventoryItem:ISearchable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        /// <summary>
        /// base constructor which defines name, description, price
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="price"></param>
        public InventoryItem(string name,string description,double price)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }
        /// <summary>
        /// empty constructor for entity recognision
        /// </summary>
        public InventoryItem()
        {

        }
        /// <summary>
        /// returns true if item name equals s
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public virtual bool FitsSearch(string s)
        {
            double price = -1;
            double.TryParse(s, out price);
            return this.Name.Contains(s) ||this.Price==price;
        }
        public override string ToString()
        {
            return string.Format("{0}: {3}\n{1}\n{2}", Id, Name, Description, Price);
        }
    }
}
