using InterfaceIVehicles.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceIVehicles.AquaticVehicles
{
    class JetSki : IAquatic
    {
        public double MaxWaterSpeed { get; set; } = 70;

        public int PassengerCapacity { get; set; } = 2;

        public void Start()
        {
            Console.WriteLine("The jetski zips through the waves with the greatest of ease.");
        }

        public void Drive()
        {
            Console.WriteLine("The jetski zips through the waves with the greatest of ease.");
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
