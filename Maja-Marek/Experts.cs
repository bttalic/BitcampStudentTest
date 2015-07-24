using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_24_07
{
    class Experts : Employee, ISearchable
    {
        private string expertise;

        public Experts (string name, string surname, int salary, string expertise) : base (name, surname, salary)
        {
            this.expertise = expertise;
        }

        public string Expertise { get { return expertise; } set { expertise = value; } }

        public override string ToString()
        {
            return String.Format("Expertise: {0}", expertise);
        }

        //public override ISearchable FitsSearch(string s)
        //{
        //    if (this.Name.Contains(s) || this.Surname.Contains(s))
        //        return this;
        //    else
        //        return null;
        //}

        public override bool FitsSearch(string s)
        {
            if (this.Name.Contains(s) || this.Surname.Contains(s))
                return true;
            else
                return false;
        }
    }
}
