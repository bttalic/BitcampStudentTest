using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class PawnShop
    {
        private List<InventoryItem> inventoryItemList;
        private List<Employee> employeeList;

        public List<InventoryItem> InventoryItemList { get { return inventoryItemList; } }
        public List<Employee> EmployeeList { get { return employeeList; } }

        public PawnShop()
        {
            this.inventoryItemList = new List<InventoryItem>();
            this.employeeList = new List<Employee>();
        }

        /// <summary>
        /// Adding and sorting an item
        /// </summary>
        /// <param name="i"></param>
        public void AddInventoryItem(InventoryItem i)
        {
            inventoryItemList.Add(i);
            inventoryItemList.Sort();
        }

        /// <summary>
        /// Adding an employee
        /// </summary>
        /// <param name="e"></param>
        public void AddEmployees(Employee e)
        {
            employeeList.Add(e);
            employeeList.Sort();
        }

        /// <summary>
        /// Finding an employee
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public List<ISearchable> Find(string s)
        {
            List<ISearchable> list = new List<ISearchable>(employeeList);
            list.AddRange(inventoryItemList);
            List<ISearchable> results = new List<ISearchable>();
            foreach (ISearchable item in list)
            {
                if (item.fitsSearch(s) != null)
                    results.Add(item);
            }
            return results;
        }

    }
}
