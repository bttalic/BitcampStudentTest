using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop
{
    class Car : Inventory
    {
        
        public enum Condition { New, GreatCondition, GoodCondition, BadCondition, Undriveable};
        public enum Type {Small, MidSize, Large, Sports, Luxury }
        public int YearOfManufacture;
        public string maker;
        private Condition condition;
        private Type type;

        public Car(string name, string description, double price, int YearOfManufacture,
            string maker, Condition condition, Type type)
            : base (name,description,price)
        {
            this.YearOfManufacture = YearOfManufacture;
            this.maker = maker;
            this.condition = condition;
            this.type = type;
        }
        public override string ToString()
        {
            return base.ToString() +
                String.Format("YearOfManufacture: {0}\n Maker: {1}\n Condition: {2}\n Type: {3} ", YearOfManufacture, maker, condition, type);
        }




    }
}
