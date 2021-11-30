using System;
using System.Collections.Generic;
using System.Text;
using VehicleFleet.Enums;

namespace VehicleFleet.Transmissions
{
    class VariableTransmission : Transmission
    {
        public VariableTransmission(int numberGears, string manufacturer) : base(numberGears, manufacturer)
        {
            Type = TransmissonType.Variable;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
