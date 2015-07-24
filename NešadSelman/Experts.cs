using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Experts : Workers        //klasa experts nasljedjuje klasu workers
    {

        private string expertise;


        public Experts(string expertise, string name, string lastName, int wage) : base(name,lastName,wage)
        {
            this.expertise = expertise;       
          
        }

          public string Expertise { get { return expertise; } }


    }
}
