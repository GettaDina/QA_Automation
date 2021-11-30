using System;
using System.Collections.Generic;
using System.Text;
using VehicleFleet.Enums;

namespace VehicleFleet.Engines
{
    class HybridEngine : Engine
    {
        public HybridEngine(double power, double volume, string serialNumber) : base(power, volume, serialNumber)
        {
            Type = EngineType.Hybrid;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
