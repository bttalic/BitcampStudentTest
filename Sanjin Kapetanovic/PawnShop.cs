using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class PawnShop
    {    
        private List<InventoryItem> list;
        private List<Employee> employees;

        public PawnShop()
        {
            this.list = new List<InventoryItem>();
            this.employees = new List<Employee>();
        }
        public void AddVehicle(string name,string description, int productionYear,double price,string manufacturer,string type,string condition)
        {
            list.Add(new Vehicle(name,description, productionYear, price, manufacturer,type, condition));
        }

        public void AddWatch(string name,string description,int productionYear,double price,string manufacturer,string material)
        {
            list.Add(new Watch(name,description, productionYear, price, manufacturer, material));
        }
        public void AddCasualEmployee(string firstName, string lastName, double payCheck)
        {
            employees.Add(new Casual(firstName, lastName, payCheck));
        }
        public void AddExpertEmployee(string firstName,string lastName, string expertise, double payCheck)
        {
            employees.Add(new Expert(firstName, lastName, expertise, payCheck));
        }
        /// <summary>
        /// Sorting list of employees by name
        /// </summary>
        public void SortEmployeebyName()
        {
            employees = employees.OrderBy(x => x.FirstName).ToList();
        }
        /// <summary>
        /// Sorting list of employees by salary
        /// </summary>
        public void SortEmployeebySalary()
        {
            employees = employees.OrderBy(x => x.PayCheck).ToList();
        }
        /// <summary>
        /// Method that print list of employees
        /// </summary>
        public void PrintEmployees()
        {
            foreach(Employee emp in employees)
                Console.WriteLine(emp+"\n");
        }
        /// <summary>
        /// Sorting list of inventory items by name
        /// </summary>
        public void SortbyName()
        {
            list = list.OrderBy(x=>x.Name).ToList();
        }
        /// <summary>
        /// Sorting list of inventory items by price
        /// </summary>
        public void SortbyPrice()
        {
            list = list.OrderBy(x=>x.Price).ToList();
        }
        /// <summary>
        /// Method that prints list of InventoryItems
        /// </summary>
        public void PrintInventoryItems()
        {
            foreach(InventoryItem ex in list)
                Console.WriteLine(ex + "\n");
        }
        /// <summary>
        /// Method that searches list of InventoryItems for matching object(InventoryItem)
        /// </summary>
        /// <param name="input"></string>
        /// <returns></returning object if it is found and null if it isn't>
        public InventoryItem SearchInventoryItem(string input)
        {
            foreach(InventoryItem ex in list)
            {
                InventoryItem result=ex.FitsSearch(input);
                if (result != null)
                    return result;
            }
            Console.WriteLine("Cannot find InventoryItem");
            return null;
        }
        /// <summary>
        /// Method that searches list of employes for matching object(employee)
        /// </summary>
        /// <param name="input"></string>
        /// <returns></returning object if it is found and null if it isn't>
        public Employee SearchEmployee(string input)
        {
            foreach(Employee emp in employees)
            {
                Employee result = emp.FitsSearch(input);
                if (result != null)
                    return result;
            }
            Console.WriteLine("Cannot find employee");
            return null;
        }
    }
    }

