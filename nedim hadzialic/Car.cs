using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniTest
{
    class Car:Inventory
    {

        private string type;
        private int productionYear;
        private string manufacturer;
        private enumCondition condition;
        public enum enumCondition {  Excelent= 1, Good, Bad };

        private bool parsing;
        public Car(string name, int price,string desc,
            string type,int productionYear,string manufacturer,string enumcondition):base(name,price,desc)
        {
            this.type = type;
            this.productionYear = productionYear;
            this.manufacturer = manufacturer;
            this.parsing = Enum.TryParse(enumcondition, out condition);
        
        }
       



        public  override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4} {5} {6}", id, name,price , desc, type, productionYear, manufacturer, condition);
        }

    }
}
