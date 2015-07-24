using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Employee : IComparable, ISearchable
    {
        private string firstname;
        private string lastname;

        public Employee(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public string FullName { get { return firstname + " " + lastname; } }

        public override string ToString()
        {
            return String.Format("Name: {0} {1}", firstname, lastname);
        }

        public int CompareTo(object obj)
        {
            if(obj is Employee)
            {
                Employee other = (Employee)obj;
                return this.FullName.CompareTo(other.FullName);
            }
            else
            {
                throw new ArgumentException();
            }
        }

          public bool fitsSearch(string s)
        {
            if (this.firstname.Contains(s) || this.lastname.Contains(s))
                return true;
            else
            return false;
        }

    }
}
