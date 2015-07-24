using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W10D05PawnShopTest
{
    class Watch: InventoryItem
    {
        private string make;
        private int age;

        public Material material {get; set;}

        public enum Material
        {
            gold=1,
            silver,
            rubber,
            other
        }
        
        
        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        //constructor includes all attributes and is based on the InventoryItem class
        public Watch(int id, string itemName, int price, string description, string make, int age, Material material)
            : base(id, itemName, price, description)
        {
            this.make = make;
            this.age = age;
            this.material = material;
        }

        public override string ToString()
        {
            return string.Format("Item: {0}, Price: {1}, Description: {2}, Make {3}, Age {4}, Material {5}", itemName, price, description, make, material);
        }



        /// <summary>
        /// checking if object falls under Watch category and if it is the same as another object of the same category; we are using the id for confirmation
        /// </summary>
        /// <param name="obj">object we are verifying</param>
        /// <returns>returns true or falls</returns>
        public override bool Equals(object obj)
        {
            if (obj is Watch)
            {
                Watch other = (Watch)obj;
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
