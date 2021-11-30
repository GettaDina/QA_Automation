using System;
using System.Collections.Generic;
using System.Text;
using VehicleFleet.Enums;

namespace VehicleFleet.Transmissions
{
    class AutomaticTransmission : Transmission
    {
        public AutomaticTransmission(int numberGears, string manufacturer) : base(numberGears, manufacturer)
        {
            Type = TransmissonType.Automatic;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
