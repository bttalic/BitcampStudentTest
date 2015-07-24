using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest
{
    interface ISearchable<T>
    {


        T SearchByName(string n);
        T SearchByPrice(double p);


    }
}
