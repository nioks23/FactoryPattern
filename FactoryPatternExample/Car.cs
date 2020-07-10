using System;
namespace FactoryPatternExample
{
    public class Car : IVehicle
    {
        public Car()
        {
        }

        public void Drive()
        {
            Console.WriteLine("You have created a Sedan!");
            Console.WriteLine("That's a sweet ride!");
        }    
    }
}
