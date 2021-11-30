using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleFleet.Chassis
{
    class SixWheeleChassi : Chassi
    {
        public SixWheeleChassi(string number, double permissibleLoad) : base(number, permissibleLoad)
        {
            NumberWheels = 6;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
