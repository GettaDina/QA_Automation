using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleFleet.Transports
{
    abstract class Transport
    {
        public Chassi Chassi { get; private protected set; }
        public Engine Engine { get; private protected set; }
        public Transmission Transmission { get; private protected set; }
        public Transport(Chassi chassi, Engine engine, Transmission transmission)
        {
            Chassi = chassi;
            Engine = engine;
            Transmission = transmission;
        }
        public override string ToString()
        {
            return "Transport specification:\n" + "Chassi:\n" + Chassi +
                "Engine:\n" + Engine + "Transmission:\n" + Transmission;
        }
    }
}
