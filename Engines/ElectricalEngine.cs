using System;
using System.Collections.Generic;
using System.Text;
using VehicleFleet.Enums;

namespace VehicleFleet.Engines
{
    class ElectricalEngine : Engine
    {
        public ElectricalEngine(double power, double volume, string serialNumber) : base(power, volume, serialNumber)
        {
            Type = EngineType.Electrical;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
