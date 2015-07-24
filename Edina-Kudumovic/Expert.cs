using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest
{
    class Expert : Employee
    {
        private string expertise;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="surname">surname</param>
        /// <param name="earning">earning</param>
        /// <param name="expertise">expertise</param>
        public Expert(string name, string surname, double earning, string expertise) : base(name, surname, earning)
        {
            this.expertise = expertise;
        }

        public string Expertise { get { return expertise; } set { expertise = value; } }

        /// <summary>
        /// Returns string representation of the Expert
        /// </summary>
        /// <returns>string containing all the expert data</returns>
        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}", Name, Surname, Earning, expertise);
        }
    }
}
