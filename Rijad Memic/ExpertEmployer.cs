using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10D05_Test
{
    class ExpertEmployer : Employer
    {
        private string expertise;

        public string Expertise { get { return expertise; } set { expertise = value; } }

        public ExpertEmployer(string firstName, string lastName, int paycheck, string expertise)
            : base(firstName, lastName, paycheck)
        {
            this.expertise = expertise;
        }

        public override string ToString()
        {
            return string.Format("{0}:\n First name: {1}\n Last name:{2}\n Paycheck: {3}\n Expert in: {4}", Id, FirstName, LastName, Paycheck, expertise);
        }


    }
}
