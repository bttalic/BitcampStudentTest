using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PownShop
{
    interface ISearchable<T>
    {
        T FitsSearch(string s);
    }
}
