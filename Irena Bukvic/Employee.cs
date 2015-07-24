using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest
{
    class Employee: IComparable, ISearchable
    {

        public enum Expert { Pawnbroker, SportsMemorabilia, MilitaryAntiques, CarExpert }

        private string name;
        private string lastName;
        private int sallary;
        private Expert expert;

        public string Name { get; set; }
        public string LastName { get; set; }
        public int Sallary { get; set; }

        public Employee(string name, string lastName, int sallary)
        {
            this.name = name;
            this.lastName = lastName;
            this.sallary = sallary;
        }
        public Employee(string name, string lastName, int sallary, Expert expert)
        {
            this.name = name;
            this.lastName = lastName;
            this.sallary = sallary;
            this.expert = expert;
        }


        public override string ToString()
        {
            return string.Format(" Name:{0}\nLastName:{1}\nSallary:{2},Expert in: {3}",name,lastName, sallary, expert);
        }
       

        /// <summary>
        /// compares employees on the basis of  their names
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is Employee)
            {
                Employee other = (Employee)obj;
                return this.Name.CompareTo(other.Name);
            }
            else
            {
                throw new ArgumentException();
            }

        }

       /// <summary>
       /// For finding employees on the basis of theor name or last name
       /// </summary>
       /// <param name="s"></param>
       /// <returns></returns>
        public bool fitsSearch(string s)
        {
            if (this.name.Contains(s) || this.lastName.Contains(s))
                return true;
            else
                return false;
        }
    }
}
