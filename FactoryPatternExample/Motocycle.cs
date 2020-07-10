using System;
namespace FactoryPatternExample
{
    public class Motocycle : IVehicle
    {
        public Motocycle()
        {
        }

        public void Drive()
        {
            Console.WriteLine("You have created a Harley Davidson!");
            Console.WriteLine("Checkout this new Beast!!");
        }
    }
}
