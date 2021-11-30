using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleFleet
{
    abstract class Chassi
    {       
        public int NumberWheels { get; private protected set; }
        public string Number { get; private protected set; }
        public double PermissibleLoad { get; private protected set; }       
        public Chassi(string number, double permissibleLoad)
        {
            Number = number;
            PermissibleLoad = permissibleLoad;
        }
        public override string ToString()
        {
            return "NumberWheels - " + NumberWheels + " Number - " + Number + " PermissibleLoad - " + PermissibleLoad + "\n";
        }
    }
}
