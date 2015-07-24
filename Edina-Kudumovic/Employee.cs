using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest
{
    class Employee : ISearchable
    {
        private string name;
        private string surname;
        private double earning;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="surname">surname</param>
        /// <param name="earning">earning</param>
        public Employee(string name, string surname, double earning)
        {
            this.name = name;
            this.surname = surname;
            this.earning = earning;
        }

        public string Name { get { return name; } set { name = value; } }

        public string Surname { get { return surname; } set { surname = value; } }

        public double Earning { get { return earning; } }


        /// <summary>
        /// Returns string representation of the Employee
        /// </summary>
        /// <returns>string containing all the employee data</returns>
        public override string ToString()
        {
            return String.Format("{0} {1} {2}", name, surname, earning);
        }


        /// <summary>
        /// Search does string s fits in name or surname of employee
        /// </summary>
        /// <param name="s">string s</param>
        /// <returns></returns>
        public ISearchable FitsSearch(string s)
        {
            if (this.name.Contains(s) || this.surname.Contains(s))
            {
                return this;
            }
            else
            {
                return null;
            }
        }

    }
}
