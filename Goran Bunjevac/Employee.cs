using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Test
{
    class Employee : ISearchable<Employee>
    {
        protected static int Employee_Count = 0;

        private string name;
        private string surname;
        private double salary;
        private int id;

        public string Name { get { return name; } }
        public string Surname { get { return surname; } }
        public double Salary { get { return salary; } }

        public Employee(string name, string surname, double salary)
        {
            this.name = name;
            this.surname = surname;
            this.salary = salary;
            this.id = Employee_Count;
        }

        public override string ToString()
        {
            return String.Format("{0}: {1}, {2}, {3}", id, name, surname, salary);
        }

        /// Method from ISearchable interface
        /// Method checks if inputed string is same as
        /// employees name,surname or id
        /// </summary>
        /// <param name="s">Name,surname or id</param>
        /// <returns></returns>
        public Employee FitsSearch(string s)
        {
            if (this.name == s)
            {
                return this;
            }
            if (this.surname == s)
            {
                return this;
            }
            if (this.id.ToString() == s)
            {
                return this;
            }
            return null;
        }

    }
}
