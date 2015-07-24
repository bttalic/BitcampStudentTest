using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop
{
    public enum Condition { Perfect, Preserved, Bad };
    public class Car : InventoryItem
    {
        
        public string CarType { get; set; }
        public int YearOfProduction { get; set; }
        public Enum Condition { get; set; }

        public Car (string name, string description, double price, string carType, int yearOfProduction, Enum condition)
            : base (name, description, price)
        {
            this.CarType = carType;
            this.YearOfProduction = yearOfProduction;
            this.Condition = condition;
        }
        /// <summary>
        /// Method returns all properties from class Car and its inherited class)
        /// </summary>
        /// <returns>String which has description about Car object</returns>
        public override string ToString()
        {
            return String.Format("Id: {0}\nName: {1}Description: {2}\nPrice: {3} USD\nCar type: {4}\nYear of production: {5}\nCondition: {6}\n", this.Id, this.Name, this.Description, this.Price, CarType, YearOfProduction,Condition);
        }

    }
}
