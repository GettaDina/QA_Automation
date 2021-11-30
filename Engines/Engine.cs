using System;
using System.Collections.Generic;
using System.Text;
using VehicleFleet.Enums;

namespace VehicleFleet
{
    abstract class Engine
    {
        public double Power { get; private protected set; }
        public double Volume { get; private protected set; }
        public EngineType Type { get; private protected set; }
        public string SerialNumber { get; private protected set; }
        public Engine(double power, double volume, string serialNumber)
        {
            Power = power;            
            Volume = volume;
            SerialNumber = serialNumber;
        }
        public override string ToString()
        {
            return "Power - " + Power + " Volume - " + Volume + " Type - " + Type + " SerialNumber - " + SerialNumber + "\n";
        }
    }
}
