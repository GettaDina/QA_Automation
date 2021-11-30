using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleFleet.Chassis
{
    class TwoWheeleChassi : Chassi
    {
        public TwoWheeleChassi(string number, double permissibleLoad) : base(number, permissibleLoad)
        {
            NumberWheels = 2;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
