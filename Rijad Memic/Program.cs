using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10D05_Test
{

    class Program
    {
    
        static void Main(string[] args)
        {
            // Add Inventory
            List<InventoryItem> watchAndCarList = new List<InventoryItem>();

            watchAndCarList.Add(new Cars("Golf", "Brand new Golf two.", 2300, "W", 1986, "Deutschland", Cars.Condicions.Perfect));
            watchAndCarList.Add(new Cars("Zafira", "Big, family car.", 22000, "Opel", 2003, "France", Cars.Condicions.Good));
            watchAndCarList.Add(new Cars("Yugo", "Old, but cool car and reliable car.", 1000, "Zastava", 1978, "Yugoslavia", Cars.Condicions.Bad));
            watchAndCarList.Add(new Watches("Sl56M", "For real man.", 12000, "Festina", 2, Watches.Materials.Silver));
            watchAndCarList.Add(new Watches("KW44", "Watch for woman with style.", 2300, "Gucci", 3, Watches.Materials.Gold));
            watchAndCarList.Add(new Watches("MH22", "If you need it, and if you don't, you simply must have one.", 5600, "Dolce & Gabbana", 1, Watches.Materials.Rubber));
            watchAndCarList.Add(new Watches("PZ007", "Just like Bond, only better.", 190000, "Casio", 75, Watches.Materials.Other));


            // Sort elemnts by it's name.
            IEnumerable<InventoryItem> sortByName = watchAndCarList.OrderBy(x => x.Name).ToList();            

            foreach (var element in sortByName)
            {
                Console.WriteLine(element);
            }


            Console.WriteLine("Now sort by price.");


            // Sort elements by it's price.
            IEnumerable<InventoryItem> sortByPrice = watchAndCarList.OrderBy(x => x.Price).ToList();

            foreach (var item in sortByPrice)
            {
                Console.WriteLine(item);
            }

           
            // Add Employers.
            List<Employer> emplopyers = new List<Employer>();

            emplopyers.Add(new Employer("Rijad", "Memic", 2600));
            emplopyers.Add(new Employer("Edard", "Stark", 1500));

            foreach (var item in emplopyers)
            {
                Console.WriteLine(item);
            }

            // Add Expert employers.
            List<ExpertEmployer> experts = new List<ExpertEmployer>();

            experts.Add(new ExpertEmployer("David", "Malik", 3000, "Watches"));
            experts.Add(new ExpertEmployer("Kevin", "James", 4500, "Cars"));

            foreach (var item in experts)
            {
                Console.WriteLine(item);
            }

         

            Console.ReadLine();

        }

        
    }
}
