using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W10D05_minitest
{
    class Expert:Employee
    {

        public string Expertise;


        public Expert(string fn, string ln, int w, string Expertise):base(fn, ln, w)
        {


            this.Expertise = Expertise;
        }


        public override string ToString()
        {
            return FirstName + " - " + LastName + "Wage: " + Wage+"Expertise "+Expertise;
        }


    }
}
