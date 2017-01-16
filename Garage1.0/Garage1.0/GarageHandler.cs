using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    class GarageHandler
    {
        Garage<Vehicle> garage;
        public void CreateGarage()
        {
            ConsoleKeyInfo menuChoice;
            Console.WriteLine("=========================================");
            Console.WriteLine("Welcome To Garage Project");

            Console.WriteLine("How Much Capacity You need in Garage");
            int capacity = Convert.ToInt32(Console.ReadLine());          /// Set Error Handling

            if (capacity > 0)
            {
                Console.WriteLine("=======================");
                garage = new Garage<Vehicle>(capacity);
                Console.WriteLine("Garage has been created"
                    + "\n Press any Key to Continue...........");
                Console.ReadKey();

                do
                {
                    Console.Clear();
                    Console.WriteLine("1. Add Vehicle in Garage \n"
                        + "2. Remove Vehicle from Garage\n"
                        + "3. Find Specific Vehicle from Garage\n"
                        + "4. How many Vehicles exist in Garage\n"
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
                        case '4':
                            ShowAll();
                            break;
                        default:
                            break;
                    }
                } while (menuChoice.KeyChar != '0');
            }
            else
            {
                Console.WriteLine("Sorry you are not allowed for Garage");

                Console.ReadKey();
            }
            // end-if
        }
            private void ShowAll()
        {
            throw new NotImplementedException();
        }

        private void FindVehicle()
        {

            Console.WriteLine("Registration Number? ");
            string regnumber = Console.ReadLine();
            Console.Clear();
            Vehicle searchVehicle = garage.Where(tempveh => tempveh.RegistrationNumber == regnumber).FirstOrDefault();

            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(searchVehicle))
            {

                string name = descriptor.Name;
                object value = descriptor.GetValue(searchVehicle);
                Console.WriteLine("{0}={1}", name, value);

            }

            Console.ReadLine();

        }

        private void RemoveVehicle()
        {

            Console.Clear();
            Console.WriteLine("Which Vehicle you want to Remove from Garage\n" +
            "Enter Registration Number?");
            string regnumber = Console.ReadLine();
            var searchVehicle = garage.Where(tempveh => tempveh.RegistrationNumber == regnumber).FirstOrDefault();

            

            if (searchVehicle != null)
            {
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(searchVehicle))
                {

                    string name = descriptor.Name;
                    object value = descriptor.GetValue(searchVehicle);
                    Console.WriteLine("{0}={1}", name, value);

                }

                Console.WriteLine("Vehicle is removed from Garage", garage.Remove(searchVehicle).RegistrationNumber);
            }
            else
            {
                Console.WriteLine("Record not Exist");

            }
            Console.ReadLine();
        }


        private void AddVehicle()
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
                    AddAirplane();
                    break;
                case 2:
                    AddCar();
                    break;
                case 3:
                    AddBus();
                    break;
                case 4:
                    AddMotorcycle();
                    break;
                case 5:
                    AddBoat();
                    break;
                default:
                    break;
            }






        }

        private void AddBoat()
        {
            Console.Clear();
            Boat boat = new Boat();
            vehicleGeneralData(boat);
            Console.WriteLine("Enter Fuel Type of Boat");
            boat.FuelType = Console.ReadLine();
            Console.WriteLine("Enter Type of Boat");
            boat.Type = Console.ReadLine();
            ParkedVehicle(boat);
        }

        private static void vehicleGeneralData(Vehicle vehicle)
        {
            Console.WriteLine("Enter Registraion Number of Boat");
            vehicle.RegistrationNumber = Console.ReadLine();
            Console.WriteLine("Enter Color of Boat");
            vehicle.Color = Console.ReadLine();
            Console.WriteLine("Enter Number of Wheels in Boat");
            vehicle.NumberOfWheels = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number of Seats in Boat");
            vehicle.NumberOfSeats = Convert.ToInt32(Console.ReadLine());
        }

        private void AddMotorcycle()
        {
            Console.Clear();
            Motorcycle motorcycle = new Motorcycle();
            vehicleGeneralData(motorcycle);
            Console.WriteLine("Enter Model of MotorCycle");
            motorcycle.Model = Console.ReadLine();
            Console.WriteLine("Enter Make of MotorCycle");
            motorcycle.Make = Console.ReadLine();
            Console.WriteLine("Enter Year of MotorCycle");
            motorcycle.Year = Console.ReadLine();                  /// consider the type of property
            Console.WriteLine("Enter Type of MotorCycle.");
            motorcycle.Type = Console.ReadLine();
            Console.WriteLine("Enter FUEL Type.");
            motorcycle.FuelType = Console.ReadLine();

            ParkedVehicle(motorcycle);
        }

        private void ParkedVehicle(Vehicle vehicle)
        {

            if (garage.Add(vehicle))
            {
                Console.WriteLine("Vehicle is Parked in Garage");
            }
            else
            {
                Console.WriteLine("No space to Park!");
            }
            Console.ReadKey();
        }

        private void AddBus()
        {
            Console.Clear();
            Bus bus = new Bus();
            vehicleGeneralData(bus);
            Console.WriteLine("Enter FUEL Type.");
            bus.FuelType = Console.ReadLine();
            Console.WriteLine("Enter Type of Bus");
            bus.Type = Console.ReadLine();
            ParkedVehicle(bus);
        }

        private void AddCar()
        {
            Console.Clear();
            Car car = new Car();
            vehicleGeneralData(car);
            Console.WriteLine("Enter Model of Car");
            car.Model = Console.ReadLine();
            Console.WriteLine("Enter Make of Car");
            car.Make = Console.ReadLine();
            Console.WriteLine("Enter Year of Car");
            car.Year = Console.ReadLine();                  /// consider the type of property
            Console.WriteLine("Enter FUEL Type.");
            car.FuelType = Console.ReadLine();
            ParkedVehicle(car);
        }

        private void AddAirplane()
        {
            Console.Clear();
            Airplane airplane = new Airplane();
            vehicleGeneralData(airplane);
            Console.WriteLine("Enter FUEL Type.");
            airplane.FuelType = Console.ReadLine();
            Console.WriteLine("Enter Wings Shape.");
            airplane.WingsShape = Console.ReadLine();
            ParkedVehicle(airplane);
        }

        private static string AskforString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        private static int AskForInt(string question)
        {
            string parse;
            int input;
            bool result = false;
            string error = "";
            do
            {

                parse = AskforString(error + question);
                result = int.TryParse(parse, out input);
                error = "Kindly enter correct Numbers ";

            }
            while (!result);
            return input;
        }
    }

}


