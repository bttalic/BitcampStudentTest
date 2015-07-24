using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_24_07
{
    class Employee : ISearchable
    {
        private string name;
        private string surname;
        private int salary;

        public Employee(string name, string surname, int salary)
        {
            this.name = name;
            this.surname=surname;
            this.salary=salary;
        }

        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public int Salary { get { return salary; } set { salary = value; } }

        public override string ToString()
        {
            return String.Format("Name: {0}\nSurname: {1}\nSalary : {2}", name, surname, salary);
        }

        //public override ISearchable FitsSearch(string s)
        //{
        //    if (this.Name.Contains(s) || this.Surname.Contains(s))
        //        return this;
        //    else
        //        return null;
        //}

        public override bool FitsSearch(string s)
        {
            if (this.Name.Contains(s) || this.Surname.Contains(s))
                return true;
            else
                return false;
        }
    }
}
