using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniTest
{
    class Expert:Employe
    {

        private string expertise;



        public Expert(string name, string surname, int wage ,string expertise)
            : base(name, surname, wage)
        {
            this.expertise = expertise;
        
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}",id,name ,surname, wage,expertise);
        }

    }
}
