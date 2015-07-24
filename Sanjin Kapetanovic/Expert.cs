using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Expert : Employee
    {
        private string expertise;
        public Expert(string firstName, string lastName, string expertise, double payCheck) : base(firstName, lastName, payCheck) 
        {
            this.expertise = expertise;
        }
        public override string ToString()
        {
            return String.Format("Employee ID: {0}, Firstname: {1}, Lastname: {2}, Expertise: {3}, PayCheck: {4}", EmployeeId, FirstName, LastName, expertise, PayCheck);
        }
    }
}
