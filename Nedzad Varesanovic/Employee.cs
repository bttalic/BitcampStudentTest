using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PownShop
{
    class Employee:IComparable
    {
        private string name;
        private string lastname;
        private double sallary;

        public string Name { get { return name; } }
        public string Lastname { get { return Lastname; } }
        public double Sallary { get { return sallary; } }

        public Employee(string name, string lastname, double sallary)
        {
            this.name = name;
            this.lastname = lastname;
            this.sallary = sallary;
        }
        /// <summary>
        /// Method implemented from Interface IComparable
        /// return -1,0 or 1 if this object is smaller, eqal or larger than parameters object
        /// In this case, employees name
        /// </summary>
        /// <param name="obj">object as parameter</param>
        /// <returns>integer (-1,0,1)</returns>
        public int CompareTo(object obj)
        {
            if (!(obj is Employee))
            {
                throw new ArgumentException("Object is not an Employee.");
            }
            Employee other = (Employee)obj;
            return this.Name.CompareTo(other.Name);
        }
        /// <summary>
        /// Overrided ToString method which return string with basic information about Employee object
        /// </summary>
        /// <returns>string (basic information)</returns>
        public override string ToString()
        {
            return String.Format("Name : {0}\nLastname : {1}\nSallary : {2}\n", Name, Lastname, Sallary);
        }
    }
}
