using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    abstract class Employee : ISearchable<Employee>
    {
        private static int EMPID = 0;
        private string firstName;
        private string lastName;
        private int employeeId;
        private double payCheck;
        public Employee(string firstName, string lastName, double payCheck)
        {
            this.FirstName = firstName;
            this.LastName = LastName;
            this.employeeId = ++EMPID;
            this.payCheck = payCheck;
        }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public int EmployeeId { get { return employeeId; } set { employeeId = value; } }
        public double PayCheck { get { return payCheck; } set { payCheck = value; } }
        /// <summary>
        /// Method that takes string and check if is matching with name od id
        /// </summary>
        /// <param name="s"></string>
        /// <returns></this object if matchs or null if not>
        public Employee FitsSearch(string s)
        {
            if (this.FirstName.Contains(s)
                || this.LastName.Contains(s)
                || this.EmployeeId.ToString() == s)
                return this;
            return null;
        }
    }
}
