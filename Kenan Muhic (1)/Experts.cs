using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    /// <summary>
    /// inherits worker class, adds expertise
    /// </summary>
    class Experts:Worker
    {
        public string Expertise { get; set; }
        public Experts(string name,string surname,double paycheck,string expertise)
            :base(name,surname,paycheck)
        {
            this.Expertise = expertise;
        }
        //for entity recognision
        public Experts()
        {

        }
        public override string ToString()
        {
            return base.ToString() + " " + Expertise;
        }
    }
}
