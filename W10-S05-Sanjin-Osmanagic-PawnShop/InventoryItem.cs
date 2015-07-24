using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop
{   
    public class InventoryItem
    {
        static int InventoryCounter = 0;
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public InventoryItem(string name, string description, double price)
        {
            this.Id = InventoryCounter++;
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }

        /// <summary>
        /// Method returns all properties from class InventoryItem
        /// </summary>
        /// <returns>String which has description about InventoryItem object</returns>
        public override string ToString()
        {
            return String.Format("Id: {0}\nName: {1}Description: {2}\nPrice: {3} USD\n",Id,Name,Description,Price);
        }
    }
}
