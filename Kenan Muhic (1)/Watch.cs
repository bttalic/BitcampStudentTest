using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    /// <summary>
    /// inherits inventoryitem and implements isearchable
    /// </summary>
    class Watch:InventoryItem
    {
        public enum Material { zlato, srebro, guma, ostalo };
        public Material material { get; set; }
        /// <summary>
        /// uses base constructor and adds value for materials
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="price"></param>
        /// <param name="material"></param>
        public Watch(string name,string description,double price,Material material)
            :base(name,description,price)
        {
            this.material = material;
        }
        //for entity
        public Watch()
        {

        }
        public override string ToString()
        {
            return base.ToString() + string.Format("\n{0}", material);
        }
    }
}
