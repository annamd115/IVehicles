using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceIVehicles.Interfaces
{
    public interface IVehicle
    {
        int PassengerCapacity { get; }

        void Start();
        void Stop();
    }
}
