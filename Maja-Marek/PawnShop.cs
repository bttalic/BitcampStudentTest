using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_24_07
{
    class PawnShop
    {
        private List<InventoryItem> inItems;
        private List<Employee> employees;

        public PawnShop()
        {
            this.inItems = new List<InventoryItem>();
            this.employees = new List<Employee>();
        }

        public List<InventoryItem> InItems { get { return InItems; } }
        public List<Employee> Employees { get { return employees; } }

        public void AddItems(InventoryItem item)
        {
            inItems.Add(item);
            inItems.Sort();
        }

        public void AddEmployee(Employee emp)
        {
            employees.Add(emp);
            employees.Sort();
        }

        public List<ISearchable> Find(string s)
        {
            List<ISearchable> all = new List<ISearchable>(inItems);
            all.AddRange(employees);

            List<ISearchable> list = new List<ISearchable>();

            foreach (ISearchable i in all)
            {
                if (i.FitsSearch(s) != null)
                {
                    list.Add(i);
                }
            }
            return list;

        }


    }
}
