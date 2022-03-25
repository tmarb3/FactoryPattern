using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(bool bed)
        {
            switch(bed)
            {
                case true:
                    return new Truck();
                case false:
                    return new Car();
                
            }

        }
    }
}
