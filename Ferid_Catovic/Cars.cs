using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest
{
    class Cars : InventoryItem
    {
        private string type { get; set; }
        private int yearBuild { get; set; }
        private string fact { get; set; }
        private string condition { get; set; }


        public Cars(string name, string desc, int price, string type, int yearBuild, string fact, string condition) : base(name,desc,price)
        {
            this.type = type;
            this.yearBuild = yearBuild;
            this.fact = fact;
            this.condition = condition;
            
            
          
        }



        public override string ToString()
        {
            return String.Format("Year: {0}\nManufacturer: {1}\nCondition: {2}",yearBuild,fact,condition);
        }






    }
}
