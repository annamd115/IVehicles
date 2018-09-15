using InterfaceIVehicles.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceIVehicles.LandVehicles
{
    class Motorcycle : ILand
    {
        public int Wheels { get; set; } = 2;

        public int Doors { get; set; } = 0;

        public double MaxLandSpeed { get; set; } = 376.36;

        public string TransmissionType { get; set; } = "dual clutch";

        public double EngineVolume {get; set;} = 500;

        public int PassengerCapacity { get; set; } = 2;

        public void Drive()
        {
            Console.WriteLine("The motorcycle zips between cars at astonishing speeds.");
        }

        public void Start()
        {
            Console.WriteLine("vroom");
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
