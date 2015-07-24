using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop
{
    /// <summary>
    /// Represents one employee of pawn shop
    /// </summary>
    public class Employee
    {
        private static int ID = 0;
        private int id;
        private string name;
        private string lastName;
        private double salary;

        public Employee(string name, string lastName, double salary)
        {
            this.name = name;
            this.lastName = lastName;
            this.salary = salary;
            this.id = ++ID;
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
        }



        /// <summary>
        /// Overriden Equlas method from object
        /// </summary>
        /// <param name="obj">object type Employee</param>
        /// <returns>true if objects are equals or
        /// false if they are not</returns>
        public override bool Equals(object obj)
        {
            if (obj is Employee)
            {
                Employee other = (Employee)obj;
                if (this.id == other.id)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Overriden ToString method from object
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return string.Format("{0} \n{1} \n{2}", name, lastName, salary);
        }
    }
}
