using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop
{
    /// <summary>
    /// Interface for searching by string "s".
    /// </summary>
    public interface ISearchable
    {
        bool fitsSearch(string s);
    }
}
