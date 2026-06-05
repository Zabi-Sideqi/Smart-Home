using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Home
{
    public class Refrigerator : Appliance
    {
        public int Temperature { get; set; }
        public Refrigerator(string brand, string room, int temperature)
            : base(brand, room)
        {
            Temperature = temperature;
        }
        public override string GetInfo()
        {
            return $"{base.GetInfo()} set to {Temperature}°C";
        }
        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Brand} refrigerator is now cooling.");
        }
        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Brand} refrigerator is now off.");
        }
        public override double GetDailyEnergyUsage()
        {
            // Anta att kylskåpet använder 3.6 kWh per dag när det är på. 
            return 3.6;
        }
    }
}
