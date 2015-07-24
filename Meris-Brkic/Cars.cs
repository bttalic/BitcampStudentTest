using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest
{
    enum car { Perfectly, Preserved, Bad}
    class Cars:InventoryItem
    {
        private car c;
        private string carType;
        private int year;
        private string Manufacturer;

        public Cars(string n, string d, int p,string ct, int y, string mn, car c):base(n, d, p)

        {
            this.carType = ct;
            this.year = y;
            this.Manufacturer = mn;
            this.c = c;
        }

        /// <summary>
        /// method override..
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {
            return "Car Type " + carType + "Year " + year + "Manfact. " + Manufacturer + "Condition "+c;
        }

        public override bool Equals(object obj)
        {
            if(obj is Cars)
            {
                Cars crs = (Cars)obj;
                if (id == crs.GetId())
                    return true;
                else { return false; }
            }
            else
            { return false; }
        }



    }
}
