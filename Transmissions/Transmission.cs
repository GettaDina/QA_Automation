using System;
using System.Collections.Generic;
using System.Text;
using VehicleFleet.Enums;

namespace VehicleFleet
{
    abstract class Transmission
    {
        public TransmissonType Type { get; private protected set; }
        public int NumberGears { get; private protected set; }
        public string Manufacturer { get; private protected set; }
        public Transmission (int numberGears, string manufacturer)
        {
            Manufacturer = manufacturer;
            NumberGears = numberGears;
        }
        public override string ToString()
        {
            return "Type - " + Type + " NumberGears - " + NumberGears + " Manufacturer - " + Manufacturer + "\n";
        }
    }
}
