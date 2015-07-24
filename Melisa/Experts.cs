using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Experts : Employee
    {
        string expertise;

        public Experts(string firstname, string lastname, string expertise)
            : base(firstname, lastname)
        {
            this.expertise = expertise;
        }

        public override string ToString()
        {
            return String.Format("Expertise: {0}", expertise);
        }
    }
}
