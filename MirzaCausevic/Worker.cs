using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop
{
    class Worker : Employe
    {
        public Worker(string name, string lastName, int salary)
        {
            this.name = name;
            this.lastName = lastName;
            this.salary = salary;
        }


        
    }
}
