using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Employee
    {
        protected string name;
        protected string surname;
        protected double salary;

        public Employee(string name, string surname, double salary)
        {
            this.name = name;
            this.surname = surname;
            this.salary = salary;
        }
    }
}
