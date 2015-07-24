using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    /// <summary>
    /// defines search method for inventoryitems
    /// </summary>
    interface ISearchable
    {
        bool FitsSearch(string s);
    }
}
