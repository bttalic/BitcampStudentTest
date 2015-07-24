using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop
{
    /// <summary>
    /// Represents expert of pawn shop
    /// </summary>
    public class Expert : Employee
    {
        private string experty;

        public Expert(string name, string lastName, double salary, string experty) : base(name, lastName, salary)
        {
            this.experty = experty;
        }

        public string Experty
        {
            get { return experty; }
            set { experty = value; }
        }
    }
}
