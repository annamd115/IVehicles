using InterfaceIVehicles.AquaticVehicles;
using InterfaceIVehicles.FlyingVehicles;
using InterfaceIVehicles.Interfaces;
using InterfaceIVehicles.LandVehicles;
using System;
using System.Collections.Generic;

namespace InterfaceIVehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            var jetski = new JetSki();
            var pontoon = new Pontoon();
            var cessna = new Cessna();
            var rocket = new Rocket();
            var car = new Car();
            var motororcycle = new Motorcycle();


            // Build a collection of all vehicles that fly
            // With a single `foreach`, have each vehicle Fly()
            var flyingThings = new List<IFlying> { cessna, rocket};
            foreach (var flyingThing in flyingThings)
            {
                flyingThing.Fly();
            }

            // Build a collection of all vehicles that operate on roads
            // With a single `foreach`, have each road vehicle Drive()
            var roadThings = new List<ILand> { motororcycle, car };
            foreach (var roadThing in roadThings)
            {
                roadThing.Drive();
            }

            // Build a collection of all vehicles that operate on water
            // With a single `foreach`, have each water vehicle Drive()
            var waterThings = new List<IAquatic> { jetski, pontoon };
            foreach (var waterThing in waterThings)
            {
                waterThing.Drive();
            }

            Console.ReadLine();
        }
    }
}
