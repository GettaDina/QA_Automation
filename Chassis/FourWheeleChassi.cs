using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleFleet.Chassis
{
    class FourWheeleChassi : Chassi
    {
        public FourWheeleChassi(string number, double permissibleLoad) : base(number, permissibleLoad)
        {
            NumberWheels = 4;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
