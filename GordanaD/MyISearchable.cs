using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W10D05PawnShopTest
{
    public interface MyISearchable
    {
     
            MyISearchable NameSearch(string s);

            MyISearchable PriceSearch(int i);
        }

    }

