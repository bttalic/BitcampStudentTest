using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Vehiacle : Inventory          //klasa vehiacle nasljedjuje klasu inventory
    {
        private string type;
        private int year;
        private string manufacturer;
        private string condition;
 


         public Vehiacle(string type, int year, string manufacturer, string condition,int id, string name, string description, double price  ) : base (id, name,description,price)
        {
            this.type = type;
            this.year = year;
            this.manufacturer = manufacturer;
            this.condition = condition;
        }

         public string Type { get { return type; } }
         public int Year { get { return year; } }
         public string Manufacturer { get { return manufacturer; } }
           public string Condition { get { return condition; } }




          public override string ToString()
          {
              return String.Format("{0}, {1}, {2}, {3}", type, year, manufacturer, condition);
          }


        

    }
}
