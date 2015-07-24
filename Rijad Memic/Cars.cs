using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10D05_Test
{
    class Cars : InventoryItem
    {
        public enum Condicions { Perfect, Good, Bad };


        private string mark;
        private int year;
        private string maker;
        private Condicions condicion;

        public string Mark { get { return mark; } set { mark = value; } }
        public int Year { get { return year; } set { year = value; } }

        public string Maker { get { return maker; } set { maker = value; } }

        public Condicions Condicion { get { return condicion; } set { condicion = value; } }

        public Cars(string name, string description, double price, string mark, int year, string maker, Condicions condicion)
            : base(name, description, price)
        {
            this.maker = mark;
            this.year = year;
            this.maker = maker;
            this.condicion = condicion;
        }

        public override string ToString()
        {
            return string.Format("{0}:\n Name: {1}\n Description: {2}\n Price: {3}\n Mark: {4}\n Year of making: {5}\n Maker: {6}\n Condicion: {7}", Id, Name, Description, Price, mark, year, maker, condicion);
        }

    }
}
