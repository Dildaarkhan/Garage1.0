using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    class Program
    {

        static GarageHandler garage;
       
        static void Main(string[] args)
        {
            garage = new GarageHandler();
            garage.CreateGarage();
        }

           


    }
}
