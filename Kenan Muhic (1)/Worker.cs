using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    /// <summary>
    /// implements isearchable
    /// </summary>
    class Worker:ISearchable
    {
        //for entity
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Paycheck { get; set; }
        public Worker(string name, string surname, double paycheck)
        {
            this.Name = name;
            this.Surname=surname;
            this.Paycheck=paycheck;
        }
        //for entity
        public Worker()
        {

        }
        /// <summary>
        /// implements fitssearch method which searches by name or surname
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool FitsSearch(string s)
        {
            return this.Name.Contains(s) || this.Surname.Contains(s);
        }
        public override string ToString()
        {
            return string.Format("{0}: {1} {2}", Id, Name, Surname);
        }
    }
}
