using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace W10D05PawnShopTest
{
    class Employee
    {
        public string name {get; set;}
        public string surname {get; set;}
        public double salary {get; set;}



        public Employee (string name, string surname, double salary)
        {
            this.name = name;
            this.surname = surname;
            this.salary = salary;
        }


    public override string ToString()
        {
            return string.Format("Name: {0}, Surname: {1}, Salary: {2}", name, surname, salary);
        }

    }

}
