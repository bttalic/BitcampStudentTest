using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Test
{
    class Experts : Employee
    {
        private enumExpertise expertise;
        private bool parsing;
        private int id;

        public enum enumExpertise { Wathes = 1, Vehicles = 2 };

        public Experts(string name, string surname, double salary, string expertisestring)
            : base(name, surname, salary)
        {
            this.id = ++Employee_Count;
            this.parsing = Enum.TryParse(expertisestring, out expertise);
        }

        public override string ToString()
        {
            return String.Format("{0}: {1}, {2}, {3}, {4}", id, Name, Surname, Salary, expertise);
        }
    }
}
