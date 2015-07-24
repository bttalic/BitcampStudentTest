using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop
{
    /// <summary>
    /// Represents ona car in pawn shop
    /// </summary>
    public class Cars : InventoryItem
    {
        private string type;
        private int yearBuilt;
        private string manufacturer;
        private Condition condition;

        public Cars(string name, string description, double price, string type, int yearBuilt, string manufacturer, int condition) : base(name, description, price)
        {
            this.type = type;
            this.yearBuilt = yearBuilt;
            this.manufacturer = manufacturer;
            this.condition = (Condition)condition;
        }

        /// <summary>
        /// Overriden ToString method from object
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return string.Format("{0} \n{1} \n{2} \n{3} \n{4} \n{5} \n{6}", Name, Description, Price, type, yearBuilt, manufacturer, condition);
        }
    }
}
