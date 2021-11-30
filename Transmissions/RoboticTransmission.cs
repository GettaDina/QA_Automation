using System;
using System.Collections.Generic;
using System.Text;
using VehicleFleet.Enums;

namespace VehicleFleet.Transmissions
{
    class RoboticTransmission : Transmission
    {
        public RoboticTransmission(int numberGears, string manufacturer) : base(numberGears, manufacturer)
        {
            Type = TransmissonType.Robotic;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
