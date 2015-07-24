using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest
{
    class Staff
    {
        protected static int ID_STAFF = 0;
        private int staffId;
        private string firstName;
        private string lastName;
        private double salary;

        public Staff(string firstName, string lastName, double salary)
        {
            staffId = ++ID_STAFF;
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
        }

        public int IDS { get { return ID_STAFF; } set { ID_STAFF = value; } }
        public int StaffId { get { return staffId; } set { staffId = value; } }
        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }
        public double Salary { get { return salary; } }



        public override string ToString()
        {
            return string.Format("{0}. {1} - {2} - {3}", StaffId, FirstName, LastName, Salary);
        }
    

    }
}
