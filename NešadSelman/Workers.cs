using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Workers : ISearchable
    {
        private string name;
        private string lastName;
        private int wage;



        public Workers(string name, string lastName, int wage)
        {
            this.name = name;
            this.lastName = lastName;
            this.wage = wage;
     
        }


        public string Name { get { return name; } }
        public string LastName { get { return lastName; } }
        public int Wage { get { return wage; } }


        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}", name, lastName, wage);
        }


        public ISearchable Search(string s)
         {
             if (this.name.Contains(s) || this.lastName.Contains(s))
                return this;
             else
                 return null; 
        }
    }
}
