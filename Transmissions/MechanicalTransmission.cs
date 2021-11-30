using System;
using System.Collections.Generic;
using System.Text;
using VehicleFleet.Enums;

namespace VehicleFleet.Transmissions
{
    class MechanicalTransmission : Transmission
    {
        public MechanicalTransmission(int numberGears, string manufacturer) : base(numberGears, manufacturer)
        {
            Type = TransmissonType.Mechanical;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
