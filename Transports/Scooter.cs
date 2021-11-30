using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleFleet.Transports
{
    class Scooter : Transport
    {     
        public double Weight { get; private protected set; }
        public Scooter(Chassi chassi, Engine engine, Transmission transmission, double weight) : base(chassi, engine, transmission)
        {
            Weight = weight;
        }
        public override string ToString()
        {
            return base.ToString() + "Unique fields:\n" + "Weight - " + Weight;
        }
    }
}
