using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Expert : Employee
    {
        private string expertise;

        public Expert(string name, string surname, double salary, string expertise) : base (name, surname, salary)
        {
            this.name = name;
            this.surname = surname;
            this.salary = salary;
            this.expertise = expertise;
        }
    }
}
