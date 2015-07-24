using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PownShop
{
    public enum Expertise { Vehicles,Watches}
    class ExpertEmployee : Employee
    {
        private Expertise expertise;

        public Expertise Expertise { get { return expertise; } }

        public ExpertEmployee(string name, string lastname, double sallary, Expertise expertise):base(name,lastname,sallary)
        {
            this.expertise = expertise;
        }
        /// <summary>
        /// Overrided ToString method which return string with basic information about ExpertEmployee object
        /// </summary>
        /// <returns>string (basic information)</returns>
        public override string ToString()
        {
            string item = base.ToString();
            return String.Format(item + "Expertise : {}", Expertise);
        }

    }
}
