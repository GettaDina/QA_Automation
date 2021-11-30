using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleFleet.Transports
{
    class Truck : Transport
    {
        public double BodyDimensions { get; private protected set; }
        public Truck(Chassi chassi, Engine engine, Transmission transmission, double bodyDimensions) : base(chassi, engine, transmission)
        {
            BodyDimensions = bodyDimensions;
        }
        public override string ToString()
        {
            return base.ToString() + "Unique fields:\n" + "BodyDimensions - " + BodyDimensions;
        }
    }
}
