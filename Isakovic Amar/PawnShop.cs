using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W10D05_minitest
{
    class PawnShop
    {
        public string Name;
        List<InventoryItem> Items;
        List<Employee> Employees;
        /// <summary>
        /// Constructor that takes one argument
        /// </summary>
        /// <param name="name"></param>
        public PawnShop(string name)
        {

            this.Name = name;
            Items = new List<InventoryItem>();
            Employees = new List<Employee>();

        }

        /// <summary>
        /// Method for adding Items in Inventory
        /// </summary>
        /// <param name="item"></param>
        public void AddItem(InventoryItem item)
        {
            Items.Add(item);


        }
        /// <summary>
        /// Search method for finding any items that contain anythign common with the entered string s
        /// </summary>
        /// <param name="s"></param>
        public void Search(string s)
        {
            Console.WriteLine("SEARCH RESULTS:");
            foreach (var item in Items)
            { 
            if(item.fitsSearch(s))
                Console.WriteLine(item);
            
            }
        }

     

        /// <summary>
        /// Method for Adding Employees in the List 
        /// </summary>
        /// <param name="em"></param>
        public void AddEmployee(Employee em)
        {
            Employees.Add(em);


        }
        /// <summary>
        /// Overrided ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            string numberofEmployees = Convert.ToString(Employees.Count);
                string numberofInventory=Convert.ToString(Items.Count);
            return Name+" Number of employees: "+numberofEmployees+"; Number of Items in Inventory: "+ numberofInventory;
        }



        /// <summary>
        /// We print All elements from list sorted by name
        /// </summary>
        public void PrintSortedByName()
        {
            Console.WriteLine("Printed AND SORTED BY THE NAME:");
          //  List<InventoryItem> temp = Items.Where(x =>x.ItemName!="").OrderBy(x => x).ToList();
            Items.Sort();
            
            foreach (var item in Items)
            { Console.WriteLine(item);}

        }


        /// <summary>
        /// we print all elements sorted by the price
        /// </summary>
        public void PrintSortedByPrice()
        {
            Console.WriteLine("PRINTED AND SORTED BY PRICE:");
            //List<InventoryItem> temp = Items.Where(x =>x.ItemName!="").OrderBy(x => x).ToList();

            Komparataor kp = new Komparataor();
            Items.Sort(kp);
            foreach (var item in Items)
            { Console.WriteLine(item); }

        }

  





       
    }

}
