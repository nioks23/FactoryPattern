using System;
namespace FactoryPatternExample
{
    public class Tricycle : IVehicle
    {
        public Tricycle()
        {
        }

        public void Drive()
        {
            Console.WriteLine("Well you have created something bizarre!");
            Console.WriteLine("Let's ride it!");
        }
    }
}
