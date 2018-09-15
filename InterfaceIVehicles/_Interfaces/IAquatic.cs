using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceIVehicles.Interfaces
{
    public interface IAquatic : IVehicle
    {
        double MaxWaterSpeed { get; }

        void Drive();
    }
}
