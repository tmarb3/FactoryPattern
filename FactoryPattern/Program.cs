using System;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter if the vehicle has a bed");
            bool bed;
            var input = bool.TryParse(Console.ReadLine(), out bed);

            var vehicle = VehicleFactory.GetVehicle(bed);
            vehicle.Drive();



        }

    }
}
