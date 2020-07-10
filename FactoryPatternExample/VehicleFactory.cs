﻿using System;
namespace FactoryPatternExample
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string wheelCount)
        {
            switch (wheelCount)
            {
                case "2":
                    return new Motocycle();
                case "3":
                    return new Tricycle();
                case "4":
                    return new Car();
                default:
                    return new Car();

            }
        }

    }
}
