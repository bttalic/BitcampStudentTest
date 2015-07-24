using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest
{
    class StaffExpert:Staff
    {

        private string experties;

        public StaffExpert(string firstName, string lastName, double salary, string experties)
            : base(firstName, lastName, salary)
        {
            StaffId = IDS;
            this.experties = experties;
        }


        public override string ToString()
        {
            return string.Format("{0}. {1} - {2} - {3}", StaffId, FirstName, LastName, Salary);
        }

    }
}
