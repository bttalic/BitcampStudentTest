using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop
{
    class Expert : Employee
    {
        string Expertise { get; set; }

        public Expert(string firstName, string lastName, double wage, string expertise)
            :base(firstName,lastName,wage)
        {
            this.Expertise = expertise;
        }
        /// <summary>
        /// Method returns all properties from class Expert and its inherited class)
        /// </summary>
        /// <returns>String which has description about Expert object</returns>
        public override string ToString()
        {
            return String.Format("Employee first name: {0}\nLast name: {1}\nEmployee wage: {2}\nExpertise: {3}\n", this.FirstName, this.LastName, this.Wage, Expertise);
        }
    }
}
