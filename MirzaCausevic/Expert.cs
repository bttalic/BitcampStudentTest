using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop
{
    class Expert:Employe
    {

        public string experteese;
        public Expert(string name, string lastName, int salary,string experteese)
        {
            this.name = name;
            this.lastName = lastName;
            this.salary = salary;
            this.experteese = experteese;
        }
    }
}
