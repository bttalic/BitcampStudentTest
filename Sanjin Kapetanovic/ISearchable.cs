using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    interface ISearchable<T>
    {
        /// <summary>
        /// Method than needs to be implemented
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        T FitsSearch(string s);
    }
}
