using InterfaceIVehicles.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceIVehicles.FlyingVehicles
{
    class Cessna : IFlying
    {
        public int Wheels { get; set; } = 2;

        public int Doors { get; set; } =2;

        public bool Winged { get; set; } = true;

        public double MaxAirSpeed { get; set; } = 145.4;

        public string TransmissionType { get; set; } = "turboshaft";

        public double EngineVolume { get; set; } = 31.1;

        public int PassengerCapacity { get; set; } = 5;

        public void Fly()
        {
            Console.WriteLine("The Cessna flies like a bird.");
        }

        public void Start()
        {
            Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun.");
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
