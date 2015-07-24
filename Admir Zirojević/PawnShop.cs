using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class PawnShop
    {
        private List<InventoryItem> invetoryItem;    
        private List<Employee> employee;
        

        public PawnShop()
        {
            this.invetoryItem = new List<InventoryItem>();
            this.employee = new List<Employee>();
            
        }


        public List<InventoryItem> InvetoryItem { get { return invetoryItem; } }
        public List<Employee> Employee { get { return employee; } }


        /// <summary>
        /// adds an object of InvetoryItem type
        /// </summary>
        /// <param name="some object of InvetoryItem type"></param>
        public void AddInventory(InventoryItem ie)
        {
          
            invetoryItem.Add(ie);
           
        }
        /// <summary>
        /// adds an object of Employee type
        /// </summary>
        /// <param name="some object of Employee type"></param>
        public void AddEmployee(Employee e)
        {
            employee.Add(e);
           
        }


        public override string ToString()
        {
            return string.Format("InvetoryItem {0} Employee {1}", invetoryItem, employee);
        }


        /// <summary>
        /// searches or adds specific object if not found
        /// </summary>
        /// <param name="string name of object you want to search"></param>
        /// <returns>object of List(ISearcheable) type</returns>
        public List<ISearchable> Search(string s) 
        {
            List<ISearchable> results = new List<ISearchable>();
            foreach (InventoryItem e in invetoryItem)
            {
                if (e.fitsSearch(s) != null)
                    results.Add(e);
            }
            foreach (Employee e in employee)
            {
                if (e.fitsSearch(s) != null)
                    results.Add(e);
            }
            return results;
        }
    }
}
