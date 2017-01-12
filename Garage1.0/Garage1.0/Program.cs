using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    class Program
    {
           static Garage<Vehicle> garage;
        static void Main(string[] args)
        {

            ConsoleKeyInfo menuChoice;
            Console.WriteLine("=========================================");
            Console.WriteLine("Welcome To Garage Project");
            Console.WriteLine("Do You Want To Create a Garage? Y/N");
            string crateGarage = Console.ReadLine();
            if ((crateGarage == "y") || (crateGarage == "Y"))
            {
                garage = new Garage<Vehicle>(20);
                Vehicle[] vehicle = new Vehicle[20];
                Console.WriteLine("Garage has been created");
                Console.WriteLine("=======================");
                Console.Write("Press any key to continue...");
                Console.ReadLine();


                do
                {
                    Console.Clear();
                    Console.WriteLine($"1. Add Vehicle in Garage \n" +
                                       "2. Remove Vehicle from Garage\n" +
                                       "3. Replace Vehicle from Garage\n"+
                                       "4. Find Specific Vehicle from Garage\n"+
                                       "0. Exit");
                    Console.WriteLine("");
                                   



                    menuChoice = Console.ReadKey();
                    Console.WriteLine("");

                    switch (menuChoice.KeyChar)
                    {
                        case '1':
                            AddVehicle();

                            break;
                        default:
                            break;
                    }
                } while (menuChoice.KeyChar != '0');
            }
            // end-if
        }

        private static void AddVehicle()
        {
            do
            {
                int subMenu;
                Console.WriteLine("Which type of Vehicle you want to Add in Garage");
                Console.WriteLine($"1. Add AirPlane in Garage \n" +
                       "2. Add Car in Garage\n" +
                       "3. Add Bus in Garage\n" +
                       "4. Add Motorcyle in Garage\n" +
                       "5. Add Boat in Garage");
                int.TryParse(Console.ReadLine(), out subMenu);
                switch (subMenu)
                {
                    case 1:
                        Airplane airplane = new Airplane();
                        airplane.Color = "Red";
                        airplane.Fuel = FuelType.Gasoline;
                        garage.Add(airplane);
                        break;
                    case 2:
                        foreach (var item in garage)
                        {
                            Console.WriteLine("Garage :" + item);
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                    case 4:
                    case 5:





                    default:
                        break;
                }



                break;
            } while (true);
        }

    }
}
