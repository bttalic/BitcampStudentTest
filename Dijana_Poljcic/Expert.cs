using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek10Day5
{
    class Expert: Employee
    {
        public enum Expertise {Antiques,Japaneseart,PopArt}
        private Expertise expertise;
        public Expert(string firstName, string lastName, int payCheck, Expertise expertise):base
            (firstName,lastName,payCheck)
        {
            this.expertise = expertise;
        }
        public override string ToString()
        {
            return base.ToString() +
                String.Format("Fistname:{0}\nLastname:{1}\nPayceck:{2}\nExperise:{3}", FirstName, LastName, PayCheck, expertise);
        }
    }
}
