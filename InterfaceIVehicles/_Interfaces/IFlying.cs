using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceIVehicles.Interfaces
{
    public interface IFlying : IVehicle
    {
        int Wheels { get; }
        int Doors { get; }
        bool Winged { get; }
        double MaxAirSpeed { get; }
        string TransmissionType { get; }
        double EngineVolume { get; }

        void Fly();
    }
}
