using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Test
{
    interface ISearchable<T>
    {
        T FitsSearch(string s);

    }
}
