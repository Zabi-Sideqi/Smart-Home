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

        public void ScheduleAllSchedulableDevices(DateTime time)
        {
            foreach (Appliance device in _devices)
            {

                // 1. Kontrollera om device implementerar ISchedulable. 
                // 2. Casta device till ISchedulable. 
                // 3. Anropa Schedule(time). 
                if (device is ISchedulable schedulable)
                {
                    schedulable.Schedule(time);
                }
            }
        }
        internal List<ISchedulable> GetSchedulableDevices()
        {
            List<ISchedulable> result = new List<ISchedulable>();
            foreach (Appliance device in _devices)
            {

                // Om device implementerar ISchedulable, 
                // lägg till det i result. 
                if (device is ISchedulable schedulable)
                {
                    result.Add(schedulable);
                }
            }
            return result;
        }
    }
}
/*
Varför kan listan vara List<ISchedulable>
även om objekten egentligen är olika klasser?

Eftersom alla objekten implementerar
ISchedulable.

De är olika klasser, men de följer samma
interface och har därför Schedule()
och NextRun.

Därför kan de lagras i samma lista.
*/