using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W10D05_minitest
{
    class Car:InventoryItem
    {

    public    enum Conditions
        {

            Perfect=0, OK=1, Bad=2
            

        }

        public string Type;
        public string Maker;
        public int YearMade;
        public Conditions state;


        public Car(string name, string details, int price, string type, string maker, int year, Conditions p):base(name, details, price)
        {

            this.Type = type;
            this.Maker = maker;
            this.YearMade = year;
            this.state = p;

        }

        public override string ToString()
        {
            return "ItemName:" + ItemName + "\n Details: " + Details + "\n Price" + price + " \n State:" + state.ToString() + "\n Maker" + Maker + "\n Year Made: "+YearMade;
        }


    }
}
