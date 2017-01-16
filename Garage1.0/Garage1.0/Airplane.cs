using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    class Airplane : Vehicle
    {
        public string WingsShape { get; set; }
        public string FuelType { get; set; }
        public override string ToString()
        {
            return $"Registration number=,{ base.RegistrationNumber}"
                +"";
        }
    }
}
