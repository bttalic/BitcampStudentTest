using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest
{
    class Program
    {

        public static void PrintInventory(PawnShop i)
        {
            foreach (InventoryItem it in i.InventoryItem)
            {
                Console.WriteLine(it);
            }
        }

        public static void PrintEmployees(PawnShop ps)
        {
            foreach (Employee e in ps.Employee)
            {
                Console.WriteLine(e);
            }
        }
        
        static void Main(string[] args)
        {
            PawnShop ps = new PawnShop();

            Cars c = new Cars("BMW X5", "Fast and furious", 100000, "Jeep", 2014, "BMW", Cars.Condition.excellent);

            Clocks cl = new Clocks("Rolex","Old and good", 1400, "Sweden", Clocks.Period.Modern, Clocks.Material.gold);

            ps.AddInventory(c);
            ps.AddInventory(cl);
          
            PrintInventory(ps);

            Employee one = new Employee("Indiana", "Jones", 1000, Employee.Expert.Pawnbroker);
            Employee two = new Employee("Lara", "Croft", 20000, Employee.Expert.MilitaryAntiques);

            
            ps.AddEmployee(one);
            //ps.AddEmployee(two);

            PrintEmployees(ps);
          
        }
    }
}
