using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop
{
    public interface ISearchable
    {
        bool FitsSearch(string s);
    }
}
