using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleFleet.Transports
{
    class Car : Transport
    {
        public double TrunkVolume { get; private protected set; }
        public bool AvailabilityReplaceableWheel { get; private protected set; }
        public int NumberSeats { get; private protected set; }
        public Car(Chassi chassi, Engine engine, Transmission transmission, double trunkVolume, bool availabilityReplaceableWheel, int numberSeats) : base(chassi, engine, transmission)
        {           
            TrunkVolume = trunkVolume;
            AvailabilityReplaceableWheel = availabilityReplaceableWheel;
            NumberSeats = numberSeats;
        }
        public override string ToString()
        {
            return base.ToString() + "Unique fields:\n" + "TrunkVolume - " + TrunkVolume + " AvailabilityReplaceableWheel - " + AvailabilityReplaceableWheel + " NumberSeats - " + NumberSeats;
        }
    }
}
