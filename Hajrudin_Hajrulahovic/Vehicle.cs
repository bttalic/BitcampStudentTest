using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace W10D05PawnShopTest
{
    class Vehicle: InventoryItem
    {
        private string model;
        private int productionYear;
        private string make;
        public Condition condition { get; set; }
        public enum Condition
        {
            mint=1,
            wellKept,
            poor
        }


        public string Model
        {
            get {return model;}
            set { model=value;}
        }


        public int ProductionYear
        {
            get {return productionYear;}
            set {productionYear=value;}
        }

        public string Make
        {
            get {return make;}
            set {make=value;}
        }


        //constructor includes all attributes and is based on the InventoryItem class
        public Vehicle(int id, string itemName, int price, string description, string model, int productionYear, string make, Condition condition): base (id, itemName, price, description)
        {
            this.model = model;
            this.productionYear = productionYear;
            this.make = make;
            this.condition = condition;
        }


        public override string ToString()
        {
            return string.Format("Item: {0}, Price: {1}, Description: {2}, Model {3}, Production Year: {4}, Make: {5}, Condition: {6}", itemName, price, description, model, productionYear, make, condition);
        }



        /// <summary>
        /// checking if object falls under Vehicle category and if it is the same as another object of the same category; we are using the id for confirmation
        /// </summary>
        /// <param name="obj">object we are verifying</param>
        /// <returns>returns true or falls</returns>
        public override bool Equals(object obj)
        {
            if (obj is Vehicle)
            {
                Vehicle other = (Vehicle)obj;
                return this.id == other.id;
            }
            else
            {
                return false;
            }
        }



        /// <summary>
        /// the method is checking if an object contains the string provided
        /// </summary>
        /// <param name="s">string we are comparing against the item names</param>
        /// <returns>if valid, returns the object we are checking; else returns null</returns>
        public override MyISearchable NameSearch(string s)
        {
            if (this.itemName.Contains(s))
                return this;
            else
                return null;
        }


        /// <summary>
        /// the method is checking price of an object equals the integer used as parameter
        /// </summary>
        /// <param name="s">price used as search criteria</param>
        /// <returns>if valid, returns the object we are checking; else returns null</returns>
        public override MyISearchable PriceSearch(int i)
        {
            if (this.price.Equals(i))
                return this;
            else
                return null;
        }

    }
}
