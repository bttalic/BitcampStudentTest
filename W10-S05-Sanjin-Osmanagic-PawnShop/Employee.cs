using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Wage { get; set; }

        public Employee(string firstName, string lastName, double wage)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Wage = wage;
        }
        /// <summary>
        /// Method returns all properties from class Employee
        /// </summary>
        /// <returns>String which has description about Employee object</returns>
        public override string ToString()
        {
            return String.Format("Employee first name: {0}\nLast name: {1}\nEmployee wage: {2}\n", FirstName, LastName, Wage);
        }
    }
}
