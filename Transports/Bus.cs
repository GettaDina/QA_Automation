using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleFleet.Transports
{
    class Bus : Transport
    {
        public int SeatingCapacity { get; private protected set; }
        public int FullCapacity { get; private protected set; }
        public bool AvailabilityConductor { get; private protected set; }
        public Bus(Chassi chassi, Engine engine, Transmission transmission, int seatingCapacity, int fullCapacity, bool availabilityConductor) : base(chassi, engine, transmission)
        {
            SeatingCapacity = seatingCapacity;
            FullCapacity = fullCapacity;
            AvailabilityConductor = availabilityConductor;
        }
        public override string ToString()
        {
            return base.ToString() + "Unique fields:\n" + "SeatingCapacity - " + SeatingCapacity + " FullCapacity - " + FullCapacity + " AvailabilityConductor - " + AvailabilityConductor;
        }
    }
}
