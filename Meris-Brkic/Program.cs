using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest
{
    class Program
    {
        static void Main(string[] args)
        {
            

            PawnShop test = new PawnShop("Pawn");
            test.AddTtem(new Cars("A8","somethig about car",20000,"SportCar",2015,"Audi",(car)1));
            test.AddTtem(new Cars("X5","somethig about car",70000,"Car",2013,"BMW",(car)0));
            test.AddTtem(new Cars("911", "somethig about car", 100000, "SportCar", 2015, "Porshe", (car)2));



            while (true)
            {
                Console.WriteLine("1-Enter Item");
                Console.WriteLine("2- Enter Employees");
                Console.WriteLine("3- Sort Items");
                Console.WriteLine("4 All Item");
                int a;
                Int32.TryParse(Console.ReadLine(), out a);

                switch (a)
                {

                    case 1:
                        {
                            Console.WriteLine("For enter item, press 1; For enter watches, press 2; For items press 3");
                            int c;
                            Int32.TryParse(Console.ReadLine(), out c);
                            if (c == 1)
                            {
                                Console.WriteLine("Enter type car");
                                string name = Console.ReadLine();
                                Console.WriteLine("Enter details");
                                string details = Console.ReadLine();
                                Console.WriteLine("year const. ");
                                string autor = Console.ReadLine();
                                Console.WriteLine("Enter condition--- 0 perfectly, 1 preserved,  2 bad");
                                int choice;
                                Int32.TryParse(Console.ReadLine(), out choice);
                                test.AddTtem(new Cars(name, details, 1, "X6", 2015, "BMW", (car)1));


                            }

                            if (c == 2)
                            {
                                Console.WriteLine("Enter watches ");
                                string name = Console.ReadLine();
                                Console.WriteLine("Enter details ");
                                string detalj = Console.ReadLine();
                                Console.WriteLine("Enter price ");
                                string autor = Console.ReadLine();
                                Console.WriteLine("Enter condition--- 0 Perfectly,  1 Preserved, 2 Bad");
                                int choice;
                                Int32.TryParse(Console.ReadLine(), out choice);
                                //test.AddTtem(new Cars(name, details, 1, "Xty", 2015, "Rolex", (watches)1));


                            }
                            if (c == 3)
                            {
                                Console.WriteLine("enter item");
                                string name = Console.ReadLine();
                                Console.WriteLine("enter details");
                                string details = Console.ReadLine();
                                Console.WriteLine("Enter price: ");
                               //int price = Console.ReadLine();

                                test.AddTtem(new InventoryItem(name, details,200000));


                            }

                            break;
                        }



                    case 2:
                        {
                            Console.WriteLine("Enter name employees: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter Last name employees: ");
                            string detalj = Console.ReadLine();
                            Console.WriteLine("plata: ");

                            int choice;
                            Int32.TryParse(Console.ReadLine(), out choice);
                            test.AddEmployee(new Employees(name, detalj, choice));

                            break;
                        }



                    case 3:
                        {
                            //test.AddTtem();
                            break;
                        }


                    case 4:
                        {


                            foreach (Cars e in test.inventoryItems)
                            { Console.WriteLine(e); }
                            break;
                        }


                    default:
                        {
                            Console.WriteLine("invalid input");

                            break;
                        }
                }





            }
        }
    }
}
