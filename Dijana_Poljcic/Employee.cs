using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek10Day5
{
    class Employee
    {
       List<Employee> employees;
       private string firstName;
       private string lastName;
       private int payCheck;
       public Employee(string firstName, string lastName, int payCheck)
       {
           this.employees = new List<Employee>();
           this.firstName = firstName;
           this.lastName = lastName;
           this.payCheck = payCheck;
       }
       public string FirstName { get { return firstName; } set { firstName = value; } }
       public string LastName { get { return lastName; } set { lastName = value; } }
       public int PayCheck { get { return payCheck; } set { payCheck = value; } }


    }
}
