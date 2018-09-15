using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceIVehicles.Interfaces
{
    interface ILand : IVehicle
    {
        int Wheels { get; }
        int Doors { get; }
        double MaxLandSpeed { get; }
        string TransmissionType { get; }
        double EngineVolume { get; }

        void Drive();
    }
}
