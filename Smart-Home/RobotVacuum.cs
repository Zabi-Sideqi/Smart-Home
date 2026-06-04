using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Home
{
    internal class RobotVacuum
    {
        public string Brand { get; set; }
        public int BatteryLevel { get; set; }

        public RobotVacuum(string brand, int batteryLevel)
        {
            Brand = brand;
            BatteryLevel = batteryLevel;
        }
        public void StartCleaning()
        {
            Console.WriteLine($"{Brand} robot vacuum is starts cleaning.");
        }
        public void StopCleaning()
        {
            Console.WriteLine($"{Brand} robot vacuum has stops cleaning.");
        }
        public void PrintCleaningEnergy()
        {
            Console.WriteLine($"{Brand} robot vacuum uses 0.4 kWh per cleaning .");
        }



    }
}
