using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest
{
    class Employee
    {
        private string name { get; set; }
        private string surname { get; set; }
        private int wages { get; set; }



        public Employee(string name, string surname, int wages)
        {
            this.name = name;
            this.surname = surname;
            this.wages = wages;
        }



        public override string ToString()
        {
            return String.Format("Name: {0}\nSurname: {1}\nWages: {2}", name, surname, wages);
        }

    }
}
