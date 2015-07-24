using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest
{
    class Watches:InventoryItem
    {

        private enum material { Gold = 1, Plastic, Metal };
        private material mat;
        private bool parse;

        private string maker;
        private int old;

        public Watches(string name, string description, double price, string material, string maker, int old)
            : base(name, description, price)
        {
            Id = AID;
            this.parse = Enum.TryParse(material, out mat);
            this.maker = maker;
            this.old = old;
            

        }



        public override bool Equals(object obj)
        {
            if (obj is Watches)
            {
                Watches other = (Watches)obj;
                return this.Id == other.Id;
            }
            else
            {
                return false;
            }
        }


        public override string ToString()
        {
            return string.Format("{0}. {1} - {2} - {3} - {4} - {5} - {6}", Id, Name, Description, Price, mat, maker, old);
        }


    }
}
