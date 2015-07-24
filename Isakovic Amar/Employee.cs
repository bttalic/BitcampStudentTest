using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W10D05_minitest
{
    class Employee
    {
         static int ID=0;
        public string FirstName;
        public string LastName;
        public int Wage;


        public Employee(string fn, string ln, int w)
        {

            ID = ID++;
            this.FirstName = fn;
            this.LastName = ln;
            this.Wage = w;

        }

        public int GetId()
        { return ID; }

        public override string ToString()
        {
            return FirstName + " - " + LastName + "Wage: " + Wage;
        }
        public override bool Equals(object obj)
         {
             if (obj is Employee)
             {
                 Employee test = (Employee)obj;
                 if (this.GetId() == test.GetId()) return true;
                 else
                 { return false; }

             }
             else
             { return false; }
         }
    }
}
