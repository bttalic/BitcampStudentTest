using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop
{
    class Program
    {
        static void Main(string[] args)
        {
            PawnShop shop = new PawnShop("Pawn Shop");
            
            InventoryItem watch1 = new Watches("cassio1", "stupid watch", 159.99, 1, "cassio", 5);
            InventoryItem watch2 = new Watches("cassio2", "stupid watch", 129.99, 2, "cassio", 2);
            InventoryItem watch3 = new Watches("cassio3", "stupid watch", 119.99, 3, "cassio", 3);

            InventoryItem car = new Cars("golf 6", "good car", 45999.99, "limuzina",2014, "VW", 1);

            shop.AddItem(watch1);
            shop.AddItem(watch2);
            shop.AddItem(watch3);
            shop.AddItem(car);

            shop.RemoveItem(4);

            //shop.PrintItems();

            Employee employee = new Employee("Eldin", "Soljic", 999.99);
            Employee expert = new Employee("Benjamin", "Talic", 999.98);

            shop.AddEmployee(employee);
            shop.AddEmployee(expert);

            //shop.PrintEmployees();

            List<InventoryItem> items = shop.FindItems("129");

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
