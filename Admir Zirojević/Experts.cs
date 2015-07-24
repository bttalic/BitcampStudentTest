using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    public enum Expertise { History = 1, Literature, AllAround };
    class Experts : Employee
    {
       private static int ID = 1;

        private int expertId;
        private Expertise expertise;
        
        public Experts(string name, string lastName, double payCheck, Expertise expertise)
            : base(name, lastName, payCheck)
        {
            this.expertise = expertise;
            this.expertId=ID++;
        }

        public Expertise Expertise { get { return expertise; } }
        public int ExpertId { get { return expertId; } }


        public override bool Equals(object obj)
        {
            if (obj is Experts)
            {
                Experts other = (Experts)obj;
                if (this.expertId.Equals(other.expertId))
                    return true;
                else return false;
            }
            else
            {
                return false;
            }

        }

        public override string ToString()
        {
            return String.Format("Name {0} LastName {1} PayCheck {2} ID {3} Expertise {4}", Name,LastName,PayCheck,expertId,expertise);
        }
    }
}
