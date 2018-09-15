using InterfaceIVehicles.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceIVehicles.AquaticVehicles
{
    class Pontoon : IAquatic
    {
        public double MaxWaterSpeed { get; set; } = 22;

        public int PassengerCapacity { get; set; } = 10;

        public void Drive()
        {
            Console.WriteLine("The pontoon is slow but steady.");
        }

        public void Start()
        {
            Console.WriteLine("Pontoons are the real party boat."); ;
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
