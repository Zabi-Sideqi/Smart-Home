using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Home
{
    public class RobotVacuum : Appliance
    {
        public int BatteryLevel { get; set; }

        public RobotVacuum(string brand, string room, int batteryLevel)
            :base (brand, room)
        {
            BatteryLevel = batteryLevel;
        }
        public override string GetInfo()
        {
            return $"{base.GetInfo()} with a battery level of {BatteryLevel}%";
        }
        public override void TurnOn()
        {
            IsOn = true ;
            Console.WriteLine($"{Brand} robot vacuum starts cleaning.");
        }
        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Brand} robot vacuum stops cleaning.");
        }
        public override double GetDailyEnergyUsage()
        {
            // Anta att robotdammsugaren använder 0.2 kWh per timme när den är på. 
            return 0.4;
        }


    }

}
