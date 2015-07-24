using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Employee : ISearchable
    {
        private static int ID = 1;

         private int employeeId;
        private string name;
        private string lastName;
        private double payCheck;
        private List<Experts> experts; 

        public Employee(string name, string lastName, double payCheck)
        {
            this.name = name;
            this.lastName = lastName;
            this.payCheck = payCheck;
            this.employeeId = ID++;
            this.experts = new List<Experts>();
        }

        public string Name { get { return name; } }
        public string LastName { get { return lastName; } }
        public double PayCheck { get { return payCheck; } }
        public int EmployeeID { get { return employeeId; } }

        public override bool Equals(object obj)
        {
            if (obj is Employee)
            {
               Employee other = (Employee)obj;
                if (this.employeeId.Equals(other.employeeId))
                    return true;
                else return false;
            }
            else
            {
                return false;
            }

        }

        public override string ToString()
        {
            return String.Format("Name {0} LastName {1} PayCheck {2} ID {3}", name, lastName, payCheck, employeeId);
        }


        public ISearchable fitsSearch(string s)
        {
            if (this.Name.Contains(s) || this.lastName.Contains(s))
                return this;
            else
                return null;
        }
    }
}
