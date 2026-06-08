using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Home
{
    public class  Oven : Appliance
    {
        public int MaxTemperature { get; set; }

        public Oven(string brand, string room, int maxTemperature)
            : base(brand, room)
        {
            MaxTemperature = maxTemperature;
        }
        public override string GetInfo()
        {
            return $"{base.GetInfo()} with maximum temperature of {MaxTemperature}°C";

        }
        //public override void TurnOn()
        //{
        //    IsOn = true;
        //    Console.WriteLine($"{Brand} oven starts preheating.");
        //}

        public sealed override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Brand} oven starts preheating.");
        }
        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Brand} oven stops preheating.");
        }
        public override double GetDailyEnergyUsage()
        {
            // Anta att ugnen använder 2.5 kWh per timme när den är på. 
            return 2.5;
        }

    }

}
