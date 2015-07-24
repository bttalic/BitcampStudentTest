using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest
{
  
    public class PawnShop //: ISearchable
    {

        public List<InventoryItem> inventory { get; set; }

        public List<Employee> employee { get; set; }

        public void AddItem(InventoryItem i)
        {
            inventory.Add(i);
        }

        public void AddEmployee(Employee e)
        {
            employee.Add(e);
       }
     

    }
}
