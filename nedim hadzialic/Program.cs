using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniTest
{
    class Program
    {
       public static PawnShop pawnShop = new PawnShop();
       
        /// <summary>
        /// prints inventar
        /// </summary>
        /// <param name="num"></param>
        static void PrintInventar(int num = 0)
        {
            if (num == 1)
            {
                pawnShop.AllInventory.OrderBy(x => x.Name);
            
            }
            else if (num == 2)
            {

                pawnShop.AllInventory.OrderBy(x=>x.Price);
            
            }
          
             
                foreach (var item in pawnShop.AllInventory )
            {
                Console.WriteLine(item);
            }

        }
        /// <summary>
        /// prints by name
        /// </summary>
        static void PrintByName()
        {
            pawnShop.AllInventory.Sort();
            foreach (var item in pawnShop.AllInventory)
            {
                Console.WriteLine(item);
            }
        
        
        
        }

      
        static void PrintAllEmployes()
        {
            
            foreach (var item in pawnShop.AllEmployes )
            {
                Console.WriteLine(item);
            }
        
        }

       
        static void AddEmploye()
        {
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("enter surname");
            string surname = Console.ReadLine();
            Console.WriteLine("Wage");
            int wage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Expertise(optional)");
            string expertise = Console.ReadLine();

            if (expertise == "")
            {
                Employe e = new Employe(name, surname, wage);
                pawnShop.AllEmployes.Add(e);
            }
            else
            {
                Expert e1 = new Expert(name, surname, wage, expertise);
                pawnShop.AllEmployes.Add(e1);
            }
        }
        static void RemoveEmplye()
        {

            Console.WriteLine("kojeg uposlenika zelite izbrisati");
            PrintAllEmployes();
            int choice = Convert.ToInt32( Console.ReadLine());

            pawnShop.AllEmployes.RemoveAt(choice - 1);
        
        }
        static void PrintByWage()
        {
            pawnShop.AllEmployes.OrderBy(x => x.Wage);
            foreach (var item in pawnShop.AllEmployes)
            {
                Console.WriteLine(item);
            }
        
        
        }

        static void EmployeMenu()
        {
            Console.WriteLine("1.Isprintaj sve uposlenike\n2.Isprintaj uposlenike po velicni plate\n3.Add Employe\n4.RemoveEmploye\n5.Vrati se na pocetni meni ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    PrintAllEmployes();
                    break;
                case 2:
                    PrintByWage();
                    break;
               case 3:
                    AddEmploye();
                    EmployeMenu();
                    break;
                case 4:
                    RemoveEmplye();
                    Console.WriteLine("\nuposlenik izbrisan\n");
                    EmployeMenu();
                    break;
                case 5:
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("pogresan unos");
                    break;

            }

        }
        static void RemoveInventary()
        { 
        
            Console.WriteLine("koga zelite izbrisati");
            PrintInventar();
            int choice = Convert.ToInt32(Console.ReadLine());


            pawnShop.AllInventory.RemoveAt(choice - 1);
        
        }

        static void AddCar()
        {
            Console.WriteLine("upisi ime");
            string name = Console.ReadLine();
            Console.WriteLine("upisi cijenu");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("opisi predmet");
            string desc = Console.ReadLine();
            Console.WriteLine(  "upisi tip");
            string type = Console.ReadLine();
            Console.WriteLine("upisi godinu proizvodnje");
            int prodY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("unesi proizvodzaca");
            string manufacturer = Console.ReadLine();
            Console.WriteLine("upisi stanje 1:odlicno 2:dobro 3:lose");
            string condition = Console.ReadLine();

            Car c = new Car(name,price,desc,type,prodY,manufacturer,condition);

            pawnShop.AllInventory.Add(c);

        
        
        
        }
        static void AddWatch()
        {
            Console.WriteLine("upisi ime");
            string name = Console.ReadLine();
            Console.WriteLine("upisi cijenu");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("opisi predmet");
            string desc = Console.ReadLine();
            Console.WriteLine("od kojeg je materijala 1.plastika 2. metal 3. guma");
            string material = Console.ReadLine();
            Console.WriteLine("ime proizvodzaca");
            string manufacturer = Console.ReadLine();
            Console.WriteLine("staros u godinama");
            int age = Convert.ToInt32(Console.ReadLine());

            Watch w = new Watch(name, price, desc, material, manufacturer, age);

            pawnShop.AllInventory.Add(w);
        
        
        }

        static void AddInventary()
         {
             Console.WriteLine("upisi ime");
             string name = Console.ReadLine();
             Console.WriteLine("upisi cijenu");
             int price = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("opisi predmet");
             string desc = Console.ReadLine();

             Inventory inv = new Inventory(name,price,desc);
    
    
          }
        static void AddToInventaryMenu()
        {
            Console.WriteLine("1.dodaj inventar");
            Console.WriteLine("2.dodaj auto");
            Console.WriteLine("3.sat");
            Console.WriteLine("4.povratak na glavni meni");
            Console.WriteLine(" ");
            int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        AddInventary();
                        AddToInventaryMenu();
                        break;
                    case 2:
                        AddCar();
                        AddToInventaryMenu();
                        break;
                    case 3:
                        AddWatch();
                        AddToInventaryMenu();
                        break;
                    case 4:
                        MainMenu();
                        break;
                
                }
         }

       
        static void InventarMenu()
        {
            Console.WriteLine("1.Isprintaj inventar\n2.isprintaj inventar po imenu\n3.isprintaj inventar po cijeni\n4.dodaj u invventar\n5.izbrisi iz inventara\n6.Vrati se na pocetni meni");
            int option = Convert.ToInt32(Console.ReadLine()); 
        
            switch(option)
            {
                case 1:
                    PrintInventar();
                    break;
                case 2:
                    PrintInventar(1);
                    break;
                case 3:
                    PrintInventar(2);
                    break;
                case 4 :
                    AddToInventaryMenu();
                    break;
                case 5:
                    RemoveInventary();
                    InventarMenu();
                    break;
                case 6:
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("pogresan unos");
                    break;

            }
        
        }


        static void MainMenu()
        {

            Console.WriteLine("Dobrodosli u PawnShop");

            Console.WriteLine("Izaberite sta zelite pretrazivati");

            Console.WriteLine("1.Inventar\n2.Uposlenike");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            { 
                case 1:
                    InventarMenu();
                    break;
                case 2:
                    EmployeMenu();
                    break;
                default:
                    Console.WriteLine("pogresan unos");
                    break;
               
            }

        }

        static void Main(string[] args)
        {

            

            MainMenu();



        }
    }
}
