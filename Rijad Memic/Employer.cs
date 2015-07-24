using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10D05_Test
{
    class Employer
    {
        static private int COUNT = 1;

        private string firstName;

        private string lastName;

        private int paycheck;

        private int id;

        public string FirstName { get { return firstName; } set { firstName = value; } }

        public string LastName { get { return lastName; } set { lastName = value; } }

        public int Paycheck { get { return paycheck; } set { paycheck = value; } }

        public int Id { get { return id; } }

        public Employer(string firstName, string lastName, int paycheck)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.paycheck = paycheck;
            this.id = COUNT++;
        }

        public override string ToString()
        {
            return string.Format("{0}\n First name: {1}\n Last name: {2}\n Paycheck: {3}", id, firstName, lastName, paycheck);
        }


    }
}
