using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W10D05PawnShopTest
{
    class ExpertEmployee: Employee
    {
        private string fieldOfExpertise;

        public string FieldOfExpertise
        {
            get { return fieldOfExpertise; }
            set { fieldOfExpertise = value; }
        }

        //constructor includes all attributes and is based on the Employee class
        public ExpertEmployee(string name, string surname, double salary, string fieldOfExpertise): base (name, surname, salary)
        {
            this.name = name;
            this.surname = surname;
            this.salary = salary;
            this.fieldOfExpertise = fieldOfExpertise;
        }


        public override string ToString()
        {
            return string.Format("Name: {0}, Surname: {1}, Salary: {2}, Field of Expertise{3}", name, surname, salary, fieldOfExpertise);
        }

    }
}
