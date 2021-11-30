using System;
using VehicleFleet.Chassis;
using VehicleFleet.Engines;
using VehicleFleet.Transmissions;
using VehicleFleet.Transports;


namespace VehicleFleet
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectricalEngine a = new ElectricalEngine(12,53,"type1");
           
            FourWheeleChassi b = new FourWheeleChassi("type2", 12);
            
            MechanicalTransmission c = new MechanicalTransmission(35, "type3");
            Car d = new Car(b, a, c, 234.2, true, 3);
            Console.WriteLine(d.ToString());




        }
    }
}
