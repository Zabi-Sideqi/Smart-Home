using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Home
{
    public class SmartHomeController
    {
        private List<Appliance> _devices = new List<Appliance>();

        public void AddDevice(Appliance device)
        {

            // Lägg till device i listan. 
            _devices.Add(device);
        }

        public void TurnOnAll()
        {

            // Loopa igenom alla devices och starta dem. 
            // Du får inte använda if/switch på specifika klasser. 
            foreach (Appliance device in _devices)
            {
                device.TurnOn();
            }

       }

        public void TurnOffAll()
        {
            
            // Loopa igenom alla devices och stäng av dem. 
            foreach(Appliance device in _devices)
            {
                device.TurnOff();
            }
        }

        public void PrintStatusReport()
        {

            // Loopa igenom alla devices. 
            // Skriv ut GetInfo() och om apparaten är på eller av. 
            foreach (Appliance device in _devices)
            {
                Console.WriteLine(device.GetInfo());
                Console.WriteLine($"Status: {(device.IsOn ? "på" : "av")}");
                Console.WriteLine();
            }

        }

        public double GetTotalDailyEnergyUsage()
        {
            
            // Räkna ihop GetDailyEnergyUsage() för alla devices. 
            // Returnera totalsumman. 
            double total = 0;
            
            foreach (Appliance device in _devices)
            {
                total += device.GetDailyEnergyUsage();
            }

            return total;
        }
    }
}
