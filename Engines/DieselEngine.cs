using System;
using System.Collections.Generic;
using System.Text;
using VehicleFleet.Enums;

namespace VehicleFleet.Engines
{
    class DieselEngine : Engine
    {
        public DieselEngine(double power, double volume, string serialNumber) : base(power, volume, serialNumber)
        {
            Type = EngineType.Diesel;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
