using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Home
{   
    public class Washer : Appliance, ISchedulable
    {
        public int CapacityKg { get; set; }

        public DateTime NextRun { get; set; }
        public void Schedule(DateTime time)
        {
            NextRun = time;

            Console.WriteLine($"{Brand} washer scheduled to run at {NextRun}.");
        }

        public Washer(string brand, string room, int capacitykg) 
            : base (brand, room)

        {
            CapacityKg = capacitykg;
        }
        public override string GetInfo()
        {
            return $"{base.GetInfo()} with a capacity of {CapacityKg} kg";
        }
        public override void TurnOn()
        {
            IsOn = true ;
            Console.WriteLine($"{Brand} washer starts a washing program.");
        }
        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Brand} washer stops the washing program.");
        }
        public override double GetDailyEnergyUsage()
        {
            // Returnera en uppskattning av energiförbrukningen baserat på kapaciteten. 
            // Exempel: 0.5 kWh per kg kapacitet.
            return 1.2;
        }

    }
    
          
}
