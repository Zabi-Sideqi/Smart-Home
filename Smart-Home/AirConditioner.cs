using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Home
{
   public class AirConditioner : Appliance
    {
        public int TargetTemperature { get; set; }
        public AirConditioner(string brand, string room, int targetTemperature)
            : base(brand, room)
        {
            TargetTemperature = targetTemperature;
        }
        public override string GetInfo()
        {
            return $"{base.GetInfo()} with target temperature {TargetTemperature}°C";
        }
        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Brand} air conditioner is now cooling.");
        }
        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Brand} air conditioner is now off.");
        }
        public override double GetDailyEnergyUsage()
        {
           
            return 1.8;
        }
    }
}
