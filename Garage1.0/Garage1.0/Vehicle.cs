using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    enum FuelType { Gasoline, Diesel, Hybrid, Pedal ,Electric, Air}

    class Vehicle
    {

        public string RegistrationNumber { get; set; }
        
        public string Color { get; set; }

        public FuelType Fuel;


        public int NumberOfWheels { get; set; }

        public string Design { get; set; }


    }
}
