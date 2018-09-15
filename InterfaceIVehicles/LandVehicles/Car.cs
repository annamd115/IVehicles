using InterfaceIVehicles.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceIVehicles.LandVehicles
{
    class Car : ILand
    {
        public int Wheels { get; set; } = 4;

        public int Doors { get; set; } = 4;

        public double MaxLandSpeed { get; set; } = 435.31;

        public string TransmissionType { get; set; } = "automatic";

        public double EngineVolume { get; set; } = 2000;

        public int PassengerCapacity { get; set; } = 5;

        public void Drive()
        {
            Console.WriteLine("The car gets you where you need to go.");
        }

        public void Start()
        {
            Console.WriteLine("Here we go!");
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
