using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop
{
    class Program
    {
        /// <summary>
        /// Method for easier initial adding of items and employees to the PasnShop object
        /// Items added: 16
        /// Employees added: 4
        /// </summary>
        /// <param name="shop">PawnShop class object</param>
        public static void AddSomeItemsAndEmployees(PawnShop shop)
        {
            shop.AddItem("Laptop Toshiba", "Used laptop", 200);
            shop.AddItem("Laptop Sony", "Used laptop", 200);
            shop.AddItem("Laptop MacBookPro", "New laptop", 2000);
            shop.AddItem("Mobile phone iPhone 5", "Useed mobile phone", 300);
            shop.AddItem("Mobile phone iPhone 4s", "Used mobile phone", 250.50);
            shop.AddItem("Mobile phone iPhone 6", "Used mobile phone", 700);
            shop.AddItem("Mobile phone Galaxy S5", "Used mobile phone", 350.99);
            shop.AddItem("Mobile phone Galaxy S4", "Used mobile phone", 270);

            shop.AddItem("BMW 320d", "Color: blue, Doors: 4", 7500, "Limusine", 2008, Condition.Preserved);
            shop.AddItem("BMW 535d xDrive", "Color: white, Doors: 5", 20000, "Limusine", 2012, Condition.Preserved);
            shop.AddItem("Citroen C5", "Color: black, Doors: 5", 8000, "Limusine", 2002, Condition.Bad);
            shop.AddItem("Volkswagen Passat", "Color: black, Doors: 5", 17000, "Limusine", 2014, Condition.Perfect);

            shop.AddItem("Seiko 1334K", "Water-resistant watch", 200, Material.Rubber, "Seiko", 2);
            shop.AddItem("Casio c499", "Unisex watch", 350, Material.Other, "Casio", 5);
            shop.AddItem("Swatch ultra light Sw333", "Sport watch", 100, Material.Rubber, "Seiko", 2);
            shop.AddItem("Rolex Gold Edition", "Gentlemans watch", 200, Material.Gold, "Rolex", 10);

            shop.AddEmployee("Harry", "Johnson", 7500);
            shop.AddEmployee("Larry", "Fieldson", 7800);
            shop.AddEmployee("Jurry", "Hurnikov", 15000, "Watch expert");
            shop.AddEmployee("Nicholas", "Bushington", 15000, "Car expert");
        }
        static void Main(string[] args)
        {
            PawnShop shop = new PawnShop();

            AddSomeItemsAndEmployees(shop);

            Console.WriteLine("Please enter the name of the product: ");
            string searchItem = Console.ReadLine();
            shop.fitsSearch(searchItem);

            Console.WriteLine("Please enter the price for searching the products: ");

            double price = 0;
            try
            {
                price = Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception pr)
            {
                Console.WriteLine("Price format is not supported or not entered");
                Console.WriteLine(pr.Message);
            }
            shop.SearchProductByPrice(price);

            // Display PawnShop inventory
            shop.ShowInventory();

            // Display PawnShop employees
            shop.ShowEmpoloyees();

            ///////Delete inventory
            shop.DeleteInventoryItem();
            shop.ShowInventory();

            ///////Delete employees
            shop.DeleteEmployee();
            shop.ShowEmpoloyees();
        }
    }
}
