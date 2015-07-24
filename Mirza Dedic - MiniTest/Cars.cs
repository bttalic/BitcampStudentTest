using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest
{
    class Cars:InventoryItem
    {
        private enum condition { Perfect = 1, Preserved, Bad };
        private condition cond;
        private bool parse;

        private string type;
        private int year;
        private string maker;
        

        public Cars(string name, string description, double price, string type, int year, string maker, string condition)
            : base(name, description, price)
        {
            Id = AID;
            this.type = type;
            this.year = year;
            this.maker = maker;
            this.parse = Enum.TryParse(condition, out cond);
            
        }




        public override bool Equals(object obj)
        {
            if (obj is Cars)
            {
                Cars other = (Cars)obj;
                return this.Id == other.Id;
            }
            else
            {
                return false;
            }
        }


        public override string ToString()
        {
            return string.Format("{0}. {1} - {2} - {3} - {4} - {5} - {6}", Id, Name, Description, Price, type, year, maker, cond);
        }

    }
}
