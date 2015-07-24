using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public enum Condition { Perfect = 1, Good, Bad };
    class Cars : InventoryItem
    {
     

        private string type;
        private string maker;
        private Condition condition;
        private int productionYear;

        public Cars(string name,string description,double price,string type, string maker, Condition condition, int productionYear) :base (name,description,productionYear)
        {
            this.type = type;
            this.maker = maker;
            this.condition = condition;
            this.productionYear = productionYear;
           
        }

        public int ProductionYear { get { return productionYear; } }
        public Condition Condition { get { return condition; } }
        public string Maker { get { return maker; } }
        public string Type { get { return type; } }



        public override string ToString()
        {
            return String.Format("Name {0} Description {1} Price {2} ID {3} Type {4} Maker {5} Condition {6} ProductionYear {7}",Name,Description,Price,InvetoryID,type, maker, condition, productionYear);
        }
    }
}
