using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest
{
    class PawnShop
    {
        private List<Inventory> inventories;
        private List<Employee> employees;

        /// <summary>
        /// Constructor
        /// </summary>
        public PawnShop()
        {
            this.inventories = new List<Inventory>();
            this.employees = new List<Employee>();
        }

        public List<Inventory> Inventories { get { return inventories; } }

        public List<Employee> Employees { get { return employees; } }


        /// <summary>
        /// Add inventories to the list
        /// </summary>
        /// <param name="i"></param>
        public void AddInventory(Inventory i)
        {
            inventories.Add(i);
            
        }

        /// <summary>
        /// Add employees to the list
        /// </summary>
        /// <param name="e"></param>
        public void AddEmployee(Employee e)
        {
            employees.Add(e);          
        }

  
        public List<ISearchable> Find(string s)
        {
            List<ISearchable> everything = new List<ISearchable>(employees);
            everything.AddRange(inventories);
            List<ISearchable> results = new List<ISearchable>();
            foreach (ISearchable i in everything)
            {
                if (i.FitsSearch(s) != null)
                {
                    results.Add(i);
                }
            }
            return results;
        }
    }
}
