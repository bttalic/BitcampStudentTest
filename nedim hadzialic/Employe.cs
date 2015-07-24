using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniTest
{
    class Employe : IComparable<Employe>
    {
        static int EMP_Count = 0;

        protected string name;
        protected string surname;
        protected int wage;
        protected int id;
        public Employe(string name,string surname,int wage)
        {
            this.name = name;
            this.surname = surname;
            this.wage = wage;
            this.id = ++EMP_Count;
        
        }
        public String Name { get; set; }
        public int Id { get; set; }
        public int Wage { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}",id, name, surname, wage);
        }

        public int CompareTo(Employe other)
        {
            return this.name.CompareTo(other.name);
        }



    }
}
