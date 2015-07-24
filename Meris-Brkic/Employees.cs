using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest
{
    class Employees
    {
        
        private string name;
        private string lastname;
        private int pay;

        public Employees(string n, string l, int p)
        {
            name = n;
            lastname = l;
           pay=p;

        }
        /// <summary>
        /// employees fits search
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public Employees FiitsSearch(string s)
        {

            if (this.name.Contains(s)||this.lastname.Contains(s))

                return this;

            else return null;
        }
    }
}

    

