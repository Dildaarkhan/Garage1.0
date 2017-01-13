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
                Console.WriteLine("=======================");
                Console.WriteLine("How Much Capacity You need in Garage");
                int capacity = Convert.ToInt32(Console.ReadLine());          /// Set Error Handling
                garage = new Garage<Vehicle>(capacity);
                Console.WriteLine("Garage has been created"
                    + "\n Press any Key to Continue...........");
                Console.ReadKey();

                do
                {
                    Console.Clear();
                    Console.WriteLine("1. Add Vehicle in Garage \n"
                        + "2. Remove Vehicle from Garage\n"
                        + "3. Find Vehicle from Garage\n"
                        + "4. Find Specific Vehicle from Garage\n"
                        + "0. Exit");
                    Console.WriteLine("");




                    menuChoice = Console.ReadKey();
                   
                    switch (menuChoice.KeyChar)
                    {
                        case '1':
                            AddVehicle();

                            break;
                        case '2':
                            RemoveVehicle();
                            break;
                        case '3':
                            FindVehicle();
                            break;
                        default:
                            break;
                    }
                } while (menuChoice.KeyChar != '0');
            }
            // end-if
        }

        private static void FindVehicle()
        {
            //int count = garage.Count;
           

            //for (int i = 0; i < count; i++)
            //{
            //    Console.WriteLine();

            //}
            
            Console.ReadLine();
        }

        private static void RemoveVehicle()
        {
            bool exit = false;
            do
            {
                int subMenu;
                Console.Clear();
                Console.WriteLine("Which Vehicle you want to Remove from Garage");
                Console.WriteLine($"1. Enter Vehicle Registration Number to Remove from Garage\n" +
                                              "0. Exit");
                int.TryParse(Console.ReadLine(), out subMenu);
                var veh = new Vehicle[2];

                switch (subMenu)
                {
                    case 1:
                        //string regNumber = Console.ReadLine();

                        foreach (var item in garage)
                        {
                            Console.WriteLine(item.RegistrationNumber);
                        }
                        Console.ReadLine();                      
                        break;

                    case 0:
                        exit = true;
                        break;
                    default:
                        break;
                }


            } while (exit);
        }


        private static void AddVehicle()
        {
            bool exit;
            do
            {
                int subMenu;
                Console.Clear();
                Console.WriteLine("Which type of Vehicle you want to Add in Garage");
                Console.WriteLine($"1. Add AirPlane in Garage \n" +
                       "2. Add Car in Garage\n" +
                       "3. Add Bus in Garage\n" +
                       "4. Add Motorcyle in Garage\n" +
                       "5. Add Boat in Garage\n" +
                       "0. Exit");
                int.TryParse(Console.ReadLine(), out subMenu);

                switch (subMenu)
                {
                    case 1:
                        Console.Clear();
                        Airplane airplane = new Airplane();
                        Console.WriteLine("Enter Registraion Number of AirPlane");
                        airplane.RegistrationNumber = Console.ReadLine();
                        Console.WriteLine("Enter Color of AirPlane");
                        airplane.Color = Console.ReadLine();
                        airplane.Fuel = FuelType.Gasoline;
                        garage.Add(airplane);
                        break;
                    case 2:
                        Console.Clear();
                        Car car = new Car();
                        Console.WriteLine("Enter Registraion Number of Car");
                        car.RegistrationNumber = Console.ReadLine();
                        Console.WriteLine("Enter Color of Car");
                        car.Color = Console.ReadLine();
                        car.Fuel = FuelType.Gasoline;
                        garage.Add(car);
                        break;
                    case 3:
                        Console.Clear();
                        Bus bus = new Bus();
                        Console.WriteLine("Enter Registraion Number of Bus");
                        bus.RegistrationNumber = Console.ReadLine();
                        Console.WriteLine("Enter Color of Bus");
                        bus.Color = Console.ReadLine();
                        bus.Fuel = FuelType.Gasoline;
                        bus.Type = BusType.motorbus;
                        garage.Add(bus);
                        break;
                    case 4:
                        Console.Clear();
                        Motorcycle motorcycle = new Motorcycle();
                        Console.WriteLine("Enter Registraion Number of MotorCycle");
                        motorcycle.RegistrationNumber = Console.ReadLine();
                        Console.WriteLine("Enter Color of MotorCycle");
                        motorcycle.Color = Console.ReadLine();
                        motorcycle.Fuel = FuelType.Gasoline;
                        garage.Add(motorcycle);
                        break;
                    case 5:
                        Console.Clear();
                        Boat boat = new Boat();
                        Console.WriteLine("Enter Registraion Number of Boat");
                        boat.RegistrationNumber = Console.ReadLine();
                        Console.WriteLine("Enter Color of Boat");
                        boat.Color = Console.ReadLine();
                        //Console.WriteLine("Enter Fuel Type of Boat");
                        boat.Fuel = FuelType.Gasoline;
                        garage.Add(boat);
                        break;

                    case 0:
                        exit = true;
                        break;
                    default:
                        break;
                }



                break;
            } while (exit);

        }



    }
}
