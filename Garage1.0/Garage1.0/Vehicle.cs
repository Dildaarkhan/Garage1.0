using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    enum FuelType { Gasoline, Diesel, Hybrid }

    class Vehicle
    {
        
        private string  registrationNumber;

        public string  RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }


        public string Color { get; set; }


        public FuelType Fuel;

        

        private int numberOfWheels;

        public int NumberOfWheels
        {
            get { return numberOfWheels; }
            set { numberOfWheels = value; }
        }

        public string Design { get; set; }


    }
}
