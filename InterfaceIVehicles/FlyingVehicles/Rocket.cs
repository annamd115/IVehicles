using InterfaceIVehicles.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceIVehicles.FlyingVehicles
{
    class Rocket : IFlying
    {
        public int Wheels { get; set; } = 0;

        public int Doors { get; set; } = 1;

        public bool Winged { get; set; } = false;

        public double MaxAirSpeed { get; set; } = 17640;

        public string TransmissionType { get; set; } = "cross-drive turbo";

        public double EngineVolume { get; set; } = 1000000;

        public int PassengerCapacity => 10;

        public void Fly()
        {
            Console.WriteLine("The rocket will take you to Mars.");
        }

        public void Start()
        {
            Console.WriteLine("Lift off!");
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
