using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleFleet.Chassis
{
    class EightWheeleChassi : Chassi
    {
        public EightWheeleChassi(string number, double permissibleLoad) : base(number, permissibleLoad)
        {
            NumberWheels = 8;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
