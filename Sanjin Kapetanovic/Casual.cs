using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Casual:Employee
    {
        public Casual(string firstName, string lastName, double payCheck) : base(firstName, lastName, payCheck) { }
        public override string ToString()
        {
            return String.Format("Employee ID: {0}, Firstname: {1}, Lastname: {2}, PayCheck: {3}",EmployeeId, FirstName, LastName, PayCheck);
        }
    }
}
