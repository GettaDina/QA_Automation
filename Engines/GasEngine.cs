using System;
using System.Collections.Generic;
using System.Text;
using VehicleFleet.Enums;

namespace VehicleFleet.Engines
{
    class GasEngine : Engine
    {                
        public GasEngine(double power, double volume, string serialNumber) : base(power, volume, serialNumber)
        {           
            Type = EngineType.Gas;           
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
