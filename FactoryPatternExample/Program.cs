using System;

namespace FactoryPatternExample
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of wheels of the car you want to create");

            var numberOfWheels = Console.ReadLine();
            var vehicle = VehicleFactory.GetVehicle(numberOfWheels);
            vehicle.Drive();

        }
    }
}
